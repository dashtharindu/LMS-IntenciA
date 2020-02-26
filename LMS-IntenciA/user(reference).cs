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
    public partial class frm_reference : Form
    {
        public frm_reference()
        {
            InitializeComponent();
        }
        string isbn_grid = "";

        private void frm_reference_Load(object sender, EventArgs e)
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.ShowDialog();
        }

        private void frm_reference_FormClosing(object sender, FormClosingEventArgs e)
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
                RefView RefView = new RefView(isbn_grid);
                RefView.ShowDialog();
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
