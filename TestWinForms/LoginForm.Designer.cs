namespace TestWinForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label3 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonClosePass = new System.Windows.Forms.Button();
            this.buttonOpenPass = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(225, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 67);
            this.label3.TabIndex = 2;
            this.label3.Text = "Авторизация";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(219, 164);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(342, 53);
            this.loginField.TabIndex = 5;
            this.loginField.TextChanged += new System.EventHandler(this.loginField_TextChanged);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(219, 262);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(342, 56);
            this.passField.TabIndex = 6;
            this.passField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(305, 376);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(163, 65);
            this.login.TabIndex = 7;
            this.login.Text = "Войти";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(219, 334);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 22);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Запомнить меня";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(321, 456);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(135, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Еще нет аккаунта?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonClosePass
            // 
            this.buttonClosePass.BackColor = System.Drawing.Color.White;
            this.buttonClosePass.ForeColor = System.Drawing.Color.Black;
            this.buttonClosePass.Image = ((System.Drawing.Image)(resources.GetObject("buttonClosePass.Image")));
            this.buttonClosePass.Location = new System.Drawing.Point(567, 262);
            this.buttonClosePass.Name = "buttonClosePass";
            this.buttonClosePass.Size = new System.Drawing.Size(58, 56);
            this.buttonClosePass.TabIndex = 11;
            this.buttonClosePass.Text = "\r\n";
            this.buttonClosePass.UseVisualStyleBackColor = false;
            this.buttonClosePass.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonOpenPass
            // 
            this.buttonOpenPass.BackColor = System.Drawing.Color.White;
            this.buttonOpenPass.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenPass.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenPass.Image")));
            this.buttonOpenPass.Location = new System.Drawing.Point(567, 262);
            this.buttonOpenPass.Name = "buttonOpenPass";
            this.buttonOpenPass.Size = new System.Drawing.Size(58, 56);
            this.buttonOpenPass.TabIndex = 10;
            this.buttonOpenPass.Text = "\r\n";
            this.buttonOpenPass.UseVisualStyleBackColor = false;
            this.buttonOpenPass.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestWinForms.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(119, 262);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestWinForms.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(119, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 563);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonClosePass);
            this.Controls.Add(this.buttonOpenPass);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonOpenPass;
        private System.Windows.Forms.Button buttonClosePass;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}