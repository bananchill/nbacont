using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nbacont
{
    public partial class auth : Form
    {
        Admin useractive;
        DbController dbController = new DbController();
        int i = 0;
        public auth()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void auth_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (loginbox.Text != "" || passwodbox.Text != "")
            {

                useractive = DbController.Activeus(loginbox.Text, passwodbox.Text);
                if (useractive != null)
                {
                    MessageBox.Show("Здравствйте " + useractive.Name.ToString() + "вы вошли в систему", "Вход");
                    switch (dbController.auto(loginbox.Text, passwodbox.Text))
                    {
                        case "Technical Administrator":
                            visitorform forms = new visitorform(useractive);
                            forms.Show();
                            this.Hide();
                            break;
                        case "Event Administrator":
                            visitorform a = new visitorform(useractive);
                            a.Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("Что-то пошло не так, повторите ввод");
                            break;
                    }
                }
                if (useractive == null)
                {
                    i++;
                    MessageBox.Show("неверный Пароль  или логин ");
                }
                if (i == 3)
                {
                    MessageBox.Show("Три раза введен неверный логин или пароль", "Повторите запуск приложения");
                    this.Close();
                }

            }
            else
            {
                i++;
                MessageBox.Show("Поля не могут быть пустыми");
            }
        }



        private void VisitorButtn_Click(object sender, EventArgs e)
        {
            visitorform forms = new visitorform(useractive);
            forms.Show();
            this.Hide();
        }
    }
}
