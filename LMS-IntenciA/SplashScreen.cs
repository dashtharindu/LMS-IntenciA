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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void TimerLoading_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            lb_disp.Text = progressBar1.Value +"%   Starting Library Management System....";
            if(progressBar1.Value == 100)
            {
                TimerLoading.Stop();

                String con_ser = @"server=localhost;user id=root";
                MySqlConnection server = new MySqlConnection(con_ser);
                lb_disp.Text = "Connecting to the server.....";

                try
                {
                    server.Open();
                    lb_disp.Text = "Connected to the Server....";
                    //MessageBox.Show(this, "server found", "OK !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    server.Close();

                    String con_db = @"server=localhost;user id=root;database=lms";
                    MySqlConnection db = new MySqlConnection(con_db);
                    lb_disp.Text = "Connecting to the Database....";
                    try
                    {
                        db.Open();
                        //MessageBox.Show(this, "Database found", "OK !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lb_disp.Text = "Connected to the Database....";
                        db.Close();

                        this.Close();
                        //frm_login login = new frm_login();
                        //login.ShowDialog();
                    }
                    catch (Exception)
                    {
                        lb_disp.Text = "Error occured while connecting to the Database !";
                        MessageBox.Show("Server is connected but the database is not found !", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Application.Exit();
                        Application.ExitThread();
                    }
                }
                catch (Exception)
                {
                    lb_disp.Text = "Error occured while connecting to the Server !";
                    MessageBox.Show("Please check XAMPP is already running and MySQL service is started... ", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Application.Exit();
                    Application.ExitThread();
                }
            }
        }

    }
}
