using System.Data;
using System.Data.SqlClient;


namespace Connect_Database
{
public partial class Form1 : Form
{


    public Form1()
    {
        InitializeComponent();
    }
        Dbcontion Q = new Dbcontion();

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        String name, surname, phone, email, address, noted;
        name = textBox1.Text.ToString();
        surname = textBox2.Text.ToString();
        phone = textBox3.Text.ToString();
        email = textBox4.Text.ToString();
        address = textBox5.Text.ToString();
        noted = textBox6.Text.ToString();
        Q.Query("insert into tb_Employee (Em_name,Em_Surname,Em_Phone,Em_Email,Em_Address,Noted) values ('" + name + "','" + surname + "','" + phone + "','" + email + "','" + address + "','" + noted + "')");
        
    }

    private void textBox6_TextChanged(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
            Q.Query("select*from tb_Employee");
            BindingSource binding = new BindingSource();
            binding.DataSource = Q.ds.Tables["EMP"];
            textBox1.DataBindings.Add("Text", binding, "Em_Name");
            textBox2.DataBindings.Add("Text", binding, "Em_Surname");
            textBox3.DataBindings.Add("Text", binding, "Em_Phone");
            textBox4.DataBindings.Add("Text", binding, "Em_Email");
            textBox5.DataBindings.Add("Text", binding, "Em_Address");
            textBox6.DataBindings.Add("Text", binding, "Noted");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update();
        }
        private void update()
        {
            string sql = "Update tb_Employee set Em_Name = @name, Em_Surname = @sur, Em_Phone = @phone, Em_Email = @emil, note = @not";
            SqlCommand command = new SqlCommand();
            command.Parameters.Clear();
            command.CommandText = sql;
            command.Parameters.AddWithValue("name", textBox1.Text);
            command.Parameters.AddWithValue("sur", textBox2.Text);
            command.Parameters.AddWithValue("phone", textBox3.Text);
            command.Parameters.AddWithValue("emil", textBox4.Text);
            command.Parameters.AddWithValue("not", textBox5.Text);

            int re = command.ExecuteNonQuery();
            if(re == -1)
            {
                MessageBox.Show("ss");
            }
            else
            {
                MessageBox.Show("er");
            }
            
        }
    }
}
