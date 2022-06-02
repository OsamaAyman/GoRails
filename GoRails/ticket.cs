using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoRails
{
    public partial class ticket : UserControl
    {
        public ticket()
        {
            InitializeComponent();
        }

        public string from_location
        {
            get
            {
                return from.Text;
            }
            set
            {
                from.Text = value;
            }
        }
        public string to_location
        {
            get
            {
                return To.Text;
            }
            set
            {
                To.Text = value;
            }
        }
        public string when
        {
            get
            {
                return from_when.Text;
            }
            set
            {
                from_when.Text = value;
            }
        }
        public string until
        {
            get
            {
                return to_when.Text;
            }
            set
            {
                to_when.Text = value;
            }
        }
        public string get_status
        {
            get
            {
                return ticket_status.Text;
            }
            set
            {
                ticket_status.Text = value;
              //  if (value == "waiting") this.BackColor = Color.FromArgb(141, 210, 138);
              //  else this.BackColor = Color.FromArgb(252, 241, 170);
            }
        }
        public string get_price
        {
            get
            {
                return ticket_price.Text;
            }
            set
            {
                ticket_price.Text = value;
            }
        }
        public string Duration
        {
            get
            {
                return duration.Text;
            }
            set
            {
                duration.Text = value;
            }
        }
        public string Ticket_ID
        {
            get
            {
                return ticket_id.Text;
            }
            set
            {
                ticket_id.Text = value;
            }
        }
        public string Train_ID
        {
            get
            {
                return train_id.Text;
            }
            set
            {
                train_id.Text = value;
            }
        }
        public event EventHandler delete;
        protected void Button1_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.delete != null)
                this.delete(this, e);
        }
    }
}
