using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Net;
using Docvision_Lib;

namespace Docvision_test_task
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=DocvisionDb;Trusted_Connection=True;TrustServerCertificate=True";
        private void ReloadGrid(string connectionString, DataGridView dataGridView1)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("USE DocvisionDb SELECT id AS ID, letters_name AS Имя, addressee AS Адрес, sender AS Отправитель, content AS Содержание, tags AS Тэги FROM Letters;", connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.ReadOnly = true;

            }
            
        }


        public Form1()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            textBoxId.Text = Docvision.AutoId(connectionString);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
                    
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            ReloadGrid(connectionString, dataGridView1);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand($"USE DocvisionDb SELECT*FROM Letters WHERE Letters.id={textBoxId.Text};", connection);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                        while (reader.Read())
                        {
                            textBoxId.Text = Convert.ToString(reader.GetInt32(0));
                            textBoxName.Text = reader.GetString(1);
                            dateTimePicker.Value = reader.GetDateTime(2);
                            textBoxAddressee.Text = reader.GetString(3);
                            textBoxSender.Text = reader.GetString(4);
                            textBoxContent.Text = reader.GetString(5);
                            textBoxTags.Text = reader.GetString(6);
                        }
                            

                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        

        private void buttonAutoId_Click(object sender, EventArgs e)
        {
            textBoxId.Text = Docvision.AutoId(connectionString);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                switch (String.IsNullOrEmpty(textBoxName.Text) | String.IsNullOrEmpty(textBoxAddressee.Text) | String.IsNullOrEmpty(textBoxContent.Text)
                | String.IsNullOrEmpty(textBoxTags.Text))
                {
                    case true:
                        MessageBox.Show("Не все значения заполнены");
                        break;
                    default:
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {

                            SqlCommand command = new SqlCommand($"USE DocvisionDb INSERT INTO Letters (letters_name, letters_date, addressee, sender, content, tags) VALUES ('{textBoxName.Text}', '{dateTimePicker.Value}', '{textBoxAddressee.Text}', '{textBoxSender.Text}', '{textBoxContent.Text}', '{textBoxTags.Text}');", connection);
                            connection.Open();
                            MessageBox.Show($"Запись добавлена, затронуто - {command.ExecuteNonQuery()} строк");
                            connection.Close();
                        }
                        break;
                }
                ReloadGrid(connectionString, dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClearGrid_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.Open();
                        command.CommandText = $"USE DocvisionDb DELETE FROM Letters WHERE Letters.id={textBoxId.Text};";
                        command.Connection = connection;
                        MessageBox.Show($"Удалено строк - {command.ExecuteNonQuery()}");
                        connection.Close();

                    }
                }


                ReloadGrid(connectionString, dataGridView1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonEditLetter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Введите ID");
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            connection.Open();
                            command.CommandText = $"USE DocvisionDb UPDATE Letters" +
                                $" SET letters_name='{textBoxName.Text}', letters_date='{dateTimePicker.Value}', addressee='{textBoxAddressee.Text}', sender='{textBoxSender.Text}', content='{textBoxContent.Text}', tags='{textBoxTags.Text}'" +
                                $" WHERE Letters.id={textBoxId.Text};";
                            command.Connection = connection;
                            MessageBox.Show($"Изменено строк - {command.ExecuteNonQuery()}");
                            connection.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            ReloadGrid(connectionString, dataGridView1);
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxId.Text = Docvision.AutoId(connectionString);
                textBoxName.Text = String.Empty;
                dateTimePicker.Value = DateTime.Now;
                textBoxAddressee.Text = String.Empty;
                textBoxSender.Text = String.Empty;
                textBoxContent.Text = String.Empty;
                textBoxTags.Text = String.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}