namespace LMS_IntenciA
{
    partial class FineHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FineHistory));
            this.btn_CRate = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.dgv_FineHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FineHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CRate
            // 
            this.btn_CRate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CRate.Location = new System.Drawing.Point(12, 428);
            this.btn_CRate.Name = "btn_CRate";
            this.btn_CRate.Size = new System.Drawing.Size(101, 27);
            this.btn_CRate.TabIndex = 0;
            this.btn_CRate.Text = "Change fine rates";
            this.btn_CRate.UseVisualStyleBackColor = false;
            this.btn_CRate.Click += new System.EventHandler(this.btn_CRate_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_OK.Location = new System.Drawing.Point(274, 428);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(101, 27);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // dgv_FineHistory
            // 
            this.dgv_FineHistory.AllowUserToAddRows = false;
            this.dgv_FineHistory.AllowUserToDeleteRows = false;
            this.dgv_FineHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_FineHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_FineHistory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_FineHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FineHistory.GridColor = System.Drawing.SystemColors.Menu;
            this.dgv_FineHistory.Location = new System.Drawing.Point(12, 12);
            this.dgv_FineHistory.Name = "dgv_FineHistory";
            this.dgv_FineHistory.ReadOnly = true;
            this.dgv_FineHistory.RowHeadersVisible = false;
            this.dgv_FineHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FineHistory.Size = new System.Drawing.Size(363, 410);
            this.dgv_FineHistory.TabIndex = 10;
            // 
            // FineHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(387, 457);
            this.Controls.Add(this.dgv_FineHistory);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_CRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(403, 496);
            this.Name = "FineHistory";
            this.Text = "Fine Report";
            this.Load += new System.EventHandler(this.FineHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FineHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CRate;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridView dgv_FineHistory;
    }
}