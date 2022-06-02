namespace GoRails
{
    partial class ticket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ticket));
            this.container = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.train_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ticket_id = new System.Windows.Forms.Label();
            this.ticket_price = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ticket_status = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.to_when = new System.Windows.Forms.Label();
            this.from_when = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.container.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.Transparent;
            this.container.Controls.Add(this.panel2);
            this.container.Controls.Add(this.button1);
            this.container.Controls.Add(this.ticket_status);
            this.container.Controls.Add(this.duration);
            this.container.Controls.Add(this.to_when);
            this.container.Controls.Add(this.from_when);
            this.container.Controls.Add(this.To);
            this.container.Controls.Add(this.from);
            this.container.Controls.Add(this.panel1);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(804, 114);
            this.container.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.train_id);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ticket_id);
            this.panel2.Controls.Add(this.ticket_price);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(474, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 104);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Train ID :";
            // 
            // train_id
            // 
            this.train_id.AutoSize = true;
            this.train_id.Location = new System.Drawing.Point(70, 45);
            this.train_id.Name = "train_id";
            this.train_id.Size = new System.Drawing.Size(41, 16);
            this.train_id.TabIndex = 18;
            this.train_id.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ticket ID : ";
            // 
            // ticket_id
            // 
            this.ticket_id.AutoSize = true;
            this.ticket_id.Location = new System.Drawing.Point(70, 21);
            this.ticket_id.Name = "ticket_id";
            this.ticket_id.Size = new System.Drawing.Size(53, 16);
            this.ticket_id.TabIndex = 16;
            this.ticket_id.Text = "ticket_id";
            // 
            // ticket_price
            // 
            this.ticket_price.AutoSize = true;
            this.ticket_price.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.ticket_price.Location = new System.Drawing.Point(2, 70);
            this.ticket_price.Name = "ticket_price";
            this.ticket_price.Size = new System.Drawing.Size(59, 23);
            this.ticket_price.TabIndex = 15;
            this.ticket_price.Text = "price";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(738, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 104);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ticket_status
            // 
            this.ticket_status.AutoSize = true;
            this.ticket_status.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ticket_status.Location = new System.Drawing.Point(46, 76);
            this.ticket_status.Name = "ticket_status";
            this.ticket_status.Size = new System.Drawing.Size(50, 19);
            this.ticket_status.TabIndex = 8;
            this.ticket_status.Text = "Status";
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Location = new System.Drawing.Point(164, 51);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(54, 16);
            this.duration.TabIndex = 5;
            this.duration.Text = "duration";
            // 
            // to_when
            // 
            this.to_when.AutoSize = true;
            this.to_when.Location = new System.Drawing.Point(292, 51);
            this.to_when.Name = "to_when";
            this.to_when.Size = new System.Drawing.Size(19, 16);
            this.to_when.TabIndex = 3;
            this.to_when.Text = "to";
            // 
            // from_when
            // 
            this.from_when.AutoSize = true;
            this.from_when.Location = new System.Drawing.Point(47, 51);
            this.from_when.Name = "from_when";
            this.from_when.Size = new System.Drawing.Size(65, 16);
            this.from_when.TabIndex = 2;
            this.from_when.Text = "from when";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.To.Location = new System.Drawing.Point(291, 14);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(35, 23);
            this.To.TabIndex = 1;
            this.To.Text = "TO";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.from.Location = new System.Drawing.Point(46, 14);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(58, 23);
            this.from.TabIndex = 0;
            this.from.Text = "From";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 10);
            this.panel1.TabIndex = 10;
            // 
            // ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Name = "ticket";
            this.Size = new System.Drawing.Size(804, 114);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Label to_when;
        private System.Windows.Forms.Label from_when;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Label ticket_status;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label train_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ticket_id;
        private System.Windows.Forms.Label ticket_price;
    }
}
