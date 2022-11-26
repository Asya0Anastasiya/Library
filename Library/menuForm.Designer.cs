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
            this.find = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.pagesInput = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.yearInput = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.authorInput = new System.Windows.Forms.TextBox();
            this.findBy = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sortBy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LightSkyBlue;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(4, 30);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(179, 45);
            this.add.TabIndex = 0;
            this.add.Text = "Add ";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.LightSkyBlue;
            this.find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.find.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.find.Location = new System.Drawing.Point(247, 30);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(179, 45);
            this.find.TabIndex = 1;
            this.find.Text = "Find by";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            this.find.MouseMove += new System.Windows.Forms.MouseEventHandler(this.find_MouseMove);
            // 
            // sort
            // 
            this.sort.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sort.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sort.Location = new System.Drawing.Point(483, 30);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(179, 45);
            this.sort.TabIndex = 2;
            this.sort.Text = "Sort by";
            this.sort.UseVisualStyleBackColor = false;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            this.sort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sort_MouseMove);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.LightSkyBlue;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.show.Location = new System.Drawing.Point(725, 30);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(179, 45);
            this.show.TabIndex = 3;
            this.show.Text = "Show all";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(4, 104);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(150, 32);
            this.title.TabIndex = 4;
            this.title.Text = "Title:";
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(4, 145);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(150, 31);
            this.titleInput.TabIndex = 5;
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.author.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.author.Location = new System.Drawing.Point(4, 202);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(150, 32);
            this.author.TabIndex = 6;
            this.author.Text = "Author:";
            // 
            // pagesInput
            // 
            this.pagesInput.Location = new System.Drawing.Point(4, 454);
            this.pagesInput.Name = "pagesInput";
            this.pagesInput.Size = new System.Drawing.Size(150, 31);
            this.pagesInput.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(4, 407);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 32);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Amout of pages:";
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(4, 342);
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(150, 31);
            this.yearInput.TabIndex = 10;
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.year.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.year.Location = new System.Drawing.Point(4, 304);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(207, 32);
            this.year.TabIndex = 11;
            this.year.Text = "Year of publication:";
            // 
            // authorInput
            // 
            this.authorInput.Location = new System.Drawing.Point(4, 240);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(150, 31);
            this.authorInput.TabIndex = 12;
            // 
            // findBy
            // 
            this.findBy.Location = new System.Drawing.Point(247, 145);
            this.findBy.Name = "findBy";
            this.findBy.Size = new System.Drawing.Size(179, 31);
            this.findBy.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(247, 240);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 129);
            this.listBox1.TabIndex = 14;
            // 
            // sortBy
            // 
            this.sortBy.Location = new System.Drawing.Point(483, 145);
            this.sortBy.Name = "sortBy";
            this.sortBy.Size = new System.Drawing.Size(179, 31);
            this.sortBy.TabIndex = 15;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(916, 647);
            this.Controls.Add(this.sortBy);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.findBy);
            this.Controls.Add(this.authorInput);
            this.Controls.Add(this.year);
            this.Controls.Add(this.yearInput);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.pagesInput);
            this.Controls.Add(this.author);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.title);
            this.Controls.Add(this.show);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.find);
            this.Controls.Add(this.add);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "menuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Button add;
        private Button find;
        private Button sort;
        private Button show;
        private TextBox title;
        private TextBox titleInput;
        private TextBox author;
        private TextBox pagesInput;
        private TextBox textBox5;
        private TextBox yearInput;
        private TextBox year;
        private TextBox authorInput;
        private TextBox findBy;
        private ListBox listBox1;
        private TextBox sortBy;
    }
}