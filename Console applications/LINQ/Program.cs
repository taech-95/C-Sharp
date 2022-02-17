using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            University_Manager um = new University_Manager();
            um.MaleStudents();
            um.SortedStudents();
            um.AllStudentsFromBejing();
            int id;
            try
            {
                 id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                throw;
            }

            um.ReceiveStudentsUniversity(id);
          
            um.ReceiveStudentsUniversity(1);

            int[] someInts = { 30, 12, 14, 56, 72, 13, 17, 22, 33 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();
            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;
            um.StudentAndUniviersityNames();
            Console.ReadLine();


        }
    }
}
