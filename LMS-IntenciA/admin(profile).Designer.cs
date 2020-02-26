namespace LMS_IntenciA
{
    partial class frm_admin_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_admin_profile));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_rfsh = new System.Windows.Forms.Button();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.btn_st_del = new System.Windows.Forms.Button();
            this.btn_st_add = new System.Windows.Forms.Button();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_pos = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Profile Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profile Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Position :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_rfsh);
            this.groupBox1.Controls.Add(this.dgv_staff);
            this.groupBox1.Controls.Add(this.btn_st_del);
            this.groupBox1.Controls.Add(this.btn_st_add);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(488, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 572);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff members";
            // 
            // btn_rfsh
            // 
            this.btn_rfsh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_rfsh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rfsh.Location = new System.Drawing.Point(265, 487);
            this.btn_rfsh.Name = "btn_rfsh";
            this.btn_rfsh.Size = new System.Drawing.Size(75, 31);
            this.btn_rfsh.TabIndex = 10;
            this.btn_rfsh.Text = "Refresh";
            this.btn_rfsh.UseVisualStyleBackColor = false;
            this.btn_rfsh.Click += new System.EventHandler(this.btn_rfsh_Click);
            // 
            // dgv_staff
            // 
            this.dgv_staff.AllowUserToAddRows = false;
            this.dgv_staff.AllowUserToDeleteRows = false;
            this.dgv_staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_staff.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.GridColor = System.Drawing.SystemColors.Menu;
            this.dgv_staff.Location = new System.Drawing.Point(6, 35);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.ReadOnly = true;
            this.dgv_staff.RowHeadersVisible = false;
            this.dgv_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_staff.Size = new System.Drawing.Size(486, 404);
            this.dgv_staff.TabIndex = 10;
            this.dgv_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentClick);
            // 
            // btn_st_del
            // 
            this.btn_st_del.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_st_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_st_del.Location = new System.Drawing.Point(358, 487);
            this.btn_st_del.Name = "btn_st_del";
            this.btn_st_del.Size = new System.Drawing.Size(134, 31);
            this.btn_st_del.TabIndex = 5;
            this.btn_st_del.Text = "Delete";
            this.btn_st_del.UseVisualStyleBackColor = false;
            this.btn_st_del.Click += new System.EventHandler(this.btn_st_del_Click);
            // 
            // btn_st_add
            // 
            this.btn_st_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_st_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_st_add.Location = new System.Drawing.Point(6, 487);
            this.btn_st_add.Name = "btn_st_add";
            this.btn_st_add.Size = new System.Drawing.Size(151, 31);
            this.btn_st_add.TabIndex = 4;
            this.btn_st_add.Text = "Add";
            this.btn_st_add.UseVisualStyleBackColor = false;
            this.btn_st_add.Click += new System.EventHandler(this.btn_st_add_Click);
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_type.Location = new System.Drawing.Point(214, 152);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(54, 20);
            this.lb_type.TabIndex = 7;
            this.lb_type.Text = "Admin";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(214, 216);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(0, 20);
            this.lb_name.TabIndex = 8;
            // 
            // lb_pos
            // 
            this.lb_pos.AutoSize = true;
            this.lb_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pos.Location = new System.Drawing.Point(214, 291);
            this.lb_pos.Name = "lb_pos";
            this.lb_pos.Size = new System.Drawing.Size(0, 20);
            this.lb_pos.TabIndex = 9;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Location = new System.Drawing.Point(184, 487);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 31);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // frm_admin_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lb_pos);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frm_admin_profile";
            this.Text = "Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_admin_profile_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_st_del;
        private System.Windows.Forms.Button btn_st_add;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_pos;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.Button btn_rfsh;
        private System.Windows.Forms.Button btn_edit;
    }
}