namespace LMS_IntenciA
{
    partial class staff_edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staff_edit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sNic = new System.Windows.Forms.TextBox();
            this.txt_sFName = new System.Windows.Forms.TextBox();
            this.txt_usrName = new System.Windows.Forms.TextBox();
            this.txt_sPass = new System.Windows.Forms.TextBox();
            this.txt_sCPass = new System.Windows.Forms.TextBox();
            this.cmb_sPos = new System.Windows.Forms.ComboBox();
            this.btn_clr = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_pw = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIC No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type new Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 626);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Re-Type Password :";
            // 
            // txt_sNic
            // 
            this.txt_sNic.Location = new System.Drawing.Point(418, 98);
            this.txt_sNic.MaxLength = 10;
            this.txt_sNic.Name = "txt_sNic";
            this.txt_sNic.Size = new System.Drawing.Size(228, 26);
            this.txt_sNic.TabIndex = 1;
            // 
            // txt_sFName
            // 
            this.txt_sFName.Location = new System.Drawing.Point(418, 173);
            this.txt_sFName.MaxLength = 75;
            this.txt_sFName.Name = "txt_sFName";
            this.txt_sFName.Size = new System.Drawing.Size(228, 26);
            this.txt_sFName.TabIndex = 2;
            // 
            // txt_usrName
            // 
            this.txt_usrName.Location = new System.Drawing.Point(418, 327);
            this.txt_usrName.MaxLength = 50;
            this.txt_usrName.Name = "txt_usrName";
            this.txt_usrName.Size = new System.Drawing.Size(228, 26);
            this.txt_usrName.TabIndex = 4;
            // 
            // txt_sPass
            // 
            this.txt_sPass.Location = new System.Drawing.Point(352, 573);
            this.txt_sPass.MaxLength = 50;
            this.txt_sPass.Name = "txt_sPass";
            this.txt_sPass.Size = new System.Drawing.Size(228, 26);
            this.txt_sPass.TabIndex = 7;
            this.txt_sPass.TextChanged += new System.EventHandler(this.txt_sPass_TextChanged);
            // 
            // txt_sCPass
            // 
            this.txt_sCPass.Location = new System.Drawing.Point(352, 623);
            this.txt_sCPass.MaxLength = 50;
            this.txt_sCPass.Name = "txt_sCPass";
            this.txt_sCPass.Size = new System.Drawing.Size(228, 26);
            this.txt_sCPass.TabIndex = 8;
            this.txt_sCPass.TextChanged += new System.EventHandler(this.txt_sCPass_TextChanged);
            // 
            // cmb_sPos
            // 
            this.cmb_sPos.FormattingEnabled = true;
            this.cmb_sPos.Items.AddRange(new object[] {
            "Lending",
            "Reference",
            "Magazines_Newspapers"});
            this.cmb_sPos.Location = new System.Drawing.Point(418, 253);
            this.cmb_sPos.Name = "cmb_sPos";
            this.cmb_sPos.Size = new System.Drawing.Size(228, 28);
            this.cmb_sPos.TabIndex = 3;
            this.cmb_sPos.Text = "Lending";
            // 
            // btn_clr
            // 
            this.btn_clr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clr.Location = new System.Drawing.Point(493, 398);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(153, 42);
            this.btn_clr.TabIndex = 6;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = false;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(271, 398);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(158, 42);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Update";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_pw
            // 
            this.btn_pw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pw.Location = new System.Drawing.Point(629, 600);
            this.btn_pw.Name = "btn_pw";
            this.btn_pw.Size = new System.Drawing.Size(118, 49);
            this.btn_pw.TabIndex = 9;
            this.btn_pw.Text = "Change password";
            this.btn_pw.UseVisualStyleBackColor = false;
            this.btn_pw.Click += new System.EventHandler(this.btn_pw_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(170, 537);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 129);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change user password";
            // 
            // staff_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_pw);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cmb_sPos);
            this.Controls.Add(this.txt_sCPass);
            this.Controls.Add(this.txt_sPass);
            this.Controls.Add(this.txt_usrName);
            this.Controls.Add(this.txt_sFName);
            this.Controls.Add(this.txt_sNic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "staff_edit";
            this.Text = "Login access update";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.staff_edit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sNic;
        private System.Windows.Forms.TextBox txt_sFName;
        private System.Windows.Forms.TextBox txt_usrName;
        private System.Windows.Forms.TextBox txt_sPass;
        private System.Windows.Forms.TextBox txt_sCPass;
        private System.Windows.Forms.ComboBox cmb_sPos;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_pw;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}