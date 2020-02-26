namespace LMS_IntenciA
{
    partial class frm_reference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reference));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.btn_view = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_searchCount = new System.Windows.Forms.Label();
            this.lb_search2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.cmb_searchBy = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_details = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contactUsToolStripMenuItem.Text = "Contact us";
            this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_2);
            this.groupBox1.Controls.Add(this.lb_1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(0, 611);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 117);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Developed by";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.BackColor = System.Drawing.Color.Transparent;
            this.lb_2.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.Location = new System.Drawing.Point(213, 45);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(280, 23);
            this.lb_2.TabIndex = 2;
            this.lb_2.Text = "(Infortec International-Nugegoda)";
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.BackColor = System.Drawing.Color.Transparent;
            this.lb_1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(87, 43);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(130, 25);
            this.lb_1.TabIndex = 1;
            this.lb_1.Text = "IntenciA group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LMS_IntenciA.Properties.Resources._1405154916814;
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_books
            // 
            this.dgv_books.AllowUserToAddRows = false;
            this.dgv_books.AllowUserToDeleteRows = false;
            this.dgv_books.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_books.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.GridColor = System.Drawing.SystemColors.Menu;
            this.dgv_books.Location = new System.Drawing.Point(51, 199);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.ReadOnly = true;
            this.dgv_books.RowHeadersVisible = false;
            this.dgv_books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_books.Size = new System.Drawing.Size(901, 345);
            this.dgv_books.TabIndex = 16;
            this.dgv_books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellContentClick);
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(51, 550);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(137, 31);
            this.btn_view.TabIndex = 15;
            this.btn_view.Text = "Refresh";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Reference";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_searchCount);
            this.groupBox2.Controls.Add(this.lb_search2);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.cmb_searchBy);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(51, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 118);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Box";
            // 
            // lb_searchCount
            // 
            this.lb_searchCount.AutoSize = true;
            this.lb_searchCount.Location = new System.Drawing.Point(600, 81);
            this.lb_searchCount.Name = "lb_searchCount";
            this.lb_searchCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_searchCount.Size = new System.Drawing.Size(17, 19);
            this.lb_searchCount.TabIndex = 7;
            this.lb_searchCount.Text = "0";
            this.lb_searchCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_search2
            // 
            this.lb_search2.AutoSize = true;
            this.lb_search2.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_search2.Location = new System.Drawing.Point(623, 82);
            this.lb_search2.Name = "lb_search2";
            this.lb_search2.Size = new System.Drawing.Size(164, 18);
            this.lb_search2.TabIndex = 6;
            this.lb_search2.Text = "Record(s) matched search";
            this.lb_search2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(413, 78);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(84, 28);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cmb_searchBy
            // 
            this.cmb_searchBy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_searchBy.FormattingEnabled = true;
            this.cmb_searchBy.Items.AddRange(new object[] {
            "ISBN",
            "Name",
            "Author"});
            this.cmb_searchBy.Location = new System.Drawing.Point(103, 31);
            this.cmb_searchBy.Name = "cmb_searchBy";
            this.cmb_searchBy.Size = new System.Drawing.Size(304, 27);
            this.cmb_searchBy.TabIndex = 4;
            this.cmb_searchBy.Text = "Name";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(103, 78);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(304, 27);
            this.txt_search.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Text :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by :";
            // 
            // btn_details
            // 
            this.btn_details.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_details.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_details.Location = new System.Drawing.Point(217, 550);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(107, 31);
            this.btn_details.TabIndex = 19;
            this.btn_details.Text = "Details";
            this.btn_details.UseVisualStyleBackColor = false;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // frm_reference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_details);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frm_reference";
            this.Text = "Nugegoda Public Library - Reference unit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_reference_FormClosing);
            this.Load += new System.EventHandler(this.frm_reference_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_searchCount;
        private System.Windows.Forms.Label lb_search2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cmb_searchBy;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_details;
    }
}