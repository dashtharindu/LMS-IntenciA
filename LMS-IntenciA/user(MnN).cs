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
    public partial class frm_MnN : Form
    {
        public frm_MnN()
        {
            InitializeComponent();
        }
        string magazine_grid = "";
        string newspaper_grid = "";

        private void frm_MnN_Load(object sender, EventArgs e)
        {
            DataTable dt_M = new DataTable();
            String ma_sql = "SELECT mIndex as Index_No , name as Magazine_Name , date as Date , pur_date as Purchase_Date , category as Category , remarks as Remarks FROM mgazines";
            MySqlCommand ma_cmd = new MySqlCommand(ma_sql, conman.connection());
            using (MySqlDataAdapter da_M = new MySqlDataAdapter(ma_cmd))
            {
                da_M.Fill(dt_M);
                dgv_magazines.DataSource = dt_M;
            }

            DataTable dt_N = new DataTable();
            String n_sql = "SELECT nIndex as Index_No , name as Newspaper_Name , date as Date , pur_date as Purchase_Date , category as Category , remarks as Remarks FROM newspapers";
            MySqlCommand n_cmd = new MySqlCommand(n_sql, conman.connection());
            using (MySqlDataAdapter da_N = new MySqlDataAdapter(n_cmd))
            {
                da_N.Fill(dt_N);
                dgv_newspapers.DataSource = dt_N;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.ShowDialog();
        }

        private void frm_MnN_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_mSearch_Click(object sender, EventArgs e)
        {
            string mSearch_txt = txt_mSearch.Text;
            string mSearch_by = cmb_mSearch.Text;

            if (mSearch_by == "Index_No")
            {
                mSearch_by = "mIndex";
            }
            else if (mSearch_by == "Name")
            {
                mSearch_by = "name";
            }
            else if (mSearch_by == "Date")
            {
                mSearch_by = "date";
            }
            else if (mSearch_by == "Category")
            {
                mSearch_by = "category";
            }

            try
            {
                DataTable dt_M = new DataTable();
                String ma_sql = "SELECT mIndex as Index_No , name as Magazine_Name , date as Date , pur_date as Purchase_Date , category as Category , remarks as Remarks FROM mgazines WHERE " + mSearch_by + " LIKE '%" + mSearch_txt + "%'";
                MySqlCommand ma_cmd = new MySqlCommand(ma_sql, conman.connection());
                using (MySqlDataAdapter da_M = new MySqlDataAdapter(ma_cmd))
                {
                    da_M.Fill(dt_M);
                    dgv_magazines.DataSource = dt_M;
                }

                int mnnSearch_rows = dt_M.Rows.Count;
                lb_mSearch.Text = mnnSearch_rows.ToString();
                lb_m.Text = "Magazine(s) match search";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Search! \n \n1)Please check you are selected correct \"search by\" text \n2)Please Enter correct \"search\" text", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_nSearch_Click(object sender, EventArgs e)
        {
            string nSearch_txt = txt_nSearch.Text;
            string nSearch_by = cmb_nSearch.Text;

            if (nSearch_by == "Index_No")
            {
                nSearch_by = "nIndex";
            }
            else if (nSearch_by == "Name")
            {
                nSearch_by = "name";
            }
            else if (nSearch_by == "Date")
            {
                nSearch_by = "date";
            }
            else if (nSearch_by == "Category")
            {
                nSearch_by = "category";
            }

            try
            {
                DataTable dt_N = new DataTable();
                String n_sql = "SELECT nIndex as Index_No , name as Newspaper_Name , date as Date , pur_date as Purchase_Date , category as Category , remarks as Remarks FROM newspapers WHERE " + nSearch_by + " LIKE '%" + nSearch_txt + "%'";
                MySqlCommand n_cmd = new MySqlCommand(n_sql, conman.connection());
                using (MySqlDataAdapter da_N = new MySqlDataAdapter(n_cmd))
                {
                    da_N.Fill(dt_N);
                    dgv_newspapers.DataSource = dt_N;
                }

                int mnnSearch_rows = dt_N.Rows.Count;
                lb_nSearch.Text = mnnSearch_rows.ToString();
                lb_n.Text = "Newspaper(s) match search";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Search! \n \n1)Please check you are selected correct \"search by\" text \n2)Please Enter correct \"search\" text", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_MagazineReg reg_M = new frm_MagazineReg();
            reg_M.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frm_NewspaperReg reg_N = new frm_NewspaperReg();
            reg_N.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt_N = new DataTable();
            String n_sql = "SELECT nIndex as Index_No , name as Newspaper_Name , date as Date , pur_date as Purchase_Date , category as Category , remarks as Remarks FROM newspapers";
            MySqlCommand n_cmd = new MySqlCommand(n_sql, conman.connection());
            using (MySqlDataAdapter da_N = new MySqlDataAdapter(n_cmd))
            {
                da_N.Fill(dt_N);
                dgv_newspapers.DataSource = dt_N;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt_M = new DataTable();
            String ma_sql = "SELECT mIndex as Index_No , name as Magazine_Name , date as Date , pur_date as Purchase_Date , category as Category , remarks as Remarks FROM mgazines";
            MySqlCommand ma_cmd = new MySqlCommand(ma_sql, conman.connection());
            using (MySqlDataAdapter da_M = new MySqlDataAdapter(ma_cmd))
            {
                da_M.Fill(dt_M);
                dgv_magazines.DataSource = dt_M;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (magazine_grid != "")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Delete Magazine IndexNo:" + magazine_grid + "?", "Confirm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    String sql_del = "DELETE from `mgazines` WHERE mIndex='" + magazine_grid + "'";
                    MySqlCommand cmd_del = new MySqlCommand(sql_del, conman.connection());
                    cmd_del.ExecuteNonQuery();

                    MessageBox.Show("Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataTable dt_M = new DataTable();
                    String ma_sql = "SELECT mIndex as Index_No , name as Magazine_Name , date as Date , pur_date as Purchase_Date , category as Category , remarks as Remarks FROM mgazines";
                    MySqlCommand ma_cmd = new MySqlCommand(ma_sql, conman.connection());
                    using (MySqlDataAdapter da_M = new MySqlDataAdapter(ma_cmd))
                    {
                        da_M.Fill(dt_M);
                        dgv_magazines.DataSource = dt_M;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select Magazine Index number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_magazines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_magazines.Rows[e.RowIndex];

                magazine_grid = row.Cells["Index_No"].Value.ToString();
            }
        }

        private void dgv_newspapers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_newspapers.Rows[e.RowIndex];
                newspaper_grid = row.Cells["Index_No"].Value.ToString();
            }
        }

        private void btn_newsDel_Click(object sender, EventArgs e)
        {
            if (newspaper_grid != "")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Delete Newspaper IndexNo:" + newspaper_grid + "?", "Confirm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    String sql_del = "DELETE from `newspapers` WHERE nIndex='" + newspaper_grid + "'";
                    MySqlCommand cmd_del = new MySqlCommand(sql_del, conman.connection());
                    cmd_del.ExecuteNonQuery();

                    MessageBox.Show("Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataTable dt_N = new DataTable();
                    String n_sql = "SELECT nIndex as Index_No , name as Newspaper_Name , date as Date , pur_date as Purchase_Date , category as Category , remarks as Remarks FROM newspapers";
                    MySqlCommand n_cmd = new MySqlCommand(n_sql, conman.connection());
                    using (MySqlDataAdapter da_N = new MySqlDataAdapter(n_cmd))
                    {
                        da_N.Fill(dt_N);
                        dgv_newspapers.DataSource = dt_N;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select Newspaper Index number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_about about = new frm_about();
            about.ShowDialog();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_contact contact = new frm_contact();
            contact.ShowDialog();
        }
    }
}
