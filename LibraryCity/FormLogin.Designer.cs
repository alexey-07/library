namespace LibraryCity
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel2 = new Panel();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtLog = new TextBox();
            btnGuest = new Button();
            btnLog = new Button();
            lblLog = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtLog);
            panel2.Controls.Add(btnGuest);
            panel2.Controls.Add(btnLog);
            panel2.Controls.Add(lblLog);
            panel2.Location = new Point(13, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 247);
            panel2.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(164, 109);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(58, 19);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(73, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(227, 26);
            txtPassword.TabIndex = 4;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(73, 57);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(227, 26);
            txtLog.TabIndex = 3;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.FromArgb(74, 111, 165);
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Location = new Point(73, 210);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(227, 27);
            btnGuest.TabIndex = 2;
            btnGuest.Text = "Гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += BtnGuest_Click;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.FromArgb(74, 111, 165);
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Location = new Point(73, 177);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(227, 27);
            btnLog.TabIndex = 1;
            btnLog.Text = "Войти";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += BtnLog_Click;
            // 
            // lblLog
            // 
            lblLog.AutoSize = true;
            lblLog.Location = new Point(164, 35);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(52, 19);
            lblLog.TabIndex = 0;
            lblLog.Text = "Логин";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.book_placeholder;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(147, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 370);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormLogin";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизция";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Button button2;
        private Label label1;
        private Button button1;
        private Label lblLogin;
        private TextBox textBox2;
        private TextBox txtLogin;
        private Panel panel1;
        private Panel panel2;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtLog;
        private Button btnGuest;
        private Button btnLog;
        private Label lblLog;
        private PictureBox pictureBox1;
    }
}
