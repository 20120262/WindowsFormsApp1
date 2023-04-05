using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using WindowsFormsApp1.Connection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_DangNhap_Click(object sender, EventArgs e)
        {

        }

        private void lbn_Password_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbn_Username_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool Login (string username,string password)
        {
            try
            {
                OracleConnection conn = Connection.DBConnection.GetDBConnection(username, password);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: {0}", ex);
                return false;
            }
        }
    }
}
