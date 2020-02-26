using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace LMS_IntenciA
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        String pos;

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


        private void btn_sub_Click(object sender, EventArgs e)
        {
            String un = txt_un.Text.Replace("'","");
            un = un.Replace("\"", "");
            String pw = sha256(txt_pw.Text);

            if (un != "" && pw != "")
            {
                DataTable dt_login = new DataTable();
                String sql = "SELECT * FROM login WHERE usr_un='" + un + "' AND usr_pw='" + pw + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conman.connection());
                using (MySqlDataAdapter da_login = new MySqlDataAdapter(cmd))
                {
                    da_login.Fill(dt_login);
                }

                int rowcount = dt_login.Rows.Count;
                if (rowcount > 0)
                {
                    foreach (DataRow row in dt_login.Rows)
                    {
                        pos = row["usr_pos"].ToString();
                    }

                    if (pos == "admin")
                    {
                        this.Hide();
                        frm_admin admin = new frm_admin();
                        admin.ShowDialog();
                    }
                    else if (pos == "Lending")
                    {
                        this.Hide();
                        frm_lending lending = new frm_lending();
                        lending.ShowDialog();
                    }
                    else if (pos == "Reference")
                    {
                        this.Hide();
                        frm_reference reference = new frm_reference();
                        reference.ShowDialog();
                    }
                    else if (pos == "Magazines_Newspapers")
                    {
                        this.Hide();
                        frm_MnN MnN = new frm_MnN();
                        MnN.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid user !", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password ! \nPlease try again....", "Login Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please Enter your username and password !", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_un.Text = "";
            txt_pw.Text = "";
        }

        private void txt_pw_TextChanged(object sender, EventArgs e)
        {
            txt_pw.UseSystemPasswordChar = true ;
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                //e.Cancel = false;
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
