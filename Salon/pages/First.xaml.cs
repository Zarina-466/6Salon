using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Salon.pages
{
    public partial class First : Page
    {
        private string connectionString = "Data Source=DESKTOP-0LPQU2O;Initial Catalog=parikmaher;Integrated Security=True"; 

        public First()
        {
            InitializeComponent();
            LoadData();
        }

        // Метод для загрузки данных из базы данных
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Zapisi"; // Название вашей таблицы
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Привязываем данные к DataGrid
                    RecordsDataGrid.ItemsSource = dataTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        // Метод для добавления записи
        private void AddZapisi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Zapisi (Client, Master, Service, Date, Time, Status) VALUES (@Client, @Master, @Service, @Date, @Time, @Status)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Client", "Новый клиент");
                    command.Parameters.AddWithValue("@Master", "Новый мастер");
                    command.Parameters.AddWithValue("@Service", "Новая услуга");
                    command.Parameters.AddWithValue("@Date", DateTime.Now);
                    command.Parameters.AddWithValue("@Time", DateTime.Now.TimeOfDay);
                    command.Parameters.AddWithValue("@Status", "Запланировано");

                    command.ExecuteNonQuery();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления записи: {ex.Message}");
            }
        }

        // Метод для редактирования записи
        private void EditZapisi_Click(object sender, RoutedEventArgs e)
        {
            if (RecordsDataGrid.SelectedItem is DataRowView row)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Zapisi SET Client = @Client, Master = @Master, Service = @Service, Date = @Date, Time = @Time, Status = @Status WHERE ID = @ID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID", row["ID"]);
                        command.Parameters.AddWithValue("@Client", "Изменённый клиент");
                        command.Parameters.AddWithValue("@Master", row["Master"]);
                        command.Parameters.AddWithValue("@Service", row["Service"]);
                        command.Parameters.AddWithValue("@Date", row["Date"]);
                        command.Parameters.AddWithValue("@Time", row["Time"]);
                        command.Parameters.AddWithValue("@Status", "Изменённый статус");

                        command.ExecuteNonQuery();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка редактирования записи: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования.");
            }
        }

        // Метод для удаления записи
        private void DeleteZapisi_Click(object sender, RoutedEventArgs e)
        {
            if (RecordsDataGrid.SelectedItem is DataRowView row)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Zapisi WHERE ID = @ID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID", row["ID"]);

                        command.ExecuteNonQuery();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления записи: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.");
            }
        }
    }
}