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
    public partial class Z1 : Form
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
        public Z1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns_1()
        {
            dataGridView1.Columns.Add("ID_borrowing", "ID выдачи");//3
            dataGridView1.Columns.Add("ID_librarian", "ID библиотекаря");//
            dataGridView1.Columns.Add("reader_Surname", "Фамилия читателя");//
            dataGridView1.Columns.Add("book_Name", "Название книги");//


            dataGridView1.Columns.Add("isNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            int ID_borrowing = (record.GetValue(0) == DBNull.Value) ? 0 : (int)record.GetValue(0);
            int ID_librarian = (record.GetValue(8) == DBNull.Value) ? 0 : (int)record.GetValue(8);
            string reader_Surname = (record.GetValue(15) == DBNull.Value) ? string.Empty : record.GetString(15);
            string book_Name = (record.GetValue(21) == DBNull.Value) ? string.Empty : record.GetString(21);

            dwg.Rows.Add(ID_borrowing, ID_librarian, reader_Surname, book_Name, RowState.ModifiedNew);
        }
        private void RefreshDataGrid1(DataGridView dwg, string deliver)
        {
            dwg.Rows.Clear();

            string querystring = $"SELECT *" +
                $"FROM Borrowing " +
                $"INNER JOIN Librarian ON Librarian.ID_librarian = " +
                $"Borrowing.ID_librarian " +
                $"INNER JOIN Reader ON Reader.ID_reader = Borrowing.ID_reader " +
                $"INNER JOIN Book ON Book.ID_book = Borrowing.ID_book " +
                $"where Librarian.librarian_FIO = '{deliver}'";

;            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }

        private void Z1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");
            con.Open();

            CreateColumns_1();
            SqlDataReader dr3;
            DataTable dt3 = new DataTable();
            SqlCommand task3;
            task3 = new SqlCommand("Select * FROM Librarian", con);
            dr3 = task3.ExecuteReader();
            dt3.Load(dr3);
            comboBox2.DisplayMember = "librarian_FIO";
            comboBox2.ValueMember = "ID_librarian";
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

        private void button3_Click(object sender, EventArgs e)
        {
            Forma item = new Forma();
            item.Show();
            this.Hide();
        }
    }
}
