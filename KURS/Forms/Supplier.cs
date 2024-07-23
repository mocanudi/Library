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
    public partial class Supplier : Form
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
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_author", "ID");
            dataGridView1.Columns.Add("author_Name", "Имя");
            dataGridView1.Columns.Add("author_Surname", "Фамилия");

            dataGridView1.Columns.Add("isNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }
        public Supplier()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void RefreshDataGrid(DataGridView dwg)
        {
            dwg.Rows.Clear();

            string querystring = $"select * from Author";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forma item = new Forma();
            item.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewAuthor adds = new NewAuthor();
            adds.Show();
        }
        private void Search(DataGridView dwg)
        {
            dwg.Rows.Clear();
            string searchString = $"select * from Author where concat (ID_author, author_Surname, author_Name) " +
                $"like '%" + Search_tb.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, database.getConnection());

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

        private void Search_tb_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
    }
}
