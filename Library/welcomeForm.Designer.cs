namespace Library
{
    partial class welcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contacts = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.support = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkRed;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(269, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 45);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Welcome to our Library!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.contacts, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.menu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.support, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(299, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 76);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // contacts
            // 
            this.contacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contacts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.contacts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contacts.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.contacts.Location = new System.Drawing.Point(3, 3);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(126, 70);
            this.contacts.TabIndex = 0;
            this.contacts.Text = "Contacts";
            this.contacts.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menu.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.menu.Location = new System.Drawing.Point(135, 3);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(126, 70);
            this.menu.TabIndex = 1;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // support
            // 
            this.support.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.support.Dock = System.Windows.Forms.DockStyle.Fill;
            this.support.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.support.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.support.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.support.Location = new System.Drawing.Point(267, 3);
            this.support.Name = "support";
            this.support.Size = new System.Drawing.Size(128, 70);
            this.support.TabIndex = 2;
            this.support.Text = "Support Us";
            this.support.UseVisualStyleBackColor = false;
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "welcomeForm";
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.welcomeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button contacts;
        private Button menu;
        private Button support;
    }
}