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
    public partial class treno : UserControl
    {
        public treno()
        {
            InitializeComponent();
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
        public string get_price
        {
            get
            {
                return ticket_price.Text;
            }
            set
            {
                ticket_price.Text = double.Parse(value).ToString() + " $";
                class2.Text = (double.Parse(value) * 1.5).ToString() + " $";
                class3.Text = (double.Parse(value) * 2).ToString() + " $";
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
        public string Seat1
        {
            get
            {
                return seat1.Text;
            }
            set
            {
                seat1.Text = value;
            }
        }
        public string Seat2
        {
            get
            {
                return seat2.Text;
            }
            set
            {
                seat2.Text = value;
            }
        }
        public string Seat3
        {
            get
            {
                return seat3.Text;
            }
            set
            {
                seat3.Text = value;
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

      
    }

}
