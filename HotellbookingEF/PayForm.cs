using HotellbookingEF.Data;
using HotellbookingEF.Enum;
using HotellbookingEF.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HotellbookingEF
{
    public partial class PayForm : Form
    {
        IDataRepository _data = new DataRepository();
        Booking book;
        const string _pay = "Pay";
        const string _cancel = "Cancel";
        const string _credit = "Credit";
        public PayForm(Booking booking)
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("dddd dd MMMM");
            book = booking;
            ShowListView(booking);
        }
        private void ShowListView(Booking booking)
        {
            int days = (booking.BookingDateEnd - booking.BookingDateStart).Days;
            var rooms = _data.Get<Room>().ToList();
            string room = rooms.FirstOrDefault(r => r.Id == booking.RoomId).Name;
            listView1.Items.Add(new ListViewItem(new string[] { room, days.ToString(), booking.Cost.ToString() }));
            lblTotal.Text = booking.Cost.ToString() + " kr";
        }
        private void AddBookingAndInvoice(DateTime? datepaid = null)
        {
            try
            {
                _data.Add(book);
                Booking lastAddedBooking = _data.Get<Booking>().ToList().LastOrDefault();
                Invoice invoice = new Invoice()
                {
                    CustomerId = book.CustomerId,
                    InvoiceStatus = datepaid.HasValue? InvoiceStatus.Paid.ToString() : InvoiceStatus.Unpaid.ToString(),
                    Total = book.Cost,
                    BookingId = lastAddedBooking.Id,
                    DatePaid = datepaid
                };
                _data.Add(invoice);
            }
            catch (Exception)
            { }
            MessageBox.Show($"Successfully booked!");
            CloseThisForm();
        }     
        private void CloseThisForm()
        {
            var form = new Form1();
            form.Refresh();
            Close();
        }      
        private void btnPayInvoice_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case _pay:
                    AddBookingAndInvoice(book.BookingDate);
                    break;
                case _credit:
                    AddBookingAndInvoice();
                    break;
                case _cancel:
                    CloseThisForm();
                    break;
            }
        }
    }
}
