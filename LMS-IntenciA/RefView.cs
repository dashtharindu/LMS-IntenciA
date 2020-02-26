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
    public partial class RefView : Form
    {
        public RefView(string PassRefIsbn)
        {
            InitializeComponent();
            lb_isbn.Text = PassRefIsbn;
        }

        private void RefView_Load(object sender, EventArgs e)
        {
            string isbn = lb_isbn.Text;
            DataTable Len = new DataTable();
            String l_sql = "SELECT branchNo as Branch_No , AcquisitionNo as Acquisition_No FROM reference WHERE isbn='" + isbn + "'";
            MySqlCommand l_cmd = new MySqlCommand(l_sql, conman.connection());
            using (MySqlDataAdapter da_l = new MySqlDataAdapter(l_cmd))
            {
                da_l.Fill(Len);
                dgv_RefDetails.DataSource = Len;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
