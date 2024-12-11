using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Авторизация
{
    public partial class Form1 : Form
    {
        public string usr, psswd;
        public Dictionary<String, String> Users = new Dictionary<String, String>()
        {
            {"admin", "admin"},
            {"user", "user"},
            {"seller", "seller"}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (LoginUser(username.Text, currentPassword.Text))
            {
                
                if (username.Text.ToLower().Contains("admin"))
                {
                    Form2 form2 = new Form2(this);
                    form2.Show();
                }
                else if(username.Text.ToLower().Contains("seller"))
                {
                    Form5 form = new Form5();
                    form.Show();
                }
                else
                {
                    Form4 form4 = new Form4(this);
                    form4.Show();
                }
            }
            else
            {
                currentPassword.Text = "";
                username.Text = "";
                MessageBox.Show("Не получилось авторизоваться");
            }
        }

        private bool LoginUser(string userName, string password)
        {
            if (Users.ContainsKey(userName))
            {
                string curPassword = Users[userName];
                if(curPassword == password)
                {
                    return true;
                }
            }
            return false;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            username.Text = usr;
            currentPassword.Text = psswd;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(this);
            form.Show();
        }
    }
}
