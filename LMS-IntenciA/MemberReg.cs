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
    public partial class frm_member_reg : Form
    {
        public frm_member_reg()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            String memNo = txt_membershipNo.Text.Replace("'", "");
            memNo = memNo.Replace("\"", "");

            String mFName = txt_mFName.Text.Replace("'", "");
            mFName = mFName.Replace("\"", "");

            String mMName = txt_mMName.Text.Replace("'", "");
            mMName = mMName.Replace("\"", "");

            String mLName = txt_mLName.Text.Replace("'", "");
            mLName = mLName.Replace("\"", "");

            String mNIC = txt_mNIC.Text.Replace("'", "");
            mNIC = mNIC.Replace("\"", "");

            String mBday = txt_mBday.Text.Replace("'", "");
            mBday = mBday.Replace("\"", "");

            String mAdd1 = txt_mAdd1.Text.Replace("'", "");
            mAdd1 = mAdd1.Replace("\"", "");

            String mAdd2 = txt_mAdd2.Text.Replace("'", "");
            mAdd2 = mAdd2.Replace("\"", "");

            String mAdd3 = txt_mAdd3.Text.Replace("'", "");
            mAdd3 = mAdd3.Replace("\"", "");

            String mJob = txt_mJob.Text.Replace("'", "");
            mJob = mJob.Replace("\"", "");

            String mPhone = txt_mPhone.Text.Replace("'", "");
            mPhone = mPhone.Replace("\"", "");

            String mAge = txt_mAge.Text.Replace("'", "");
            mAge = mAge.Replace("\"", "");

            String mRemarks = txt_mRemarks.Text.Replace("'", "");
            mRemarks = mRemarks.Replace("\"", "");

            //Regular Expression strings..
            string regex_date = @"^\d{4}-((0\d)|(1[012]))-(([012]\d)|3[01])$";
            string regex_phone = @"^\d{10}$";
            string regex_nic = @"^\d{9}(V|v|x|X)$" ;

            if (memNo != "" && mFName != "" && mMName != "" && mLName != "" && mNIC != "" && mBday != "" && mAdd1 != "" && mAdd2 != "" && mAdd3 != "" && mJob != "" && mPhone != "")
            {
                if (Regex.IsMatch(mNIC, regex_nic) == true)
                {
                    if (Regex.IsMatch(mBday, regex_date) == true)
                    {
                        if (Regex.IsMatch(mPhone, regex_phone) == true)
                        {
                            String gNIC = txt_gNIC.Text.Replace("'", "");
                            gNIC = gNIC.Replace("\"", "");

                            String gFName = txt_gFName.Text.Replace("'", "");
                            gFName = gFName.Replace("\"", "");

                            String gMName = txt_gMName.Text.Replace("'", "");
                            gMName = gMName.Replace("\"", "");

                            String gLName = txt_gLName.Text.Replace("'", "");
                            gLName = gLName.Replace("\"", "");

                            String gAdd1 = txt_gAdd1.Text.Replace("'", "");
                            gAdd1 = gAdd1.Replace("\"", "");

                            String gAdd2 = txt_gAdd2.Text.Replace("'", "");
                            gAdd2 = gAdd2.Replace("\"", "");

                            String gAdd3 = txt_gAdd3.Text.Replace("'", "");
                            gAdd3 = gAdd3.Replace("\"", "");

                            String gJob = txt_gJob.Text.Replace("'", "");
                            gJob = gJob.Replace("\"", "");

                            String gPhone = txt_gPhone.Text.Replace("'", "");
                            gPhone = gPhone.Replace("\"", "");

                            String gRemarks = txt_gRemarks.Text.Replace("'", "");
                            gRemarks = gRemarks.Replace("\"", "");

                            if (gNIC != "" && gFName != "" && gMName != "" && gLName != "" && gAdd1 != "" && gAdd2 != "" && gAdd3 != "" && gJob != "" && gPhone != "")
                            {
                                if (Regex.IsMatch(gNIC, regex_nic) == true)
                                {
                                    if (Regex.IsMatch(gPhone, regex_phone) == true)
                                    {
                                        String sql1 = "INSERT INTO `members` VALUE ('" + memNo + "','" + mFName + "','" + mMName + "','" + mLName + "','" + mNIC + "','" + mBday + "','" + mAdd1 + "','" + mAdd2 + "','" + mAdd3 + "','" + mJob + "','" + mPhone + "','" + mAge + "','" + mRemarks + "')";
                                        MySqlCommand cmd1 = new MySqlCommand(sql1, conman.connection());
                                        cmd1.ExecuteNonQuery();

                                        String sql2 = "INSERT INTO `granter` VALUE ('" + gNIC + "','" + gFName + "','" + gMName + "','" + gLName + "','" + gAdd1 + "','" + gAdd2 + "','" + gAdd3 + "','" + gJob + "','" + gPhone + "','" + memNo + "','" + gRemarks + "')";
                                        MySqlCommand cmd2 = new MySqlCommand(sql2, conman.connection());
                                        cmd2.ExecuteNonQuery();

                                        MessageBox.Show("Registration Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        btn_clr.Text = "Add New";
                                    }
                                    else
                                    {
                                    MessageBox.Show("Invalid granter phone number! \nPlease use 10 characters phone number", "Invalid phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                 MessageBox.Show("Invalid granter NIC number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("You must fill all granter text fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid member phone number! \nPlease use 10 characters phone number", "Invalid phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid member Birth day! \nPlease use YYYY-MM-DD format for a date", "Birthday Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid member NIC number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Registration Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_membershipNo.Text = "";
            txt_mFName.Text = "";
            txt_mMName.Text = "";
            txt_mLName.Text = "";
            txt_mNIC.Text = "";
            txt_mBday.Text = "";
            txt_mAdd1.Text = "";
            txt_mAdd2.Text = "";
            txt_mAdd3.Text = "";
            txt_mJob.Text = "";
            txt_mPhone.Text = "";
            txt_mAge.Text = "";
            txt_mRemarks.Text = "";

            txt_gNIC.Text = "";
            txt_gFName.Text = "";
            txt_gMName.Text = "";
            txt_gLName.Text = "";
            txt_gAdd1.Text = "";
            txt_gAdd2.Text = "";
            txt_gAdd3.Text = "";
            txt_gJob.Text = "";
            txt_gPhone.Text = "";
            txt_gRemarks.Text = "";
        }
    }
}
