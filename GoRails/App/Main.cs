using System;
using GoRails.App;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GoRails
{
    public partial class MainForm : Form
    {
        public bool Out=false;
        int ID;
        public static SqlConnection con = new SqlConnection(@"Data Source=OSOS-PC\SQLEXPRESS;Initial Catalog=gorails;Integrated Security=True");
        public MainForm(int id)
        {
            InitializeComponent();
            booking_container.Visible = false;
            train_adding_page.Visible = false;
            ticket_delete_page.Visible = false;
            ticket_display_panel.Visible = true;
            Trains_list_page.Visible = false;
            delete_train_page.Visible = false;

            ID = id;
            if (id != 0)
            {
                add_trains.Visible = false;
                train_delete_button.Visible = false;

            }
            display_all();
        }

        private void sidebar_button_click(object sender, EventArgs e)
        {
            var se = (Button)sender;
            SidePanel.Top = se.Top;
            if(se.Name== "add_button")
            {
                booking_container.Visible = true;
                selected_ticket.Visible = false;
                train_adding_page.Visible = false;
                ticket_delete_page.Visible = false;
                ticket_display_panel.Visible = false;
                Trains_list_page.Visible = false;
                delete_train_page.Visible = false;



            }
            else if (se.Name == "sidebar_deleteticket")
            {
                booking_container.Visible = false;
                train_adding_page.Visible = false;
                ticket_delete_page.Visible = true;
                ticket_display_panel.Visible = false;
                delete_train_page.Visible = false;

                Trains_list_page.Visible = false;


            }
            else if (se.Name == "add_trains")
            {
                booking_container.Visible = false;
                train_adding_page.Visible = true;
                ticket_delete_page.Visible = false;
                ticket_display_panel.Visible = false;
                delete_train_page.Visible = false;

                Trains_list_page.Visible = false;


            }
            else if(se.Name== "ticket_display_button")
            {
                booking_container.Visible = false;
                train_adding_page.Visible = false;
                ticket_delete_page.Visible = false;
                ticket_display_panel.Visible = true;
                Trains_list_page.Visible = false;
                delete_train_page.Visible = false;


                display_my_ticket();
            }
            else if(se.Name=="list_trains")
            {
                booking_container.Visible = false;
                train_adding_page.Visible = false;
                ticket_delete_page.Visible = false;
                ticket_display_panel.Visible = false;
                Trains_list_page.Visible = true;
                delete_train_page.Visible = false;
                display_trains();

            }
            else if(se.Name== "train_delete_button")
            {
                booking_container.Visible = false;
                train_adding_page.Visible = false;
                ticket_delete_page.Visible = false;
                ticket_display_panel.Visible = false;
                Trains_list_page.Visible = false;
                delete_train_page.Visible = true;
            }
        }
        private void display_trains()
        {
            train_display_flowpanel.Controls.Clear();
            using (SqlCommand cmd = new SqlCommand("get_trains", con))
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    treno t = new treno();
                    t.Train_ID = reader[0].ToString();
                    t.Seat1= reader[2].ToString();
                    t.Seat2 = reader[3].ToString();
                    t.Seat3 = reader[4].ToString();
                    t.when = reader[5].ToString();
                    t.from_location = reader[6].ToString();
                    t.until = reader[7].ToString();
                    t.to_location = reader[8].ToString();
                    t.Duration = reader[9].ToString();
                    t.get_price = reader[10].ToString();
                    t.Width = 850;
                    t.Height = 105;
                    train_display_flowpanel.Controls.Add(t);


                }
                con.Close();
            }
        }
        private void display_all()
        {
            ticket_display_flow.Controls.Clear();
            using (SqlCommand cmd = new SqlCommand("details", con))
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ticket t = new ticket();
                    t.Train_ID = reader[0].ToString();
                    t.Ticket_ID = reader[1].ToString();
                    t.from_location = reader[2].ToString();
                    t.to_location = reader[3].ToString();
                    t.when = reader[4].ToString();
                    t.until = reader[5].ToString();
                    t.Duration = reader[6].ToString();
                    t.get_status = reader[7].ToString();
                    t.delete += delete_ticket;
                    t.Width = 850;
                    t.Height = 128;
                    ticket_display_flow.Controls.Add(t);


                }
                con.Close();
            }
        }
        private void FindAtrain(object sender, EventArgs e)
        {
            
            selected_ticket.Visible = false;
            bool ok = true;
            int train_id;
            if(book_train_id.Text==""||!int.TryParse(book_train_id.Text,out train_id))
            {
                book_train_id_error.Text = "Enter A Train ID Number";
                ok = false;
            }
            else
            {
                book_train_id_error.Text = "";
            }
            if(book_train_class.SelectedItem==null|| book_train_class.SelectedItem.ToString()=="Choose A Class"||book_train_class.SelectedItem.ToString() == "")
            {

                book_train_class_error.Text = "Choose a Class please";
                ok = false;
            }
            else
            {
                book_train_class_error.Text = "";
            }
            if(ok==true)
            {
                using (SqlCommand cmd = new SqlCommand("check_train", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@train_id", book_train_id.Text));
                    SqlParameter output_avilable = new SqlParameter("@avilable", DbType.Int64) { Direction = ParameterDirection.Output };

                    cmd.Parameters.Add(output_avilable);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    
                    if (int.Parse(output_avilable.Value.ToString()) == 0)
                    {
                        ok = false;
                        book_train_id_error.Text = "Train id Doesn't exits";
                    }
                    else
                    {
                        ok = true;
                        book_train_id_error.Text = "";

                    }
                    con.Close();


                }
                
                if(ok==true)
                {
                    selected_ticket.Visible = true;
                    using (SqlCommand cmd = new SqlCommand("book_ticket ", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@train_id", book_train_id.Text));
                        cmd.Parameters.Add(new SqlParameter("@pass_id", ID));
                        cmd.Parameters.Add(new SqlParameter("@class", book_train_class.SelectedItem));
                        cmd.Parameters.Add(new SqlParameter("@date", DateTime.Now.ToString()));

                        SqlParameter output_avilable = new SqlParameter() { Direction = ParameterDirection.Output };
                        SqlParameter output_departime = new SqlParameter("@departime", SqlDbType.DateTime) { Direction = ParameterDirection.Output };
                        SqlParameter output_departlocation = new SqlParameter("@departlocation", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output };
                        SqlParameter output_arrivaltime = new SqlParameter("@train_arrival_time", SqlDbType.DateTime) { Direction = ParameterDirection.Output };
                        SqlParameter output_arrivalelocation = new SqlParameter("@train_arrivale_location", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output };
                        SqlParameter output_duration = new SqlParameter("@duration", DbType.Int64) { Direction = ParameterDirection.Output };
                        SqlParameter output_ID = new SqlParameter("@ticket_id", DbType.Int64) { Direction = ParameterDirection.Output };
                        SqlParameter output_price = new SqlParameter("@price", SqlDbType.Money) { Direction = ParameterDirection.Output };

                        output_avilable.ParameterName = "@avilable";
                        output_avilable.DbType = DbType.Int64;
                        output_avilable.Direction = ParameterDirection.Output;


                        cmd.Parameters.Add(output_avilable);
                        cmd.Parameters.Add(output_departime);
                        cmd.Parameters.Add(output_departlocation);
                        cmd.Parameters.Add(output_arrivaltime);
                        cmd.Parameters.Add(output_arrivalelocation);
                        cmd.Parameters.Add(output_duration);
                        cmd.Parameters.Add(output_ID);
                        cmd.Parameters.Add(output_price);






                        con.Open();
                        cmd.ExecuteNonQuery();
                        int x = int.Parse(output_avilable.Value.ToString());
                        if (x == 1 || x == 2)
                        {
                            train_departure_time.Text = output_departime.Value.ToString();
                            train_arrival_time.Text = output_arrivaltime.Value.ToString();
                            train_departeur_location.Text = output_departlocation.Value.ToString();
                            train_arrival_location.Text = output_arrivalelocation.Value.ToString();
                            book_duration.Text = output_duration.Value.ToString() + " h";
                            Book_ID.Text = output_ID.Value.ToString();
                            book_price.Text =(float.Parse(output_price.Value.ToString()))+" $";
                            if (x == 1) Book_status.Text = "Reserved";
                            else if (x == 2) Book_status.Text = "waiting";
                        }
                        else if(x==0)
                        {
                            selected_ticket.Visible = false;

                        }
                        con.Close();

                    }
                }

            }
        }
        private void numbers(object sender, EventArgs e)
        {
            var se = (TextBox)sender;
            if (!System.Text.RegularExpressions.Regex.IsMatch(se.Text, "^[0-9]*$"))
            {
                se.Text = "";
            }
        }
        private void pointer_Enter(object sender, EventArgs e)
        {
            var se = (TextBox)sender;
            if (se.ForeColor == Color.FromArgb(136, 147, 159))
            {
                se.ForeColor = Color.FromArgb(0, 0, 0);
                se.Text = "";
            }
        }
        private void pointer_Leave(object sender, EventArgs e)
        {
            var se = (TextBox)sender;
            if (se.ForeColor == Color.FromArgb(255, 255, 255) && String.IsNullOrWhiteSpace(se.Text))
            {
                se.ForeColor = Color.FromArgb(136, 147, 159);
                if (se.Name == "book_train_id") se.Text = "Enter Train ID";
                else if (se.Name == "train_add_seat_number") se.Text = "Enter the Number of Seats ";
                else if (se.Name == "train_add_departure_location") se.Text = "Enter Departure Location";
                else if (se.Name == "train_add_arrival_location") se.Text = "Enter Arrival Location";
                else if (se.Name == "train_add_tickt_price") se.Text = "Enter Average Ticket Price";
               

            }
        }


        private void train_add(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("add_train ", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@department_date", train_add_departure_date.Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@department_location", train_add_departure_location.Text));
                cmd.Parameters.Add(new SqlParameter("@arrival_date", train_add_arrival_date.Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@destination", train_add_arrival_location.Text));
                cmd.Parameters.Add(new SqlParameter("@price", int.Parse(train_add_tickt_price.Text)));
                cmd.Parameters.Add(new SqlParameter("@total_seats", int.Parse(train_add_seat_number.Text)));


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void logout_click(object sender, EventArgs e)
        {
            Out = true;
            this.Close();
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            if (delete_textbox.Text == "") delete_error.Text = "Enter the ticket id";
            else
            {
                using (SqlCommand cmd = new SqlCommand("delete_ticket ", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ticket_d", delete_textbox.Text));
                    SqlParameter output_avilable = new SqlParameter("@avilable", DbType.Int64) { Direction = ParameterDirection.Output };

                    cmd.Parameters.Add(output_avilable);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    if (int.Parse(output_avilable.Value.ToString()) == 0) delete_error.Text = "ticket doesn't exist";
                    else if (int.Parse(output_avilable.Value.ToString()) == 1)
                    {
                        delete_error.Text = "";
                        delete_label.Text = "Ticket deleted";
                    }

                }
            }
        }
        private void delete_ticket(object sender, EventArgs e)
        {
            delete_error.Text = "";
            var se = (ticket)sender;
            using (SqlCommand cmd = new SqlCommand("delete_ticket ", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ticket_d", se.Ticket_ID));
                SqlParameter output_avilable = new SqlParameter("@avilable", DbType.Int64) { Direction = ParameterDirection.Output };

                cmd.Parameters.Add(output_avilable);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                if(int.Parse(output_avilable.Value.ToString()) == 1)
                {

                    booking_container.Visible = false;
                    train_adding_page.Visible = false;
                    ticket_delete_page.Visible = false;
                    ticket_display_panel.Visible = false;
                    Trains_list_page.Visible = true;
                    delete_train_page.Visible = false;
                    display_trains();
                    display_all();
                }
                else
                {
                    delete_error.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (train_delete_id.Text == "") delete_train_error.Text = "Enter the train id";
            else
            {
                using (SqlCommand cmd = new SqlCommand("delete_train", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@train_id", train_delete_id.Text));
                    SqlParameter output_avilable = new SqlParameter("@avilable", DbType.Int64) { Direction = ParameterDirection.Output };

                    cmd.Parameters.Add(output_avilable);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    if (int.Parse(output_avilable.Value.ToString()) == 0) delete_train_error.Text = "Train doesn't exist";
                    else if (int.Parse(output_avilable.Value.ToString()) == 1)
                    {
                        delete_train_error.Text = "";
                        delete_train_msg.Text = "";
                        booking_container.Visible = false;
                        train_adding_page.Visible = false;
                        ticket_delete_page.Visible = false;
                        ticket_display_panel.Visible = false;
                        Trains_list_page.Visible = true;
                        delete_train_page.Visible = false;
                        display_trains();
                    }

                }
            }
        }

       
        private void display_my_ticket()
        {
            ticket_display_flow.Controls.Clear();
            using (SqlCommand cmd = new SqlCommand("disblay_my_ticket", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@pass_id", ID));

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ticket t = new ticket();
                    t.Train_ID = reader[0].ToString();
                    t.Ticket_ID = reader[1].ToString();
                    t.from_location = reader[2].ToString();
                    t.to_location = reader[3].ToString();
                    t.when = reader[4].ToString();
                    t.until = reader[5].ToString();
                    t.Duration = reader[6].ToString();
                    t.get_status = reader[7].ToString();
                    t.delete += delete_ticket;
                    t.Width = 850;
                    t.Height = 128;
                    ticket_display_flow.Controls.Add(t);


                }
                con.Close();
            }
        }

        private void train_display_flowpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
