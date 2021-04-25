namespace WindowsFormsApplication1
{
    partial class pageDel
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
            this.lbldel = new System.Windows.Forms.Label();
            this.txtdel = new System.Windows.Forms.TextBox();
            this.btndel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldel
            // 
            this.lbldel.AutoSize = true;
            this.lbldel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldel.Location = new System.Drawing.Point(74, 26);
            this.lbldel.Name = "lbldel";
            this.lbldel.Size = new System.Drawing.Size(361, 25);
            this.lbldel.TabIndex = 1;
            this.lbldel.Text = "Enter Cell Number To Delete Record";
            this.lbldel.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtdel
            // 
            this.txtdel.Location = new System.Drawing.Point(79, 64);
            this.txtdel.Name = "txtdel";
            this.txtdel.Size = new System.Drawing.Size(356, 20);
            this.txtdel.TabIndex = 2;
            this.txtdel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndel.Location = new System.Drawing.Point(79, 90);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(356, 56);
            this.btndel.TabIndex = 3;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // pageDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 201);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.txtdel);
            this.Controls.Add(this.lbldel);
            this.Name = "pageDel";
            this.Text = "pageDel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldel;
        private System.Windows.Forms.TextBox txtdel;
        private System.Windows.Forms.Button btndel;
    }
}