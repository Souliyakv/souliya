using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Connect_Database
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Dbcontion Q = new Dbcontion();

        private void button2_Click(object sender, EventArgs e)
        {
            String goods_name;
            String goods_price;
            goods_name = textBox1.Text.ToString();
            goods_price = textBox2.Text.ToString();
            Q.Query("insert into tb_goods (goods_name,goods_price) values('" + goods_name + "','" + goods_price + "')");
        }
    }
}
