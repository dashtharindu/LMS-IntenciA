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
    public partial class frm_admin : Form
    {
        public frm_admin()
        {
            InitializeComponent();
        }

        //SearchBox search = new SearchBox();
        string isbn_grid = "";
        string mem_grid = "";
        string magazine_grid = "";
        string newspaper_grid = "";

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.ShowDialog();
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
            if(isbn_grid != "")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Delete ISBN:"+ isbn_grid + "?", "Confirm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    String sql_del1 = "DELETE from `books` WHERE isbn='" + isbn_grid + "'";
                    MySqlCommand cmd_del1 = new MySqlCommand(sql_del1, conman.connection());
                    cmd_del1.ExecuteNonQuery();

                    String sql_del2 = "DELETE from `lending` WHERE isbn='" + isbn_grid + "'";
                    MySqlCommand cmd_del2 = new MySqlCommand(sql_del2, conman.connection());
                    cmd_del2.ExecuteNonQuery();

                    String sql_del3 = "DELETE from `reference` WHERE isbn='" + isbn_grid + "'";
                    MySqlCommand cmd_del3 = new MySqlCommand(sql_del3, conman.connection());
                    cmd_del3.ExecuteNonQuery();

                    MessageBox.Show("Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataTable dt_books = new DataTable();
                    String b_sql = "SELECT isbn as ISBN , name as Name , author_name as Author , price as Price FROM books";
                    MySqlCommand b_cmd = new MySqlCommand(b_sql, conman.connection());
                    using (MySqlDataAdapter da_books = new MySqlDataAdapter(b_cmd))
                    {
                        da_books.Fill(dt_books);
                        dgv_books.DataSource = dt_books;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select isbn number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (isbn_grid != "")
            {
                frm_book_edit book_edit = new frm_book_edit(isbn_grid);
                book_edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select isbn number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if(mem_grid != "")
            {
                frm_member_edit mem_edit = new frm_member_edit(mem_grid);
                mem_edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select Membership number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if(mem_grid != "")
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Delete Membership No:" + mem_grid + "?", "Confirm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    String sql_del = "DELETE from `members` WHERE membershipNo='" + mem_grid + "'";
                    MySqlCommand cmd_del = new MySqlCommand(sql_del, conman.connection());
                    cmd_del.ExecuteNonQuery();

                    MessageBox.Show("Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataTable dt_members = new DataTable();
                    String m_sql = "SELECT membershipNo as Membership_No , fName as Name , phoneNo as Phone_No FROM members";
                    MySqlCommand m_cmd = new MySqlCommand(m_sql, conman.connection());
                    using (MySqlDataAdapter da_members = new MySqlDataAdapter(m_cmd))
                    {
                        da_members.Fill(dt_members);
                        dgv_members.DataSource = dt_members;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select Membership number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    String n_sql = "SELECT nIndex as Index_No , name as Newspaper_Name , date as Date FROM newspapers";
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

        private void btn_magDel_Click(object sender, EventArgs e)
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
                    String ma_sql = "SELECT mIndex as Index_No , name as Magazine_Name , date as Date FROM mgazines";
                    MySqlCommand ma_cmd = new MySqlCommand(ma_sql, conman.connection());
                    using (MySqlDataAdapter da_M = new MySqlDataAdapter(ma_cmd))
                    {
                        da_M.Fill(dt_M);
                        dgv_magazine.DataSource = dt_M;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select Magazine Index number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string search_txt = txt_search.Text;
            string search_by = cmb_searchBy.Text;

            if(search_by == "Name")
            {
                search_by = "name";
            }
            else if(search_by == "ISBN")
            {
                search_by = "isbn";
            }
            else if (search_by == "Author")
            {
                search_by = "author_name";
            }

            try
            {
                DataTable dt_books = new DataTable();
                String b_sql = "SELECT isbn as ISBN , name as Name , author_name as Author , price as Price FROM books WHERE " + search_by + " LIKE '%" + search_txt + "%'";
                MySqlCommand b_cmd = new MySqlCommand(b_sql, conman.connection());
                using (MySqlDataAdapter da_books = new MySqlDataAdapter(b_cmd))
                {
                    da_books.Fill(dt_books);
                    dgv_books.DataSource = dt_books;
                }
                int search_rows = dt_books.Rows.Count;
                lb_searchCount.Text = search_rows.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Search! \n \n1)Please check you are selected correct \"search by\" text \n2)Please Enter correct \"search\" text", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void lendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_lending lending = new frm_lending();
            lending.ShowDialog();
        }

        private void referenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_reference reference = new frm_reference();
            reference.ShowDialog();
        }

        private void finesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FineHistory fineH = new FineHistory();
            fineH.ShowDialog();
        }

        private void btn_mSearch_Click(object sender, EventArgs e)
        {
            string mSearch_txt = txt_mSearch.Text;
            string mSearch_by = cmb_mSearchBy.Text;

            if (mSearch_by == "Name")
            {
                mSearch_by = "fName";
            }
            else if (mSearch_by == "Membership_No")
            {
                mSearch_by = "membershipNo";
            }
            else if (mSearch_by == "Phone_No")
            {
                mSearch_by = "phoneNo";
            }

            try
            {
                DataTable dt_members = new DataTable();
                String m_sql = "SELECT membershipNo as Membership_No , fName as Name , phoneNo as Phone_No FROM members WHERE " + mSearch_by + " LIKE '%" + mSearch_txt + "%'";
                MySqlCommand m_cmd = new MySqlCommand(m_sql, conman.connection());
                using (MySqlDataAdapter da_members = new MySqlDataAdapter(m_cmd))
                {
                    da_members.Fill(dt_members);
                    dgv_members.DataSource = dt_members;
                }
                int mSearch_rows = dt_members.Rows.Count;
                lb_mSearch.Text = mSearch_rows.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Search! \n \n1)Please check you are selected correct \"search by\" and \"Category\" texts. \n2)Please Enter correct \"search\" text", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_mnnSearch_Click(object sender, EventArgs e)
        {
            string mnnCat = cmb_cat.Text;
            string mnnSearch_txt = txt_mnnSearch.Text;
            string mnnSearch_by = cmb_mnnSearch.Text;

            if (mnnSearch_by == "Index_No")
            {
                if(mnnCat == "Magazines")
                {
                    mnnSearch_by = "mIndex";
                }
                else if(mnnCat == "Newspapers")
                {
                    mnnSearch_by = "nIndex";
                }
            }
                    
            else if (mnnSearch_by == "Name")
            {
                mnnSearch_by = "name";
            }
            else if (mnnSearch_by == "Date")
            {
                mnnSearch_by = "date";
            }
            
            if (mnnCat == "Magazines")
            {
                try
                {
                    DataTable dt_M = new DataTable();
                    String ma_sql = "SELECT mIndex as Index_No , name as Magazine_Name , date as Date FROM mgazines WHERE " + mnnSearch_by + " LIKE '%" + mnnSearch_txt + "%'";
                    MySqlCommand ma_cmd = new MySqlCommand(ma_sql, conman.connection());
                    using (MySqlDataAdapter da_M = new MySqlDataAdapter(ma_cmd))
                    {
                        da_M.Fill(dt_M);
                        dgv_magazine.DataSource = dt_M;
                    }

                    int mnnSearch_rows = dt_M.Rows.Count;
                    lb_mnnSearch.Text = mnnSearch_rows.ToString();
                    lb_mnn.Text = "Magazine(s) match search";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Search! \n \n1)Please check you are selected correct \"search by\" text \n2)Please Enter correct \"search\" text", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(mnnCat == "Newspapers")
            {
                try
                {
                    DataTable dt_N = new DataTable();
                    String n_sql = "SELECT nIndex as Index_No , name as Newspaper_Name , date as Date FROM newspapers WHERE " + mnnSearch_by + " LIKE '%" + mnnSearch_txt + "%'";
                    MySqlCommand n_cmd = new MySqlCommand(n_sql, conman.connection());
                    using (MySqlDataAdapter da_N = new MySqlDataAdapter(n_cmd))
                    {
                        da_N.Fill(dt_N);
                        dgv_newspapers.DataSource = dt_N;
                    }

                    int mnnSearch_rows = dt_N.Rows.Count;
                    lb_mnnSearch.Text = mnnSearch_rows.ToString();
                    lb_mnn.Text = "Newspaper(s) match search";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Search! \n \n1)Please check you are selected correct \"search by\" text \n2)Please Enter correct \"search\" text", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Search! \n \n1)Please check you are selected correct \"Category\" text ", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adminProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_admin_profile ad_prof = new frm_admin_profile();
            ad_prof.ShowDialog();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_contact contact = new frm_contact();
            contact.ShowDialog();
        }


    }
}
