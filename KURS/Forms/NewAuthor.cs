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
    public partial class NewAuthor : Form
    {
        DataBase database = new DataBase();
        public NewAuthor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Supplier item = new Supplier();
            item.Show();
            this.Hide();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");
            database.OpenConnection();
            con.Open();

            SqlCommand taskInsertCar = new SqlCommand("insert into Author (author_Name, author_Surname)" +
                " values (@a, @b)", con);
            taskInsertCar.Parameters.Add("@a", SqlDbType.VarChar);
            taskInsertCar.Parameters.Add("@b", SqlDbType.VarChar);

            taskInsertCar.Parameters["@a"].Value = textBox2.Text;
            taskInsertCar.Parameters["@b"].Value = textBox3.Text;
            taskInsertCar.ExecuteNonQuery();
            MessageBox.Show("Автор добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            database.ClosedConnection();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
