namespace LMS_IntenciA
{
    partial class frm_admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_admin));
            this.tab_admin = new System.Windows.Forms.TabControl();
            this.tb_books = new System.Windows.Forms.TabPage();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_searchCount = new System.Windows.Forms.Label();
            this.lb_search2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.cmb_searchBy = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_mbrships = new System.Windows.Forms.TabPage();
            this.dgv_members = new System.Windows.Forms.DataGridView();
            this.btn_mEdit = new System.Windows.Forms.Button();
            this.btn_mDel = new System.Windows.Forms.Button();
            this.btn_mAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_mSearch = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_mSearch = new System.Windows.Forms.Button();
            this.cmb_mSearchBy = new System.Windows.Forms.ComboBox();
            this.txt_mSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_mRefsh = new System.Windows.Forms.Button();
            this.tb_mnn = new System.Windows.Forms.TabPage();
            this.btn_magDel = new System.Windows.Forms.Button();
            this.dgv_newspapers = new System.Windows.Forms.DataGridView();
            this.dgv_magazine = new System.Windows.Forms.DataGridView();
            this.btn_newsDel = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmb_cat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_mnnSearch = new System.Windows.Forms.Label();
            this.lb_mnn = new System.Windows.Forms.Label();
            this.btn_mnnSearch = new System.Windows.Forms.Button();
            this.cmb_mnnSearch = new System.Windows.Forms.ComboBox();
            this.txt_mnnSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lmsDataSet = new LMS_IntenciA.lmsDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksTableAdapter = new LMS_IntenciA.lmsDataSetTableAdapters.booksTableAdapter();
            this.tab_admin.SuspendLayout();
            this.tb_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tb_mbrships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_members)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tb_mnn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_newspapers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_magazine)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmsDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_admin
            // 
            this.tab_admin.Controls.Add(this.tb_books);
            this.tab_admin.Controls.Add(this.tb_mbrships);
            this.tab_admin.Controls.Add(this.tb_mnn);
            this.tab_admin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_admin.Location = new System.Drawing.Point(48, 44);
            this.tab_admin.Name = "tab_admin";
            this.tab_admin.SelectedIndex = 0;
            this.tab_admin.Size = new System.Drawing.Size(915, 548);
            this.tab_admin.TabIndex = 0;
            // 
            // tb_books
            // 
            this.tb_books.Controls.Add(this.dgv_books);
            this.tb_books.Controls.Add(this.btn_view);
            this.tb_books.Controls.Add(this.btn_edit);
            this.tb_books.Controls.Add(this.btn_del);
            this.tb_books.Controls.Add(this.btn_add);
            this.tb_books.Controls.Add(this.groupBox2);
            this.tb_books.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_books.Location = new System.Drawing.Point(4, 28);
            this.tb_books.Name = "tb_books";
            this.tb_books.Padding = new System.Windows.Forms.Padding(3);
            this.tb_books.Size = new System.Drawing.Size(907, 516);
            this.tb_books.TabIndex = 0;
            this.tb_books.Text = "Books";
            this.tb_books.UseVisualStyleBackColor = true;
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
            this.dgv_books.Location = new System.Drawing.Point(3, 128);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.ReadOnly = true;
            this.dgv_books.RowHeadersVisible = false;
            this.dgv_books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_books.Size = new System.Drawing.Size(901, 345);
            this.dgv_books.TabIndex = 5;
            this.dgv_books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellContentClick);
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(278, 479);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 31);
            this.btn_view.TabIndex = 4;
            this.btn_view.Text = "Refresh";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(165, 479);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(107, 31);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit / View";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(84, 479);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 31);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(3, 479);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 31);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 118);
            this.groupBox2.TabIndex = 0;
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
            // tb_mbrships
            // 
            this.tb_mbrships.Controls.Add(this.dgv_members);
            this.tb_mbrships.Controls.Add(this.btn_mEdit);
            this.tb_mbrships.Controls.Add(this.btn_mDel);
            this.tb_mbrships.Controls.Add(this.btn_mAdd);
            this.tb_mbrships.Controls.Add(this.groupBox3);
            this.tb_mbrships.Controls.Add(this.btn_mRefsh);
            this.tb_mbrships.Location = new System.Drawing.Point(4, 28);
            this.tb_mbrships.Name = "tb_mbrships";
            this.tb_mbrships.Padding = new System.Windows.Forms.Padding(3);
            this.tb_mbrships.Size = new System.Drawing.Size(907, 516);
            this.tb_mbrships.TabIndex = 1;
            this.tb_mbrships.Text = "Memberships";
            this.tb_mbrships.UseVisualStyleBackColor = true;
            // 
            // dgv_members
            // 
            this.dgv_members.AllowUserToAddRows = false;
            this.dgv_members.AllowUserToDeleteRows = false;
            this.dgv_members.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_members.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_members.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_members.GridColor = System.Drawing.SystemColors.Menu;
            this.dgv_members.Location = new System.Drawing.Point(3, 128);
            this.dgv_members.Name = "dgv_members";
            this.dgv_members.ReadOnly = true;
            this.dgv_members.RowHeadersVisible = false;
            this.dgv_members.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_members.Size = new System.Drawing.Size(901, 345);
            this.dgv_members.TabIndex = 9;
            this.dgv_members.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_members_CellContentClick);
            // 
            // btn_mEdit
            // 
            this.btn_mEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mEdit.Location = new System.Drawing.Point(165, 479);
            this.btn_mEdit.Name = "btn_mEdit";
            this.btn_mEdit.Size = new System.Drawing.Size(125, 31);
            this.btn_mEdit.TabIndex = 7;
            this.btn_mEdit.Text = "Edit / View";
            this.btn_mEdit.UseVisualStyleBackColor = false;
            this.btn_mEdit.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_mDel
            // 
            this.btn_mDel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mDel.Location = new System.Drawing.Point(84, 479);
            this.btn_mDel.Name = "btn_mDel";
            this.btn_mDel.Size = new System.Drawing.Size(75, 31);
            this.btn_mDel.TabIndex = 6;
            this.btn_mDel.Text = "Delete";
            this.btn_mDel.UseVisualStyleBackColor = false;
            this.btn_mDel.Click += new System.EventHandler(this.btn_mDel_Click);
            // 
            // btn_mAdd
            // 
            this.btn_mAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mAdd.Location = new System.Drawing.Point(3, 479);
            this.btn_mAdd.Name = "btn_mAdd";
            this.btn_mAdd.Size = new System.Drawing.Size(75, 31);
            this.btn_mAdd.TabIndex = 5;
            this.btn_mAdd.Text = "Add";
            this.btn_mAdd.UseVisualStyleBackColor = false;
            this.btn_mAdd.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_mSearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_mSearch);
            this.groupBox3.Controls.Add(this.cmb_mSearchBy);
            this.groupBox3.Controls.Add(this.txt_mSearch);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(901, 118);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Box";
            // 
            // lb_mSearch
            // 
            this.lb_mSearch.AutoSize = true;
            this.lb_mSearch.Location = new System.Drawing.Point(600, 81);
            this.lb_mSearch.Name = "lb_mSearch";
            this.lb_mSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_mSearch.Size = new System.Drawing.Size(17, 19);
            this.lb_mSearch.TabIndex = 7;
            this.lb_mSearch.Text = "0";
            this.lb_mSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(623, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Record(s) matched search";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_mSearch
            // 
            this.btn_mSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mSearch.Location = new System.Drawing.Point(413, 78);
            this.btn_mSearch.Name = "btn_mSearch";
            this.btn_mSearch.Size = new System.Drawing.Size(84, 28);
            this.btn_mSearch.TabIndex = 5;
            this.btn_mSearch.Text = "Search";
            this.btn_mSearch.UseVisualStyleBackColor = false;
            this.btn_mSearch.Click += new System.EventHandler(this.btn_mSearch_Click);
            // 
            // cmb_mSearchBy
            // 
            this.cmb_mSearchBy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mSearchBy.FormattingEnabled = true;
            this.cmb_mSearchBy.Items.AddRange(new object[] {
            "Membership_No",
            "Name",
            "Phone_No"});
            this.cmb_mSearchBy.Location = new System.Drawing.Point(103, 31);
            this.cmb_mSearchBy.Name = "cmb_mSearchBy";
            this.cmb_mSearchBy.Size = new System.Drawing.Size(304, 27);
            this.cmb_mSearchBy.TabIndex = 4;
            this.cmb_mSearchBy.Text = "Membership_No";
            // 
            // txt_mSearch
            // 
            this.txt_mSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mSearch.Location = new System.Drawing.Point(103, 78);
            this.txt_mSearch.Name = "txt_mSearch";
            this.txt_mSearch.Size = new System.Drawing.Size(304, 27);
            this.txt_mSearch.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Search Text :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search by :";
            // 
            // btn_mRefsh
            // 
            this.btn_mRefsh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mRefsh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mRefsh.Location = new System.Drawing.Point(296, 479);
            this.btn_mRefsh.Name = "btn_mRefsh";
            this.btn_mRefsh.Size = new System.Drawing.Size(75, 31);
            this.btn_mRefsh.TabIndex = 8;
            this.btn_mRefsh.Text = "Refresh";
            this.btn_mRefsh.UseVisualStyleBackColor = false;
            this.btn_mRefsh.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_mnn
            // 
            this.tb_mnn.Controls.Add(this.btn_magDel);
            this.tb_mnn.Controls.Add(this.dgv_newspapers);
            this.tb_mnn.Controls.Add(this.dgv_magazine);
            this.tb_mnn.Controls.Add(this.btn_newsDel);
            this.tb_mnn.Controls.Add(this.button10);
            this.tb_mnn.Controls.Add(this.groupBox4);
            this.tb_mnn.Controls.Add(this.button7);
            this.tb_mnn.Location = new System.Drawing.Point(4, 28);
            this.tb_mnn.Name = "tb_mnn";
            this.tb_mnn.Size = new System.Drawing.Size(907, 516);
            this.tb_mnn.TabIndex = 2;
            this.tb_mnn.Text = "Magazines & Newspapers";
            this.tb_mnn.UseVisualStyleBackColor = true;
            // 
            // btn_magDel
            // 
            this.btn_magDel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_magDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_magDel.Location = new System.Drawing.Point(374, 478);
            this.btn_magDel.Name = "btn_magDel";
            this.btn_magDel.Size = new System.Drawing.Size(75, 31);
            this.btn_magDel.TabIndex = 11;
            this.btn_magDel.Text = "Delete";
            this.btn_magDel.UseVisualStyleBackColor = false;
            this.btn_magDel.Click += new System.EventHandler(this.btn_magDel_Click);
            // 
            // dgv_newspapers
            // 
            this.dgv_newspapers.AllowUserToAddRows = false;
            this.dgv_newspapers.AllowUserToDeleteRows = false;
            this.dgv_newspapers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_newspapers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_newspapers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_newspapers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_newspapers.GridColor = System.Drawing.SystemColors.Menu;
            this.dgv_newspapers.Location = new System.Drawing.Point(458, 153);
            this.dgv_newspapers.Name = "dgv_newspapers";
            this.dgv_newspapers.ReadOnly = true;
            this.dgv_newspapers.RowHeadersVisible = false;
            this.dgv_newspapers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_newspapers.Size = new System.Drawing.Size(446, 319);
            this.dgv_newspapers.TabIndex = 10;
            this.dgv_newspapers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_newspapers_CellContentClick);
            // 
            // dgv_magazine
            // 
            this.dgv_magazine.AllowUserToAddRows = false;
            this.dgv_magazine.AllowUserToDeleteRows = false;
            this.dgv_magazine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_magazine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_magazine.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_magazine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_magazine.GridColor = System.Drawing.SystemColors.Menu;
            this.dgv_magazine.Location = new System.Drawing.Point(3, 153);
            this.dgv_magazine.Name = "dgv_magazine";
            this.dgv_magazine.ReadOnly = true;
            this.dgv_magazine.RowHeadersVisible = false;
            this.dgv_magazine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_magazine.Size = new System.Drawing.Size(446, 319);
            this.dgv_magazine.TabIndex = 9;
            this.dgv_magazine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_magazine_CellContentClick);
            // 
            // btn_newsDel
            // 
            this.btn_newsDel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_newsDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_newsDel.Location = new System.Drawing.Point(829, 478);
            this.btn_newsDel.Name = "btn_newsDel";
            this.btn_newsDel.Size = new System.Drawing.Size(75, 31);
            this.btn_newsDel.TabIndex = 6;
            this.btn_newsDel.Text = "Delete";
            this.btn_newsDel.UseVisualStyleBackColor = false;
            this.btn_newsDel.Click += new System.EventHandler(this.btn_newsDel_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Location = new System.Drawing.Point(3, 478);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 31);
            this.button10.TabIndex = 5;
            this.button10.Text = "Add";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmb_cat);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lb_mnnSearch);
            this.groupBox4.Controls.Add(this.lb_mnn);
            this.groupBox4.Controls.Add(this.btn_mnnSearch);
            this.groupBox4.Controls.Add(this.cmb_mnnSearch);
            this.groupBox4.Controls.Add(this.txt_mnnSearch);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(901, 144);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Box";
            // 
            // cmb_cat
            // 
            this.cmb_cat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cat.FormattingEnabled = true;
            this.cmb_cat.Items.AddRange(new object[] {
            "Magazines",
            "Newspapers"});
            this.cmb_cat.Location = new System.Drawing.Point(103, 33);
            this.cmb_cat.Name = "cmb_cat";
            this.cmb_cat.Size = new System.Drawing.Size(304, 27);
            this.cmb_cat.TabIndex = 9;
            this.cmb_cat.Text = "Magazines";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category :";
            // 
            // lb_mnnSearch
            // 
            this.lb_mnnSearch.AutoSize = true;
            this.lb_mnnSearch.Location = new System.Drawing.Point(600, 111);
            this.lb_mnnSearch.Name = "lb_mnnSearch";
            this.lb_mnnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_mnnSearch.Size = new System.Drawing.Size(17, 19);
            this.lb_mnnSearch.TabIndex = 7;
            this.lb_mnnSearch.Text = "0";
            this.lb_mnnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_mnn
            // 
            this.lb_mnn.AutoSize = true;
            this.lb_mnn.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mnn.Location = new System.Drawing.Point(623, 112);
            this.lb_mnn.Name = "lb_mnn";
            this.lb_mnn.Size = new System.Drawing.Size(164, 18);
            this.lb_mnn.TabIndex = 6;
            this.lb_mnn.Text = "Record(s) matched search";
            this.lb_mnn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_mnnSearch
            // 
            this.btn_mnnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mnnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mnnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mnnSearch.Location = new System.Drawing.Point(413, 108);
            this.btn_mnnSearch.Name = "btn_mnnSearch";
            this.btn_mnnSearch.Size = new System.Drawing.Size(84, 28);
            this.btn_mnnSearch.TabIndex = 5;
            this.btn_mnnSearch.Text = "Search";
            this.btn_mnnSearch.UseVisualStyleBackColor = false;
            this.btn_mnnSearch.Click += new System.EventHandler(this.btn_mnnSearch_Click);
            // 
            // cmb_mnnSearch
            // 
            this.cmb_mnnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mnnSearch.FormattingEnabled = true;
            this.cmb_mnnSearch.Items.AddRange(new object[] {
            "Index_No",
            "Name",
            "Date"});
            this.cmb_mnnSearch.Location = new System.Drawing.Point(103, 71);
            this.cmb_mnnSearch.Name = "cmb_mnnSearch";
            this.cmb_mnnSearch.Size = new System.Drawing.Size(304, 27);
            this.cmb_mnnSearch.TabIndex = 4;
            this.cmb_mnnSearch.Text = "Name";
            // 
            // txt_mnnSearch
            // 
            this.txt_mnnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mnnSearch.Location = new System.Drawing.Point(103, 108);
            this.txt_mnnSearch.Name = "txt_mnnSearch";
            this.txt_mnnSearch.Size = new System.Drawing.Size(304, 27);
            this.txt_mnnSearch.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Search Text :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Search by :";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(90, 478);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 31);
            this.button7.TabIndex = 8;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.lmsDataSet;
            // 
            // lmsDataSet
            // 
            this.lmsDataSet.DataSetName = "lmsDataSet";
            this.lmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_2);
            this.groupBox1.Controls.Add(this.lb_1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(0, 610);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 117);
            this.groupBox1.TabIndex = 6;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referenceToolStripMenuItem,
            this.lendingToolStripMenuItem,
            this.finesToolStripMenuItem,
            this.adminProfileToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.referenceToolStripMenuItem.Text = "Reference";
            this.referenceToolStripMenuItem.Click += new System.EventHandler(this.referenceToolStripMenuItem_Click);
            // 
            // lendingToolStripMenuItem
            // 
            this.lendingToolStripMenuItem.Name = "lendingToolStripMenuItem";
            this.lendingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lendingToolStripMenuItem.Text = "Lending";
            this.lendingToolStripMenuItem.Click += new System.EventHandler(this.lendingToolStripMenuItem_Click);
            // 
            // finesToolStripMenuItem
            // 
            this.finesToolStripMenuItem.Name = "finesToolStripMenuItem";
            this.finesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.finesToolStripMenuItem.Text = "Fines";
            this.finesToolStripMenuItem.Click += new System.EventHandler(this.finesToolStripMenuItem_Click);
            // 
            // adminProfileToolStripMenuItem
            // 
            this.adminProfileToolStripMenuItem.Name = "adminProfileToolStripMenuItem";
            this.adminProfileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adminProfileToolStripMenuItem.Text = "Admin Profile";
            this.adminProfileToolStripMenuItem.Click += new System.EventHandler(this.adminProfileToolStripMenuItem_Click);
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
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1004, 725);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tab_admin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frm_admin";
            this.Text = "Nugegoda Public Library";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_admin_FormClosing);
            this.Load += new System.EventHandler(this.frm_admin_Load);
            this.tab_admin.ResumeLayout(false);
            this.tb_books.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tb_mbrships.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_members)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tb_mnn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_newspapers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_magazine)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmsDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_admin;
        private System.Windows.Forms.TabPage tb_books;
        private System.Windows.Forms.TabPage tb_mbrships;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tb_mnn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_searchCount;
        private System.Windows.Forms.Label lb_search2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cmb_searchBy;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_mSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_mSearch;
        private System.Windows.Forms.ComboBox cmb_mSearchBy;
        private System.Windows.Forms.TextBox txt_mSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_mnnSearch;
        private System.Windows.Forms.Label lb_mnn;
        private System.Windows.Forms.Button btn_mnnSearch;
        private System.Windows.Forms.ComboBox cmb_mnnSearch;
        private System.Windows.Forms.TextBox txt_mnnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_mEdit;
        private System.Windows.Forms.Button btn_mDel;
        private System.Windows.Forms.Button btn_mAdd;
        private System.Windows.Forms.Button btn_newsDel;
        private System.Windows.Forms.Button button10;
        private lmsDataSet lmsDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private lmsDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.DataGridView dgv_members;
        private System.Windows.Forms.DataGridView dgv_magazine;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finesToolStripMenuItem;
        private System.Windows.Forms.Button btn_mRefsh;
        private System.Windows.Forms.DataGridView dgv_newspapers;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_magDel;
        private System.Windows.Forms.ComboBox cmb_cat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem adminProfileToolStripMenuItem;
    }
}