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
    public partial class frm_MagazineReg : Form
    {
        public frm_MagazineReg()
        {
            InitializeComponent();
        }

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

            string regex_date = @"^\d{4}-((0\d)|(1[012]))-(([012]\d)|3[01])$";

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
    }
}
