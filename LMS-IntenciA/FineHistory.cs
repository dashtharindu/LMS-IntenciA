using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace LMS_IntenciA
{
    public partial class FineHistory : Form
    {
        public FineHistory()
        {
            InitializeComponent();
        }

        private void FineHistory_Load(object sender, EventArgs e)
        {
            DataTable FineHistory = new DataTable();
            String b_sql = "SELECT No as Record_No , Date , Fine , branchNo as Branch_No FROM fine_history";
            MySqlCommand b_cmd = new MySqlCommand(b_sql, conman.connection());
            using (MySqlDataAdapter da_FH = new MySqlDataAdapter(b_cmd))
            {
                da_FH.Fill(FineHistory);
                dgv_FineHistory.DataSource = FineHistory;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CRate_Click(object sender, EventArgs e)
        {
            frm_fines fines = new frm_fines();
            fines.ShowDialog();
        }
    }
}
