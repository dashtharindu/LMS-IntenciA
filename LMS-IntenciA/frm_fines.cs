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
    public partial class frm_fines : Form
    {
        DataSet ds_fines;
        MySqlDataAdapter da_fines;
        MySqlCommandBuilder cmdb_fines;

        public frm_fines()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                cmdb_fines = new MySqlCommandBuilder(da_fines);
                da_fines.Update(ds_fines, "fines_details");
                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_fines_Load(object sender, EventArgs e)
        {
             ds_fines = new System.Data.DataSet();
             String sql_fines = "SELECT * FROM fines ";
             MySqlCommand cmd_fines = new MySqlCommand(sql_fines, conman.connection());
             da_fines = new MySqlDataAdapter(cmd_fines);
             da_fines.Fill(ds_fines, "fines_details");
             dgv_fines.DataSource = ds_fines.Tables[0];
        }
    }
}
