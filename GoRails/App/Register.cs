using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GoRails.App
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            //System.Text.RegularExpressions.Regex.IsMatch(signup_age.Text, "[^ 0-9]");

        }

        private void pointer_Enter(object sender, EventArgs e)
        {
            var se = (TextBox)sender;
            if (se.ForeColor == Color.FromArgb(136, 147, 159))
            {
                se.ForeColor = Color.FromArgb(255, 255, 255);
                se.Text = "";
            }
        }
        
        private void pointer_Leave(object sender, EventArgs e)
        {
            var se = (TextBox)sender;
            if (se.ForeColor == Color.FromArgb(255, 255, 255) && String.IsNullOrWhiteSpace(se.Text))
            {
                se.ForeColor = Color.FromArgb(136, 147, 159);
                if (se.Name == "signup_name") se.Text = "Enter Your Full Name";
                else if (se.Name == "signup_id") se.Text = "Enter ID";
                else if (se.Name == "signup_password") se.Text = "password";
                else if (se.Name == "signup_repassword") se.Text = "password";
                else if (se.Name == "signup_age") se.Text = "Age";
                else if (se.Name == "signup_phone") se.Text = "Enter Phone Number";
                else if (se.Name == "signup_city") se.Text = "city";
                else if (se.Name == "signup_street") se.Text = "street";
                else if (se.Name == "login_id") se.Text = "Enter Your ID";
                else if (se.Name == "login_password") se.Text = "password";

            }
        }
        private void pager(object sender, EventArgs e)
        {
            
            var s = (LinkLabel)sender;
            if(s.Name== "login_to_signup")
            {
                Login_page.Visible = false;
                Signup_page.Visible = true;
            }
            else if (s.Name == "signup_to_login")
            {
                
                Login_page.Visible = true;
                Signup_page.Visible = false;
            
            }
        }

        private void close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submit(object sender, EventArgs e)
        {
            bool ok = true;
            var se = (Button)sender;

            #region check signup
            if (se.Name== "signup_submit")
            {
               
                if (signup_name.Text == "" || signup_name.ForeColor == Color.FromArgb(136, 147, 159))
                {
                    signup_name_error.Text = "*Enter Name";
                    ok = false;

                }
                else
                {
                    signup_name_error.Text = "";
                }
                /*-------------------------------------------------------*/

                if (signup_id.Text == "" || signup_id.ForeColor == Color.FromArgb(136, 147, 159))
                {
                    signup_id_error.Text = "*Enter ID";
                    ok = false;

                }
                else
                {
                    signup_id_error.Text = "";
                }

                /*-------------------------------------------------------*/
                if (signup_password.Text=="" || signup_password.ForeColor==Color.FromArgb(136, 147, 159))
                {
                    signup_password_error.Text = "*Enter password";
                    ok = false;

                }
                else
                {
                    signup_password_error.Text = "";
                }
                /*-------------------------------------------------------*/

                if (signup_repassword.Text == "" || signup_repassword.ForeColor == Color.FromArgb(136, 147, 159))
                {
                    signup_repassword_error.Text = "*Enter password";
                    ok = false;

                }
                else
                {
                    signup_repassword_error.Text = "";

                }
                /*-------------------------------------------------------*/

                if (signup_age.Text == "" || signup_age.ForeColor == Color.FromArgb(136, 147, 159))
                {
                    signup_age_error.Text = "*Enter Age";
                    ok = false;

                }
                else
                {
                    signup_age_error.Text = "";

                }
                /*-------------------------------------------------------*/

                if (signup_phone.Text == "" || signup_phone.ForeColor == Color.FromArgb(136, 147, 159))
                {
                    signup_phone_error.Text = "*Enter Phone Number";
                    ok = false;

                }
                else
                {
                    signup_phone_error.Text = "";

                }
                /*-------------------------------------------------------*/
                if (signup_city.Text=="" || signup_city.ForeColor==Color.FromArgb(136, 147, 159))
                {
                    ok = false;
                    signup_city_error.Text = "*Enter city";
                }
                else
                {
                    signup_city_error.Text = "";

                }
                /*-------------------------------------------------------*/
                if (signup_street.Text=="" || signup_street.ForeColor==Color.FromArgb(136, 147, 159))
                {
                    ok = false;
                    signup_street_error.Text = "*Enter street";
                }
                else
                {
                    signup_street_error.Text = "";

                }
                /*-------------------------------------------------------*/
                if (signup_password.Text != signup_repassword.Text)
                {
                    ok = false;
                    signup_repassword_error.Text = "Passwords don't match";

                }
                /*-------------------------------------------------------*/
                #endregion

                if (ok)
                {
                    
                    using (SqlCommand cmd = new SqlCommand("check_pass_id " , MainForm.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@pass_id", signup_id.Text));
                        cmd.Parameters.Add(new SqlParameter("@pass_name", signup_name.Text));
                        cmd.Parameters.Add(new SqlParameter("@pass_age", signup_age.Text));
                        cmd.Parameters.Add(new SqlParameter("@pass_street", signup_street.Text));
                        cmd.Parameters.Add(new SqlParameter("@pass_password", signup_password.Text));
                        cmd.Parameters.Add(new SqlParameter("@pass_phone", signup_phone.Text));
                        cmd.Parameters.Add(new SqlParameter("@pass_city", signup_city.Text));

                        SqlParameter output = new SqlParameter();

                        output.ParameterName = "@b";
                        output.DbType = DbType.Int64;
                        output.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(output);

                        MainForm.con.Open();
                        cmd.ExecuteNonQuery();

                        int x = int.Parse(output.Value.ToString());
                        if (x==0)
                        {
                            signup_id_error.Text = "*Not vaild id";
                        }
                        else
                        {
                            Login_page.Visible = true;
                            Signup_page.Visible = false;
                        }
                        MainForm.con.Close();


                    }
                    

                }

            }

            #region check login
            else if (se.Name== "login_submit")
            {
                if (login_id.Text == "" || login_id.ForeColor == Color.FromArgb(136, 147, 159))
                {
                    login_id_error.Text = "*Enter id";
                    ok = false;
                }
                else login_id_error.Text = "";

                if (login_password.Text == "" || login_password.ForeColor == Color.FromArgb(136, 147, 159))
                {
                    login_password_error.Text = "*Enter Password";
                    ok = false;
                }
                else login_password_error.Text = "";
                #endregion


                if (ok)
                {
                    using (SqlCommand cmd = new SqlCommand("passenger_login ", MainForm.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@pass_id", login_id.Text));                     
                        cmd.Parameters.Add(new SqlParameter("@pass_password", login_password.Text));
                     
                        SqlParameter output = new SqlParameter();
                        output.ParameterName = "@output";
                        output.DbType = DbType.Int64;
                        output.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(output);

                        MainForm.con.Open();
                        cmd.ExecuteNonQuery();

                        MainForm.con.Close();
                        int x = int.Parse(output.Value.ToString());
                        if (x == 0)
                        {
                            login_id_error.Text = "*Login id or password is not correct";
                        }
                        else
                        {
                            MainForm ff=new MainForm(int.Parse(login_id.Text));
                            ff.Show();
                            ff.FormClosed += Register_FormClosing;
                            this.Hide();
                        }

                    }
                }

            }
        }

        private void numbers(object sender, EventArgs e)
        {
            var se = (TextBox)sender;
            if (!Regex.IsMatch(se.Text, "^[0-9]*$"))
            {
                se.Text = "";
            }
        }

        private void Register_FormClosing(object sender, FormClosedEventArgs e)
        {
            var se = (MainForm)sender;
            
            if(se.Out==false) this.Close();
            else
            {
                this.Show();
            }
        }
    }
}
