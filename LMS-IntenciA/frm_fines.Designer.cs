namespace LMS_IntenciA
{
    partial class frm_fines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_fines));
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_fines = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fines)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(252, 416);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(93, 29);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgv_fines
            // 
            this.dgv_fines.AllowUserToAddRows = false;
            this.dgv_fines.AllowUserToDeleteRows = false;
            this.dgv_fines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_fines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fines.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_fines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fines.GridColor = System.Drawing.SystemColors.Menu;
            this.dgv_fines.Location = new System.Drawing.Point(36, 60);
            this.dgv_fines.Name = "dgv_fines";
            this.dgv_fines.RowHeadersVisible = false;
            this.dgv_fines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fines.Size = new System.Drawing.Size(309, 350);
            this.dgv_fines.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fine Rate";
            // 
            // frm_fines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(387, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_fines);
            this.Controls.Add(this.btn_update);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_fines";
            this.Text = "Change fine rates";
            this.Load += new System.EventHandler(this.frm_fines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgv_fines;
        private System.Windows.Forms.Label label1;
    }
}