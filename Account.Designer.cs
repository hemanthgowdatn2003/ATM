namespace ATM21
{
    partial class Account
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccNumTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AccNameTb = new System.Windows.Forms.TextBox();
            this.AccFnameTb = new System.Windows.Forms.TextBox();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.EducationCb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PinTb = new System.Windows.Forms.TextBox();
            this.DOBdate = new System.Windows.Forms.DateTimePicker();
            this.LoginBTn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 100);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(795, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 42);
            this.label6.TabIndex = 2;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "ACCOUNT NUMBER";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 52);
            this.label2.TabIndex = 6;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AccNumTb
            // 
            this.AccNumTb.Location = new System.Drawing.Point(18, 181);
            this.AccNumTb.Multiline = true;
            this.AccNumTb.Name = "AccNumTb";
            this.AccNumTb.Size = new System.Drawing.Size(317, 50);
            this.AccNumTb.TabIndex = 7;
            this.AccNumTb.TextChanged += new System.EventHandler(this.AccNumTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "NAME";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "FATHER NAME";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 36);
            this.label7.TabIndex = 11;
            this.label7.Text = "PHONE #";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(495, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 36);
            this.label8.TabIndex = 12;
            this.label8.Text = "ADDRESS";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(495, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 36);
            this.label9.TabIndex = 13;
            this.label9.Text = "EDUCATION";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(495, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 36);
            this.label10.TabIndex = 14;
            this.label10.Text = "DOB";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // AccNameTb
            // 
            this.AccNameTb.Location = new System.Drawing.Point(18, 293);
            this.AccNameTb.Multiline = true;
            this.AccNameTb.Name = "AccNameTb";
            this.AccNameTb.Size = new System.Drawing.Size(317, 50);
            this.AccNameTb.TabIndex = 15;
            this.AccNameTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AccFnameTb
            // 
            this.AccFnameTb.Location = new System.Drawing.Point(18, 390);
            this.AccFnameTb.Multiline = true;
            this.AccFnameTb.Name = "AccFnameTb";
            this.AccFnameTb.Size = new System.Drawing.Size(317, 50);
            this.AccFnameTb.TabIndex = 16;
            this.AccFnameTb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(18, 491);
            this.PhoneTb.Multiline = true;
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(317, 50);
            this.PhoneTb.TabIndex = 17;
            this.PhoneTb.TextChanged += new System.EventHandler(this.PhoneTb_TextChanged);
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(501, 168);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(317, 163);
            this.AddressTb.TabIndex = 19;
            this.AddressTb.TextChanged += new System.EventHandler(this.AddressTb_TextChanged);
            // 
            // EducationCb
            // 
            this.EducationCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EducationCb.FormattingEnabled = true;
            this.EducationCb.Items.AddRange(new object[] {
            "Non Graduate",
            "Under Graduate",
            "Post Graduate"});
            this.EducationCb.Location = new System.Drawing.Point(501, 390);
            this.EducationCb.Name = "EducationCb";
            this.EducationCb.Size = new System.Drawing.Size(300, 39);
            this.EducationCb.TabIndex = 20;
            this.EducationCb.SelectedIndexChanged += new System.EventHandler(this.EducationCb_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 556);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 36);
            this.label11.TabIndex = 22;
            this.label11.Text = "PIN";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // PinTb
            // 
            this.PinTb.Location = new System.Drawing.Point(18, 595);
            this.PinTb.Multiline = true;
            this.PinTb.Name = "PinTb";
            this.PinTb.Size = new System.Drawing.Size(317, 50);
            this.PinTb.TabIndex = 23;
            this.PinTb.TextChanged += new System.EventHandler(this.PinTb_TextChanged);
            // 
            // DOBdate
            // 
            this.DOBdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBdate.Location = new System.Drawing.Point(501, 500);
            this.DOBdate.Name = "DOBdate";
            this.DOBdate.Size = new System.Drawing.Size(317, 41);
            this.DOBdate.TabIndex = 24;
            this.DOBdate.ValueChanged += new System.EventHandler(this.DOBdate_ValueChanged);
            // 
            // LoginBTn
            // 
            this.LoginBTn.Location = new System.Drawing.Point(390, 590);
            this.LoginBTn.Name = "LoginBTn";
            this.LoginBTn.Size = new System.Drawing.Size(137, 47);
            this.LoginBTn.TabIndex = 25;
            this.LoginBTn.Text = "Submit";
            this.LoginBTn.UseVisualStyleBackColor = true;
            this.LoginBTn.Click += new System.EventHandler(this.LoginBTn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(599, 590);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(136, 47);
            this.LogoutBtn.TabIndex = 26;
            this.LogoutBtn.Text = "Back";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(863, 657);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.LoginBTn);
            this.Controls.Add(this.DOBdate);
            this.Controls.Add(this.PinTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.EducationCb);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.AccFnameTb);
            this.Controls.Add(this.AccNameTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AccNumTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AccNumTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AccNameTb;
        private System.Windows.Forms.TextBox AccFnameTb;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.ComboBox EducationCb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PinTb;
        private System.Windows.Forms.DateTimePicker DOBdate;
        private System.Windows.Forms.Button LoginBTn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label6;
    }
}