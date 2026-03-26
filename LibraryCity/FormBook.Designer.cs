namespace LibraryCity
{
    partial class FormBook
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
            pnTop = new Panel();
            lbUserName = new Label();
            btnLogout = new Button();
            dvgBooks = new DataGridView();
            pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgBooks).BeginInit();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.Controls.Add(lbUserName);
            pnTop.Controls.Add(btnLogout);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(10, 10);
            pnTop.Name = "pnTop";
            pnTop.Padding = new Padding(0, 0, 0, 10);
            pnTop.Size = new Size(1009, 43);
            pnTop.TabIndex = 0;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Dock = DockStyle.Right;
            lbUserName.Location = new Point(795, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(45, 19);
            lbUserName.TabIndex = 3;
            lbUserName.Text = "label1";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(74, 111, 165);
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(840, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(169, 33);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // dvgBooks
            // 
            dvgBooks.AllowUserToAddRows = false;
            dvgBooks.AllowUserToDeleteRows = false;
            dvgBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dvgBooks.BackgroundColor = Color.White;
            dvgBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgBooks.ColumnHeadersVisible = false;
            dvgBooks.Dock = DockStyle.Fill;
            dvgBooks.Location = new Point(10, 53);
            dvgBooks.Name = "dvgBooks";
            dvgBooks.RowHeadersVisible = false;
            dvgBooks.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dvgBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgBooks.Size = new Size(1009, 507);
            dvgBooks.TabIndex = 1;
            // 
            // FormBook
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 570);
            Controls.Add(dvgBooks);
            Controls.Add(pnTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormBook";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Книги";
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTop;
        private DataGridView dvgBooks;
        private Label lbUserName;
        private Button btnLogout;
    }
}