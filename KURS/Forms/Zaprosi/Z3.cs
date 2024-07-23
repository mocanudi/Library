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
namespace KURS.Forms.Zaprosi
{
    public partial class Z3 : Form
    {
        DataBase database = new DataBase();
        int selectedRow;
        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }
        public Z3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            int ID_order = (record.GetValue(0) == DBNull.Value) ? 0 : (int)record.GetValue(0);
            string client_Surname = (record.GetValue(10) == DBNull.Value) ? string.Empty : record.GetString(10);
            string item_Name = (record.GetValue(16) == DBNull.Value) ? string.Empty : record.GetString(16);

            dwg.Rows.Add(item_Name,ID_order, client_Surname, RowState.ModifiedNew);
        }
        private void RefreshDataGrid1(DataGridView dwg, string item)
        {
            dwg.Rows.Clear();

            string querystring = $"SELECT *" +
                $"FROM Borrowing " +
                $"INNER JOIN Reader ON Reader.ID_reader = Borrowing.ID_reader " +
                $"INNER JOIN Book ON Book.ID_book = Borrowing.ID_book " +
                $"where Book.book_Name = '{item}'";

            ; SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }
        private void CreateColumns_3()
        {
            dataGridView1.Columns.Add("book_Name", "Название книги");
            dataGridView1.Columns.Add("ID_borrowing", "ID выдачи");
            dataGridView1.Columns.Add("reader_Surname", "Фамилия читателя");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }
        private void Z3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");
            con.Open();

            CreateColumns_3();
            SqlDataReader dr3;
            DataTable dt3 = new DataTable();
            SqlCommand task3;
            task3 = new SqlCommand("Select * FROM Book", con);
            dr3 = task3.ExecuteReader();
            dt3.Load(dr3);
            comboBox2.DisplayMember = "book_Name";
            comboBox2.ValueMember = "ID_book";
            comboBox2.DataSource = dt3;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = comboBox2.Text;
            RefreshDataGrid1(dataGridView1, a);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forma item = new Forma();
            item.Show();
            this.Hide();
        }
    }
}
