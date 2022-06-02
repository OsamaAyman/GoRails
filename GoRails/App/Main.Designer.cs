using Bunifu.Framework.UI;

namespace GoRails
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titlebar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.Panel();
            this.list_trains = new System.Windows.Forms.Button();
            this.train_delete_button = new System.Windows.Forms.Button();
            this.ticket_display_button = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.add_trains = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.sidebar_deleteticket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.book_train_id = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.book_train_id_error = new System.Windows.Forms.Label();
            this.find_train_button = new System.Windows.Forms.Button();
            this.book_train_class = new System.Windows.Forms.ComboBox();
            this.booking_container = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.book_train_class_error = new System.Windows.Forms.Label();
            this.selected_ticket = new System.Windows.Forms.Panel();
            this.book_price = new System.Windows.Forms.Label();
            this.Book_ID = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.train_arrival_location = new System.Windows.Forms.Label();
            this.train_departeur_location = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Book_status = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.train_arrival_time = new System.Windows.Forms.Label();
            this.train_departure_time = new System.Windows.Forms.Label();
            this.book_duration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Train_departeur_time_error = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.train_adding_page = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.train_add_arrival_date = new System.Windows.Forms.DateTimePicker();
            this.train_add_departure_date = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.train_add_tickt_price = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.train_add_arrival_location = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.train_add_departure_location = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.train_add_seat_number = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.delete_train_page = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.delete_train_msg = new System.Windows.Forms.Label();
            this.delete_train_error = new System.Windows.Forms.Label();
            this.train_delete_id = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.ticket_delete_page = new System.Windows.Forms.Panel();
            this.delete_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.delete_error = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete_textbox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.ticket_display_panel = new System.Windows.Forms.Panel();
            this.ticket_display_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.Trains_list_page = new System.Windows.Forms.Panel();
            this.train_display_flowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.titlebar.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.booking_container.SuspendLayout();
            this.selected_ticket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.train_adding_page.SuspendLayout();
            this.container.SuspendLayout();
            this.delete_train_page.SuspendLayout();
            this.ticket_delete_page.SuspendLayout();
            this.ticket_display_panel.SuspendLayout();
            this.Trains_list_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.titlebar.Controls.Add(this.button2);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(209, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(1022, 41);
            this.titlebar.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(980, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.sidebar.Controls.Add(this.list_trains);
            this.sidebar.Controls.Add(this.train_delete_button);
            this.sidebar.Controls.Add(this.ticket_display_button);
            this.sidebar.Controls.Add(this.logout);
            this.sidebar.Controls.Add(this.add_button);
            this.sidebar.Controls.Add(this.add_trains);
            this.sidebar.Controls.Add(this.SidePanel);
            this.sidebar.Controls.Add(this.sidebar_deleteticket);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(209, 690);
            this.sidebar.TabIndex = 0;
            // 
            // list_trains
            // 
            this.list_trains.FlatAppearance.BorderSize = 0;
            this.list_trains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_trains.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_trains.ForeColor = System.Drawing.Color.White;
            this.list_trains.Image = ((System.Drawing.Image)(resources.GetObject("list_trains.Image")));
            this.list_trains.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.list_trains.Location = new System.Drawing.Point(12, 259);
            this.list_trains.Name = "list_trains";
            this.list_trains.Size = new System.Drawing.Size(197, 54);
            this.list_trains.TabIndex = 12;
            this.list_trains.Text = "       Trains";
            this.list_trains.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.list_trains.UseVisualStyleBackColor = true;
            this.list_trains.Click += new System.EventHandler(this.sidebar_button_click);
            // 
            // train_delete_button
            // 
            this.train_delete_button.FlatAppearance.BorderSize = 0;
            this.train_delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.train_delete_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.train_delete_button.ForeColor = System.Drawing.Color.White;
            this.train_delete_button.Image = ((System.Drawing.Image)(resources.GetObject("train_delete_button.Image")));
            this.train_delete_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.train_delete_button.Location = new System.Drawing.Point(12, 319);
            this.train_delete_button.Name = "train_delete_button";
            this.train_delete_button.Size = new System.Drawing.Size(197, 54);
            this.train_delete_button.TabIndex = 11;
            this.train_delete_button.Text = "       Delete Train";
            this.train_delete_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.train_delete_button.UseVisualStyleBackColor = true;
            this.train_delete_button.Click += new System.EventHandler(this.sidebar_button_click);
            // 
            // ticket_display_button
            // 
            this.ticket_display_button.FlatAppearance.BorderSize = 0;
            this.ticket_display_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticket_display_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_display_button.ForeColor = System.Drawing.Color.White;
            this.ticket_display_button.Image = ((System.Drawing.Image)(resources.GetObject("ticket_display_button.Image")));
            this.ticket_display_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ticket_display_button.Location = new System.Drawing.Point(12, 104);
            this.ticket_display_button.Name = "ticket_display_button";
            this.ticket_display_button.Size = new System.Drawing.Size(197, 54);
            this.ticket_display_button.TabIndex = 10;
            this.ticket_display_button.Text = "       My Tickets";
            this.ticket_display_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ticket_display_button.UseVisualStyleBackColor = true;
            this.ticket_display_button.Click += new System.EventHandler(this.sidebar_button_click);
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(12, 633);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(197, 54);
            this.logout.TabIndex = 9;
            this.logout.Text = "       LOGOUT";
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_click);
            // 
            // add_button
            // 
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Image = ((System.Drawing.Image)(resources.GetObject("add_button.Image")));
            this.add_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_button.Location = new System.Drawing.Point(12, 157);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(197, 54);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "       Book Ticket";
            this.add_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.sidebar_button_click);
            // 
            // add_trains
            // 
            this.add_trains.FlatAppearance.BorderSize = 0;
            this.add_trains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_trains.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_trains.ForeColor = System.Drawing.Color.White;
            this.add_trains.Image = ((System.Drawing.Image)(resources.GetObject("add_trains.Image")));
            this.add_trains.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_trains.Location = new System.Drawing.Point(12, 379);
            this.add_trains.Name = "add_trains";
            this.add_trains.Size = new System.Drawing.Size(197, 54);
            this.add_trains.TabIndex = 7;
            this.add_trains.Text = "       ADD A TRAIN";
            this.add_trains.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_trains.UseVisualStyleBackColor = true;
            this.add_trains.Click += new System.EventHandler(this.sidebar_button_click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 104);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 6;
            // 
            // sidebar_deleteticket
            // 
            this.sidebar_deleteticket.FlatAppearance.BorderSize = 0;
            this.sidebar_deleteticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidebar_deleteticket.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidebar_deleteticket.ForeColor = System.Drawing.Color.White;
            this.sidebar_deleteticket.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_deleteticket.Image")));
            this.sidebar_deleteticket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebar_deleteticket.Location = new System.Drawing.Point(12, 209);
            this.sidebar_deleteticket.Name = "sidebar_deleteticket";
            this.sidebar_deleteticket.Size = new System.Drawing.Size(197, 54);
            this.sidebar_deleteticket.TabIndex = 5;
            this.sidebar_deleteticket.Text = "       Delete Ticket";
            this.sidebar_deleteticket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sidebar_deleteticket.UseVisualStyleBackColor = true;
            this.sidebar_deleteticket.Click += new System.EventHandler(this.sidebar_button_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Book A Ticket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Train ID : ";
            // 
            // book_train_id
            // 
            this.book_train_id.BackColor = System.Drawing.SystemColors.Control;
            this.book_train_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.book_train_id.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.book_train_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(159)))));
            this.book_train_id.Location = new System.Drawing.Point(32, 133);
            this.book_train_id.Name = "book_train_id";
            this.book_train_id.Size = new System.Drawing.Size(295, 17);
            this.book_train_id.TabIndex = 35;
            this.book_train_id.Text = "Enter Train ID";
            this.book_train_id.WordWrap = false;
            this.book_train_id.TextChanged += new System.EventHandler(this.numbers);
            this.book_train_id.MouseEnter += new System.EventHandler(this.pointer_Enter);
            this.book_train_id.MouseLeave += new System.EventHandler(this.pointer_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(159)))));
            this.panel3.Location = new System.Drawing.Point(32, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 2);
            this.panel3.TabIndex = 37;
            // 
            // book_train_id_error
            // 
            this.book_train_id_error.AutoSize = true;
            this.book_train_id_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.book_train_id_error.Location = new System.Drawing.Point(91, 97);
            this.book_train_id_error.Name = "book_train_id_error";
            this.book_train_id_error.Size = new System.Drawing.Size(0, 16);
            this.book_train_id_error.TabIndex = 39;
            // 
            // find_train_button
            // 
            this.find_train_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.find_train_button.FlatAppearance.BorderSize = 0;
            this.find_train_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_train_button.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.find_train_button.ForeColor = System.Drawing.Color.White;
            this.find_train_button.Location = new System.Drawing.Point(799, 124);
            this.find_train_button.Name = "find_train_button";
            this.find_train_button.Size = new System.Drawing.Size(144, 38);
            this.find_train_button.TabIndex = 47;
            this.find_train_button.Text = "Book";
            this.find_train_button.UseVisualStyleBackColor = false;
            this.find_train_button.Click += new System.EventHandler(this.FindAtrain);
            // 
            // book_train_class
            // 
            this.book_train_class.BackColor = System.Drawing.SystemColors.Control;
            this.book_train_class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_train_class.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.book_train_class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(159)))));
            this.book_train_class.FormattingEnabled = true;
            this.book_train_class.IntegralHeight = false;
            this.book_train_class.Items.AddRange(new object[] {
            "First Class",
            "Buisness Class",
            "Economic Class"});
            this.book_train_class.Location = new System.Drawing.Point(491, 133);
            this.book_train_class.Name = "book_train_class";
            this.book_train_class.Size = new System.Drawing.Size(212, 27);
            this.book_train_class.TabIndex = 51;
            this.book_train_class.Text = "Choose Class";
            // 
            // booking_container
            // 
            this.booking_container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.booking_container.Controls.Add(this.label24);
            this.booking_container.Controls.Add(this.book_train_class_error);
            this.booking_container.Controls.Add(this.selected_ticket);
            this.booking_container.Controls.Add(this.pictureBox1);
            this.booking_container.Controls.Add(this.book_train_class);
            this.booking_container.Controls.Add(this.find_train_button);
            this.booking_container.Controls.Add(this.book_train_id_error);
            this.booking_container.Controls.Add(this.panel3);
            this.booking_container.Controls.Add(this.book_train_id);
            this.booking_container.Controls.Add(this.label3);
            this.booking_container.Controls.Add(this.label1);
            this.booking_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booking_container.Location = new System.Drawing.Point(0, 0);
            this.booking_container.Name = "booking_container";
            this.booking_container.Size = new System.Drawing.Size(1022, 657);
            this.booking_container.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(487, 91);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 19);
            this.label24.TabIndex = 55;
            this.label24.Text = "Class : ";
            // 
            // book_train_class_error
            // 
            this.book_train_class_error.AutoSize = true;
            this.book_train_class_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.book_train_class_error.Location = new System.Drawing.Point(556, 92);
            this.book_train_class_error.Name = "book_train_class_error";
            this.book_train_class_error.Size = new System.Drawing.Size(0, 16);
            this.book_train_class_error.TabIndex = 54;
            // 
            // selected_ticket
            // 
            this.selected_ticket.Controls.Add(this.book_price);
            this.selected_ticket.Controls.Add(this.Book_ID);
            this.selected_ticket.Controls.Add(this.label28);
            this.selected_ticket.Controls.Add(this.label6);
            this.selected_ticket.Controls.Add(this.train_arrival_location);
            this.selected_ticket.Controls.Add(this.train_departeur_location);
            this.selected_ticket.Controls.Add(this.label12);
            this.selected_ticket.Controls.Add(this.label13);
            this.selected_ticket.Controls.Add(this.label14);
            this.selected_ticket.Controls.Add(this.Book_status);
            this.selected_ticket.Controls.Add(this.label11);
            this.selected_ticket.Controls.Add(this.train_arrival_time);
            this.selected_ticket.Controls.Add(this.train_departure_time);
            this.selected_ticket.Controls.Add(this.book_duration);
            this.selected_ticket.Controls.Add(this.label2);
            this.selected_ticket.Controls.Add(this.label5);
            this.selected_ticket.Controls.Add(this.Train_departeur_time_error);
            this.selected_ticket.Controls.Add(this.label10);
            this.selected_ticket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selected_ticket.Location = new System.Drawing.Point(0, 189);
            this.selected_ticket.Name = "selected_ticket";
            this.selected_ticket.Size = new System.Drawing.Size(1020, 466);
            this.selected_ticket.TabIndex = 53;
            // 
            // book_price
            // 
            this.book_price.AutoSize = true;
            this.book_price.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.book_price.ForeColor = System.Drawing.Color.Black;
            this.book_price.Location = new System.Drawing.Point(749, 343);
            this.book_price.Name = "book_price";
            this.book_price.Size = new System.Drawing.Size(57, 23);
            this.book_price.TabIndex = 78;
            this.book_price.Text = "Price";
            // 
            // Book_ID
            // 
            this.Book_ID.AutoSize = true;
            this.Book_ID.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Book_ID.ForeColor = System.Drawing.Color.Black;
            this.Book_ID.Location = new System.Drawing.Point(290, 343);
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.Size = new System.Drawing.Size(22, 19);
            this.Book_ID.TabIndex = 77;
            this.Book_ID.Text = "ID";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(53, 343);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 19);
            this.label28.TabIndex = 76;
            this.label28.Text = "Ticket ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label6.Location = new System.Drawing.Point(337, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 30);
            this.label6.TabIndex = 75;
            this.label6.Text = "Sucssfully Booked A Ticket !!";
            // 
            // train_arrival_location
            // 
            this.train_arrival_location.AutoSize = true;
            this.train_arrival_location.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.train_arrival_location.ForeColor = System.Drawing.Color.Black;
            this.train_arrival_location.Location = new System.Drawing.Point(749, 159);
            this.train_arrival_location.Name = "train_arrival_location";
            this.train_arrival_location.Size = new System.Drawing.Size(175, 19);
            this.train_arrival_location.TabIndex = 74;
            this.train_arrival_location.Text = "Train Departeur location";
            // 
            // train_departeur_location
            // 
            this.train_departeur_location.AutoSize = true;
            this.train_departeur_location.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.train_departeur_location.ForeColor = System.Drawing.Color.Black;
            this.train_departeur_location.Location = new System.Drawing.Point(749, 96);
            this.train_departeur_location.Name = "train_departeur_location";
            this.train_departeur_location.Size = new System.Drawing.Size(175, 19);
            this.train_departeur_location.TabIndex = 73;
            this.train_departeur_location.Text = "Train Departeur location";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(512, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 19);
            this.label12.TabIndex = 72;
            this.label12.Text = "Train Arrival location";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(606, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 71;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(512, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 19);
            this.label14.TabIndex = 70;
            this.label14.Text = "Train Departeur location";
            // 
            // Book_status
            // 
            this.Book_status.AutoSize = true;
            this.Book_status.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Book_status.ForeColor = System.Drawing.Color.Black;
            this.Book_status.Location = new System.Drawing.Point(290, 290);
            this.Book_status.Name = "Book_status";
            this.Book_status.Size = new System.Drawing.Size(48, 19);
            this.Book_status.TabIndex = 69;
            this.Book_status.Text = "status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(53, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 19);
            this.label11.TabIndex = 68;
            this.label11.Text = "Status";
            // 
            // train_arrival_time
            // 
            this.train_arrival_time.AutoSize = true;
            this.train_arrival_time.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.train_arrival_time.ForeColor = System.Drawing.Color.Black;
            this.train_arrival_time.Location = new System.Drawing.Point(290, 159);
            this.train_arrival_time.Name = "train_arrival_time";
            this.train_arrival_time.Size = new System.Drawing.Size(148, 19);
            this.train_arrival_time.TabIndex = 67;
            this.train_arrival_time.Text = "Train Departeur Time";
            // 
            // train_departure_time
            // 
            this.train_departure_time.AutoSize = true;
            this.train_departure_time.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.train_departure_time.ForeColor = System.Drawing.Color.Black;
            this.train_departure_time.Location = new System.Drawing.Point(290, 96);
            this.train_departure_time.Name = "train_departure_time";
            this.train_departure_time.Size = new System.Drawing.Size(148, 19);
            this.train_departure_time.TabIndex = 66;
            this.train_departure_time.Text = "Train Departeur Time";
            // 
            // book_duration
            // 
            this.book_duration.AutoSize = true;
            this.book_duration.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.book_duration.ForeColor = System.Drawing.Color.Black;
            this.book_duration.Location = new System.Drawing.Point(290, 225);
            this.book_duration.Name = "book_duration";
            this.book_duration.Size = new System.Drawing.Size(68, 19);
            this.book_duration.TabIndex = 65;
            this.book_duration.Text = "duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(53, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 64;
            this.label2.Text = "Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(53, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 63;
            this.label5.Text = "Train Arrival Time";
            // 
            // Train_departeur_time_error
            // 
            this.Train_departeur_time_error.AutoSize = true;
            this.Train_departeur_time_error.ForeColor = System.Drawing.Color.Black;
            this.Train_departeur_time_error.Location = new System.Drawing.Point(147, 96);
            this.Train_departeur_time_error.Name = "Train_departeur_time_error";
            this.Train_departeur_time_error.Size = new System.Drawing.Size(0, 16);
            this.Train_departeur_time_error.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(53, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 19);
            this.label10.TabIndex = 61;
            this.label10.Text = "Train Departeur Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoRails.Properties.Resources.Train_black;
            this.pictureBox1.Location = new System.Drawing.Point(46, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(897, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // train_adding_page
            // 
            this.train_adding_page.Controls.Add(this.button1);
            this.train_adding_page.Controls.Add(this.train_add_arrival_date);
            this.train_adding_page.Controls.Add(this.train_add_departure_date);
            this.train_adding_page.Controls.Add(this.label23);
            this.train_adding_page.Controls.Add(this.panel9);
            this.train_adding_page.Controls.Add(this.train_add_tickt_price);
            this.train_adding_page.Controls.Add(this.label22);
            this.train_adding_page.Controls.Add(this.panel8);
            this.train_adding_page.Controls.Add(this.train_add_arrival_location);
            this.train_adding_page.Controls.Add(this.label21);
            this.train_adding_page.Controls.Add(this.label20);
            this.train_adding_page.Controls.Add(this.panel6);
            this.train_adding_page.Controls.Add(this.train_add_departure_location);
            this.train_adding_page.Controls.Add(this.label7);
            this.train_adding_page.Controls.Add(this.label19);
            this.train_adding_page.Controls.Add(this.label18);
            this.train_adding_page.Controls.Add(this.label16);
            this.train_adding_page.Controls.Add(this.label17);
            this.train_adding_page.Controls.Add(this.label15);
            this.train_adding_page.Controls.Add(this.label9);
            this.train_adding_page.Controls.Add(this.label4);
            this.train_adding_page.Controls.Add(this.panel4);
            this.train_adding_page.Controls.Add(this.train_add_seat_number);
            this.train_adding_page.Controls.Add(this.label8);
            this.train_adding_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.train_adding_page.Location = new System.Drawing.Point(0, 0);
            this.train_adding_page.Name = "train_adding_page";
            this.train_adding_page.Size = new System.Drawing.Size(1022, 657);
            this.train_adding_page.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(866, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 38);
            this.button1.TabIndex = 77;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.train_add);
            // 
            // train_add_arrival_date
            // 
            this.train_add_arrival_date.CustomFormat = "dddd ,MMMM dd ,yyyy HH:mm tt";
            this.train_add_arrival_date.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.train_add_arrival_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.train_add_arrival_date.Location = new System.Drawing.Point(283, 333);
            this.train_add_arrival_date.Name = "train_add_arrival_date";
            this.train_add_arrival_date.Size = new System.Drawing.Size(342, 24);
            this.train_add_arrival_date.TabIndex = 67;
            // 
            // train_add_departure_date
            // 
            this.train_add_departure_date.CustomFormat = "dddd ,MMMM dd ,yyyy HH:mm tt";
            this.train_add_departure_date.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.train_add_departure_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.train_add_departure_date.Location = new System.Drawing.Point(283, 190);
            this.train_add_departure_date.Name = "train_add_departure_date";
            this.train_add_departure_date.Size = new System.Drawing.Size(342, 24);
            this.train_add_departure_date.TabIndex = 66;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.label23.Location = new System.Drawing.Point(294, 489);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 16);
            this.label23.TabIndex = 65;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.panel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(159)))));
            this.panel9.Location = new System.Drawing.Point(283, 484);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(342, 2);
            this.panel9.TabIndex = 64;
            // 
            // train_add_tickt_price
            // 
            this.train_add_tickt_price.BackColor = System.Drawing.SystemColors.Control;
            this.train_add_tickt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.train_add_tickt_price.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.train_add_tickt_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(159)))));
            this.train_add_tickt_price.Location = new System.Drawing.Point(283, 461);
            this.train_add_tickt_price.Name = "train_add_tickt_price";
            this.train_add_tickt_price.Size = new System.Drawing.Size(295, 17);
            this.train_add_tickt_price.TabIndex = 63;
            this.train_add_tickt_price.Text = "Enter Average Tiket Price";
            this.train_add_tickt_price.WordWrap = false;
            this.train_add_tickt_price.TextChanged += new System.EventHandler(this.numbers);
            this.train_add_tickt_price.Enter += new System.EventHandler(this.pointer_Enter);
            this.train_add_tickt_price.Leave += new System.EventHandler(this.pointer_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.label22.Location = new System.Drawing.Point(294, 425);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 16);
            this.label22.TabIndex = 62;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(159)))));
            this.panel8.Location = new System.Drawing.Point(283, 420);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(342, 2);
            this.panel8.TabIndex = 61;
            // 
            // train_add_arrival_location
            // 
            this.train_add_arrival_location.BackColor = System.Drawing.SystemColors.Control;
            this.train_add_arrival_location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.train_add_arrival_location.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.train_add_arrival_location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(159)))));
            this.train_add_arrival_location.Location = new System.Drawing.Point(283, 397);
            this.train_add_arrival_location.Name = "train_add_arrival_location";
            this.train_add_arrival_location.Size = new System.Drawing.Size(295, 17);
            this.train_add_arrival_location.TabIndex = 60;
            this.train_add_arrival_location.Text = "Enter Arrival Location";
            this.train_add_arrival_location.WordWrap = false;
            this.train_add_arrival_location.Enter += new System.EventHandler(this.pointer_Enter);
            this.train_add_arrival_location.Leave += new System.EventHandler(this.pointer_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.label21.Location = new System.Drawing.Point(294, 357);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 16);
            this.label21.TabIndex = 59;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.label20.Location = new System.Drawing.Point(294, 291);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 16);
            this.label20.TabIndex = 56;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(159)))));
            this.panel6.Location = new System.Drawing.Point(283, 286);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 2);
            this.panel6.TabIndex = 55;
            // 
            // train_add_departure_location
            // 
            this.train_add_departure_location.BackColor = System.Drawing.SystemColors.Control;
            this.train_add_departure_location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.train_add_departure_location.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.train_add_departure_location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(159)))));
            this.train_add_departure_location.Location = new System.Drawing.Point(283, 263);
            this.train_add_departure_location.Name = "train_add_departure_location";
            this.train_add_departure_location.Size = new System.Drawing.Size(295, 17);
            this.train_add_departure_location.TabIndex = 54;
            this.train_add_departure_location.Text = "Enter Departure Location";
            this.train_add_departure_location.WordWrap = false;
            this.train_add_departure_location.Enter += new System.EventHandler(this.pointer_Enter);
            this.train_add_departure_location.Leave += new System.EventHandler(this.pointer_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.label7.Location = new System.Drawing.Point(294, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 53;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(82, 463);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 19);
            this.label19.TabIndex = 50;
            this.label19.Text = "Ticket Price : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(82, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(133, 19);
            this.label18.TabIndex = 49;
            this.label18.Text = "Number of Seats : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(82, 399);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 19);
            this.label16.TabIndex = 48;
            this.label16.Text = "Arrival Location : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(82, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 19);
            this.label17.TabIndex = 47;
            this.label17.Text = "Departure Location : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(82, 331);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 19);
            this.label15.TabIndex = 46;
            this.label15.Text = "Arrival Date : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(82, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "Departure Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.label4.Location = new System.Drawing.Point(294, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(159)))));
            this.panel4.Location = new System.Drawing.Point(283, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 2);
            this.panel4.TabIndex = 43;
            // 
            // train_add_seat_number
            // 
            this.train_add_seat_number.BackColor = System.Drawing.SystemColors.Control;
            this.train_add_seat_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.train_add_seat_number.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.train_add_seat_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(159)))));
            this.train_add_seat_number.Location = new System.Drawing.Point(283, 116);
            this.train_add_seat_number.Name = "train_add_seat_number";
            this.train_add_seat_number.Size = new System.Drawing.Size(295, 17);
            this.train_add_seat_number.TabIndex = 42;
            this.train_add_seat_number.Text = "Enter the Number of Seats ";
            this.train_add_seat_number.WordWrap = false;
            this.train_add_seat_number.TextChanged += new System.EventHandler(this.numbers);
            this.train_add_seat_number.Enter += new System.EventHandler(this.pointer_Enter);
            this.train_add_seat_number.Leave += new System.EventHandler(this.pointer_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(82, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 41;
            this.label8.Text = "Add A Train";
            // 
            // container
            // 
            this.container.Controls.Add(this.train_adding_page);
            this.container.Controls.Add(this.ticket_display_panel);
            this.container.Controls.Add(this.Trains_list_page);
            this.container.Controls.Add(this.delete_train_page);
            this.container.Controls.Add(this.ticket_delete_page);
            this.container.Controls.Add(this.booking_container);
            this.container.Location = new System.Drawing.Point(209, 38);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1022, 657);
            this.container.TabIndex = 3;
            // 
            // delete_train_page
            // 
            this.delete_train_page.Controls.Add(this.button3);
            this.delete_train_page.Controls.Add(this.delete_train_msg);
            this.delete_train_page.Controls.Add(this.delete_train_error);
            this.delete_train_page.Controls.Add(this.train_delete_id);
            this.delete_train_page.Controls.Add(this.label30);
            this.delete_train_page.Controls.Add(this.label31);
            this.delete_train_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_train_page.Location = new System.Drawing.Point(0, 0);
            this.delete_train_page.Name = "delete_train_page";
            this.delete_train_page.Size = new System.Drawing.Size(1022, 657);
            this.delete_train_page.TabIndex = 51;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(836, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 38);
            this.button3.TabIndex = 62;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // delete_train_msg
            // 
            this.delete_train_msg.AutoSize = true;
            this.delete_train_msg.Font = new System.Drawing.Font("Century Gothic", 35.25F);
            this.delete_train_msg.Location = new System.Drawing.Point(369, 331);
            this.delete_train_msg.Name = "delete_train_msg";
            this.delete_train_msg.Size = new System.Drawing.Size(0, 57);
            this.delete_train_msg.TabIndex = 63;
            // 
            // delete_train_error
            // 
            this.delete_train_error.AutoSize = true;
            this.delete_train_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.delete_train_error.Location = new System.Drawing.Point(104, 82);
            this.delete_train_error.Name = "delete_train_error";
            this.delete_train_error.Size = new System.Drawing.Size(0, 16);
            this.delete_train_error.TabIndex = 61;
            // 
            // train_delete_id
            // 
            this.train_delete_id.BackColor = System.Drawing.SystemColors.Control;
            this.train_delete_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.train_delete_id.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.train_delete_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(159)))));
            this.train_delete_id.Location = new System.Drawing.Point(33, 116);
            this.train_delete_id.Name = "train_delete_id";
            this.train_delete_id.Size = new System.Drawing.Size(295, 17);
            this.train_delete_id.TabIndex = 59;
            this.train_delete_id.Text = "Enter Ticket ID";
            this.train_delete_id.WordWrap = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(29, 78);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(76, 19);
            this.label30.TabIndex = 57;
            this.label30.Text = "Ticket ID : ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(29, 10);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(151, 24);
            this.label31.TabIndex = 58;
            this.label31.Text = "Delete A Train";
            // 
            // ticket_delete_page
            // 
            this.ticket_delete_page.Controls.Add(this.delete_label);
            this.ticket_delete_page.Controls.Add(this.delete_button);
            this.ticket_delete_page.Controls.Add(this.delete_error);
            this.ticket_delete_page.Controls.Add(this.panel1);
            this.ticket_delete_page.Controls.Add(this.delete_textbox);
            this.ticket_delete_page.Controls.Add(this.label26);
            this.ticket_delete_page.Controls.Add(this.label27);
            this.ticket_delete_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticket_delete_page.Location = new System.Drawing.Point(0, 0);
            this.ticket_delete_page.Name = "ticket_delete_page";
            this.ticket_delete_page.Size = new System.Drawing.Size(1022, 657);
            this.ticket_delete_page.TabIndex = 3;
            // 
            // delete_label
            // 
            this.delete_label.AutoSize = true;
            this.delete_label.Font = new System.Drawing.Font("Century Gothic", 35.25F);
            this.delete_label.Location = new System.Drawing.Point(363, 331);
            this.delete_label.Name = "delete_label";
            this.delete_label.Size = new System.Drawing.Size(0, 57);
            this.delete_label.TabIndex = 49;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.delete_button.ForeColor = System.Drawing.Color.White;
            this.delete_button.Location = new System.Drawing.Point(754, 121);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(144, 38);
            this.delete_button.TabIndex = 48;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // delete_error
            // 
            this.delete_error.AutoSize = true;
            this.delete_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.delete_error.Location = new System.Drawing.Point(122, 98);
            this.delete_error.Name = "delete_error";
            this.delete_error.Size = new System.Drawing.Size(0, 16);
            this.delete_error.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(159)))));
            this.panel1.Location = new System.Drawing.Point(47, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 2);
            this.panel1.TabIndex = 43;
            // 
            // delete_textbox
            // 
            this.delete_textbox.BackColor = System.Drawing.SystemColors.Control;
            this.delete_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delete_textbox.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.delete_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(159)))));
            this.delete_textbox.Location = new System.Drawing.Point(47, 134);
            this.delete_textbox.Name = "delete_textbox";
            this.delete_textbox.Size = new System.Drawing.Size(295, 17);
            this.delete_textbox.TabIndex = 42;
            this.delete_textbox.Text = "Enter Ticket ID";
            this.delete_textbox.WordWrap = false;
            this.delete_textbox.TextChanged += new System.EventHandler(this.numbers);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(43, 97);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 19);
            this.label26.TabIndex = 40;
            this.label26.Text = "Ticket ID : ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(43, 34);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(164, 24);
            this.label27.TabIndex = 41;
            this.label27.Text = "Delete A Ticket";
            // 
            // ticket_display_panel
            // 
            this.ticket_display_panel.Controls.Add(this.ticket_display_flow);
            this.ticket_display_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticket_display_panel.Location = new System.Drawing.Point(0, 0);
            this.ticket_display_panel.Name = "ticket_display_panel";
            this.ticket_display_panel.Size = new System.Drawing.Size(1022, 657);
            this.ticket_display_panel.TabIndex = 4;
            // 
            // ticket_display_flow
            // 
            this.ticket_display_flow.AutoScroll = true;
            this.ticket_display_flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticket_display_flow.Location = new System.Drawing.Point(0, 0);
            this.ticket_display_flow.Name = "ticket_display_flow";
            this.ticket_display_flow.Size = new System.Drawing.Size(1022, 657);
            this.ticket_display_flow.TabIndex = 0;
            // 
            // Trains_list_page
            // 
            this.Trains_list_page.Controls.Add(this.train_display_flowpanel);
            this.Trains_list_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Trains_list_page.Location = new System.Drawing.Point(0, 0);
            this.Trains_list_page.Name = "Trains_list_page";
            this.Trains_list_page.Size = new System.Drawing.Size(1022, 657);
            this.Trains_list_page.TabIndex = 5;
            // 
            // train_display_flowpanel
            // 
            this.train_display_flowpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.train_display_flowpanel.Location = new System.Drawing.Point(0, 0);
            this.train_display_flowpanel.Name = "train_display_flowpanel";
            this.train_display_flowpanel.Size = new System.Drawing.Size(1022, 657);
            this.train_display_flowpanel.TabIndex = 0;
            this.train_display_flowpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.train_display_flowpanel_Paint);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.titlebar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 690);
            this.Controls.Add(this.titlebar);
            this.Controls.Add(this.container);
            this.Controls.Add(this.sidebar);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "GoRails";
            this.titlebar.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.booking_container.ResumeLayout(false);
            this.booking_container.PerformLayout();
            this.selected_ticket.ResumeLayout(false);
            this.selected_ticket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.train_adding_page.ResumeLayout(false);
            this.train_adding_page.PerformLayout();
            this.container.ResumeLayout(false);
            this.delete_train_page.ResumeLayout(false);
            this.delete_train_page.PerformLayout();
            this.ticket_delete_page.ResumeLayout(false);
            this.ticket_delete_page.PerformLayout();
            this.ticket_display_panel.ResumeLayout(false);
            this.Trains_list_page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button add_trains;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button sidebar_deleteticket;
        private System.Windows.Forms.Panel booking_container;
        private System.Windows.Forms.ComboBox book_train_class;
        private System.Windows.Forms.Button find_train_button;
        private System.Windows.Forms.Label book_train_id_error;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox book_train_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel selected_ticket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label train_arrival_location;
        private System.Windows.Forms.Label train_departeur_location;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Book_status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label train_arrival_time;
        private System.Windows.Forms.Label train_departure_time;
        private System.Windows.Forms.Label book_duration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Train_departeur_time_error;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label book_train_class_error;
        private System.Windows.Forms.Panel train_adding_page;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox train_add_seat_number;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker train_add_arrival_date;
        private System.Windows.Forms.DateTimePicker train_add_departure_date;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox train_add_tickt_price;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox train_add_arrival_location;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox train_add_departure_location;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel ticket_delete_page;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label delete_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label delete_error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox delete_textbox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button ticket_display_button;
        private System.Windows.Forms.Panel ticket_display_panel;
        private System.Windows.Forms.FlowLayoutPanel ticket_display_flow;
        private System.Windows.Forms.Label Book_ID;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label book_price;
        private System.Windows.Forms.Button list_trains;
        private System.Windows.Forms.Button train_delete_button;
        private BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel Trains_list_page;
        private System.Windows.Forms.FlowLayoutPanel train_display_flowpanel;
        private System.Windows.Forms.Panel delete_train_page;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox train_delete_id;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label delete_train_msg;
        private System.Windows.Forms.Label delete_train_error;
    }
}

