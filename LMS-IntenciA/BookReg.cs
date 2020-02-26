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
    public partial class frm_book_reg : Form
    {
        public frm_book_reg()
        {
            InitializeComponent();
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

            //Validation strings..
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
                            //book copy1
                            String c1_BranchNo = txt_c1_BranchNo.Text.Replace("'", "");
                            c1_BranchNo = c1_BranchNo.Replace("\"", "");

                            String c1_AqNo = txt_c1_AqNo.Text.Replace("'", "");
                            c1_AqNo = c1_AqNo.Replace("\"", "");

                            String c1_unit = cmb_c1_unit.Text.Replace("'", "");
                            c1_unit = c1_unit.Replace("\"", "");

                            //book copy2
                            String c2_BranchNo = txt_c2_BranchNo.Text.Replace("'", "");
                            c2_BranchNo = c2_BranchNo.Replace("\"", "");

                            String c2_AqNo = txt_c2_AqNo.Text.Replace("'", "");
                            c2_AqNo = c2_AqNo.Replace("\"", "");

                            String c2_unit = cmb_c2_unit.Text.Replace("'", "");
                            c2_unit = c2_unit.Replace("\"", "");

                            //book copy3
                            String c3_BranchNo = txt_c3_BranchNo.Text.Replace("'", "");
                            c3_BranchNo = c3_BranchNo.Replace("\"", "");

                            String c3_AqNo = txt_c3_AqNo.Text.Replace("'", "");
                            c3_AqNo = c3_AqNo.Replace("\"", "");

                            String c3_unit = cmb_c3_unit.Text.Replace("'", "");
                            c3_unit = c3_unit.Replace("\"", "");

                            if (c1_BranchNo != "" && c1_AqNo != "" && c1_unit != "")
                            {
                                if (c2_BranchNo != "" && c2_AqNo != "" && c2_unit != "")
                                {
                                    String sql2 = "INSERT INTO " + c1_unit + " (isbn,branchNo,acquisitionNo) VALUE ('" + isbn + "','" + c1_BranchNo + "','" + c1_AqNo + "')";
                                    MySqlCommand cmd2 = new MySqlCommand(sql2, conman.connection());
                                    cmd2.ExecuteNonQuery();

                                    String sql1 = "INSERT INTO `books` VALUE ('" + isbn + "','" + BookName + "','" + lname + "','" + fname + "','" + price + "','" + ClassNo + "','" + RegDate + "','" + bookshop + "','" + year + "','" + publisher + "','" + publication + "','" + remarks + "')";
                                    MySqlCommand cmd1 = new MySqlCommand(sql1, conman.connection());
                                    cmd1.ExecuteNonQuery();
                                
                                    String sql3 = "INSERT INTO " + c2_unit + " ( isbn , branchNo , acquisitionNo ) VALUE ('" + isbn + "','" + c2_BranchNo + "','" + c2_AqNo + "')";
                                    MySqlCommand cmd3 = new MySqlCommand(sql3, conman.connection());
                                    cmd3.ExecuteNonQuery();

                                    if (c3_BranchNo != "" && c3_AqNo != "" && c3_unit != "")
                                    {
                                        String sql4 = "INSERT INTO " + c3_unit + " ( isbn , branchNo , acquisitionNo ) VALUE ('" + isbn + "','" + c3_BranchNo + "','" + c3_AqNo + "')";
                                        MySqlCommand cmd4 = new MySqlCommand(sql4, conman.connection());
                                        cmd4.ExecuteNonQuery();
                                    }
                                    MessageBox.Show("Registration Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    btn_clr.Text = "Add New";
                                }
                                else
                                {
                                    MessageBox.Show("Please fill copy2 field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please fill copy1 field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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
                    MessageBox.Show("Invalid ISBN number! \nPlease use 13 numbers without Spaces and Dashes(-)", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Registration Fail \nPlease fill all text fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
            txt_c1_BranchNo.Text = "";
            txt_c1_AqNo.Text = "";

            txt_c2_BranchNo.Text = "";
            txt_c2_AqNo.Text = "";

            txt_c3_BranchNo.Text = "";
            txt_c3_AqNo.Text = "";
        }

    }
}
