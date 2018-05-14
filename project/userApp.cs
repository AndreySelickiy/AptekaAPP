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

    public partial class userApp : Form
    {

        MySqlConnection MySqlConnection;
        public userApp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userApp_Load(object sender, EventArgs e)
        {
            string conStr = "server = localhost; user = root; database = mydb; password = root; ";
            MySqlConnection = new MySqlConnection(conStr);
            MySqlConnection.Open();
            MySqlDataReader reader = null;
            MySqlCommand command = new MySqlCommand("SELECT * FROM people", MySqlConnection);
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(Convert.ToString(reader["worker_id"]) + " " + Convert.ToString(reader["f_name"]) + " " + Convert.ToString(reader["l_name"]) + " " + Convert.ToString(reader["position"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
            MySqlDataReader reader = null;
            MySqlCommand command = new MySqlCommand("SELECT * FROM people", MySqlConnection);
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox6.Items.Add(Convert.ToString(reader["worker_id"]) + " " + Convert.ToString(reader["f_name"]) + " " + Convert.ToString(reader["l_name"]) + " " + Convert.ToString(reader["position"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
        //Расчет ЗП 

        private void расчетToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
            MySqlDataReader reader = null;
            MySqlCommand command = new MySqlCommand("SELECT * FROM zp", MySqlConnection);

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
        private void userApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MySqlConnection != null && MySqlConnection.State != ConnectionState.Closed)
                MySqlConnection.Close();
        }


        private void показатьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
            MySqlDataReader reader = null;
            MySqlCommand command = new MySqlCommand("SELECT * FROM people", MySqlConnection);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            


        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
          
            
        }
        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }
        private async void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }


        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button9_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO preparat (nazv_prep, kol_vo, price_zakup, price_real) VALUES (@nazv_prep, @kol_vo, @price_zakup, @price_real)", MySqlConnection);
            command.Parameters.AddWithValue("nazv_prep", textBox15.Text);
            command.Parameters.AddWithValue("kol_vo", textBox13.Text);
            command.Parameters.AddWithValue("price_zakup", textBox10.Text);
            command.Parameters.AddWithValue("price_real", textBox2.Text);
            MySqlDataReader reader = null;
            MySqlCommand commands = new MySqlCommand("SELECT *, MAX ('prepp_id')", MySqlConnection);
            try
            {
                reader = commands.ExecuteReader();
                while (reader.Read())
                {
                    double f, s;
                    f = Convert.ToDouble(reader["prepp_id"]);

                    s = f + 1;
                    MySqlCommand com = new MySqlCommand("INSERT INTO preparat (prep_id) VALUES (@prepp_id)");
                    com.Parameters.AddWithValue("@prepp_id", s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }


        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private  void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO preparat (nazv_prep, kol_vo, price_zakup, price_real) VALUES (@nazv_prep, @kol_vo, @price_zakup, @price_real)", MySqlConnection);
            command.Parameters.AddWithValue("nazv_prep", textBox15.Text);
            command.Parameters.AddWithValue("kol_vo", textBox13.Text);
            command.Parameters.AddWithValue("price_zakup", textBox10.Text);
            command.Parameters.AddWithValue("price_real", textBox2.Text);
            command.ExecuteNonQuery();
            MySqlDataReader reader = null;
            MySqlCommand commands = new MySqlCommand("SELECT *, MAX ('prepp_id')", MySqlConnection);
            try
            {
                reader = commands.ExecuteReader();
                while (reader.Read())
                {
                    double f, s;
                    f = Convert.ToDouble(reader["prepp_id"]);
                    s = f + 1;
                    MySqlCommand com = new MySqlCommand("INSERT INTO preparat (prepp_id) VALUES (@prepp_id)");
                    com.Parameters.AddWithValue("@prepp_id", s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

            listBox6.Items.Clear();
            MySqlDataReader reader = null;
            MySqlCommand command = new MySqlCommand("SELECT * FROM preparat", MySqlConnection);
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    listBox6.Items.Add(Convert.ToString(reader["prepp_id"]) + " " + Convert.ToString(reader["nazv_prep"]) + " " + Convert.ToString(reader["kol_vo"]) + " " + Convert.ToString(reader["price_zakup"] + " " + Convert.ToString(reader["price_real"])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

        }

        private async void button11_Click_1(object sender, EventArgs e)
        {
         
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO preparat (nazv_prep, kol_vo, price_zakup, price_real) VALUES (@nazv_prep, @kol_vo, @price_zakup, @price_real)", MySqlConnection);
            command.Parameters.AddWithValue("nazv_prep", textBox15.Text);
            command.Parameters.AddWithValue("kol_vo", textBox13.Text);
            command.Parameters.AddWithValue("price_zakup", textBox10.Text);
            command.Parameters.AddWithValue("price_real", textBox2.Text);
            command.ExecuteNonQuery();
            MySqlDataReader reader = null;
            MySqlCommand commands = new MySqlCommand("SELECT *, MAX ('prepp_id')", MySqlConnection);
            try
            {
                reader = commands.ExecuteReader();
                while (reader.Read())
                {
                    double f, s;
                    f = Convert.ToDouble(reader["prepp_id"]);
                    s = f + 1;
                    MySqlCommand com = new MySqlCommand("INSERT INTO preparat (prepp_id) VALUES (@prepp_id)");
                    com.Parameters.AddWithValue("@prepp_id", s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }


        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
        internal class ListBox7

        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO sales (price, koliches, nazv_sp) VALUES (@price, @koliches, @nazv_sp)", MySqlConnection);
            command.Parameters.AddWithValue("price", textBox9.Text);
            command.Parameters.AddWithValue("koliches", textBox8.Text);
            command.Parameters.AddWithValue("nazv_sp", textBox6.Text);
            command.ExecuteNonQuery();
            MySqlDataReader reader = null;
            MySqlCommand commands = new MySqlCommand("SELECT *, MAX ('sales_id')", MySqlConnection);
            try
            {
                reader = commands.ExecuteReader();
                while (reader.Read())
                {
                    double f, s;
                    f = Convert.ToDouble(reader["sales_id"]);

                    s = f + 1;
                    MySqlCommand com = new MySqlCommand("INSERT INTO dillers (sales_id) VALUES (@sales_id)");
                    com.Parameters.AddWithValue("@sales_id", s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            {
                listBox8.Items.Clear();
                MySqlDataReader reader = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM sales", MySqlConnection);
                try
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        listBox8.Items.Add(Convert.ToString(reader["sales_id"]) + " " + Convert.ToString(reader["price"]) + " " + Convert.ToString(reader["koliches"]) + " " + Convert.ToString(reader["nazv_sp"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }
            }
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button14_Click(object sender, EventArgs e)
        {

         
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
            MySqlDataReader reader = null;
            MySqlCommand command = new MySqlCommand("SELECT * FROM preparat", MySqlConnection);
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    listBox6.Items.Add(Convert.ToString(reader["prepp_id"]) + " " + Convert.ToString(reader["nazv_prep"]) + " " + Convert.ToString(reader["kol_vo"]) + " " + Convert.ToString(reader["price_zakup"] + " " + Convert.ToString(reader["price_real"])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
