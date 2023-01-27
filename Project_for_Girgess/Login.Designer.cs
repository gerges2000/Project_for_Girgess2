namespace Project_for_Girgess
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.pasword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 403);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(251, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee M S";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "Employee M S";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(57, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "C#.Net";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sql Server";
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.Teal;
            this.Reset.Location = new System.Drawing.Point(353, 363);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(59, 25);
            this.Reset.TabIndex = 8;
            this.Reset.Text = "Reset";
            this.Reset.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Teal;
            this.AddBtn.Location = new System.Drawing.Point(299, 327);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(141, 33);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "LOGIN";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // pasword
            // 
            this.pasword.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasword.Location = new System.Drawing.Point(241, 270);
            this.pasword.Multiline = true;
            this.pasword.Name = "pasword";
            this.pasword.Size = new System.Drawing.Size(252, 31);
            this.pasword.TabIndex = 4;
            this.pasword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(237, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(241, 192);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(252, 31);
            this.Username.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(237, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Name";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 403);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pasword);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poor Richard", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Reset;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox pasword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
    }
}

