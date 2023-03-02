namespace TestWinForms
{
    partial class SignUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.buttonClosePass = new System.Windows.Forms.Button();
            this.buttonOpenPass = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmClose = new System.Windows.Forms.Button();
            this.confirmOpen = new System.Windows.Forms.Button();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassConfirm = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClosePass
            // 
            this.buttonClosePass.BackColor = System.Drawing.Color.White;
            this.buttonClosePass.ForeColor = System.Drawing.Color.Black;
            this.buttonClosePass.Image = ((System.Drawing.Image)(resources.GetObject("buttonClosePass.Image")));
            this.buttonClosePass.Location = new System.Drawing.Point(693, 276);
            this.buttonClosePass.Name = "buttonClosePass";
            this.buttonClosePass.Size = new System.Drawing.Size(58, 56);
            this.buttonClosePass.TabIndex = 21;
            this.buttonClosePass.Text = "\r\n";
            this.buttonClosePass.UseVisualStyleBackColor = false;
            this.buttonClosePass.Click += new System.EventHandler(this.buttonClosePass_Click);
            // 
            // buttonOpenPass
            // 
            this.buttonOpenPass.BackColor = System.Drawing.Color.White;
            this.buttonOpenPass.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenPass.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenPass.Image")));
            this.buttonOpenPass.Location = new System.Drawing.Point(693, 276);
            this.buttonOpenPass.Name = "buttonOpenPass";
            this.buttonOpenPass.Size = new System.Drawing.Size(58, 56);
            this.buttonOpenPass.TabIndex = 20;
            this.buttonOpenPass.Text = "\r\n";
            this.buttonOpenPass.UseVisualStyleBackColor = false;
            this.buttonOpenPass.Click += new System.EventHandler(this.buttonOpenPass_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(409, 453);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(257, 65);
            this.login.TabIndex = 18;
            this.login.Text = "Создать Аккаунт";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(409, 276);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(342, 56);
            this.passField.TabIndex = 17;
            this.passField.TextChanged += new System.EventHandler(this.passField_TextChanged);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(409, 194);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(342, 53);
            this.loginField.TabIndex = 16;
            this.loginField.TextChanged += new System.EventHandler(this.loginField_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(370, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 67);
            this.label3.TabIndex = 13;
            this.label3.Text = "Регистрация";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // confirmClose
            // 
            this.confirmClose.BackColor = System.Drawing.Color.White;
            this.confirmClose.ForeColor = System.Drawing.Color.Black;
            this.confirmClose.Image = ((System.Drawing.Image)(resources.GetObject("confirmClose.Image")));
            this.confirmClose.Location = new System.Drawing.Point(693, 359);
            this.confirmClose.Name = "confirmClose";
            this.confirmClose.Size = new System.Drawing.Size(58, 56);
            this.confirmClose.TabIndex = 25;
            this.confirmClose.Text = "\r\n";
            this.confirmClose.UseVisualStyleBackColor = false;
            this.confirmClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // confirmOpen
            // 
            this.confirmOpen.BackColor = System.Drawing.Color.White;
            this.confirmOpen.ForeColor = System.Drawing.Color.Black;
            this.confirmOpen.Image = ((System.Drawing.Image)(resources.GetObject("confirmOpen.Image")));
            this.confirmOpen.Location = new System.Drawing.Point(693, 359);
            this.confirmOpen.Name = "confirmOpen";
            this.confirmOpen.Size = new System.Drawing.Size(58, 56);
            this.confirmOpen.TabIndex = 24;
            this.confirmOpen.Text = "\r\n";
            this.confirmOpen.UseVisualStyleBackColor = false;
            this.confirmOpen.Click += new System.EventHandler(this.button2_Click);
            // 
            // confirmPass
            // 
            this.confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPass.Location = new System.Drawing.Point(409, 359);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(342, 56);
            this.confirmPass.TabIndex = 23;
            this.confirmPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.confirmPass.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(273, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(273, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(86, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "Подтвердить пароль";
            // 
            // errorLogin
            // 
            this.errorLogin.ContainerControl = this;
            // 
            // errorPass
            // 
            this.errorPass.ContainerControl = this;
            // 
            // errorPassConfirm
            // 
            this.errorPassConfirm.ContainerControl = this;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 638);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmClose);
            this.Controls.Add(this.confirmOpen);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.buttonClosePass);
            this.Controls.Add(this.buttonOpenPass);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.label3);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Leave += new System.EventHandler(this.SignUp_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClosePass;
        private System.Windows.Forms.Button buttonOpenPass;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirmClose;
        private System.Windows.Forms.Button confirmOpen;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorLogin;
        private System.Windows.Forms.ErrorProvider errorPass;
        private System.Windows.Forms.ErrorProvider errorPassConfirm;
    }
}