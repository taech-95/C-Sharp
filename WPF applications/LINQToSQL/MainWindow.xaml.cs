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

namespace LINQToSQL
{
    string answer = '';
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LINQToSQLDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();
            string connestionString = ConfigurationManager.ConnectionStrings
                                        ["LINQToSQL.Properties.Settings.C_MasterclassConnectionString"].ConnectionString;
            dataContext = new LINQToSQLDataContext(connestionString);
            //InsertUniviersities("Kyiv Politech");
            //InsertStudents();
            InsertLectures();
        }

        public void InsertUniviersities(string name)
        {
            University university = new University();
            university.Name = name;
            dataContext.Universities.InsertOnSubmit(university);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {
            //Student student = new Student();
            //student.Name = name;
            //dataContext.Students.InsertOnSubmit(student);
            //dataContext.SubmitChanges();
            //MainDataGrid.ItemsSource = dataContext.Students;
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            University kyivTech = dataContext.Universities.First(un => un.Name.Equals("Kyiv Politech"));
            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Mykola", Gender = "male", UniversityID = kyivTech.Id });
            students.Add(new Student { Name = "Oksana", Gender = "female", UniversityID = yale.Id });
            students.Add(new Student { Name = "Viktor", Gender = "male", UniversityID = yale.Id });
            students.Add(new Student { Name = "Jon", Gender = "male", UniversityID = kyivTech.Id });
            students.Add(new Student { Name = "Jane", Gender = "female", UniversityID = yale.Id });
            students.Add(new Student { Name = "Olena", Gender = "female", UniversityID = kyivTech.Id });

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociation()
        {
            Student Mykola = dataContext.Students.First(st => st.Name.Equals("Mykola"));
            Student Oksana = dataContext.Students.First(st => st.Name.Equals("Oksana"));
            Student Viktor = dataContext.Students.First(st => st.Name.Equals("Viktor"));
            Student Olena = dataContext.Students.First(st => st.Name.Equals("Olena"));
            Lecture Math = dataContext.Lectures.First(lec => lec.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(lec => lec.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Mykola, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Oksana, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Viktor, Lecture = History });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Olena, Lecture = History });
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.StudentLectures;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string answer = null;
            if (answer == "ясно")
            {
                this.Close();
            }
        }
    }
}
