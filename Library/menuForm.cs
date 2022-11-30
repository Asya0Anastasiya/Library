using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Library
{
    public partial class menuForm : Form
    {
        Library library = new();
        
        public menuForm()
        {
            InitializeComponent();
            //AutoCompleteStringCollection sourceFind = new()
            //{
            //     "Title",
            //     "Author",
            //    "Year",
            //};
            //findBy.AutoCompleteCustomSource = sourceFind;
            //findBy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //findBy.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //AutoCompleteStringCollection sourceSort = new()
            //{
            //    "Title",
            //    "Author",
            //    "Year",
            //    "Pages"
            //};
            //sortBy.AutoCompleteCustomSource = sourceSort;
            //sortBy.AutoCompleteMode= AutoCompleteMode.SuggestAppend;
            //sortBy.AutoCompleteSource= AutoCompleteSource.CustomSource;
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            Book book = new(titleInput.Text, authorInput.Text, Convert.ToInt32(yearInput.Text), Convert.ToInt32(pagesInput.Text));
            library.Add(book);  
        }

        private void find_Click(object sender, EventArgs e)
        {
            switch (choosen)
            {
                case "Title":
                    break;
                case "Author":
                    break;
                case "Year":
                    Array.Sort(library.books.ToArray(), new BookComparer());
                    listBox1.Items.AddRange(library.books.ToArray());
                    break;
                default:
                    break;
            }
        }

        private void sort_Click(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {

        }


        public string choosen;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosen = comboBox1.SelectedIndex.ToString();
        }

        private void findBy_TextChanged(object sender, EventArgs e)
        {

        }

        //private void find_MouseMove(object sender, MouseEventArgs e)
        //{
        //    MessageBox.Show(
        //        "Write an option to search for:\n Title\n Author\n Year",
        //        "Info",
        //        MessageBoxButtons.OK,
        //        MessageBoxIcon.Information,
        //        MessageBoxDefaultButton.Button1,
        //        MessageBoxOptions.DefaultDesktopOnly);
        //}

        //private void sort_MouseMove(object sender, MouseEventArgs e)
        //{
        //    MessageBox.Show(
        //       "Write an option to sort for:\n Title\n Author\n Year\n Pages",
        //       "Info",
        //       MessageBoxButtons.OK,
        //       MessageBoxIcon.Information,
        //       MessageBoxDefaultButton.Button1,
        //       MessageBoxOptions.DefaultDesktopOnly);
        //}
    }
}
