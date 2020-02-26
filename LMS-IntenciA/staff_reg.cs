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
    public partial class staff_reg : Form
    {
        public staff_reg()
        {
            InitializeComponent();
        }

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
            String sNic = txt_sNic.Text.Replace("'", "");
            sNic = sNic.Replace("\"", "");

            String sFName = txt_sFName.Text.Replace("'", "");
            sFName = sFName.Replace("\"", "");

            String sPos = cmb_sPos.Text.Replace("'", "");
            sPos = sPos.Replace("\"", "");

            String usrName = txt_usrName.Text.Replace("'", "");
            usrName = usrName.Replace("\"", "");

            String sPass = txt_sPass.Text.Replace("'", "");
            sPass = sPass.Replace("\"", "");

            String sCPass = txt_sCPass.Text.Replace("'", "");
            sCPass = sCPass.Replace("\"", "");

            //Reguar Expression string
            string regex_nic = @"^\d{9}(V|v|x|X)$";

            if (sNic != "" && sFName != "" && sPos != "" && usrName != "" && sPass != "" && sCPass != "")
            {
                if (Regex.IsMatch(sNic, regex_nic) == true)
                {
                    if (txt_sPass.TextLength >= 8)
                    {
                        if (sPass == sCPass)
                        {
                            String ePass = sha256(sPass);
                            try
                            {
                                String sql1 = "INSERT INTO `login` VALUE ('" + sNic + "','" + usrName + "','" + ePass + "','" + sPos + "','" + sFName + "')";
                                MySqlCommand cmd1 = new MySqlCommand(sql1, conman.connection());
                                cmd1.ExecuteNonQuery();

                                MessageBox.Show("Staff member added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btn_clr.Text = "Add New";
                            }
                            catch(Exception exc)
                            {
                                MessageBox.Show("Registration Failed \nMay be you are already registered!", "Db Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password! \ncant match both passwords!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password! \nPassword must contain at least 8 characters", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid NIC number!", "NIC number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Registration Failed \nPlease fill all text fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
