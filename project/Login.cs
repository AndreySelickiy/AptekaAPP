using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace project
{
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
                if (textBox1.Text == "admin" & textBox2.Text == "admin")
                {
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show(this);
                }
                else if (textBox1.Text == "user" & textBox2.Text == "user")
                {
                userApp ap1 = new userApp();
                this.Hide();
                ap1.Show(this);
            }
                else MessageBox.Show("Неверный пароль или имя пользователя! Попробуйте заново!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
