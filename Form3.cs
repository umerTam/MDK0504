﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Авторизация
{
    public partial class Form3 : Form
    {
        private string user, pass;
        private Form1 form;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.usr = textBox1.Text;
            form.psswd = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(HaveIsUser(textBox1.Text) == false)
            {
                form.Users.Add(textBox1.Text, textBox2.Text);
                MessageBox.Show("Пользователен зарегестрирован!");
            }
            else
            {
                MessageBox.Show("Пользователен уже существует!");
            }
        }

        private bool HaveIsUser(string name)
        {
            if (form.Users.ContainsKey(textBox1.Text))
                    return true;
 
            return false;
        }
    }
}
