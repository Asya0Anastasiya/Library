using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Library
{
    public partial class menuForm : Form
    {
        Library library = new();
        
        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            TabControl TabControl1 = new();
            TabPage TabPage1 = new();
            TabPage TabPage2 = new();
            TabPage TabPage3 = new();
            TabPage TabPage4 = new();
            this.Controls.Add(TabControl1);
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Controls.Add(TabPage3);
            TabControl1.Controls.Add(TabPage4);
            
            TextBox title = new();
            TextBox author = new();
            TextBox year = new();
            TextBox pages = new();
            
            TabControl1.Location = new System.Drawing.Point(40, 171);
            TabControl1.Name = "tabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new System.Drawing.Size(401, 87);
            TabControl1.TabIndex = 1;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(title);
            TabPage1.Location = new System.Drawing.Point(4, 34);
            TabPage1.Name = "tabPage1";
            TabPage1.Padding = new System.Windows.Forms.Padding(3);
            TabPage1.Size = new System.Drawing.Size(393, 49);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Enter the title";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(author);
            TabPage2.Location = new System.Drawing.Point(4, 34);
            TabPage2.Name = "tabPage2";
            TabPage2.Padding = new System.Windows.Forms.Padding(3);
            TabPage2.Size = new System.Drawing.Size(393, 49);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Enter the author";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // TabPage3
            // 
            TabPage3.Controls.Add(year);
            TabPage3.Location = new System.Drawing.Point(4, 34);
            TabPage3.Name = "tabPage3";
            TabPage3.Padding = new System.Windows.Forms.Padding(3);
            TabPage3.Size = new System.Drawing.Size(393, 49);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Enter the year of publication";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // TabPage4
            // 
            TabPage4.Controls.Add(pages);
            TabPage4.Location = new System.Drawing.Point(4, 34);
            TabPage4.Name = "tabPage4";
            TabPage4.Padding = new System.Windows.Forms.Padding(3);
            TabPage4.Size = new System.Drawing.Size(393, 49);
            TabPage4.TabIndex = 3;
            TabPage4.Text = "Enter the amount of pages";
            TabPage4.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            title.Dock = System.Windows.Forms.DockStyle.Fill;
            title.Location = new System.Drawing.Point(3, 3);
            title.Name = "title";
            title.Size = new System.Drawing.Size(387, 31);
            title.TabIndex = 0;
            // 
            // author
            // 
            author.Dock = System.Windows.Forms.DockStyle.Fill;
            author.Location = new System.Drawing.Point(3, 3);
            author.Name = "author";
            author.Size = new System.Drawing.Size(387, 31);
            author.TabIndex = 0;
            // 
            // year
            // 
            year.Dock = System.Windows.Forms.DockStyle.Fill;
            year.Location = new System.Drawing.Point(3, 3);
            year.Name = "year";
            year.Size = new System.Drawing.Size(387, 31);
            year.TabIndex = 0;
            // 
            // pages
            // 
            pages.Dock = System.Windows.Forms.DockStyle.Fill;
            pages.Location = new System.Drawing.Point(3, 3);
            pages.Name = "pages";
            pages.Size = new System.Drawing.Size(387, 31);
            pages.TabIndex = 0;

            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            TabPage2.ResumeLayout(false);
            TabPage2.PerformLayout();
            TabPage3.ResumeLayout(false);
            TabPage3.PerformLayout();
            TabPage4.ResumeLayout(false);
            TabPage4.PerformLayout();
            this.ResumeLayout(false);
            Book book = new(title.Text, author.Text, Convert.ToInt16(year.Text), Convert.ToInt16(pages.Text));
            library.books.Add(book);
        }
    }
}
