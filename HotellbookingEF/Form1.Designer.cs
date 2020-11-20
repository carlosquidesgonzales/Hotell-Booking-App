namespace HotellbookingEF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.registerCustomer = new System.Windows.Forms.TabPage();
            this.btnCancelCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookARoom = new System.Windows.Forms.TabPage();
            this.cboNumPerson = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDoubleRoom = new System.Windows.Forms.Button();
            this.btnSingleRoom = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.dateTimePickerBookARoomTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBookARoomFrom = new System.Windows.Forms.DateTimePicker();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.cboCustomerBookARoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Booking = new System.Windows.Forms.TabPage();
            this.btnResetBooking = new System.Windows.Forms.Button();
            this.btnCancelBookings = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxNumPerson = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBookingsTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBookingsFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearchBooking = new System.Windows.Forms.Button();
            this.listViewBookings = new System.Windows.Forms.ListView();
            this.BookingId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateBooked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Invoice = new System.Windows.Forms.TabPage();
            this.btnPaid = new System.Windows.Forms.Button();
            this.btnUnpaid = new System.Windows.Forms.Button();
            this.btnPayCredit = new System.Windows.Forms.Button();
            this.listViewInvoice = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.registerCustomer.SuspendLayout();
            this.bookARoom.SuspendLayout();
            this.Booking.SuspendLayout();
            this.Invoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.registerCustomer);
            this.tabControl1.Controls.Add(this.bookARoom);
            this.tabControl1.Controls.Add(this.Booking);
            this.tabControl1.Controls.Add(this.Invoice);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(32, 38);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1821, 839);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.registerDataTabPage_Enter);
            // 
            // registerCustomer
            // 
            this.registerCustomer.Controls.Add(this.btnCancelCustomer);
            this.registerCustomer.Controls.Add(this.btnDeleteCustomer);
            this.registerCustomer.Controls.Add(this.btnUpdateCustomer);
            this.registerCustomer.Controls.Add(this.btnAddCustomer);
            this.registerCustomer.Controls.Add(this.cboCustomer);
            this.registerCustomer.Controls.Add(this.txtEmail);
            this.registerCustomer.Controls.Add(this.txtPhone);
            this.registerCustomer.Controls.Add(this.txtLName);
            this.registerCustomer.Controls.Add(this.txtFName);
            this.registerCustomer.Controls.Add(this.label5);
            this.registerCustomer.Controls.Add(this.label4);
            this.registerCustomer.Controls.Add(this.label3);
            this.registerCustomer.Controls.Add(this.lblFName);
            this.registerCustomer.Controls.Add(this.label1);
            this.registerCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerCustomer.Location = new System.Drawing.Point(10, 61);
            this.registerCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerCustomer.Name = "registerCustomer";
            this.registerCustomer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerCustomer.Size = new System.Drawing.Size(1801, 768);
            this.registerCustomer.TabIndex = 0;
            this.registerCustomer.Text = "Register Customer";
            this.registerCustomer.UseVisualStyleBackColor = true;
            this.registerCustomer.Enter += new System.EventHandler(this.registerDataTabPage_Enter);
            // 
            // btnCancelCustomer
            // 
            this.btnCancelCustomer.Location = new System.Drawing.Point(1144, 520);
            this.btnCancelCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelCustomer.Name = "btnCancelCustomer";
            this.btnCancelCustomer.Size = new System.Drawing.Size(325, 79);
            this.btnCancelCustomer.TabIndex = 13;
            this.btnCancelCustomer.Text = "Cancel";
            this.btnCancelCustomer.UseVisualStyleBackColor = true;
            this.btnCancelCustomer.Click += new System.EventHandler(this.RegisterCustomerButton_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Enabled = false;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(1144, 391);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(325, 79);
            this.btnDeleteCustomer.TabIndex = 12;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.RegisterCustomerButton_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Enabled = false;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(1144, 255);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(325, 76);
            this.btnUpdateCustomer.TabIndex = 11;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.RegisterCustomerButton_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Enabled = false;
            this.btnAddCustomer.Location = new System.Drawing.Point(1144, 124);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(325, 79);
            this.btnAddCustomer.TabIndex = 10;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.RegisterCustomerButton_Click);
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(512, 124);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(484, 50);
            this.cboCustomer.TabIndex = 9;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(512, 539);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(484, 49);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.CustomerTextBox_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(512, 420);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(484, 49);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.TextChanged += new System.EventHandler(this.CustomerTextBox_TextChanged);
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(512, 317);
            this.txtLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(484, 49);
            this.txtLName.TabIndex = 6;
            this.txtLName.TextChanged += new System.EventHandler(this.CustomerTextBox_TextChanged);
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(512, 217);
            this.txtFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(484, 49);
            this.txtFName.TabIndex = 5;
            this.txtFName.TextChanged += new System.EventHandler(this.CustomerTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(259, 224);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(207, 44);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // bookARoom
            // 
            this.bookARoom.Controls.Add(this.cboNumPerson);
            this.bookARoom.Controls.Add(this.label10);
            this.bookARoom.Controls.Add(this.btnDoubleRoom);
            this.bookARoom.Controls.Add(this.btnSingleRoom);
            this.bookARoom.Controls.Add(this.btnRooms);
            this.bookARoom.Controls.Add(this.txtRoom);
            this.bookARoom.Controls.Add(this.dateTimePickerBookARoomTo);
            this.bookARoom.Controls.Add(this.dateTimePickerBookARoomFrom);
            this.bookARoom.Controls.Add(this.txtCost);
            this.bookARoom.Controls.Add(this.btnBook);
            this.bookARoom.Controls.Add(this.btnCancelBooking);
            this.bookARoom.Controls.Add(this.cboCustomerBookARoom);
            this.bookARoom.Controls.Add(this.label2);
            this.bookARoom.Controls.Add(this.label6);
            this.bookARoom.Controls.Add(this.label7);
            this.bookARoom.Controls.Add(this.label8);
            this.bookARoom.Controls.Add(this.label9);
            this.bookARoom.Location = new System.Drawing.Point(10, 61);
            this.bookARoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookARoom.Name = "bookARoom";
            this.bookARoom.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookARoom.Size = new System.Drawing.Size(1801, 768);
            this.bookARoom.TabIndex = 1;
            this.bookARoom.Text = "Book a Room";
            this.bookARoom.UseVisualStyleBackColor = true;
            this.bookARoom.Enter += new System.EventHandler(this.registerDataTabPage_Enter);
            // 
            // cboNumPerson
            // 
            this.cboNumPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNumPerson.FormattingEnabled = true;
            this.cboNumPerson.Location = new System.Drawing.Point(635, 484);
            this.cboNumPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNumPerson.Name = "cboNumPerson";
            this.cboNumPerson.Size = new System.Drawing.Size(537, 50);
            this.cboNumPerson.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 484);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(326, 39);
            this.label10.TabIndex = 34;
            this.label10.Text = "Number of Persons";
            // 
            // btnDoubleRoom
            // 
            this.btnDoubleRoom.Enabled = false;
            this.btnDoubleRoom.Location = new System.Drawing.Point(848, 365);
            this.btnDoubleRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoubleRoom.Name = "btnDoubleRoom";
            this.btnDoubleRoom.Size = new System.Drawing.Size(325, 74);
            this.btnDoubleRoom.TabIndex = 33;
            this.btnDoubleRoom.Text = "Double Room";
            this.btnDoubleRoom.UseVisualStyleBackColor = true;
            this.btnDoubleRoom.Click += new System.EventHandler(this.SingleRoomDoubleRoom_Click);
            // 
            // btnSingleRoom
            // 
            this.btnSingleRoom.Enabled = false;
            this.btnSingleRoom.Location = new System.Drawing.Point(477, 365);
            this.btnSingleRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSingleRoom.Name = "btnSingleRoom";
            this.btnSingleRoom.Size = new System.Drawing.Size(325, 74);
            this.btnSingleRoom.TabIndex = 32;
            this.btnSingleRoom.Text = "Single Room";
            this.btnSingleRoom.UseVisualStyleBackColor = true;
            this.btnSingleRoom.Click += new System.EventHandler(this.SingleRoomDoubleRoom_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(184, 341);
            this.btnRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(235, 98);
            this.btnRooms.TabIndex = 31;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // txtRoom
            // 
            this.txtRoom.Enabled = false;
            this.txtRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.Location = new System.Drawing.Point(469, 656);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(705, 49);
            this.txtRoom.TabIndex = 30;
            this.txtRoom.TextChanged += new System.EventHandler(this.TextChangedBooking);
            // 
            // dateTimePickerBookARoomTo
            // 
            this.dateTimePickerBookARoomTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBookARoomTo.Location = new System.Drawing.Point(477, 179);
            this.dateTimePickerBookARoomTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBookARoomTo.Name = "dateTimePickerBookARoomTo";
            this.dateTimePickerBookARoomTo.Size = new System.Drawing.Size(695, 45);
            this.dateTimePickerBookARoomTo.TabIndex = 29;
            this.dateTimePickerBookARoomTo.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // dateTimePickerBookARoomFrom
            // 
            this.dateTimePickerBookARoomFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBookARoomFrom.Location = new System.Drawing.Point(477, 81);
            this.dateTimePickerBookARoomFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBookARoomFrom.Name = "dateTimePickerBookARoomFrom";
            this.dateTimePickerBookARoomFrom.Size = new System.Drawing.Size(695, 45);
            this.dateTimePickerBookARoomFrom.TabIndex = 28;
            this.dateTimePickerBookARoomFrom.ValueChanged += new System.EventHandler(this.DateStartChanged);
            this.dateTimePickerBookARoomFrom.TabIndexChanged += new System.EventHandler(this.DateStartChanged);
            this.dateTimePickerBookARoomFrom.Leave += new System.EventHandler(this.DateStartChanged);
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(469, 560);
            this.txtCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(705, 49);
            this.txtCost.TabIndex = 27;
            this.txtCost.TextChanged += new System.EventHandler(this.TextChangedBooking);
            // 
            // btnBook
            // 
            this.btnBook.Enabled = false;
            this.btnBook.Location = new System.Drawing.Point(1323, 95);
            this.btnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(325, 100);
            this.btnBook.TabIndex = 25;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBookARoom_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(1323, 241);
            this.btnCancelBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(325, 103);
            this.btnCancelBooking.TabIndex = 24;
            this.btnCancelBooking.Text = "Cancel";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnBookARoom_Click);
            // 
            // cboCustomerBookARoom
            // 
            this.cboCustomerBookARoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomerBookARoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerBookARoom.FormattingEnabled = true;
            this.cboCustomerBookARoom.Location = new System.Drawing.Point(469, 267);
            this.cboCustomerBookARoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCustomerBookARoom.Name = "cboCustomerBookARoom";
            this.cboCustomerBookARoom.Size = new System.Drawing.Size(705, 50);
            this.cboCustomerBookARoom.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 39);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 39);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date to";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 39);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date from";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 656);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 39);
            this.label8.TabIndex = 14;
            this.label8.Text = "Room";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 39);
            this.label9.TabIndex = 13;
            this.label9.Text = "Customer";
            // 
            // Booking
            // 
            this.Booking.Controls.Add(this.btnResetBooking);
            this.Booking.Controls.Add(this.btnCancelBookings);
            this.Booking.Controls.Add(this.label12);
            this.Booking.Controls.Add(this.label13);
            this.Booking.Controls.Add(this.label11);
            this.Booking.Controls.Add(this.comboBoxNumPerson);
            this.Booking.Controls.Add(this.dateTimePickerBookingsTo);
            this.Booking.Controls.Add(this.dateTimePickerBookingsFrom);
            this.Booking.Controls.Add(this.btnSearchBooking);
            this.Booking.Controls.Add(this.listViewBookings);
            this.Booking.Location = new System.Drawing.Point(10, 61);
            this.Booking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Booking.Name = "Booking";
            this.Booking.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Booking.Size = new System.Drawing.Size(1801, 768);
            this.Booking.TabIndex = 2;
            this.Booking.Text = "Bookings";
            this.Booking.UseVisualStyleBackColor = true;
            // 
            // btnResetBooking
            // 
            this.btnResetBooking.Location = new System.Drawing.Point(832, 646);
            this.btnResetBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetBooking.Name = "btnResetBooking";
            this.btnResetBooking.Size = new System.Drawing.Size(376, 91);
            this.btnResetBooking.TabIndex = 41;
            this.btnResetBooking.Text = "Cancel";
            this.btnResetBooking.UseVisualStyleBackColor = true;
            this.btnResetBooking.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnCancelBookings
            // 
            this.btnCancelBookings.Enabled = false;
            this.btnCancelBookings.Location = new System.Drawing.Point(1275, 646);
            this.btnCancelBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelBookings.Name = "btnCancelBookings";
            this.btnCancelBookings.Size = new System.Drawing.Size(437, 91);
            this.btnCancelBookings.TabIndex = 40;
            this.btnCancelBookings.Text = "Cancel Booking";
            this.btnCancelBookings.UseVisualStyleBackColor = true;
            this.btnCancelBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(91, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 39);
            this.label12.TabIndex = 39;
            this.label12.Text = "Date to";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(88, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 39);
            this.label13.TabIndex = 38;
            this.label13.Text = "Date from";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1099, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(326, 39);
            this.label11.TabIndex = 37;
            this.label11.Text = "Number of Persons";
            // 
            // comboBoxNumPerson
            // 
            this.comboBoxNumPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNumPerson.FormattingEnabled = true;
            this.comboBoxNumPerson.Location = new System.Drawing.Point(1515, 43);
            this.comboBoxNumPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNumPerson.Name = "comboBoxNumPerson";
            this.comboBoxNumPerson.Size = new System.Drawing.Size(220, 50);
            this.comboBoxNumPerson.TabIndex = 36;
            // 
            // dateTimePickerBookingsTo
            // 
            this.dateTimePickerBookingsTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBookingsTo.Location = new System.Drawing.Point(309, 136);
            this.dateTimePickerBookingsTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBookingsTo.Name = "dateTimePickerBookingsTo";
            this.dateTimePickerBookingsTo.Size = new System.Drawing.Size(569, 45);
            this.dateTimePickerBookingsTo.TabIndex = 31;
            // 
            // dateTimePickerBookingsFrom
            // 
            this.dateTimePickerBookingsFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBookingsFrom.Location = new System.Drawing.Point(309, 36);
            this.dateTimePickerBookingsFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBookingsFrom.Name = "dateTimePickerBookingsFrom";
            this.dateTimePickerBookingsFrom.Size = new System.Drawing.Size(569, 45);
            this.dateTimePickerBookingsFrom.TabIndex = 30;
            this.dateTimePickerBookingsFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // btnSearchBooking
            // 
            this.btnSearchBooking.Location = new System.Drawing.Point(1099, 122);
            this.btnSearchBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBooking.Name = "btnSearchBooking";
            this.btnSearchBooking.Size = new System.Drawing.Size(645, 76);
            this.btnSearchBooking.TabIndex = 11;
            this.btnSearchBooking.Text = "Search";
            this.btnSearchBooking.UseVisualStyleBackColor = true;
            this.btnSearchBooking.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // listViewBookings
            // 
            this.listViewBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookingId,
            this.RoomName,
            this.DateBooked,
            this.CheckIn,
            this.CheckOut,
            this.Price});
            this.listViewBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBookings.FullRowSelect = true;
            this.listViewBookings.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewBookings.HideSelection = false;
            this.listViewBookings.Location = new System.Drawing.Point(53, 234);
            this.listViewBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewBookings.MultiSelect = false;
            this.listViewBookings.Name = "listViewBookings";
            this.listViewBookings.Size = new System.Drawing.Size(1689, 390);
            this.listViewBookings.TabIndex = 0;
            this.listViewBookings.UseCompatibleStateImageBehavior = false;
            this.listViewBookings.View = System.Windows.Forms.View.Details;
            this.listViewBookings.SelectedIndexChanged += new System.EventHandler(this.listViewBookings_SelectedIndexChanged);
            // 
            // BookingId
            // 
            this.BookingId.Text = "BookingId";
            // 
            // RoomName
            // 
            this.RoomName.Text = "Room Name";
            this.RoomName.Width = 120;
            // 
            // DateBooked
            // 
            this.DateBooked.Text = "DateBooked";
            this.DateBooked.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DateBooked.Width = 110;
            // 
            // CheckIn
            // 
            this.CheckIn.Text = "Date From";
            this.CheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CheckIn.Width = 110;
            // 
            // CheckOut
            // 
            this.CheckOut.Text = "Date To";
            this.CheckOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CheckOut.Width = 110;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Price.Width = 80;
            // 
            // Invoice
            // 
            this.Invoice.Controls.Add(this.btnPaid);
            this.Invoice.Controls.Add(this.btnUnpaid);
            this.Invoice.Controls.Add(this.btnPayCredit);
            this.Invoice.Controls.Add(this.listViewInvoice);
            this.Invoice.Location = new System.Drawing.Point(10, 61);
            this.Invoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Invoice.Name = "Invoice";
            this.Invoice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Invoice.Size = new System.Drawing.Size(1801, 768);
            this.Invoice.TabIndex = 3;
            this.Invoice.Text = "Invoice";
            this.Invoice.UseVisualStyleBackColor = true;
            // 
            // btnPaid
            // 
            this.btnPaid.Location = new System.Drawing.Point(1299, 29);
            this.btnPaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(437, 91);
            this.btnPaid.TabIndex = 43;
            this.btnPaid.Text = "Paid";
            this.btnPaid.UseVisualStyleBackColor = true;
            this.btnPaid.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnUnpaid
            // 
            this.btnUnpaid.Location = new System.Drawing.Point(808, 29);
            this.btnUnpaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnpaid.Name = "btnUnpaid";
            this.btnUnpaid.Size = new System.Drawing.Size(437, 91);
            this.btnUnpaid.TabIndex = 42;
            this.btnUnpaid.Text = "Unpaid";
            this.btnUnpaid.UseVisualStyleBackColor = true;
            this.btnUnpaid.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnPayCredit
            // 
            this.btnPayCredit.Enabled = false;
            this.btnPayCredit.Location = new System.Drawing.Point(1307, 615);
            this.btnPayCredit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayCredit.Name = "btnPayCredit";
            this.btnPayCredit.Size = new System.Drawing.Size(437, 91);
            this.btnPayCredit.TabIndex = 41;
            this.btnPayCredit.Text = "Pay";
            this.btnPayCredit.UseVisualStyleBackColor = true;
            this.btnPayCredit.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // listViewInvoice
            // 
            this.listViewInvoice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewInvoice.FullRowSelect = true;
            this.listViewInvoice.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewInvoice.HideSelection = false;
            this.listViewInvoice.Location = new System.Drawing.Point(56, 162);
            this.listViewInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewInvoice.MultiSelect = false;
            this.listViewInvoice.Name = "listViewInvoice";
            this.listViewInvoice.Size = new System.Drawing.Size(1689, 390);
            this.listViewInvoice.TabIndex = 1;
            this.listViewInvoice.UseCompatibleStateImageBehavior = false;
            this.listViewInvoice.View = System.Windows.Forms.View.Details;
            this.listViewInvoice.SelectedIndexChanged += new System.EventHandler(this.listViewInvoice_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "InvoiceId";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Price";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 894);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.registerCustomer.ResumeLayout(false);
            this.registerCustomer.PerformLayout();
            this.bookARoom.ResumeLayout(false);
            this.bookARoom.PerformLayout();
            this.Booking.ResumeLayout(false);
            this.Booking.PerformLayout();
            this.Invoice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage registerCustomer;
        private System.Windows.Forms.TabPage bookARoom;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.ComboBox cboCustomerBookARoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookARoomTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookARoomFrom;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.TabPage Booking;
        private System.Windows.Forms.Button btnDoubleRoom;
        private System.Windows.Forms.Button btnSingleRoom;
        private System.Windows.Forms.Button btnCancelCustomer;
        private System.Windows.Forms.ComboBox cboNumPerson;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listViewBookings;
        private System.Windows.Forms.Button btnResetBooking;
        private System.Windows.Forms.Button btnCancelBookings;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxNumPerson;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookingsTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookingsFrom;
        private System.Windows.Forms.Button btnSearchBooking;
        private System.Windows.Forms.ColumnHeader BookingId;
        private System.Windows.Forms.ColumnHeader DateBooked;
        private System.Windows.Forms.ColumnHeader CheckIn;
        private System.Windows.Forms.ColumnHeader CheckOut;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader RoomName;
        private System.Windows.Forms.TabPage Invoice;
        private System.Windows.Forms.ListView listViewInvoice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnPayCredit;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Button btnUnpaid;
    }
}

