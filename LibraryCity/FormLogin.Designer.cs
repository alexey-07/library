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
            panel2 = new Panel();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(13, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 247);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 35);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 0;
            label2.Text = "Логин";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(74, 111, 165);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(73, 177);
            button3.Name = "button3";
            button3.Size = new Size(227, 27);
            button3.TabIndex = 1;
            button3.Text = "Войти";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(74, 111, 165);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(73, 210);
            button4.Name = "button4";
            button4.Size = new Size(227, 27);
            button4.TabIndex = 2;
            button4.Text = "Гость";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 26);
            textBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(73, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 26);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 109);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 5;
            label3.Text = "Пароль";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.book_placeholder;
            pictureBox1.Location = new Point(147, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 66);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
