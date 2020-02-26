namespace LMS_IntenciA
{
    partial class LenView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LenView));
            this.lb_isbn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_LenDetails = new System.Windows.Forms.DataGridView();
            this.btn_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LenDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_isbn
            // 
            this.lb_isbn.AutoSize = true;
            this.lb_isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_isbn.Location = new System.Drawing.Point(59, 190);
            this.lb_isbn.Name = "lb_isbn";
            this.lb_isbn.Size = new System.Drawing.Size(12, 16);
            this.lb_isbn.TabIndex = 15;
            this.lb_isbn.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "ISBN :";
            // 
            // dgv_LenDetails
            // 
            this.dgv_LenDetails.AllowUserToAddRows = false;
            this.dgv_LenDetails.AllowUserToDeleteRows = false;
            this.dgv_LenDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LenDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LenDetails.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_LenDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LenDetails.GridColor = System.Drawing.SystemColors.Menu;
            this.dgv_LenDetails.Location = new System.Drawing.Point(12, 12);
            this.dgv_LenDetails.Name = "dgv_LenDetails";
            this.dgv_LenDetails.ReadOnly = true;
            this.dgv_LenDetails.RowHeadersVisible = false;
            this.dgv_LenDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LenDetails.Size = new System.Drawing.Size(380, 154);
            this.dgv_LenDetails.TabIndex = 16;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_OK.Location = new System.Drawing.Point(291, 190);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(101, 27);
            this.btn_OK.TabIndex = 17;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // LenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(404, 229);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dgv_LenDetails);
            this.Controls.Add(this.lb_isbn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(420, 268);
            this.Name = "LenView";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.LenView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LenDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_isbn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_LenDetails;
        private System.Windows.Forms.Button btn_OK;
    }
}