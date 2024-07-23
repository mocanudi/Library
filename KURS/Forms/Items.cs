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
    public partial class Items : Form
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
        

        public Items()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns() {
            dataGridView1.Columns.Add("ID_book", "ID");
            dataGridView1.Columns.Add("book_Name", "Название");
            dataGridView1.Columns.Add("book_PublicationYear", "Год Публикации");
            dataGridView1.Columns.Add("book_PublishingHouse", "Издательство");
            dataGridView1.Columns.Add("book_Type", "Раздел");
            
            
            dataGridView1.Columns.Add("ID_author", "ID_Автора");
            dataGridView1.Columns.Add("ID_author", "ID_Автора");
            dataGridView1.Columns.Add("author_Name", "Имя автора");
            dataGridView1.Columns.Add("author_Surname", "Фамилия автора");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwg, IDataRecord record) {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2),
                record.GetString(3), record.GetString(4), record.GetInt32(5), record.GetInt32(6), record.GetString(7), record.GetString(8), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dwg) {
            dwg.Rows.Clear();

            string querystring = $"select * from Book INNER JOIN Author ON Book.ID_author = Author.ID_author";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) 
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }
        private void Items_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void Enter_label_Click(object sender, EventArgs e)
        {

        }




        private void Search_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

               

            }
        }

        private void Reboot_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewItem additem = new NewItem();
            additem.Show();
            this.Hide();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if(dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            
        }


       

        private void Change_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
