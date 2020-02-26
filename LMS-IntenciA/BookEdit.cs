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
    public partial class frm_book_edit : Form
    {
        DataSet ds_lending;
        MySqlDataAdapter da_lending;
        MySqlCommandBuilder cmdb_lending;

        DataSet ds_reference;
        MySqlDataAdapter da_reference;
        MySqlCommandBuilder cmdb_reference;

        public frm_book_edit(string PassIsbn)
        {
            InitializeComponent();
            txt_isbn.Text = PassIsbn;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            String isbn = txt_isbn.Text.Replace("'", "");
            isbn = isbn.Replace("\"", "");
            isbn = isbn.Replace(" ", "");
            isbn = isbn.Replace("-", "");

            String BookName = txt_BookName.Text.Replace("'", "");
            BookName = BookName.Replace("\"", "");

            String lname = txt_lname.Text.Replace("'", "");
            lname = lname.Replace("\"", "");

            String fname = txt_fname.Text.Replace("'", "");
            fname = fname.Replace("\"", "");

            String price = txt_price.Text.Replace("'", "");
            price = price.Replace("\"", "");

            String ClassNo = txt_ClassNo.Text.Replace("'", "");
            ClassNo = ClassNo.Replace("\"", "");

            String RegDate = txt_reg_date.Text.Replace("'", "");
            RegDate = RegDate.Replace("\"", "");

            String bookshop = txt_bookshop.Text.Replace("'", "");
            bookshop = bookshop.Replace("\"", "");

            String year = txt_year.Text.Replace("'", "");
            year = year.Replace("\"", "");

            String publisher = txt_publisher.Text.Replace("'", "");
            publisher = publisher.Replace("\"", "");

            String publication = txt_publication.Text.Replace("'", "");
            publication = publication.Replace("\"", "");

            String remarks = txt_remarks.Text.Replace("'", "");
            remarks = remarks.Replace("\"", "");

            //Regular Expression strings..
            string regex_isbn = @"^\d{13}$";
            string regex_date = @"^\d{4}-((0\d)|(1[012]))-(([012]\d)|3[01])$";
            string regex_year = @"^\d{4}$";

            if (isbn != "" && BookName != "" && lname != "" && fname != "" && price != "" && ClassNo != "" && RegDate != "" && bookshop != "" && year != "" && publisher != "" && publication != "")
            {
                if (Regex.IsMatch(isbn, regex_isbn) == true)
                {
                    if (Regex.IsMatch(RegDate, regex_date) == true)
                    {
                        if (Regex.IsMatch(year, regex_year) == true)
                        {
                            String sql1 = "UPDATE `books` SET isbn='" + isbn + "',name='" + BookName + "',author_lname='" + lname + "',author_name='" + fname + "',price='" + price + "',classNo='" + ClassNo + "',regDate='" + RegDate + "',bookshop='" + bookshop + "',publishYear='" + year + "',publisher='" + publisher + "',publication='" + publication + "',remarks='" + remarks + "' WHERE isbn ='" + isbn + "'";
                            MySqlCommand cmd1 = new MySqlCommand(sql1, conman.connection());
                            cmd1.ExecuteNonQuery();

                            cmdb_lending = new MySqlCommandBuilder(da_lending);
                            da_lending.Update(ds_lending, "lending_details");

                            cmdb_reference = new MySqlCommandBuilder(da_reference);
                            da_reference.Update(ds_reference, "reference_details");

                            MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Year! \nPlease use valid year for registration", "Year Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Date format! \nPlease use YYYY-MM-DD format for registration", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ISBN number!", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Registration Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_isbn.Text = "";
            txt_BookName.Text = "";
            txt_lname.Text = "";
            txt_fname.Text = "";
            txt_price.Text = "";
            txt_ClassNo.Text = "";
            txt_reg_date.Text = "";
            txt_bookshop.Text = "";
            txt_year.Text = "";
            txt_publisher.Text = "";
            txt_publication.Text = "";
            txt_remarks.Text = "";
            
        }

        private void frm_book_edit_Load(object sender, EventArgs e)
        {
            String isbn = txt_isbn.Text.Replace("'", "");
            isbn = isbn.Replace("\"", "");

            DataTable dt_BookEdit = new DataTable();
            String a_sql = "SELECT * FROM books WHERE isbn = '" + isbn + "'";
            MySqlCommand a_cmd = new MySqlCommand(a_sql, conman.connection());
            using (MySqlDataAdapter da_admin = new MySqlDataAdapter(a_cmd))
            {
                da_admin.Fill(dt_BookEdit);
            }
            foreach (DataRow row in dt_BookEdit.Rows)
            {
                txt_isbn.Text = row["isbn"].ToString();
                txt_BookName.Text = row["name"].ToString();
                txt_lname.Text = row["author_lname"].ToString();
                txt_fname.Text = row["author_name"].ToString();
                txt_price.Text = row["price"].ToString();
                txt_ClassNo.Text = row["classNo"].ToString();
                txt_reg_date.Text = row["regDate"].ToString();
                txt_bookshop.Text = row["bookshop"].ToString();
                txt_year.Text = row["publishYear"].ToString();
                txt_publisher.Text = row["publisher"].ToString();
                txt_publication.Text = row["publication"].ToString();
                txt_remarks.Text = row["remarks"].ToString();
            }

            ds_lending = new System.Data.DataSet();
            String sql_lending = "SELECT branchNo as Branch_No , AcquisitionNo as Acquisition_No FROM lending WHERE isbn='" + isbn + "'";
            MySqlCommand cmd_lending = new MySqlCommand(sql_lending, conman.connection());
            da_lending = new MySqlDataAdapter(cmd_lending);
            da_lending.Fill(ds_lending, "lending_details");
            dgv_lending.DataSource = ds_lending.Tables[0];

            ds_reference = new System.Data.DataSet();
            String sql_reference = "SELECT branchNo as Branch_No , AcquisitionNo as Acquisition_No FROM reference WHERE isbn='" + isbn + "'";
            MySqlCommand cmd_reference = new MySqlCommand(sql_reference, conman.connection());
            da_reference = new MySqlDataAdapter(cmd_reference);
            da_reference.Fill(ds_reference, "reference_details");
            dgv_reference.DataSource = ds_reference.Tables[0];
        }

    }
}
