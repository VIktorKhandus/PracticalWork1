using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ЛР_1_Маска_ввода_и_валидация_Email.DBContext;

namespace ЛР_1_Маска_ввода_и_валидация_Email
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Model1 model = new Model1();

        private void MainForm_Load(object sender, EventArgs e)
        {
            Table.DataSource = model.Users.ToList();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            FormAddUsers form = new FormAddUsers();
            form.ShowDialog();
            Table.DataSource = model.Users.ToList();
        }
    }
}
