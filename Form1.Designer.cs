namespace AirplaneBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panelPassengers = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.allPassengers = new System.Windows.Forms.ListBox();
            this.returnTicket = new System.Windows.Forms.CheckBox();
            this.refresh = new System.Windows.Forms.Button();
            this.landingCities = new System.Windows.Forms.ListBox();
            this.departureCities = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.checkSeat = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.seatNumber = new System.Windows.Forms.ListBox();
            this.seatLetter = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deptDate = new System.Windows.Forms.DateTimePicker();
            this.Book = new System.Windows.Forms.Button();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFlight = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.feedback = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.mealProvided = new System.Windows.Forms.CheckBox();
            this.departingAirport = new System.Windows.Forms.TextBox();
            this.landingAirport = new System.Windows.Forms.TextBox();
            this.transitCity = new System.Windows.Forms.TextBox();
            this.airplaneType = new System.Windows.Forms.TextBox();
            this.capacity = new System.Windows.Forms.TextBox();
            this.numberOfRows = new System.Windows.Forms.TextBox();
            this.flightID = new System.Windows.Forms.TextBox();
            this.arrivalCalendar = new System.Windows.Forms.MonthCalendar();
            this.departingCalendar = new System.Windows.Forms.MonthCalendar();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPassengers.SuspendLayout();
            this.panelFlight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.info);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 587);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // info
            // 
            this.info.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.info.FlatAppearance.BorderSize = 0;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.Gold;
            this.info.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.info.Location = new System.Drawing.Point(19, 22);
            this.info.Margin = new System.Windows.Forms.Padding(0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(194, 123);
            this.info.TabIndex = 3;
            this.info.Text = "Flight Manager";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(19, 355);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 188);
            this.button2.TabIndex = 2;
            this.button2.Text = "Flights";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(19, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 188);
            this.button1.TabIndex = 1;
            this.button1.Text = "Passengers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.minimize);
            this.panel2.Controls.Add(this.close);
            this.panel2.Location = new System.Drawing.Point(232, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 29);
            this.panel2.TabIndex = 1;
            // 
            // minimize
            // 
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(640, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(34, 29);
            this.minimize.TabIndex = 2;
            this.minimize.Text = "-";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(674, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 29);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.close.UseMnemonic = false;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panelPassengers
            // 
            this.panelPassengers.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelPassengers.Controls.Add(this.lbl);
            this.panelPassengers.Controls.Add(this.allPassengers);
            this.panelPassengers.Controls.Add(this.returnTicket);
            this.panelPassengers.Controls.Add(this.refresh);
            this.panelPassengers.Controls.Add(this.landingCities);
            this.panelPassengers.Controls.Add(this.departureCities);
            this.panelPassengers.Controls.Add(this.label18);
            this.panelPassengers.Controls.Add(this.label19);
            this.panelPassengers.Controls.Add(this.checkSeat);
            this.panelPassengers.Controls.Add(this.label16);
            this.panelPassengers.Controls.Add(this.label15);
            this.panelPassengers.Controls.Add(this.seatNumber);
            this.panelPassengers.Controls.Add(this.seatLetter);
            this.panelPassengers.Controls.Add(this.label5);
            this.panelPassengers.Controls.Add(this.label4);
            this.panelPassengers.Controls.Add(this.label3);
            this.panelPassengers.Controls.Add(this.deptDate);
            this.panelPassengers.Controls.Add(this.Book);
            this.panelPassengers.Controls.Add(this.lastName);
            this.panelPassengers.Controls.Add(this.firstName);
            this.panelPassengers.Controls.Add(this.label2);
            this.panelPassengers.Controls.Add(this.label1);
            this.panelPassengers.Location = new System.Drawing.Point(235, 29);
            this.panelPassengers.Name = "panelPassengers";
            this.panelPassengers.Size = new System.Drawing.Size(703, 559);
            this.panelPassengers.TabIndex = 2;
            this.panelPassengers.Visible = false;
            this.panelPassengers.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPassengers_Paint);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl.Location = new System.Drawing.Point(529, 160);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(116, 17);
            this.lbl.TabIndex = 29;
            this.lbl.Text = "All Passengers";
            // 
            // allPassengers
            // 
            this.allPassengers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.allPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.allPassengers.FormattingEnabled = true;
            this.allPassengers.ItemHeight = 18;
            this.allPassengers.Location = new System.Drawing.Point(516, 189);
            this.allPassengers.Name = "allPassengers";
            this.allPassengers.Size = new System.Drawing.Size(153, 166);
            this.allPassengers.TabIndex = 28;
            // 
            // returnTicket
            // 
            this.returnTicket.AutoSize = true;
            this.returnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.returnTicket.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.returnTicket.Location = new System.Drawing.Point(375, 218);
            this.returnTicket.Name = "returnTicket";
            this.returnTicket.Size = new System.Drawing.Size(103, 24);
            this.returnTicket.TabIndex = 27;
            this.returnTicket.Text = "Two way";
            this.returnTicket.UseVisualStyleBackColor = true;
            this.returnTicket.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.refresh.FlatAppearance.BorderSize = 4;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refresh.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.refresh.Location = new System.Drawing.Point(524, 462);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(131, 73);
            this.refresh.TabIndex = 26;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // landingCities
            // 
            this.landingCities.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.landingCities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.landingCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landingCities.ForeColor = System.Drawing.SystemColors.WindowText;
            this.landingCities.FormattingEnabled = true;
            this.landingCities.ItemHeight = 18;
            this.landingCities.Location = new System.Drawing.Point(235, 239);
            this.landingCities.Name = "landingCities";
            this.landingCities.Size = new System.Drawing.Size(120, 108);
            this.landingCities.TabIndex = 25;
            // 
            // departureCities
            // 
            this.departureCities.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.departureCities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departureCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.departureCities.ForeColor = System.Drawing.SystemColors.WindowText;
            this.departureCities.FormattingEnabled = true;
            this.departureCities.ItemHeight = 18;
            this.departureCities.Location = new System.Drawing.Point(50, 239);
            this.departureCities.Name = "departureCities";
            this.departureCities.Size = new System.Drawing.Size(128, 108);
            this.departureCities.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label18.Location = new System.Drawing.Point(231, 212);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "Landing City";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label19.Location = new System.Drawing.Point(46, 212);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 20);
            this.label19.TabIndex = 22;
            this.label19.Text = "Departure City";
            this.label19.Click += new System.EventHandler(this.Label19_Click);
            // 
            // checkSeat
            // 
            this.checkSeat.FlatAppearance.BorderSize = 4;
            this.checkSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkSeat.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.checkSeat.Location = new System.Drawing.Point(498, 395);
            this.checkSeat.Name = "checkSeat";
            this.checkSeat.Size = new System.Drawing.Size(157, 36);
            this.checkSeat.TabIndex = 20;
            this.checkSeat.Text = "check seat";
            this.checkSeat.UseVisualStyleBackColor = true;
            this.checkSeat.Click += new System.EventHandler(this.CheckSeat_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label16.Location = new System.Drawing.Point(349, 375);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Seat Letter";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label15.Location = new System.Drawing.Point(150, 375);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "Seat Number";
            // 
            // seatNumber
            // 
            this.seatNumber.FormattingEnabled = true;
            this.seatNumber.ItemHeight = 16;
            this.seatNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.seatNumber.Location = new System.Drawing.Point(145, 395);
            this.seatNumber.Name = "seatNumber";
            this.seatNumber.Size = new System.Drawing.Size(119, 36);
            this.seatNumber.TabIndex = 17;
            // 
            // seatLetter
            // 
            this.seatLetter.FormattingEnabled = true;
            this.seatLetter.ItemHeight = 16;
            this.seatLetter.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.seatLetter.Location = new System.Drawing.Point(335, 395);
            this.seatLetter.Name = "seatLetter";
            this.seatLetter.Size = new System.Drawing.Size(120, 36);
            this.seatLetter.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(45, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(186, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please fill the information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(429, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Departure date";
            // 
            // deptDate
            // 
            this.deptDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.deptDate.Location = new System.Drawing.Point(375, 98);
            this.deptDate.Name = "deptDate";
            this.deptDate.Size = new System.Drawing.Size(267, 22);
            this.deptDate.TabIndex = 5;
            // 
            // Book
            // 
            this.Book.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.Book.FlatAppearance.BorderSize = 4;
            this.Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Book.ForeColor = System.Drawing.Color.Yellow;
            this.Book.Location = new System.Drawing.Point(50, 462);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(468, 73);
            this.Book.TabIndex = 4;
            this.Book.Text = "Book";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastName.Location = new System.Drawing.Point(153, 134);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(135, 21);
            this.lastName.TabIndex = 3;
            this.lastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.firstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstName.Location = new System.Drawing.Point(153, 98);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(135, 21);
            this.firstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(36, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(36, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // panelFlight
            // 
            this.panelFlight.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelFlight.Controls.Add(this.label17);
            this.panelFlight.Controls.Add(this.feedback);
            this.panelFlight.Controls.Add(this.button4);
            this.panelFlight.Controls.Add(this.mealProvided);
            this.panelFlight.Controls.Add(this.departingAirport);
            this.panelFlight.Controls.Add(this.landingAirport);
            this.panelFlight.Controls.Add(this.transitCity);
            this.panelFlight.Controls.Add(this.airplaneType);
            this.panelFlight.Controls.Add(this.capacity);
            this.panelFlight.Controls.Add(this.numberOfRows);
            this.panelFlight.Controls.Add(this.flightID);
            this.panelFlight.Controls.Add(this.arrivalCalendar);
            this.panelFlight.Controls.Add(this.departingCalendar);
            this.panelFlight.Controls.Add(this.label14);
            this.panelFlight.Controls.Add(this.label13);
            this.panelFlight.Controls.Add(this.label12);
            this.panelFlight.Controls.Add(this.label11);
            this.panelFlight.Controls.Add(this.label10);
            this.panelFlight.Controls.Add(this.label9);
            this.panelFlight.Controls.Add(this.label8);
            this.panelFlight.Controls.Add(this.label7);
            this.panelFlight.Controls.Add(this.label6);
            this.panelFlight.Location = new System.Drawing.Point(235, 29);
            this.panelFlight.Name = "panelFlight";
            this.panelFlight.Size = new System.Drawing.Size(703, 559);
            this.panelFlight.TabIndex = 11;
            this.panelFlight.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelFlight_Paint);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label17.Location = new System.Drawing.Point(387, 477);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 25);
            this.label17.TabIndex = 21;
            this.label17.Text = "LOG";
            this.label17.Click += new System.EventHandler(this.Label17_Click);
            // 
            // feedback
            // 
            this.feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.feedback.Location = new System.Drawing.Point(447, 469);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(200, 45);
            this.feedback.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 5;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(122, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 83);
            this.button4.TabIndex = 19;
            this.button4.Text = "Add Flight";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // mealProvided
            // 
            this.mealProvided.AutoSize = true;
            this.mealProvided.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mealProvided.Location = new System.Drawing.Point(172, 379);
            this.mealProvided.Name = "mealProvided";
            this.mealProvided.Size = new System.Drawing.Size(18, 17);
            this.mealProvided.TabIndex = 18;
            this.mealProvided.UseVisualStyleBackColor = true;
            // 
            // departingAirport
            // 
            this.departingAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.departingAirport.Location = new System.Drawing.Point(172, 147);
            this.departingAirport.Name = "departingAirport";
            this.departingAirport.Size = new System.Drawing.Size(121, 24);
            this.departingAirport.TabIndex = 17;
            // 
            // landingAirport
            // 
            this.landingAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.landingAirport.Location = new System.Drawing.Point(172, 185);
            this.landingAirport.Name = "landingAirport";
            this.landingAirport.Size = new System.Drawing.Size(121, 24);
            this.landingAirport.TabIndex = 16;
            // 
            // transitCity
            // 
            this.transitCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.transitCity.Location = new System.Drawing.Point(172, 221);
            this.transitCity.Name = "transitCity";
            this.transitCity.Size = new System.Drawing.Size(121, 24);
            this.transitCity.TabIndex = 15;
            // 
            // airplaneType
            // 
            this.airplaneType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.airplaneType.Location = new System.Drawing.Point(172, 256);
            this.airplaneType.Name = "airplaneType";
            this.airplaneType.Size = new System.Drawing.Size(121, 24);
            this.airplaneType.TabIndex = 14;
            // 
            // capacity
            // 
            this.capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.capacity.Location = new System.Drawing.Point(172, 297);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(121, 24);
            this.capacity.TabIndex = 13;
            // 
            // numberOfRows
            // 
            this.numberOfRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfRows.Location = new System.Drawing.Point(172, 335);
            this.numberOfRows.Name = "numberOfRows";
            this.numberOfRows.Size = new System.Drawing.Size(121, 24);
            this.numberOfRows.TabIndex = 12;
            // 
            // flightID
            // 
            this.flightID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flightID.Location = new System.Drawing.Point(172, 111);
            this.flightID.Name = "flightID";
            this.flightID.Size = new System.Drawing.Size(121, 24);
            this.flightID.TabIndex = 11;
            this.flightID.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // arrivalCalendar
            // 
            this.arrivalCalendar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.arrivalCalendar.Location = new System.Drawing.Point(406, 247);
            this.arrivalCalendar.Name = "arrivalCalendar";
            this.arrivalCalendar.TabIndex = 10;
            // 
            // departingCalendar
            // 
            this.departingCalendar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.departingCalendar.Location = new System.Drawing.Point(406, 27);
            this.departingCalendar.Name = "departingCalendar";
            this.departingCalendar.TabIndex = 9;
            this.departingCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DepartingCalendar_DateChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label14.Location = new System.Drawing.Point(40, 379);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 18);
            this.label14.TabIndex = 8;
            this.label14.Text = "Meal Provided";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(40, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 18);
            this.label13.TabIndex = 7;
            this.label13.Text = "Capacity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(40, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Airplane type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(40, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "Transit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(40, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Departing Airport";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(40, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Number of rows";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(40, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Landing Airport";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(40, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Flight ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(57, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Manage flights";
            this.label6.Click += new System.EventHandler(this.Label6_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(938, 590);
            this.Controls.Add(this.panelFlight);
            this.Controls.Add(this.panelPassengers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.BackgroundImageChanged += new System.EventHandler(this.Form1_BackgroundImageChanged);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelPassengers.ResumeLayout(false);
            this.panelPassengers.PerformLayout();
            this.panelFlight.ResumeLayout(false);
            this.panelFlight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Panel panelPassengers;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.DateTimePicker deptDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button checkSeat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox seatNumber;
        private System.Windows.Forms.ListBox seatLetter;
        private System.Windows.Forms.Panel panelFlight;
        private System.Windows.Forms.CheckBox mealProvided;
        private System.Windows.Forms.TextBox departingAirport;
        private System.Windows.Forms.TextBox landingAirport;
        private System.Windows.Forms.TextBox transitCity;
        private System.Windows.Forms.TextBox airplaneType;
        private System.Windows.Forms.TextBox capacity;
        private System.Windows.Forms.TextBox numberOfRows;
        private System.Windows.Forms.TextBox flightID;
        private System.Windows.Forms.MonthCalendar arrivalCalendar;
        private System.Windows.Forms.MonthCalendar departingCalendar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox feedback;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox landingCities;
        private System.Windows.Forms.ListBox departureCities;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.CheckBox returnTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ListBox allPassengers;
    }
}

