using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ЛР_1_Маска_ввода_и_валидация_Email.DBContext;

namespace ЛР_1_Маска_ввода_и_валидация_Email
{
    public partial class FormAddUsers : Form
    {
        public FormAddUsers()
        {
            InitializeComponent();
        }
        Model1 model = new Model1();

        private void FormAddUsers_Load(object sender, EventArgs e)
        {
            BindingSourceRole.DataSource = model.Roles.ToList();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
        Close();
        }

        private void Buttonadd_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$",
    RegexOptions.IgnoreCase);
            if (!reg.IsMatch(EmailTextBox.Text))
            {
                MessageBox.Show("Почта не соотвествует требованиям!");
                return;
            }
            if (!PasswordTextBox.Text.Equals(PasswordTextBox2.Text))
            {
                MessageBox.Show("Пароли не равны!");
                return;
            }
            if (String.IsNullOrWhiteSpace(LoginTextBox.Text) ||
            String.IsNullOrWhiteSpace(PasswordTextBox.Text) ||
            String.IsNullOrWhiteSpace(First_NameTextBox.Text) ||
            String.IsNullOrWhiteSpace(Second_NameTextBox.Text) ||
            !PhonemaskedTextBox.MaskCompleted)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            //Заполнение данных о новом пользователе
            Users users = new Users();
            users.ID = 0;
            users.Login = LoginTextBox.Text;
            users.Password = PasswordTextBox.Text;
            users.Email = EmailTextBox.Text;
            users.Phone = PhonemaskedTextBox.Text;
            users.First_Name = First_NameTextBox.Text;
            users.Second_Name = Second_NameTextBox.Text;
            users.RoleID = (int)RoleIDComboBox.SelectedValue;
            users.Gender = RadioButtonMen.Checked ? "Мужской" : "Женский";
            try
            {
                //сохранение данных в БД
                model.Users.Add(users);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Данные добавленны!");
            Close();

        }
    }
}
