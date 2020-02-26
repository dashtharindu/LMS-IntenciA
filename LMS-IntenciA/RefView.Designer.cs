namespace LMS_IntenciA
{
    partial class RefView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefView));
            this.dgv_RefDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_isbn = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RefDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_RefDetails
            // 
            this.dgv_RefDetails.AllowUserToAddRows = false;
            this.dgv_RefDetails.AllowUserToDeleteRows = false;
            this.dgv_RefDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_RefDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_RefDetails.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_RefDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RefDetails.GridColor = System.Drawing.SystemColors.Menu;
            this.dgv_RefDetails.Location = new System.Drawing.Point(12, 12);
            this.dgv_RefDetails.Name = "dgv_RefDetails";
            this.dgv_RefDetails.ReadOnly = true;
            this.dgv_RefDetails.RowHeadersVisible = false;
            this.dgv_RefDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_RefDetails.Size = new System.Drawing.Size(380, 154);
            this.dgv_RefDetails.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "ISBN :";
            // 
            // lb_isbn
            // 
            this.lb_isbn.AutoSize = true;
            this.lb_isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_isbn.Location = new System.Drawing.Point(59, 192);
            this.lb_isbn.Name = "lb_isbn";
            this.lb_isbn.Size = new System.Drawing.Size(12, 16);
            this.lb_isbn.TabIndex = 13;
            this.lb_isbn.Text = "-";
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_OK.Location = new System.Drawing.Point(291, 190);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(101, 27);
            this.btn_OK.TabIndex = 14;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // RefView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(404, 229);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lb_isbn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_RefDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(430, 268);
            this.Name = "RefView";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.RefView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RefDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_RefDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_isbn;
        private System.Windows.Forms.Button btn_OK;
    }
}