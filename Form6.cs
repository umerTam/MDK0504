using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Авторизация.DDataSet8TableAdapters;

namespace Авторизация
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dDataSet12._Product_". При необходимости она может быть перемещена или удалена.
            this.product_TableAdapter3.Fill(this.dDataSet12._Product_);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource3.EndEdit();
            this.product_TableAdapter3.Update(this.dDataSet12._Product_);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        public BindingSource GetBindingSource()
        {
            return this.productBindingSource3;
        }

        public DDataSet12TableAdapters.Product_TableAdapter GetTableAdapter()
        {
            return this.product_TableAdapter3;
        }
    }
}
