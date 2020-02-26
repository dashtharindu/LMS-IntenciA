namespace LMS_IntenciA
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.lb_wc = new System.Windows.Forms.Label();
            this.lb_un = new System.Windows.Forms.Label();
            this.lb_pw = new System.Windows.Forms.Label();
            this.txt_un = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_wc
            // 
            this.lb_wc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_wc.AutoSize = true;
            this.lb_wc.BackColor = System.Drawing.Color.Transparent;
            this.lb_wc.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_wc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_wc.Location = new System.Drawing.Point(383, 33);
            this.lb_wc.Name = "lb_wc";
            this.lb_wc.Size = new System.Drawing.Size(316, 74);
            this.lb_wc.TabIndex = 0;
            this.lb_wc.Text = "Welcome";
            this.lb_wc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_un
            // 
            this.lb_un.AutoSize = true;
            this.lb_un.BackColor = System.Drawing.Color.Transparent;
            this.lb_un.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_un.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_un.Location = new System.Drawing.Point(214, 198);
            this.lb_un.Name = "lb_un";
            this.lb_un.Size = new System.Drawing.Size(124, 29);
            this.lb_un.TabIndex = 0;
            this.lb_un.Text = "Username :";
            // 
            // lb_pw
            // 
            this.lb_pw.AutoSize = true;
            this.lb_pw.BackColor = System.Drawing.Color.Transparent;
            this.lb_pw.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_pw.Location = new System.Drawing.Point(214, 270);
            this.lb_pw.Name = "lb_pw";
            this.lb_pw.Size = new System.Drawing.Size(116, 29);
            this.lb_pw.TabIndex = 0;
            this.lb_pw.Text = "Password :";
            // 
            // txt_un
            // 
            this.txt_un.Location = new System.Drawing.Point(393, 195);
            this.txt_un.Name = "txt_un";
            this.txt_un.Size = new System.Drawing.Size(389, 36);
            this.txt_un.TabIndex = 1;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(393, 262);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(389, 36);
            this.txt_pw.TabIndex = 2;
            this.txt_pw.TextChanged += new System.EventHandler(this.txt_pw_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_2);
            this.groupBox1.Controls.Add(this.lb_1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(1, 604);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 123);
            this.groupBox1.TabIndex = 7;
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
            this.lb_2.Size = new System.Drawing.Size(355, 30);
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
            this.lb_1.Size = new System.Drawing.Size(164, 31);
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
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sub.Location = new System.Drawing.Point(393, 341);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(106, 31);
            this.btn_sub.TabIndex = 3;
            this.btn_sub.Text = "Submit";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clr.Location = new System.Drawing.Point(548, 341);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(106, 31);
            this.btn_clr.TabIndex = 4;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = false;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::LMS_IntenciA.Properties.Resources._022062_3d_transparent_glass_icon_culture_book2;
            this.pictureBox2.Location = new System.Drawing.Point(12, 297);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 301);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(443, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Public Library !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1002, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_un);
            this.Controls.Add(this.lb_pw);
            this.Controls.Add(this.lb_un);
            this.Controls.Add(this.lb_wc);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frm_login";
            this.Text = "Library Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_login_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_wc;
        private System.Windows.Forms.Label lb_un;
        private System.Windows.Forms.Label lb_pw;
        private System.Windows.Forms.TextBox txt_un;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}