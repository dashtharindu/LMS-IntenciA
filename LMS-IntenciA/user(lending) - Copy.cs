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
    public partial class frm_lending : Form
    {
        public frm_lending()
        {
            InitializeComponent();
        }

        //SearchBox search = new SearchBox();
        string isbn_grid;
        string mem_grid;
        string magazine_grid;
        string newspaper_grid;

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.ShowDialog();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_admin_profile ad_prof = new frm_admin_profile();
            ad_prof.ShowDialog();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            DataTable dt_books = new DataTable();
            String b_sql = "SELECT isbn as ISBN , name as Name , author_name as Author , price as Price FROM books";
            MySqlCommand b_cmd = new MySqlCommand(b_sql, conman.connection());
            using (MySqlDataAdapter da_books = new MySqlDataAdapter(b_cmd))
            {
                da_books.Fill(dt_books);
                dgv_books.DataSource = dt_books;
            }
        }

        private void frm_admin_Load(object sender, EventArgs e)
        {
            DataTable dt_books = new DataTable();
            String b_sql = "SELECT isbn as ISBN , name as Name , author_name as Author , price as Price FROM books";
            MySqlCommand b_cmd = new MySqlCommand(b_sql, conman.connection());
            using (MySqlDataAdapter da_books = new MySqlDataAdapter(b_cmd))
            {
                da_books.Fill(dt_books);
                dgv_books.DataSource = dt_books;
            }

            DataTable dt_members = new DataTable();
            String m_sql = "SELECT membershipNo as Membership_No , fName as Name , phoneNo as Phone_No FROM members";
            MySqlCommand m_cmd = new MySqlCommand(m_sql, conman.connection());
            using (MySqlDataAdapter da_members = new MySqlDataAdapter(m_cmd))
            {
                da_members.Fill(dt_members);
                dgv_members.DataSource = dt_members;
            }

            DataTable dt_M = new DataTable();
            String ma_sql = "SELECT mIndex as Index_No , name as Magazine_Name , date as Date FROM mgazines";
            MySqlCommand ma_cmd = new MySqlCommand(ma_sql, conman.connection());
            using (MySqlDataAdapter da_M = new MySqlDataAdapter(ma_cmd))
            {
                da_M.Fill(dt_M);
                dgv_magazine.DataSource = dt_M;
            }

            DataTable dt_N = new DataTable();
            String n_sql = "SELECT nIndex as Index_No , name as Newspaper_Name , date as Date FROM newspapers";
            MySqlCommand n_cmd = new MySqlCommand(n_sql, conman.connection());
            using (MySqlDataAdapter da_N = new MySqlDataAdapter(n_cmd))
            {
                da_N.Fill(dt_N);
                dgv_newspapers.DataSource = dt_N;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Delete ISBN:"+ isbn_grid + "?", "Confirm", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                String sql_del = "DELETE from `books` WHERE isbn='" + isbn_grid + "'";
                MySqlCommand cmd_del = new MySqlCommand(sql_del, conman.connection());
                cmd_del.ExecuteNonQuery();
            }
            
        }

        private void dgv_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_books.Rows[e.RowIndex];

                isbn_grid = row.Cells["ISBN"].Value.ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_book_reg book_reg = new frm_book_reg();
            book_reg.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_member_reg member_reg = new frm_member_reg();
            member_reg.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frm_reg_MnN reg_MnN = new frm_reg_MnN();
            reg_MnN.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            frm_book_edit book_edit = new frm_book_edit(isbn_grid);
            book_edit.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_member_edit mem_edit = new frm_member_edit();
            mem_edit.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt_members = new DataTable();
            String m_sql = "SELECT membershipNo as Membership_No , fName as Name , phoneNo as Phone_No FROM members";
            MySqlCommand m_cmd = new MySqlCommand(m_sql, conman.connection());
            using (MySqlDataAdapter da_members = new MySqlDataAdapter(m_cmd))
            {
                da_members.Fill(dt_members);
                dgv_members.DataSource = dt_members;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt_M = new DataTable();
            String ma_sql = "SELECT mIndex as Index_No , name as Magazine_Name , date as Date FROM mgazines";
            MySqlCommand ma_cmd = new MySqlCommand(ma_sql, conman.connection());
            using (MySqlDataAdapter da_M = new MySqlDataAdapter(ma_cmd))
            {
                da_M.Fill(dt_M);
                dgv_magazine.DataSource = dt_M;
            }

            DataTable dt_N = new DataTable();
            String n_sql = "SELECT nIndex as Index_No , name as Newspaper_Name , date as Date FROM newspapers";
            MySqlCommand n_cmd = new MySqlCommand(n_sql, conman.connection());
            using (MySqlDataAdapter da_N = new MySqlDataAdapter(n_cmd))
            {
                da_N.Fill(dt_N);
                dgv_newspapers.DataSource = dt_N;
            }
        }

        private void dgv_members_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_members.Rows[e.RowIndex];

                mem_grid = row.Cells["Membership_No"].Value.ToString();
            }
        }

        private void btn_mDel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Delete Membership No:" + mem_grid + "?", "Confirm", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                String sql_del = "DELETE from `members` WHERE membershipNo='" + mem_grid + "'";
                MySqlCommand cmd_del = new MySqlCommand(sql_del, conman.connection());
                cmd_del.ExecuteNonQuery();
            }
        }

        private void dgv_magazine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_magazine.Rows[e.RowIndex];

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
            DialogResult dialog = MessageBox.Show("Do you really want to Delete Newspaper IndexNo:" + newspaper_grid + "?", "Confirm", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                String sql_del = "DELETE from `newspapers`, WHERE nIndex='" + newspaper_grid + "'";
                MySqlCommand cmd_del = new MySqlCommand(sql_del, conman.connection());
                cmd_del.ExecuteNonQuery();
            }
        }

        private void btn_magDel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Delete Magazine IndexNo:" + magazine_grid + "?", "Confirm", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                String sql_del = "DELETE from `mgazines` WHERE mIndex='" + magazine_grid + "'";
                MySqlCommand cmd_del = new MySqlCommand(sql_del, conman.connection());
                cmd_del.ExecuteNonQuery();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //lmsDataSet search = search.book_search(txt_search.Text);
           // dgv_books.DataSource = search.Tables["books"];
        }

        private void frm_admin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_about about = new frm_about();
            about.ShowDialog();
        }


    }
}
