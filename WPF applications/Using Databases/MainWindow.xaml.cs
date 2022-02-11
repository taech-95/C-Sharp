using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Using_Databases
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;
        public MainWindow()
        {
            InitializeComponent();
            string connestionString = ConfigurationManager.ConnectionStrings["Using_Databases.Properties.Settings.C_MasterclassConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connestionString);
            ShowZoos();
            ShowAllAnimals();
        }

        private void ShowZoos()
        {
            try
            {
                string query = "select * from Zoo";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);
                    listZoos.DisplayMemberPath = "Location";
                    listZoos.SelectedValuePath = "Id";
                    listZoos.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
               
            }

        }

        private void ShowAllAnimals()
        {
            try
            {
                string query = "select * from Animal";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                using (sqlDataAdapter)
                {
                    DataTable animalTable = new DataTable();
                    sqlDataAdapter.Fill(animalTable);
                    listOfAnimals.DisplayMemberPath = "Name";
                    listOfAnimals.SelectedValuePath = "Id";
                    listOfAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }

        }


        private void ShowAssociatedAnimals()
        {
            try
            {
                string query = "select * from Animal a inner join ZooAnimal " +
                    "za on a.Id = za.AnimalID where za.ZooID = @ZooID";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooID", listZoos.SelectedValue);
                    DataTable animalTable = new DataTable();
                    sqlDataAdapter.Fill(animalTable);
                    listOfAssociatedAnimals.DisplayMemberPath = "Name";
                    listOfAssociatedAnimals.SelectedValuePath = "Id";
                    listOfAssociatedAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void listZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("Zoo list was clicked!");
            ShowAssociatedAnimals();
        }
    }
 }

