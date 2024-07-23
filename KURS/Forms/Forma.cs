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
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Enter_label_Click(object sender, EventArgs e)
        {
            
        }

        private void Clients_btn_Click(object sender, EventArgs e)
        {
            Clients frm1 = new Clients();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void Items_btn_Click(object sender, EventArgs e)
        {
            Items frm = new Items();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }
        DataBase database = new DataBase();



        private void Forma_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source='DIN';Initial Catalog=db_AZ;Integrated Security=True");
            con.Open();
            con.Close();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Clients frm1 = new Clients();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void Orders_btn_Click(object sender, EventArgs e)
        {
            Orders frm1 = new Orders();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delivery frm1 = new Delivery();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void таблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void дейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");
            con.Open();
            Clients frm1 = new Clients();
            this.Hide();
            frm1.ShowDialog();
            con.Close();
        }

        private void поискСпискаТоваровПоДиапазонуСтоимостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");
            con.Open();
            Zaprosi.Z2 item2 = new Zaprosi.Z2();
            this.Hide();
            item2.Show();
            con.Close();
        }

        private void ыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");
            con.Open();
            Zaprosi.Z3 item2 = new Zaprosi.Z3();
            this.Hide();
            item2.Show();
            con.Close();
        }

        private void просмотрСпискаЗаказовДоставляемыхОднимДоставщикомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");
            con.Open();
            Zaprosi.Z1 item2 = new Zaprosi.Z1();
            this.Hide();
            item2.Show();
            con.Close();
        }

        private void просмотрСпискаЗаказовОпределённогоПокупателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");
            con.Open();
            Zaprosi.Z4 item2 = new Zaprosi.Z4();
            this.Hide();
            item2.Show();
            con.Close();
        }

        private void отобразитьЗаказыВОпределённыйГородToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");
            con.Open();
            Zaprosi.Z5 item2 = new Zaprosi.Z5();
            this.Hide();
            item2.Show();
            con.Close();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");
            con.Open();
            Items frm1 = new Items();
            this.Hide();
            frm1.ShowDialog();
            con.Close();
        }

        private void адресаКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");
            con.Open();
            Supplier frm1 = new Supplier();
            this.Hide();
            frm1.ShowDialog();
            con.Close();
        }

        private void доставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");
            con.Open();
            Delivery frm1 = new Delivery();
            this.Hide();
            frm1.ShowDialog();
            con.Close();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIN;Initial Catalog=db_AZ;Integrated Security=True");
            con.Open();
            Orders frm1 = new Orders();
            this.Hide();
            frm1.ShowDialog();
            con.Close();
        }
    }
}
