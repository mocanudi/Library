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
    public partial class Orders : Form
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
        public Orders()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_borrowing", "ID выдачи");//0
            dataGridView1.Columns.Add("borrowing_DateOfIssuance", "Дата выдачи");//1
            dataGridView1.Columns.Add("borrowing_DateOfReturn", "Дата возвращения");//2
            dataGridView1.Columns.Add("borrowing_Period", "Срок");//3
            dataGridView1.Columns.Add("borrowing_Status", "Статус выдачи");//4
            dataGridView1.Columns.Add("ID_librarian", "ID библиотекаря");//5
            dataGridView1.Columns.Add("ID_book", "ID книги");//5
            dataGridView1.Columns.Add("ID_reader", "ID читателя");//6
            dataGridView1.Columns.Add("reader_Surname", "Имя читателя");//7
            dataGridView1.Columns.Add("librarian_FIO", "Имя библиотекаря");//9
            dataGridView1.Columns.Add("book_Name", "Название книги");//8
            dataGridView1.Columns.Add("isNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0),
                 record.GetDateTime(1), record.GetDateTime(2),
                 record.GetString(3), record.GetString(4),

                 record.GetInt32(5), record.GetInt32(6),
                 record.GetInt32(7), record.GetString(8),
                 record.GetString(9), record.GetString(10),
                 RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dwg)
        {
            dwg.Rows.Clear();

    

            string querystring = $"SELECT Borrowing.*, Reader.reader_Surname, Librarian.librarian_FIO, Book.book_Name " +
                $"FROM Borrowing INNER JOIN Librarian ON Borrowing.ID_librarian = Librarian.ID_librarian " +
                $"INNER JOIN Reader ON Borrowing.ID_reader = Reader.ID_reader " +
                $"INNER JOIN Book ON Borrowing.ID_book = Book.ID_book ";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }
        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private void Reboot_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
        private void Search(DataGridView dwg)
                {
                    
                }
        private void Search_tb_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

               

            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewOrder additem = new NewOrder();
            additem.Show();
            this.Hide();
            this.Hide();
        }
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;
            }
        }
        private new void Update()
        {
            database.OpenConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[14].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuerry = $"delete from Reader where id = '{id}'";

                    var command = new SqlCommand(deleteQuerry, database.getConnection());
                    command.ExecuteNonQuery();
                }

                

            }

            database.ClosedConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
