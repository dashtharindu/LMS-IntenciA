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
    public partial class frm_reg_MnN : Form
    {
        public frm_reg_MnN()
        {
            InitializeComponent();
        }
        string regex_date = @"^\d{4}-((0\d)|(1[012]))-(([012]\d)|3[01])$";

        private void btn_submit_Click(object sender, EventArgs e)
        {
            String mIndex = txt_mIndex.Text.Replace("'", "");
            mIndex = mIndex.Replace("\"", "");

            String mName = txt_mName.Text.Replace("'", "");
            mName = mName.Replace("\"", "");

            String mDate = txt_mDate.Text.Replace("'", "");
            mDate = mDate.Replace("\"", "");

            String mPur_date = txt_mPur_date.Text.Replace("'", "");
            mPur_date = mPur_date.Replace("\"", "");

            String mCategory = txt_mCategory.Text.Replace("'", "");
            mCategory = mCategory.Replace("\"", "");

            String mRemarks = txt_mRemarks.Text.Replace("'", "");
            mRemarks = mRemarks.Replace("\"", "");

            if (mIndex != "" && mName != "" && mDate != "" && mPur_date != "" && mCategory != "")
            {

                if (Regex.IsMatch(mDate, regex_date) == true)
                {
                    if (Regex.IsMatch(mPur_date, regex_date) == true)
                    {
                        String sql1 = "INSERT INTO `mgazines` VALUE ('" + mIndex + "','" + mName + "','" + mDate + "','" + mPur_date + "','" + mCategory + "','" + mRemarks + "')";
                        MySqlCommand cmd1 = new MySqlCommand(sql1, conman.connection());
                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Magazine added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_clr.Text = "Add New";
                    }
                    else
                    {
                        MessageBox.Show("Invalid Purchase Date format! \nPlease use YYYY-MM-DD format for registration", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Date format! \nPlease use YYYY-MM-DD format for registration", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }             
            }

            else
            {
                MessageBox.Show("Magazine adding Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_mIndex.Text = "";
            txt_mName.Text = "";
            txt_mDate.Text = "";
            txt_mPur_date.Text = "";
            txt_mCategory.Text = "";
            txt_mRemarks.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nIndex = txt_nIndex.Text.Replace("'", "");
            nIndex = nIndex.Replace("\"", "");

            String nName = txt_nName.Text.Replace("'", "");
            nName = nName.Replace("\"", "");

            String nDate = txt_nDate.Text.Replace("'", "");
            nDate = nDate.Replace("\"", "");

            String nPur_date = txt_nPur_date.Text.Replace("'", "");
            nPur_date = nPur_date.Replace("\"", "");

            String nCategory = txt_nCategory.Text.Replace("'", "");
            nCategory = nCategory.Replace("\"", "");

            String nRemarks = txt_nRemarks.Text.Replace("'", "");
            nRemarks = nRemarks.Replace("\"", "");

            if (nIndex != "" && nName != "" && nDate != "" && nPur_date != "" && nCategory != "")
            {

                if (Regex.IsMatch(nDate, regex_date) == true)
                {
                    if (Regex.IsMatch(nPur_date, regex_date) == true)
                    {
                        String sql1 = "INSERT INTO `newspapers` VALUE ('" + nIndex + "','" + nName + "','" + nDate + "','" + nPur_date + "','" + nCategory + "','" + nRemarks + "')";
                        MySqlCommand cmd1 = new MySqlCommand(sql1, conman.connection());
                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Newspaper added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_nClr.Text = "Add New";
                    }
                    else
                    {
                        MessageBox.Show("Invalid Purchase Date format! \nPlease use YYYY-MM-DD format for registration", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Date format! \nPlease use YYYY-MM-DD format for registration", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Newspaper adding Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_nIndex.Text = "";
            txt_nName.Text = "";
            txt_nDate.Text = "";
            txt_nPur_date.Text = "";
            txt_nCategory.Text = "";
            txt_nRemarks.Text = "";
        }

    }
}
