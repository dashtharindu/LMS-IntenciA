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
    public partial class frm_member_edit : Form
    {
        public frm_member_edit(string passMem)
        {
            InitializeComponent();
            txt_membershipNo.Text = passMem ;
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
            string regex_nic = @"^\d{9}(V|v|x|X)$";

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
                                        String sql1 = "UPDATE `members` SET membershipNo='" + memNo + "',fName='" + mFName + "',mName='" + mMName + "',lName='" + mLName + "',nic='" + mNIC + "',Bday='" + mBday + "',add_L1='" + mAdd1 + "',add_L2='" + mAdd2 + "',add_L3='" + mAdd3 + "',job_school='" + mJob + "',phoneNo='" + mPhone + "',age='" + mAge + "',review='" + mRemarks + "' WHERE membershipNo ='" + memNo + "'";
                                        MySqlCommand cmd1 = new MySqlCommand(sql1, conman.connection());
                                        cmd1.ExecuteNonQuery();

                                        String sql2 = "UPDATE `granter` SET nic='" + gNIC + "',fName='" + gFName + "',mName='" + gMName + "',lName='" + gLName + "',add_L1='" + gAdd1 + "',add_L2='" + gAdd2 + "',add_L3='" + gAdd3 + "',job='" + gJob + "',phoneNo='" + gPhone + "',membershipNo='" + memNo + "',remarks='" + gRemarks + "' WHERE membershipNo ='" + memNo + "'";
                                        MySqlCommand cmd2 = new MySqlCommand(sql2, conman.connection());
                                        cmd2.ExecuteNonQuery();

                                        MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
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

        private void frm_member_edit_Load(object sender, EventArgs e)
        {
            String memNo = txt_membershipNo.Text.Replace("'", "");
            memNo = memNo.Replace("\"", "");

            DataTable dt_MemEdit = new DataTable();
            String a_sql = "SELECT * FROM members WHERE membershipNo = '" + memNo + "'";
            MySqlCommand a_cmd = new MySqlCommand(a_sql, conman.connection());
            using (MySqlDataAdapter da_admin = new MySqlDataAdapter(a_cmd))
            {
                da_admin.Fill(dt_MemEdit);
            }
            foreach (DataRow row in dt_MemEdit.Rows)
            {
                txt_membershipNo.Text = row["membershipNo"].ToString();
                txt_mFName.Text = row["fName"].ToString();
                txt_mMName.Text = row["mName"].ToString();
                txt_mLName.Text = row["lName"].ToString();
                txt_mNIC.Text = row["nic"].ToString();
                txt_mBday.Text = row["Bday"].ToString();
                txt_mAdd1.Text = row["add_L1"].ToString();
                txt_mAdd2.Text = row["add_L2"].ToString();
                txt_mAdd3.Text = row["add_L3"].ToString();
                txt_mJob.Text = row["job_school"].ToString();
                txt_mPhone.Text = row["phoneNo"].ToString();
                txt_mAge.Text = row["age"].ToString();
                txt_mRemarks.Text = row["review"].ToString();
            }

            DataTable dt_graEdit = new DataTable();
            String b_sql = "SELECT * FROM granter WHERE membershipNo = '" + memNo + "'";
            MySqlCommand b_cmd = new MySqlCommand(b_sql, conman.connection());
            using (MySqlDataAdapter da_graEdit = new MySqlDataAdapter(b_cmd))
            {
                da_graEdit.Fill(dt_graEdit);
            }
            foreach (DataRow row in dt_graEdit.Rows)
            {
                txt_gNIC.Text = row["nic"].ToString();
                txt_gFName.Text = row["fName"].ToString();
                txt_gMName.Text = row["mName"].ToString();
                txt_gLName.Text = row["lName"].ToString();
                txt_gAdd1.Text = row["add_L1"].ToString();
                txt_gAdd2.Text = row["add_L2"].ToString();
                txt_gAdd3.Text = row["add_L3"].ToString();
                txt_gJob.Text = row["job"].ToString();
                txt_gPhone.Text = row["phoneNo"].ToString();
                txt_gRemarks.Text = row["remarks"].ToString();
            }
        }
    }
}
