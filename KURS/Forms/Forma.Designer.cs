
namespace KURS.Forms
{
    partial class Forma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адресаКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискСпискаТоваровПоДиапазонуСтоимостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрСпискаЗаказовДоставляемыхОднимДоставщикомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрСпискаЗаказовОпределённогоПокупателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьЗаказыВОпределённыйГородToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.запросыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1087, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дейToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.адресаКлиентовToolStripMenuItem,
            this.доставщикиToolStripMenuItem,
            this.заказыToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.таблицыToolStripMenuItem.Text = "Действия";
            this.таблицыToolStripMenuItem.Click += new System.EventHandler(this.таблицыToolStripMenuItem_Click);
            // 
            // дейToolStripMenuItem
            // 
            this.дейToolStripMenuItem.Name = "дейToolStripMenuItem";
            this.дейToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.дейToolStripMenuItem.Text = "Читатели";
            this.дейToolStripMenuItem.Click += new System.EventHandler(this.дейToolStripMenuItem_Click);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.товарыToolStripMenuItem.Text = "Книги";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
            // 
            // адресаКлиентовToolStripMenuItem
            // 
            this.адресаКлиентовToolStripMenuItem.Name = "адресаКлиентовToolStripMenuItem";
            this.адресаКлиентовToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.адресаКлиентовToolStripMenuItem.Text = "Авторы";
            this.адресаКлиентовToolStripMenuItem.Click += new System.EventHandler(this.адресаКлиентовToolStripMenuItem_Click);
            // 
            // доставщикиToolStripMenuItem
            // 
            this.доставщикиToolStripMenuItem.Name = "доставщикиToolStripMenuItem";
            this.доставщикиToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.доставщикиToolStripMenuItem.Text = "Библиотекари";
            this.доставщикиToolStripMenuItem.Click += new System.EventHandler(this.доставщикиToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.заказыToolStripMenuItem.Text = "Выдачи книг";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискСпискаТоваровПоДиапазонуСтоимостиToolStripMenuItem,
            this.ыToolStripMenuItem,
            this.просмотрСпискаЗаказовДоставляемыхОднимДоставщикомToolStripMenuItem,
            this.просмотрСпискаЗаказовОпределённогоПокупателяToolStripMenuItem,
            this.отобразитьЗаказыВОпределённыйГородToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // поискСпискаТоваровПоДиапазонуСтоимостиToolStripMenuItem
            // 
            this.поискСпискаТоваровПоДиапазонуСтоимостиToolStripMenuItem.Name = "поискСпискаТоваровПоДиапазонуСтоимостиToolStripMenuItem";
            this.поискСпискаТоваровПоДиапазонуСтоимостиToolStripMenuItem.Size = new System.Drawing.Size(515, 22);
            this.поискСпискаТоваровПоДиапазонуСтоимостиToolStripMenuItem.Text = "Поиск списка книг по диапазону лет издания";
            this.поискСпискаТоваровПоДиапазонуСтоимостиToolStripMenuItem.Click += new System.EventHandler(this.поискСпискаТоваровПоДиапазонуСтоимостиToolStripMenuItem_Click);
            // 
            // ыToolStripMenuItem
            // 
            this.ыToolStripMenuItem.Name = "ыToolStripMenuItem";
            this.ыToolStripMenuItem.Size = new System.Drawing.Size(515, 22);
            this.ыToolStripMenuItem.Text = "Поиск списка выдач по запрашиваемой книге";
            this.ыToolStripMenuItem.Click += new System.EventHandler(this.ыToolStripMenuItem_Click);
            // 
            // просмотрСпискаЗаказовДоставляемыхОднимДоставщикомToolStripMenuItem
            // 
            this.просмотрСпискаЗаказовДоставляемыхОднимДоставщикомToolStripMenuItem.Name = "просмотрСпискаЗаказовДоставляемыхОднимДоставщикомToolStripMenuItem";
            this.просмотрСпискаЗаказовДоставляемыхОднимДоставщикомToolStripMenuItem.Size = new System.Drawing.Size(515, 22);
            this.просмотрСпискаЗаказовДоставляемыхОднимДоставщикомToolStripMenuItem.Text = "Просмотр списка выдач книг, осуществленных определенным библиотекарем";
            this.просмотрСпискаЗаказовДоставляемыхОднимДоставщикомToolStripMenuItem.Click += new System.EventHandler(this.просмотрСпискаЗаказовДоставляемыхОднимДоставщикомToolStripMenuItem_Click);
            // 
            // просмотрСпискаЗаказовОпределённогоПокупателяToolStripMenuItem
            // 
            this.просмотрСпискаЗаказовОпределённогоПокупателяToolStripMenuItem.Name = "просмотрСпискаЗаказовОпределённогоПокупателяToolStripMenuItem";
            this.просмотрСпискаЗаказовОпределённогоПокупателяToolStripMenuItem.Size = new System.Drawing.Size(515, 22);
            this.просмотрСпискаЗаказовОпределённогоПокупателяToolStripMenuItem.Text = "Просмотр списка выдач книг определенному читателя";
            this.просмотрСпискаЗаказовОпределённогоПокупателяToolStripMenuItem.Click += new System.EventHandler(this.просмотрСпискаЗаказовОпределённогоПокупателяToolStripMenuItem_Click);
            // 
            // отобразитьЗаказыВОпределённыйГородToolStripMenuItem
            // 
            this.отобразитьЗаказыВОпределённыйГородToolStripMenuItem.Name = "отобразитьЗаказыВОпределённыйГородToolStripMenuItem";
            this.отобразитьЗаказыВОпределённыйГородToolStripMenuItem.Size = new System.Drawing.Size(515, 22);
            this.отобразитьЗаказыВОпределённыйГородToolStripMenuItem.Text = "Отобразить выдачи книг в определённом городе";
            this.отобразитьЗаказыВОпределённыйГородToolStripMenuItem.Click += new System.EventHandler(this.отобразитьЗаказыВОпределённыйГородToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1029, 404);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1087, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Forma";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Forma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адресаКлиентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискСпискаТоваровПоДиапазонуСтоимостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрСпискаЗаказовДоставляемыхОднимДоставщикомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрСпискаЗаказовОпределённогоПокупателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьЗаказыВОпределённыйГородToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}