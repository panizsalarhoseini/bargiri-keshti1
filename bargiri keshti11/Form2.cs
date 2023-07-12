using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bargiri_keshti11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string NAME=textBox3.Text;
            SqlConnection DE=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\bargiri keshti11\\bargiri keshti11\\Database1.mdf\";Integrated Security=True");
            DE.Open();
            string QUERY="DELETE FROM PROUCT WHERE NAME";
            SqlCommand command= new SqlCommand(QUERY,DE);
            command.ExecuteNonQuery();
            DE.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection DE=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\bargiri keshti11\\bargiri keshti11\\Database1.mdf\";Integrated Security=True");
            DE.Open();
            string QUERY="UPDAET product SET ";
            SqlCommand command= new SqlCommand(QUERY,DE);
            command.ExecuteNonQuery();
            DE.Close();
            MessageBox.Show("changes have been saved");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection DE= new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\bargiri keshti11\\bargiri keshti11\\Database1.mdf\";Integrated Security=True");
            DE.Open();
            string QUERY= "INSERT INTO products(produc1,produc2,produc3,product4,produc5,produc6) VALUES()";

            DE.Close();

        }
    }
}
2