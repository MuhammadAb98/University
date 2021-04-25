namespace WindowsFormsApplication1
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
            this.lblownername = new System.Windows.Forms.Label();
            this.lblnamecus = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblcuscontact = new System.Windows.Forms.Label();
            this.txttypework = new System.Windows.Forms.TextBox();
            this.lblworktype = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtcharges = new System.Windows.Forms.TextBox();
            this.lblcharges = new System.Windows.Forms.Label();
            this.txtcontactnumber = new System.Windows.Forms.TextBox();
            this.DataBaseView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnloaddata = new System.Windows.Forms.Button();
            this.btndeluser = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblownername
            // 
            this.lblownername.AutoSize = true;
            this.lblownername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblownername.Location = new System.Drawing.Point(562, 9);
            this.lblownername.Name = "lblownername";
            this.lblownername.Size = new System.Drawing.Size(146, 25);
            this.lblownername.TabIndex = 0;
            this.lblownername.Text = "Owner Name";
            this.lblownername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnamecus
            // 
            this.lblnamecus.AutoSize = true;
            this.lblnamecus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamecus.Location = new System.Drawing.Point(11, 43);
            this.lblnamecus.Name = "lblnamecus";
            this.lblnamecus.Size = new System.Drawing.Size(61, 24);
            this.lblnamecus.TabIndex = 2;
            this.lblnamecus.Text = "Name";
            this.lblnamecus.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(15, 70);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(225, 38);
            this.txtname.TabIndex = 3;
            // 
            // lblcuscontact
            // 
            this.lblcuscontact.AutoSize = true;
            this.lblcuscontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuscontact.Location = new System.Drawing.Point(336, 43);
            this.lblcuscontact.Name = "lblcuscontact";
            this.lblcuscontact.Size = new System.Drawing.Size(147, 24);
            this.lblcuscontact.TabIndex = 4;
            this.lblcuscontact.Text = "Contact Number";
            this.lblcuscontact.Click += new System.EventHandler(this.label4_Click);
            // 
            // txttypework
            // 
            this.txttypework.Location = new System.Drawing.Point(15, 157);
            this.txttypework.Name = "txttypework";
            this.txttypework.Size = new System.Drawing.Size(225, 38);
            this.txttypework.TabIndex = 5;
            // 
            // lblworktype
            // 
            this.lblworktype.AutoSize = true;
            this.lblworktype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblworktype.Location = new System.Drawing.Point(11, 130);
            this.lblworktype.Name = "lblworktype";
            this.lblworktype.Size = new System.Drawing.Size(126, 24);
            this.lblworktype.TabIndex = 6;
            this.lblworktype.Text = "Type Of Work";
            this.lblworktype.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtcharges);
            this.groupBox1.Controls.Add(this.lblcharges);
            this.groupBox1.Controls.Add(this.txtcontactnumber);
            this.groupBox1.Controls.Add(this.txttypework);
            this.groupBox1.Controls.Add(this.lblworktype);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblcuscontact);
            this.groupBox1.Controls.Add(this.lblnamecus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 282);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Customer";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(90, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(186, 45);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtcharges
            // 
            this.txtcharges.Location = new System.Drawing.Point(340, 157);
            this.txtcharges.Name = "txtcharges";
            this.txtcharges.Size = new System.Drawing.Size(225, 38);
            this.txtcharges.TabIndex = 10;
            // 
            // lblcharges
            // 
            this.lblcharges.AutoSize = true;
            this.lblcharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcharges.Location = new System.Drawing.Point(336, 130);
            this.lblcharges.Name = "lblcharges";
            this.lblcharges.Size = new System.Drawing.Size(81, 24);
            this.lblcharges.TabIndex = 9;
            this.lblcharges.Text = "Charges";
            // 
            // txtcontactnumber
            // 
            this.txtcontactnumber.Location = new System.Drawing.Point(340, 70);
            this.txtcontactnumber.Name = "txtcontactnumber";
            this.txtcontactnumber.Size = new System.Drawing.Size(225, 38);
            this.txtcontactnumber.TabIndex = 8;
            // 
            // DataBaseView
            // 
            this.DataBaseView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataBaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseView.Location = new System.Drawing.Point(662, 112);
            this.DataBaseView.Name = "DataBaseView";
            this.DataBaseView.Size = new System.Drawing.Size(498, 204);
            this.DataBaseView.TabIndex = 8;
            this.DataBaseView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBaseView_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(282, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnloaddata
            // 
            this.btnloaddata.BackColor = System.Drawing.Color.Chartreuse;
            this.btnloaddata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloaddata.Location = new System.Drawing.Point(662, 327);
            this.btnloaddata.Name = "btnloaddata";
            this.btnloaddata.Size = new System.Drawing.Size(498, 45);
            this.btnloaddata.TabIndex = 9;
            this.btnloaddata.Text = "Load Data";
            this.btnloaddata.UseVisualStyleBackColor = false;
            this.btnloaddata.Click += new System.EventHandler(this.btnloaddata_Click);
            // 
            // btndeluser
            // 
            this.btndeluser.BackColor = System.Drawing.Color.Red;
            this.btndeluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeluser.ForeColor = System.Drawing.Color.White;
            this.btndeluser.Location = new System.Drawing.Point(30, 384);
            this.btndeluser.Name = "btndeluser";
            this.btndeluser.Size = new System.Drawing.Size(578, 44);
            this.btndeluser.TabIndex = 10;
            this.btndeluser.Text = "Delete User";
            this.btndeluser.UseVisualStyleBackColor = false;
            this.btndeluser.Click += new System.EventHandler(this.btndeluser_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GreenYellow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(662, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(498, 44);
            this.button3.TabIndex = 11;
            this.button3.Text = "Search User";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(662, 387);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(498, 35);
            this.txtsearch.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1206, 525);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btndeluser);
            this.Controls.Add(this.btnloaddata);
            this.Controls.Add(this.DataBaseView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblownername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblownername;
        private System.Windows.Forms.Label lblnamecus;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblcuscontact;
        private System.Windows.Forms.TextBox txttypework;
        private System.Windows.Forms.Label lblworktype;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtcharges;
        private System.Windows.Forms.Label lblcharges;
        private System.Windows.Forms.TextBox txtcontactnumber;
        private System.Windows.Forms.DataGridView DataBaseView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnloaddata;
        private System.Windows.Forms.Button btndeluser;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtsearch;
    }
}

