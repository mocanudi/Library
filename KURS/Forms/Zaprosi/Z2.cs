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
    public partial class Z2 : Form
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
        public Z2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns2()
        {
            dataGridView1.Columns.Add("ID_book", "ID");
            dataGridView1.Columns.Add("book_Name", "Название книги"); 
            dataGridView1.Columns.Add("book_PublicationYear", "Год публикации");
            dataGridView1.Columns.Add("book_PublishingHouse", "Издательство");
            dataGridView1.Columns.Add("book_Type", "Раздел");

            dataGridView1.Columns.Add("isNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2),
                record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid2(DataGridView dwg, int price)
        {
            dwg.Rows.Clear();

            string querystring = $"SELECT *" +
                $"FROM Book " +
                $"where book_PublicationYear BETWEEN 0 and '{price}'";

            ; SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }
        private void Z2_Load(object sender, EventArgs e)
        {
            CreateColumns2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox1.Text);

            RefreshDataGrid2(dataGridView1, price);
        }

        private void label1_Click(object sender, EventArgs e)
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
