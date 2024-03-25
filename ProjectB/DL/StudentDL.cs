using Guna.UI2.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace MidProjectEven.Classes.DL
{
    public class StudentDL
    {
        static public List<Student> List = new List<Student>();

        public static void ClearStudents()
        {
            List.Clear();
        }


        public static void Add_Students(Student student)
        {
            List.Add(student);
        }
        public static void RemoveFromList(Student student)
        {
            List.Remove(student);
        }




    }
}
