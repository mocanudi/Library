using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using KURS.Classes;

namespace KURS.Forms
{
    public partial class NewOrder : Form
    {
        DataBase database = new DataBase();
        public NewOrder()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            database.OpenConnection();
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");

           

                con.Open();
                SqlCommand taskInsertOrder = new SqlCommand("Insert into Borrowing(borrowing_DateOfIssuance, borrowing_DateOfReturn, borrowing_Status, borrowing_Period, ID_book, ID_reader, ID_librarian) Values(@a, @b, @c, @d, @e, @f, @g)", con);
                taskInsertOrder.Parameters.Add("@a", SqlDbType.Date);
                taskInsertOrder.Parameters.Add("@b", SqlDbType.Date);
                taskInsertOrder.Parameters.Add("@c", SqlDbType.VarChar);
                taskInsertOrder.Parameters.Add("@d", SqlDbType.VarChar);
                taskInsertOrder.Parameters.Add("@e", SqlDbType.Int);
                taskInsertOrder.Parameters.Add("@f", SqlDbType.Int);
                taskInsertOrder.Parameters.Add("@g", SqlDbType.Int);

                taskInsertOrder.Parameters["@a"].Value = dateTimePicker1.Value;
                taskInsertOrder.Parameters["@b"].Value = dateTimePicker2.Value;
                taskInsertOrder.Parameters["@c"].Value = textBox2.Text;
                taskInsertOrder.Parameters["@d"].Value = textBox3.Text; 
                taskInsertOrder.Parameters["@e"].Value = comboBox2_item.SelectedValue;
                taskInsertOrder.Parameters["@f"].Value = comboBox1_client.SelectedValue;
                taskInsertOrder.Parameters["@g"].Value = comboBox_librerian.SelectedValue;
                taskInsertOrder.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Заказ добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
          

            database.ClosedConnection();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");

            con.Open();
            SqlDataReader dr1;
            DataTable dt1 = new DataTable();
            SqlCommand task1;
            task1 = new SqlCommand("Select * FROM Reader", con);
            dr1 = task1.ExecuteReader();
            dt1.Load(dr1);
            comboBox1_client.DisplayMember = "reader_Surname";
            comboBox1_client.ValueMember = "ID_reader";
            comboBox1_client.DataSource = dt1;

            SqlDataReader dr2;
            DataTable dt2 = new DataTable();
            SqlCommand task2;
            task2 = new SqlCommand("Select * FROM Book", con);
            dr2 = task2.ExecuteReader();
            dt2.Load(dr2);
            comboBox2_item.DisplayMember = "book_Name";
            comboBox2_item.ValueMember = "ID_book";
            comboBox2_item.DataSource = dt2;

            SqlDataReader dr3;
            DataTable dt3 = new DataTable();
            SqlCommand task3;
            task3 = new SqlCommand("Select * FROM Librarian", con);
            dr3 = task3.ExecuteReader();
            dt3.Load(dr3);
            comboBox_librerian.DisplayMember = "librarian_FIO";
            comboBox_librerian.ValueMember = "ID_librarian";
            comboBox_librerian.DataSource = dt3;


            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {            
           
        }

        private void Enter_label_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Orders item = new Orders();
            item.Show();
            this.Hide();
        }

        private void comboBox1_client_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
