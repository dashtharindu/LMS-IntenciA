namespace LMS_IntenciA
{
    partial class frm_NewspaperReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NewspaperReg));
            this.btn_clr = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_nRemarks = new System.Windows.Forms.TextBox();
            this.txt_nCategory = new System.Windows.Forms.TextBox();
            this.txt_nPur_date = new System.Windows.Forms.TextBox();
            this.txt_nDate = new System.Windows.Forms.TextBox();
            this.txt_nName = new System.Windows.Forms.TextBox();
            this.txt_nIndex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_clr
            // 
            this.btn_clr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clr.Location = new System.Drawing.Point(532, 620);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(153, 42);
            this.btn_clr.TabIndex = 41;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = false;
            this.btn_clr.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(324, 620);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 42);
            this.button2.TabIndex = 40;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_nRemarks
            // 
            this.txt_nRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nRemarks.Location = new System.Drawing.Point(517, 468);
            this.txt_nRemarks.MaxLength = 100;
            this.txt_nRemarks.Multiline = true;
            this.txt_nRemarks.Name = "txt_nRemarks";
            this.txt_nRemarks.Size = new System.Drawing.Size(151, 53);
            this.txt_nRemarks.TabIndex = 39;
            // 
            // txt_nCategory
            // 
            this.txt_nCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nCategory.Location = new System.Drawing.Point(517, 387);
            this.txt_nCategory.MaxLength = 10;
            this.txt_nCategory.Name = "txt_nCategory";
            this.txt_nCategory.Size = new System.Drawing.Size(151, 26);
            this.txt_nCategory.TabIndex = 38;
            // 
            // txt_nPur_date
            // 
            this.txt_nPur_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nPur_date.Location = new System.Drawing.Point(517, 304);
            this.txt_nPur_date.MaxLength = 10;
            this.txt_nPur_date.Name = "txt_nPur_date";
            this.txt_nPur_date.Size = new System.Drawing.Size(151, 26);
            this.txt_nPur_date.TabIndex = 37;
            // 
            // txt_nDate
            // 
            this.txt_nDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nDate.Location = new System.Drawing.Point(517, 219);
            this.txt_nDate.MaxLength = 10;
            this.txt_nDate.Name = "txt_nDate";
            this.txt_nDate.Size = new System.Drawing.Size(151, 26);
            this.txt_nDate.TabIndex = 36;
            // 
            // txt_nName
            // 
            this.txt_nName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nName.Location = new System.Drawing.Point(517, 144);
            this.txt_nName.MaxLength = 20;
            this.txt_nName.Name = "txt_nName";
            this.txt_nName.Size = new System.Drawing.Size(151, 26);
            this.txt_nName.TabIndex = 35;
            // 
            // txt_nIndex
            // 
            this.txt_nIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nIndex.Location = new System.Drawing.Point(517, 67);
            this.txt_nIndex.MaxLength = 8;
            this.txt_nIndex.Name = "txt_nIndex";
            this.txt_nIndex.Size = new System.Drawing.Size(151, 26);
            this.txt_nIndex.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Remarks :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Category :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Purchase date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Date of newspaper :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(338, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Name :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(338, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Index No :";
            // 
            // frm_NewspaperReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_nRemarks);
            this.Controls.Add(this.txt_nCategory);
            this.Controls.Add(this.txt_nPur_date);
            this.Controls.Add(this.txt_nDate);
            this.Controls.Add(this.txt_nName);
            this.Controls.Add(this.txt_nIndex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frm_NewspaperReg";
            this.Text = "Add New Newspaper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_nRemarks;
        private System.Windows.Forms.TextBox txt_nCategory;
        private System.Windows.Forms.TextBox txt_nPur_date;
        private System.Windows.Forms.TextBox txt_nDate;
        private System.Windows.Forms.TextBox txt_nName;
        private System.Windows.Forms.TextBox txt_nIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}