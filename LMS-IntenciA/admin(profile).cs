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
    public partial class frm_admin_profile : Form
    {
        public frm_admin_profile()
        {
            InitializeComponent();
        }
        string nic_grid = "";

        private void frm_admin_profile_Load(object sender, EventArgs e)
        {
            DataTable dt_staff = new DataTable();
            String s_sql = "SELECT usr_nic as NIC , usr_name as Name , usr_pos as Position FROM login";
            MySqlCommand s_cmd = new MySqlCommand(s_sql, conman.connection());
            using (MySqlDataAdapter da_staff = new MySqlDataAdapter(s_cmd))
            {
                da_staff.Fill(dt_staff);
                dgv_staff.DataSource = dt_staff;
            }

            DataTable dt_admin = new DataTable();
            String a_sql = "SELECT * FROM login WHERE usr_pos='admin'";
            MySqlCommand a_cmd = new MySqlCommand(a_sql, conman.connection());
            using (MySqlDataAdapter da_admin = new MySqlDataAdapter(a_cmd))
            {
                da_admin.Fill(dt_admin);
            }
            foreach (DataRow row in dt_admin.Rows)
            {
                lb_name.Text = row["usr_name"].ToString();
                lb_pos.Text = "Librarian";
            }

        }

        private void btn_st_add_Click(object sender, EventArgs e)
        {
            staff_reg staff_reg = new staff_reg();
            staff_reg.ShowDialog();
        }

        private void btn_st_del_Click(object sender, EventArgs e)
        {
            if(nic_grid != "")
            {
                DialogResult dialog = MessageBox.Show("Do you sure want to delete staff member NIC No:" + nic_grid + "?", "Confirm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        String sql_del = "DELETE from `login` WHERE usr_nic='" + nic_grid + "'";
                        MySqlCommand cmd_del = new MySqlCommand(sql_del, conman.connection());
                        cmd_del.ExecuteNonQuery();

                        MessageBox.Show("Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DataTable dt_staff = new DataTable();
                        String s_sql = "SELECT usr_nic as NIC , usr_name as Name , usr_pos as Position FROM login";
                        MySqlCommand s_cmd = new MySqlCommand(s_sql, conman.connection());
                        using (MySqlDataAdapter da_staff = new MySqlDataAdapter(s_cmd))
                        {
                            da_staff.Fill(dt_staff);
                            dgv_staff.DataSource = dt_staff;
                        }
                    }
                    catch(Exception ex_del)
                    {
                        MessageBox.Show("Error occured while deleting data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select NIC number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_staff.Rows[e.RowIndex];

                nic_grid = row.Cells["NIC"].Value.ToString();
            }
        }

        private void btn_rfsh_Click(object sender, EventArgs e)
        {
            DataTable dt_staff = new DataTable();
            String s_sql = "SELECT usr_nic as NIC , usr_name as Name , usr_pos as Position FROM login";
            MySqlCommand s_cmd = new MySqlCommand(s_sql, conman.connection());
            using (MySqlDataAdapter da_staff = new MySqlDataAdapter(s_cmd))
            {
                da_staff.Fill(dt_staff);
                dgv_staff.DataSource = dt_staff;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (nic_grid != "")
            {
                staff_edit staff_edit = new staff_edit(nic_grid);
                staff_edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select NIC number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
