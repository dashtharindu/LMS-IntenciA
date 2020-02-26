using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace LMS_IntenciA
{
    public partial class staff_edit : Form
    {
        public staff_edit(String PassNic)
        {
            InitializeComponent();
            txt_sNic.Text = PassNic;
        }

        String sNic;


        static string sha256(string password)
        {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            sNic = txt_sNic.Text.Replace("'", "");
            sNic = sNic.Replace("\"", "");

            String sFName = txt_sFName.Text.Replace("'", "");
            sFName = sFName.Replace("\"", "");

            String sPos = cmb_sPos.Text.Replace("'", "");
            sPos = sPos.Replace("\"", "");

            String usrName = txt_usrName.Text.Replace("'", "");
            usrName = usrName.Replace("\"", "");

            //Reguar Expression string
            string regex_nic = @"^\d{9}(V|v|x|X)$";

            if (sNic != "" && sFName != "" && sPos != "" && usrName != "")
            {
                if (Regex.IsMatch(sNic, regex_nic) == true)
                {
                    try
                    {
                        String sql1 = "UPDATE `login` SET usr_nic='" + sNic + "',usr_un='" + usrName + "',usr_pos='" + sPos + "',usr_name='" + sFName + "' WHERE usr_nic='" + sNic + "'";
                        MySqlCommand cmd1 = new MySqlCommand(sql1, conman.connection());
                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Staff member updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                     catch(Exception ex)
                     {
                         MessageBox.Show("Update Failed !", "Db Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                        
                }
                else
                {
                    MessageBox.Show("Invalid NIC number!", "NIC number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Update Failed \nYou must fill all text fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_sNic.Text = "";
            txt_sFName.Text = "";
            txt_usrName.Text = "";
            txt_sPass.Text = "";
            txt_sCPass.Text = "";
        }

        private void txt_sPass_TextChanged(object sender, EventArgs e)
        {
            txt_sPass.UseSystemPasswordChar = true;
        }

        private void txt_sCPass_TextChanged(object sender, EventArgs e)
        {
            txt_sCPass.UseSystemPasswordChar = true;
        }

        private void staff_edit_Load(object sender, EventArgs e)
        {
            String sNic = txt_sNic.Text.Replace("'", "");
            sNic = sNic.Replace("\"", "");

            DataTable dt_staff = new DataTable();
            String a_sql = "SELECT * FROM login WHERE usr_nic = '" + sNic + "'";
            MySqlCommand a_cmd = new MySqlCommand(a_sql, conman.connection());
            using (MySqlDataAdapter da_staff = new MySqlDataAdapter(a_cmd))
            {
                da_staff.Fill(dt_staff);
            }
            foreach (DataRow row in dt_staff.Rows)
            {
                txt_sNic.Text = row["usr_nic"].ToString();
                txt_sFName.Text = row["usr_name"].ToString();
                cmb_sPos.Text = row["usr_pos"].ToString();
                txt_usrName.Text = row["usr_un"].ToString();
            }
        }

        private void btn_pw_Click(object sender, EventArgs e)
        {
            String sPass = txt_sPass.Text.Replace("'", "");
            sPass = sPass.Replace("\"", "");

            String sCPass = txt_sCPass.Text.Replace("'", "");
            sCPass = sCPass.Replace("\"", "");

            if (sPass != "")
            {
                if (txt_sPass.TextLength >= 8)
                {
                    if (sPass == sCPass)
                    {
                        String ePass = sha256(sPass);

                        try
                        {
                            sNic = txt_sNic.Text.Replace("'", "");
                            sNic = sNic.Replace("\"", "");

                            String sql1 = "UPDATE `login` SET usr_pw ='" + ePass + "' WHERE usr_nic='" + sNic + "'";
                            MySqlCommand cmd1 = new MySqlCommand(sql1, conman.connection());
                            cmd1.ExecuteNonQuery();

                            MessageBox.Show("Password changed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Fail to change password!", "Db Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                         MessageBox.Show("Invalid Password! \nCouldn't match both passwords!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Password! \nPassword must contain at least 8 characters", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Password!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
