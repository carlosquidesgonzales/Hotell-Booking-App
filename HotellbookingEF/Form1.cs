using HotellbookingEF.Data;
using HotellbookingEF.Enum;
using HotellbookingEF.Exceptions;
using HotellbookingEF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HotellbookingEF
{
    public partial class Form1 : Form
    {
        BindingList<Booking> _bookings;
        BindingList<Room> _rooms;
        BindingList<Customer> _customers;
        BindingList<Invoice> _invoices;
        IDataRepository _data = new DataRepository();
        const string _add = "Add";
        const string _update = "Update";
        const string _delete = "Delete";
        const string _cancel = "Cancel";
        const string _singleRoom = "Single Room";
        const string _doubleRoom = "Double Room";
        const string _book = "Book";
        const string _search = "Search";
        const string _cancelBooking = "Cancel Booking";
        const string _paid = "Paid";
        const string _unpaid = "Unpaid";
        const string _pay = "Pay";

        public Form1()
        {
            InitializeComponent();
            ResetBookingDate();
        }
        #region Actions
        private void registerDataTabPage_Enter(object sender, EventArgs e)
        {
            try
            {
                _bookings = new BindingList<Booking>(_data.Get<Booking>().ToList());
                _customers = new BindingList<Customer>(_data.Get<Customer>().ToList());
                _invoices = new BindingList<Invoice>(_data.Get<Invoice>().ToList());
                _rooms = new BindingList<Room>(_data.Get<Room>().ToList());
                SetComboBoxes();
                listViewInvoice.Items.Clear();
                RemoveUnpaidBookingAfterTenDays(_bookings, _invoices);
            }
            catch
            { }
        }
        private void RemoveUnpaidBookingAfterTenDays(BindingList<Booking> bookings, BindingList<Invoice> invoices)
        {
            var unpaidInvoiceIn = invoices.Where(i => i.InvoiceStatus == InvoiceStatus.Unpaid.ToString()).ToList();
            var unpaidBookings = bookings.Where(b => unpaidInvoiceIn.Any(u => u.BookingId == b.Id)).ToList();
            if (unpaidBookings.Count != 0)
            {
                foreach (var item in unpaidBookings)
                {
                    if ((DateTime.Now - item.BookingDate).Days >= 10)
                    {
                        _data.Delete(item);
                    }
                }
            }
        }
        private void SetComboBoxes()
        {
            BindingList<int> numbers = new BindingList<int>(Enumerable.Range(1, 4).ToList());
            cboCustomer.DataSource = _customers;
            cboCustomer.DisplayMember = "FullName";
            comboBoxNumPerson.DataSource = numbers;
            comboBoxNumPerson.DisplayMember = numbers.ToString();
            cboCustomerBookARoom.DataSource = _customers;
            cboCustomerBookARoom.DisplayMember = "FullName";
        }
        private void ResetAll(Customer customer, string message)
        {
            txtFName.Text = String.Empty;
            txtLName.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtEmail.Text = String.Empty;
            _customers.ResetBindings();
            MessageBox.Show($"Customer {customer.FirstName} {customer.LastName} {message} successfully!");
        }
        private void ResetRoomButtons()
        {
            btnSingleRoom.Enabled = false;
            btnDoubleRoom.Enabled = false;
        }
       
        private void ResetBookingDate()
        {
            dateTimePickerBookARoomFrom.MinDate = DateTime.Now;
            dateTimePickerBookARoomTo.MinDate = DateTime.Now.AddDays(1);
            //dateTimePickerFrom.MinDate = DateTime.Now; ;
            dateTimePickerBookingsTo.MinDate = DateTime.Now.AddDays(1);
        }
        #endregion
        #region Customer
        private void RegisterCustomerButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var customerToUpdateOrDelete = (Customer)cboCustomer.SelectedItem;
            switch (btn.Text)
            {
                case _add:
                   
                    try
                    {                     
                        var customerToAdd = new Customer()
                        {
                            FirstName = txtFName.Text,
                            LastName = txtLName.Text,
                            Phone = txtPhone.Text,
                            Email = txtEmail.Text
                        };
                        _customers.Add(customerToAdd);
                        _data.Add(customerToAdd);
                        cboCustomer.SelectedIndex = cboCustomer.Items.Count - 1;
                        ResetAll(customerToAdd, "added");

                    }
                    catch (EntityException<Customer> ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }
                    catch
                    {
                        MessageBox.Show($"Could not add customer data");
                    }
                    break;
                case _update:
                    try
                    {
                        customerToUpdateOrDelete.FirstName = txtFName.Text;
                        customerToUpdateOrDelete.LastName = txtLName.Text;
                        customerToUpdateOrDelete.Phone = txtPhone.Text;
                        customerToUpdateOrDelete.Email = txtEmail.Text;
                        _data.Update(customerToUpdateOrDelete);
                        ResetAll(customerToUpdateOrDelete, "updated");
                       
                    }
                    catch (EntityException<Customer> ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }
                    catch
                    {
                        MessageBox.Show($"Could not update customer data");
                    }
                   
                    break;
                case _delete:
                   
                    if (_bookings.Any(b => b.CustomerId == customerToUpdateOrDelete.Id))
                    {
                        MessageBox.Show("Could not delete customer data. Customer booking exist!");
                    }
                    else
                    {
                        try
                        {
                            _customers.Remove(customerToUpdateOrDelete);
                            _data.Delete(customerToUpdateOrDelete);
                            _customers.ResetBindings();
                            ResetAll(customerToUpdateOrDelete, "deleted");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Could not delete customer data");
                        }                    
                    }
                    break;
                case _cancel:
                    txtFName.Text = String.Empty;
                    txtLName.Text = String.Empty;
                    txtPhone.Text = String.Empty;
                    txtEmail.Text = String.Empty;
                    break;
            }
        }
        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var customer = (Customer)cboCustomer.SelectedItem;
                txtFName.Text = customer.FirstName;
                txtLName.Text = customer.LastName;
                txtPhone.Text = customer.Phone;
                txtEmail.Text = customer.Email;
            }
            catch
            { }
        }
        private void CustomerTextBox_TextChanged(object sender, EventArgs e)
        {
            var customer = (Customer)cboCustomer.SelectedItem;
            if ((txtFName.Text == customer.FirstName && txtLName.Text == customer.LastName && txtPhone.Text == customer.Phone && txtEmail.Text == customer.Email)
                || (txtFName.Text == String.Empty || txtLName.Text == String.Empty || txtPhone.Text == String.Empty || txtEmail.Text == String.Empty))
            {
                btnAddCustomer.Enabled = false;
                btnDeleteCustomer.Enabled = true;
                btnUpdateCustomer.Enabled = false;
            }
            else
            {
                btnAddCustomer.Enabled = true;
                btnDeleteCustomer.Enabled = false;
                btnUpdateCustomer.Enabled = true;
            }
        }
        #endregion
        #region Book a Room
        private void DateStartChanged(object sender, EventArgs e)
        {
            dateTimePickerBookARoomTo.MinDate = DateTime.Now.AddDays((dateTimePickerBookARoomFrom.Value - DateTime.Now).Days + 2);
            cboNumPerson.DataSource = null;
            btnBook.Enabled = false;
            ResetRoomButtons();
            ResetBooking();
        }
        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            ResetRoomButtons();
            ResetBooking();
            btnBook.Enabled = false;
            cboNumPerson.DataSource = null;
        }
        private void TextChangedBooking(object sender, EventArgs e)
        {
            if (txtCost.Text != String.Empty && txtRoom.Text != String.Empty)
            {
                btnBook.Enabled = true;
            }
        }
        private void ResetBooking()
        {
            txtCost.Text = String.Empty;
            txtRoom.Text = String.Empty;
        }
        private void SingleRoomDoubleRoom_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            BindingList<int> numbers = new BindingList<int>(Enumerable.Range(1, 2).ToList()); ;
            switch (btn.Text)
            {
               case _singleRoom:
                    txtRoom.Text = _rooms[0].Name;
                    txtCost.Text = ((dateTimePickerBookARoomTo.Value.Date - dateTimePickerBookARoomFrom.Value.Date).Days * _rooms[0].Price).ToString("F2");   
                    break;
                case _doubleRoom:
                    txtRoom.Text = _rooms[1].Name;
                    txtCost.Text = ((dateTimePickerBookARoomTo.Value.Date - dateTimePickerBookARoomFrom.Value.Date).Days * _rooms[1].Price).ToString("F2");
                    numbers = new BindingList<int>(Enumerable.Range(1, 4).ToList());
                    break;

            }
            cboNumPerson.DataSource = numbers;
            cboNumPerson.DisplayMember = numbers.ToString();
        }

        private void btnBookARoom_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case _book:
                    var booking = new Booking()
                    {
                        CustomerId = ((Customer)cboCustomerBookARoom.SelectedItem).Id,
                        RoomId = _rooms.FirstOrDefault(r => r.Name == txtRoom.Text).Id,
                        BookingDateStart = dateTimePickerBookARoomFrom.Value,
                        BookingDateEnd = dateTimePickerBookARoomTo.Value,
                        BookingDate = DateTime.Now,
                        Cost = Convert.ToDecimal(txtCost.Text),
                        NumberOfPerson = (int)cboNumPerson.SelectedValue
                    };
                    try
                    {
                        var form = new PayForm(booking);
                        form.ShowDialog();
                        _bookings = new BindingList<Booking>(_data.Get<Booking>().ToList());
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                  
                    break;
            }
            dateTimePickerBookARoomFrom.ResetText();
            dateTimePickerBookARoomTo.ResetText();
            cboNumPerson.DataSource = null;
            ResetBooking();
            ResetRoomButtons();
            ResetBookingDate();
        }
        private void btnRooms_Click(object sender, EventArgs e)
        {
            cboNumPerson.DataSource = null;
            IEnumerable<Booking> getBookings = _bookings.Where(b =>
            (b.BookingDateStart.Date < dateTimePickerBookARoomTo.Value.Date
            && b.BookingDateEnd.Date > dateTimePickerBookARoomFrom.Value.Date)).ToList();
            bool isSingleRoomBook = getBookings.Any(b => b.Room.Name == _rooms[0].Name);
            bool isDoubleRoomBook = getBookings.Any(b => b.Room.Name == _rooms[1].Name);
            btnSingleRoom.Enabled = !isSingleRoomBook;
            btnDoubleRoom.Enabled = !isDoubleRoomBook;
        }
        #endregion
        #region Search Booking
        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBookingsTo.MinDate = dateTimePickerBookingsFrom.Value.AddDays(1);
        }
        private void ShowListView()
        {
            listViewBookings.Items.Clear();
            int numberOfPers = (int)comboBoxNumPerson.SelectedValue;
            DateTime start = dateTimePickerBookingsFrom.Value.Date;
            DateTime end = dateTimePickerBookingsTo.Value.Date;
            var searchBookings = _data.Search(start, end, numberOfPers).ToList();
            foreach (var b in searchBookings)
            {
                var item = new ListViewItem(new string[]
                {
                    b.Id.ToString(),
                    b.Room.Name, b.BookingDate.ToString("MM/dd/yyyy"),
                    b.BookingDateStart.ToString("MM/dd/yyyy"),
                    b.BookingDateEnd.ToString("MM/dd/yyyy"),
                    b.Cost.ToString()
                });
                listViewBookings.Items.Add(item);
            }
        }
        private void listViewBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisableCancelBooking();
        }
        private void DisableCancelBooking()
        {
            bool selected = listViewBookings.SelectedItems.Count == 1;
            if (selected)
                btnCancelBookings.Enabled = true;
            else
                btnCancelBookings.Enabled = false;
        }
        private void btnBookings_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
              case _search:
                    ShowListView();
                    break;
                case _cancelBooking:
                    int id = Convert.ToInt32(listViewBookings.SelectedItems[0].Text);
                    Booking bookingToDelelte = _bookings.FirstOrDefault(b => b.Id == id);
                    Invoice invoice = _invoices.FirstOrDefault(i => i.CustomerId == bookingToDelelte.CustomerId);
                    try
                    {
                        _data.Delete(bookingToDelelte);
                        _data.Delete(invoice);
                        _bookings.Remove(bookingToDelelte);
                        _bookings.ResetBindings();
                        _invoices.Remove(invoice);
                        _invoices.ResetBindings();
                        MessageBox.Show($"Booking canceled successfully!");
                        listViewBookings.Items.Clear();
                        DisableCancelBooking();
                        ShowListView();
                    }
                    catch (Exception)
                    { }               
                    break;
                case _cancel:
                    listViewBookings.Items.Clear();
                    DisableCancelBooking();
                    break;
            }
        }
        #endregion
        #region Invoice
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case _unpaid:
                    listViewInvoice.Enabled = true;
                    ShowListViewInvoice(InvoiceStatus.Unpaid.ToString());
                    break;
                case _paid:
                    ShowListViewInvoice(InvoiceStatus.Paid.ToString());
                    btnPayCredit.Enabled = false;
                    listViewInvoice.Enabled = false;
                    break;
                case _pay:
                    int id = Convert.ToInt32(listViewInvoice.SelectedItems[0].Text);
                    Invoice invoice = _invoices.FirstOrDefault(i => i.Id == id);
                    invoice.InvoiceStatus = InvoiceStatus.Paid.ToString();
                    invoice.DatePaid = DateTime.Now;
                    try
                    {
                        _data.Update(invoice);
                        listViewInvoice.Items.Clear();
                        MessageBox.Show("Booking paid!");
                    }
                    catch (EntityException<Customer> ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }
                    catch
                    {
                        MessageBox.Show($"Could not update data");
                    }                  
                    break;
            }
        }
        private void ShowListViewInvoice(string status)
        {
            listViewInvoice.Items.Clear();
            IEnumerable<Invoice> getUnpaidInvoice = _invoices.Where(i => i.InvoiceStatus == status);
            foreach (var i in getUnpaidInvoice)
            {
                var item = new ListViewItem(new string[] { i.Id.ToString(), i.Booking.BookingDate.ToString("MM/dd/yyyy"), i.InvoiceStatus, i.Total.ToString() });
                listViewInvoice.Items.Add(item);
            }
        }
        private void listViewInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selected = listViewInvoice.SelectedItems.Count == 1;
            btnPayCredit.Enabled = selected ? true : false;
        }
        #endregion       
    }
}
