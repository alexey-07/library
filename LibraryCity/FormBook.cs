using LibraryCity.Models;
using LibraryCity.Properties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryCity
{
    public partial class FormBook : Form
    {
        public User CurrentUser { get; private set; }

        public bool IsGuest { get; private set; }
        public FormBook(User user, bool guest)
        {
            InitializeComponent();

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 200;
            colPhoto.FillWeight = 30;


            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colAvilable = new DataGridViewTextBoxColumn();
            colAvilable.Name = "colAvilable";
            colAvilable.FillWeight = 10;
            colAvilable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            dvgBooks.Columns.AddRange(
            [
                colPhoto,colInfo,colAvilable
            ]);

            CurrentUser = user;
            IsGuest = guest;

            lbUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;
            LoadBooks();

        }


        private void LoadBooks()
        {
            try
            {
                using (var db = new LibraryCityContext())
                {
                    var books = db.Books
                        .Include(i => i.Athor)
                        .Include(i => i.Genre)
                        .Include(i => i.PublishingHouse)
                        .ToList();

                    dvgBooks.SuspendLayout();
                    dvgBooks.Rows.Clear();

                    foreach (var book in books)
                    {
                        int rowIndex = dvgBooks.Rows.Add();
                        var row = dvgBooks.Rows[rowIndex];

                        row.Cells["colPhoto"].Value = LoadBookImage(book.Image);

                        row.Cells["colInfo"].Value = FormatBookInfo(book);

                        row.Cells["colAvilable"].Value = $"В наличие: {book.Available}";
                        row.Cells["colAvilable"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        ApllyRowStyles(row, book);
                    }
                    dvgBooks.ResumeLayout();
                    dvgBooks.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ApllyRowStyles(DataGridViewRow row, Book book)
        {
            if (book.Available <= 2)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFF3CD");
                row.DefaultCellStyle.ForeColor = Color.Black;
            }

            if (book.Available <= 0)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFCCCC");
            }

            /*   if (book.Available < 30)
               {
                   row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#D4EDDA");
               }*/
        }

        private string? FormatBookInfo(Book book)
        {
            return $"{book.BookName}" + Environment.NewLine +
                $"Автор: {book.Athor.AthorName}" + Environment.NewLine +
                $"Жанр: {book.Genre.GenreName}" + Environment.NewLine +
                $"Издательство: {book.PublishingHouse.PublishingName}" + Environment.NewLine +
                $"Год: {book.Year}" + Environment.NewLine +
                $"Страницы: {book.Copy}" + Environment.NewLine +
                $"Описание: {book.Annotation}";
        }

        private Image LoadBookImage(string image)
        {
            if (!String.IsNullOrEmpty(image) && System.IO.File.Exists(image))
            {
                return Image.FromFile(image);
            }
            return Resources.book_placeholder;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
    }
}
