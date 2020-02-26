using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
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
        string isbn_grid = "";
        string mem_grid = "";
        String BranchNo ;
        String return_day;
        String availability;

        double r1Days;
        double r1Fine;

        double r2Days;
        double r2Fine;

        double r3Days;
        double r3Fine;

        double r4Fine;

        private void frm_lending_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            txt_today.Text = today.ToString("yyyy-MM-dd");

            DateTime return_day = today.AddDays(14);
            txt_DateOfReturn.Text = return_day.ToString("yyyy-MM-dd");

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

            //Fine Rates--------------------------------------------------------------------------------------------------
            DataTable dt_r1 = new DataTable();
            String r1_sql = "SELECT * FROM fines WHERE rule_no = '1'";
            MySqlCommand r1_cmd = new MySqlCommand(r1_sql, conman.connection());
            using (MySqlDataAdapter da_r1 = new MySqlDataAdapter(r1_cmd))
            {
                da_r1.Fill(dt_r1);
            }
            foreach (DataRow row in dt_r1.Rows)
            {
                String r1d = row["days_till"].ToString();
                r1Days = double.Parse(r1d);

                String r1f = row["fine"].ToString();
                r1Fine = double.Parse(r1f);
            }

            DataTable dt_r2 = new DataTable();
            String r2_sql = "SELECT * FROM fines WHERE rule_no = '2'";
            MySqlCommand r2_cmd = new MySqlCommand(r2_sql, conman.connection());
            using (MySqlDataAdapter da_r2 = new MySqlDataAdapter(r2_cmd))
            {
                da_r2.Fill(dt_r2);
            }
            foreach (DataRow row in dt_r2.Rows)
            {
                String r2d = row["days_till"].ToString();
                r2Days = double.Parse(r2d);

                String r2f = row["fine"].ToString();
                r2Fine = double.Parse(r2f);
            }

            DataTable dt_r3 = new DataTable();
            String r3_sql = "SELECT * FROM fines WHERE rule_no = '3'";
            MySqlCommand r3_cmd = new MySqlCommand(r3_sql, conman.connection());
            using (MySqlDataAdapter da_r3 = new MySqlDataAdapter(r3_cmd))
            {
                da_r3.Fill(dt_r1);
            }
            foreach (DataRow row in dt_r1.Rows)
            {
                String r3d = row["days_till"].ToString();
                r3Days = double.Parse(r3d);

                String r3f = row["fine"].ToString();
                r3Fine = double.Parse(r3f);
            }

            DataTable dt_r4 = new DataTable();
            String r4_sql = "SELECT * FROM fines WHERE rule_no = '4'";
            MySqlCommand r4_cmd = new MySqlCommand(r4_sql, conman.connection());
            using (MySqlDataAdapter da_r4 = new MySqlDataAdapter(r4_cmd))
            {
                da_r4.Fill(dt_r4);
            }
            foreach (DataRow row in dt_r4.Rows)
            {
                String r4f = row["fine"].ToString();
                r4Fine = double.Parse(r4f);
            }
            //-----------------------------------------------------------------------------------------------------------
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.ShowDialog();
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            String branch_no = txt_BranchNo.Text;
            String memNo = txt_memNo.Text ;
            String return_date = txt_DateOfReturn.Text;
            string regex_date = @"^\d{4}-((0\d)|(1[012]))-(([012]\d)|3[01])$";

            if (branch_no != "" && memNo != "" && return_date != "")
            {
                if (Regex.IsMatch(return_date, regex_date) == true)
                {
                    DataTable dt_brnch = new DataTable();
                    String sql_br = "SELECT * FROM lending WHERE branchNo='" + branch_no + "'";
                    MySqlCommand cmd_br = new MySqlCommand(sql_br, conman.connection());
                    using (MySqlDataAdapter da_br = new MySqlDataAdapter(cmd_br))
                    {
                        da_br.Fill(dt_brnch);
                    }
                    int rowcount_br = dt_brnch.Rows.Count;
                    if (rowcount_br > 0)
                    {
                        DataTable dt_mem = new DataTable();
                        String sql_mem = "SELECT * FROM members WHERE membershipNo='" + memNo + "'";
                        MySqlCommand cmd = new MySqlCommand(sql_mem, conman.connection());
                        using (MySqlDataAdapter da_mem = new MySqlDataAdapter(cmd))
                        {
                            da_mem.Fill(dt_mem);
                        }

                        int rowcount = dt_mem.Rows.Count;
                        if (rowcount > 0)
                        {
                            foreach (DataRow row in dt_brnch.Rows)
                            {
                                availability = row["availability"].ToString();
                            }
                            if (availability == "Yes")
                            {
                                try
                                {
                                    String sql1 = "UPDATE `lending` SET ReturnDate='" + return_date + "',availability='No' WHERE branchNo ='" + branch_no + "'";
                                    MySqlCommand cmd1 = new MySqlCommand(sql1, conman.connection());
                                    cmd1.ExecuteNonQuery();

                                    MessageBox.Show("Successfully borrowed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Borrowing fail \nPlease Re-check branch no and return date !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Book is not available!", "Borrowing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Membership Number not exist. Please Register!", "Membership Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Branch number not exist!", "BranchNo Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Return Date format! \nPlease use YYYY-MM-DD format", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill Branch Number, Membership No and Return Date !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            String branch_no = txt_BranchNo.Text;
            String today_day = txt_today.Text;
            //String return_day = txt_DateOfReturn.Text;

            string regex_date = @"^\d{4}-((0\d)|(1[012]))-(([012]\d)|3[01])$";

            if (branch_no != "" && today_day != "")
            {
                if (Regex.IsMatch(today_day, regex_date) == true)
                {
                    DataTable dt_brnch = new DataTable();
                    String sql_br = "SELECT * FROM lending WHERE branchNo='" + branch_no + "'";
                    MySqlCommand cmd_br = new MySqlCommand(sql_br, conman.connection());
                    using (MySqlDataAdapter da_br = new MySqlDataAdapter(cmd_br))
                    {
                        da_br.Fill(dt_brnch);
                    }
                    int rowcount_br = dt_brnch.Rows.Count;
                    if (rowcount_br > 0)
                    {
                        foreach (DataRow row in dt_brnch.Rows)
                        {
                            return_day = row["ReturnDate"].ToString();
                            availability = row["availability"].ToString();
                        }
                        if (availability == "No")
                        {
                            DateTime t_date = DateTime.ParseExact(today_day, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                            DateTime r_date = DateTime.ParseExact(return_day, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                            double total = (t_date - r_date).TotalDays;
                            String dayss = total.ToString();
                            double days = double.Parse(dayss);

                            //lb_availability.Text = total.ToString();
                            if (days > 0)
                            {
                                if (days <= r1Days)
                                {
                                    double fine_total = days * r1Fine;
                                    DialogResult dialog = MessageBox.Show("Want to pay Rs." + fine_total + "\n Press \"Yes\" button After fine paid....", "Fine Found !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (dialog == DialogResult.Yes)
                                    {
                                        try
                                        {
                                            String sqlr = "UPDATE `lending` SET ReturnDate='-',availability='Yes' WHERE branchNo ='" + branch_no + "'";
                                            MySqlCommand cmdr = new MySqlCommand(sqlr, conman.connection());
                                            cmdr.ExecuteNonQuery();

                                            String sqlfh = "INSERT INTO `fine_history` VALUE ('','" + today_day + "','" + fine_total + "','" + branch_no + "')";
                                            MySqlCommand cmdfh = new MySqlCommand(sqlfh, conman.connection());
                                            cmdfh.ExecuteNonQuery();

                                            MessageBox.Show("Book Returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Return fail \nDatabase Error occured !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else if (days <= r2Days)
                                {
                                    double fine_total = r2Fine;
                                    DialogResult dialog = MessageBox.Show("Want to pay Rs." + fine_total + "\n Press \"Yes\" button After fine paid....", "Fine Found !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (dialog == DialogResult.Yes)
                                    {
                                        try
                                        {
                                            String sqlr = "UPDATE `lending` SET ReturnDate='-',availability='Yes' WHERE branchNo ='" + branch_no + "'";
                                            MySqlCommand cmdr = new MySqlCommand(sqlr, conman.connection());
                                            cmdr.ExecuteNonQuery();

                                            String sqlfh = "INSERT INTO `fine_history` VALUE ('','" + today_day + "','" + fine_total + "','" + branch_no + "')";
                                            MySqlCommand cmdfh = new MySqlCommand(sqlfh, conman.connection());
                                            cmdfh.ExecuteNonQuery();

                                            MessageBox.Show("Book Returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Return fail \nDatabase Error occured !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else if (days <= r3Days)
                                {
                                    double fine_total = r3Fine;
                                    DialogResult dialog = MessageBox.Show("Want to pay Rs." + fine_total + "\n Press \"Yes\" button After fine paid....", "Fine Found !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (dialog == DialogResult.Yes)
                                    {
                                        try
                                        {
                                            String sqlr = "UPDATE `lending` SET ReturnDate='-',availability='Yes' WHERE branchNo ='" + branch_no + "'";
                                            MySqlCommand cmdr = new MySqlCommand(sqlr, conman.connection());
                                            cmdr.ExecuteNonQuery();

                                            String sqlfh = "INSERT INTO `fine_history` VALUE ('','" + today_day + "','" + fine_total + "','" + branch_no + "')";
                                            MySqlCommand cmdfh = new MySqlCommand(sqlfh, conman.connection());
                                            cmdfh.ExecuteNonQuery();

                                            MessageBox.Show("Book Returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Return fail \nDatabase Error occured !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else
                                {
                                    double fine_total = r4Fine;
                                    DialogResult dialog = MessageBox.Show("Want to pay Rs." + fine_total + "\n Press \"Yes\" button After fine paid....", "Fine Found !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (dialog == DialogResult.Yes)
                                    {
                                        try
                                        {
                                            String sqlr = "UPDATE `lending` SET ReturnDate='-',availability='Yes' WHERE branchNo ='" + branch_no + "'";
                                            MySqlCommand cmdr = new MySqlCommand(sqlr, conman.connection());
                                            cmdr.ExecuteNonQuery();

                                            String sqlfh = "INSERT INTO `fine_history` VALUE ('','" + today_day + "','" + fine_total + "','" + branch_no + "')";
                                            MySqlCommand cmdfh = new MySqlCommand(sqlfh, conman.connection());
                                            cmdfh.ExecuteNonQuery();

                                            MessageBox.Show("Book Returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Return fail \nDatabase Error occured !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                try
                                {
                                    String sqlr = "UPDATE `lending` SET ReturnDate='-',availability='Yes' WHERE branchNo ='" + branch_no + "'";
                                    MySqlCommand cmdr = new MySqlCommand(sqlr, conman.connection());
                                    cmdr.ExecuteNonQuery();

                                    MessageBox.Show("Book Returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Return fail \nDatabase Error occured !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Book is available!", "Returning Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Branch number not exist!", "BranchNo Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Date format! \nPlease use YYYY-MM-DD format", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill Branch Number and \"Today\" Date !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            BranchNo = txt_BranchNo.Text;

            if (BranchNo != "")
            {
                DataTable dt_lending = new DataTable();
                String a_sql = "SELECT * FROM lending WHERE branchNo = '" + BranchNo + "'";
                MySqlCommand a_cmd = new MySqlCommand(a_sql, conman.connection());
                using (MySqlDataAdapter da_lending = new MySqlDataAdapter(a_cmd))
                {
                    da_lending.Fill(dt_lending);
                }
                foreach (DataRow row in dt_lending.Rows)
                {
                    lb_availability.Text = row["availability"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Please Insert Branch Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_lending_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            string search_txt = txt_search.Text;
            string search_by = cmb_searchBy.Text;

            if (search_by == "Name")
            {
                search_by = "name";
            }
            else if (search_by == "ISBN")
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

        private void btn_mAdd_Click(object sender, EventArgs e)
        {
            frm_member_reg member_reg = new frm_member_reg();
            member_reg.ShowDialog();
        }

        private void btn_mDel_Click(object sender, EventArgs e)
        {
            if (mem_grid != "")
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

        private void btn_mEdit_Click(object sender, EventArgs e)
        {

            if (mem_grid != "")
            {
                frm_member_edit mem_edit = new frm_member_edit(mem_grid);
                mem_edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select Membership number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_mRefsh_Click(object sender, EventArgs e)
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

        private void dgv_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_books.Rows[e.RowIndex];

                isbn_grid = row.Cells["ISBN"].Value.ToString();
            }
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            if (isbn_grid != "")
            {
                LenView LenView = new LenView(isbn_grid);
                LenView.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select isbn number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
