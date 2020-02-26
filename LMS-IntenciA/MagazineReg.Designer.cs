namespace LMS_IntenciA
{
    partial class frm_MagazineReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MagazineReg));
            this.btn_clr = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_mRemarks = new System.Windows.Forms.TextBox();
            this.txt_mCategory = new System.Windows.Forms.TextBox();
            this.txt_mPur_date = new System.Windows.Forms.TextBox();
            this.txt_mDate = new System.Windows.Forms.TextBox();
            this.txt_mName = new System.Windows.Forms.TextBox();
            this.txt_mIndex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_clr
            // 
            this.btn_clr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clr.Location = new System.Drawing.Point(534, 620);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(153, 42);
            this.btn_clr.TabIndex = 39;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = false;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(326, 620);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(158, 42);
            this.btn_submit.TabIndex = 38;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_mRemarks
            // 
            this.txt_mRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mRemarks.Location = new System.Drawing.Point(500, 468);
            this.txt_mRemarks.MaxLength = 100;
            this.txt_mRemarks.Multiline = true;
            this.txt_mRemarks.Name = "txt_mRemarks";
            this.txt_mRemarks.Size = new System.Drawing.Size(151, 53);
            this.txt_mRemarks.TabIndex = 37;
            // 
            // txt_mCategory
            // 
            this.txt_mCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mCategory.Location = new System.Drawing.Point(500, 387);
            this.txt_mCategory.MaxLength = 15;
            this.txt_mCategory.Name = "txt_mCategory";
            this.txt_mCategory.Size = new System.Drawing.Size(151, 26);
            this.txt_mCategory.TabIndex = 36;
            // 
            // txt_mPur_date
            // 
            this.txt_mPur_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mPur_date.Location = new System.Drawing.Point(500, 304);
            this.txt_mPur_date.MaxLength = 10;
            this.txt_mPur_date.Name = "txt_mPur_date";
            this.txt_mPur_date.Size = new System.Drawing.Size(151, 26);
            this.txt_mPur_date.TabIndex = 35;
            // 
            // txt_mDate
            // 
            this.txt_mDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mDate.Location = new System.Drawing.Point(500, 219);
            this.txt_mDate.MaxLength = 10;
            this.txt_mDate.Name = "txt_mDate";
            this.txt_mDate.Size = new System.Drawing.Size(151, 26);
            this.txt_mDate.TabIndex = 34;
            // 
            // txt_mName
            // 
            this.txt_mName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mName.Location = new System.Drawing.Point(500, 144);
            this.txt_mName.MaxLength = 20;
            this.txt_mName.Name = "txt_mName";
            this.txt_mName.Size = new System.Drawing.Size(151, 26);
            this.txt_mName.TabIndex = 33;
            // 
            // txt_mIndex
            // 
            this.txt_mIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mIndex.Location = new System.Drawing.Point(500, 67);
            this.txt_mIndex.MaxLength = 7;
            this.txt_mIndex.Name = "txt_mIndex";
            this.txt_mIndex.Size = new System.Drawing.Size(151, 26);
            this.txt_mIndex.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Remarks :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Category :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Date of purchase :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Date of magazine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Index No :";
            // 
            // frm_MagazineReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_mRemarks);
            this.Controls.Add(this.txt_mCategory);
            this.Controls.Add(this.txt_mPur_date);
            this.Controls.Add(this.txt_mDate);
            this.Controls.Add(this.txt_mName);
            this.Controls.Add(this.txt_mIndex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frm_MagazineReg";
            this.Text = "Add New Magazine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_mRemarks;
        private System.Windows.Forms.TextBox txt_mCategory;
        private System.Windows.Forms.TextBox txt_mPur_date;
        private System.Windows.Forms.TextBox txt_mDate;
        private System.Windows.Forms.TextBox txt_mName;
        private System.Windows.Forms.TextBox txt_mIndex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}