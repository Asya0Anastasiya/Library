namespace Library
{
    partial class menuForm
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
            this.add = new System.Windows.Forms.Button();
            //this.tabControl1 = new System.Windows.Forms.TabControl();
            //this.tabPage1 = new System.Windows.Forms.TabPage();
            //this.tabPage2 = new System.Windows.Forms.TabPage();
            //this.tabPage3 = new System.Windows.Forms.TabPage();
            //this.tabPage4 = new System.Windows.Forms.TabPage();
            //this.title = new System.Windows.Forms.TextBox();
            //this.author = new System.Windows.Forms.TextBox();
            //this.year = new System.Windows.Forms.TextBox();
            //this.pages = new System.Windows.Forms.TextBox();
            //this.tabControl1.SuspendLayout();
            //this.tabPage1.SuspendLayout();
            //this.tabPage2.SuspendLayout();
            //this.tabPage3.SuspendLayout();
            //this.tabPage4.SuspendLayout();
            //this.SuspendLayout();
            //// 
            //// add
            //// 
            this.add.Location = new System.Drawing.Point(40, 41);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(112, 34);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            //// 
            //// tabControl1
            //// 
            //this.tabControl1.Controls.Add(this.tabPage1);
            //this.tabControl1.Controls.Add(this.tabPage2);
            //this.tabControl1.Controls.Add(this.tabPage3);
            //this.tabControl1.Controls.Add(this.tabPage4);
            //this.tabControl1.Location = new System.Drawing.Point(40, 171);
            //this.tabControl1.Name = "tabControl1";
            //this.tabControl1.SelectedIndex = 0;
            //this.tabControl1.Size = new System.Drawing.Size(401, 87);
            //this.tabControl1.TabIndex = 1;
            //// 
            //// tabPage1
            //// 
            //this.tabPage1.Controls.Add(this.title);
            //this.tabPage1.Location = new System.Drawing.Point(4, 34);
            //this.tabPage1.Name = "tabPage1";
            //this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            //this.tabPage1.Size = new System.Drawing.Size(393, 49);
            //this.tabPage1.TabIndex = 0;
            //this.tabPage1.Text = "tabPage1";
            //this.tabPage1.UseVisualStyleBackColor = true;
            //// 
            //// tabPage2
            //// 
            //this.tabPage2.Controls.Add(this.author);
            //this.tabPage2.Location = new System.Drawing.Point(4, 34);
            //this.tabPage2.Name = "tabPage2";
            //this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            //this.tabPage2.Size = new System.Drawing.Size(393, 49);
            //this.tabPage2.TabIndex = 1;
            //this.tabPage2.Text = "tabPage2";
            //this.tabPage2.UseVisualStyleBackColor = true;
            //// 
            //// tabPage3
            //// 
            //this.tabPage3.Controls.Add(this.year);
            //this.tabPage3.Location = new System.Drawing.Point(4, 34);
            //this.tabPage3.Name = "tabPage3";
            //this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            //this.tabPage3.Size = new System.Drawing.Size(393, 49);
            //this.tabPage3.TabIndex = 2;
            //this.tabPage3.Text = "tabPage3";
            //this.tabPage3.UseVisualStyleBackColor = true;
            //// 
            //// tabPage4
            //// 
            //this.tabPage4.Controls.Add(this.pages);
            //this.tabPage4.Location = new System.Drawing.Point(4, 34);
            //this.tabPage4.Name = "tabPage4";
            //this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            //this.tabPage4.Size = new System.Drawing.Size(393, 49);
            //this.tabPage4.TabIndex = 3;
            //this.tabPage4.Text = "tabPage4";
            //this.tabPage4.UseVisualStyleBackColor = true;
            //// 
            //// title
            //// 
            //this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.title.Location = new System.Drawing.Point(3, 3);
            //this.title.Name = "title";
            //this.title.Size = new System.Drawing.Size(387, 31);
            //this.title.TabIndex = 0;
            //// 
            //// author
            //// 
            //this.author.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.author.Location = new System.Drawing.Point(3, 3);
            //this.author.Name = "author";
            //this.author.Size = new System.Drawing.Size(387, 31);
            //this.author.TabIndex = 0;
            //// 
            //// year
            //// 
            //this.year.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.year.Location = new System.Drawing.Point(3, 3);
            //this.year.Name = "year";
            //this.year.Size = new System.Drawing.Size(387, 31);
            //this.year.TabIndex = 0;
            //// 
            //// pages
            //// 
            //this.pages.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.pages.Location = new System.Drawing.Point(3, 3);
            //this.pages.Name = "pages";
            //this.pages.Size = new System.Drawing.Size(387, 31);
            //this.pages.TabIndex = 0;


            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 647);
            //this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.add);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "menuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.menuForm_Load);
            //this.tabControl1.ResumeLayout(false);
            //this.tabPage1.ResumeLayout(false);
            //this.tabPage1.PerformLayout();
            //this.tabPage2.ResumeLayout(false);
            //this.tabPage2.PerformLayout();
            //this.tabPage3.ResumeLayout(false);
            //this.tabPage3.PerformLayout();
            //this.tabPage4.ResumeLayout(false);
            //this.tabPage4.PerformLayout();
            //this.ResumeLayout(false);

        }

        #endregion

        private Button add;
        //private TabControl tabControl1;
        //private TabPage tabPage1;
        //private TextBox title;
        //private TabPage tabPage2;
        //private TextBox author;
        //private TabPage tabPage3;
        //private TextBox year;
        //private TabPage tabPage4;
        //private TextBox pages;
    }
}