using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace Авторизация
{
    public partial class Form5 : Form
    {
        private string _connectionString = "Data Source=201CAD3\\SQLEXPRESS;Initial Catalog=D;Integrated Security=True";
        private int _countProd = 0;

        public Form5()
        {
            InitializeComponent();

        }
        private void Form5_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM [dbo].[Product$]";

                SqlCommand cmd = new SqlCommand(query, connection);
                _countProd = (int)cmd.ExecuteScalar();
                connection.Close();
            }

            Point beginPos = new Point(13, 61);

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [dbo].[Product$]";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Label typeProd = new Label();
                    typeProd.Font = new Font(typeProd.Font.FontFamily, 14f);
                    typeProd.AutoSize = true;
                    typeProd.Text = reader["Тип продукции"].ToString();

                    Label nameProd = new Label();
                    nameProd.Font = new Font(nameProd.Font.FontFamily, 10f);
                    nameProd.AutoSize = true;
                    nameProd.Text = reader["Наименование продукции"].ToString();

                    Label articulProd = new Label();
                    articulProd.Font = new Font(nameProd.Font.FontFamily, 10f);
                    articulProd.AutoSize = true;
                    articulProd.Text = reader["Артикул"].ToString();

                    Label minProd = new Label();
                    minProd.Font = new Font(nameProd.Font.FontFamily, 12f);
                    minProd.AutoSize = true;
                    minProd.Text = reader["Минимальная стоимость для агента"].ToString();

                    Panel _imagePanel = new Panel();
                    _imagePanel.Height = 65;
                    _imagePanel.Width = 84;
                    _imagePanel.BackgroundImage = Image.FromFile("C:\\Users\\android\\Music\\Авторизация\\Resources\\image1.jpeg");
                    _imagePanel.BackgroundImageLayout = ImageLayout.Stretch;

                    Panel _mainPanel = new Panel();
                    _mainPanel.Height = 100;
                    _mainPanel.Width = 598;
                    _mainPanel.Location = beginPos;

                    _mainPanel.Controls.Add(_imagePanel);
                    _imagePanel.Location = new Point(17, 17);

                    _mainPanel.Controls.Add(typeProd);
                    typeProd.Location = new Point(126, 17);

                    _mainPanel.Controls.Add(nameProd);
                    nameProd.Location = new Point(256, 17);

                    _mainPanel.Controls.Add(articulProd);
                    articulProd.Location = new Point(127, 37);

                    _mainPanel.Controls.Add(minProd);
                    minProd.Location = new Point(493, 34);

                    beginPos.Y += 118;

                    panel2.Controls.Add(_mainPanel);
                    counterForProd++;
                }
                reader.Close();
                connection.Close();
            }
            panel2.Controls[currentCountProd].BackColor = Color.Green;
        }

        int counterForProd = 0;
        int currentCountProd = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            currentCountProd++;
            if (currentCountProd > counterForProd) return;
            panel2.Controls[currentCountProd].BackColor = Color.Green;
            panel2.Controls[currentCountProd - 1].BackColor = Color.White;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentCountProd--;
            if (currentCountProd < 0) currentCountProd = 0;
            panel2.Controls[currentCountProd].BackColor = Color.Green;
            panel2.Controls[currentCountProd + 1].BackColor = Color.White;
        }
    }

 }
