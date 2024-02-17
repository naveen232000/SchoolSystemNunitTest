using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchoolLibrary
{
    public class SchoolManagement
    {
        List<Teachers> teachers = new List<Teachers>() {
        new Teachers(){Id=1,Name="Sam",SubjectTeach="Science",Salary=32654, Doj=new DateTime(day:12,month:10,year:2023)},
        new Teachers(){Id=2,Name="Jon",SubjectTeach="Maths",Salary=32564,Doj=new DateTime(day:10,month:11,year:2023)},
        new Teachers(){Id=3,Name="Heen",SubjectTeach="English",Salary=12356,Doj=new DateTime(day:23,month:05,year:2023)},
        new Teachers(){Id=4,Name="Ken",SubjectTeach="Physics",Salary=54123,Doj=new DateTime(day:28,month:04,year:2023)},
        };
        public List<Teachers> AllTeachers()
        {
            return teachers;
        }

        List<Students> students = new List<Students>() {
       new Students(){ Id=101, Name="Naveen", ClassStudy="Class 1",DOB=new DateTime(day:23,month:12,year:2003)},
       new Students(){ Id=102, Name="Ramesh", ClassStudy="Class 2",DOB=new DateTime(day:13,month:02,year:2005)},
       new Students(){ Id=103, Name="Ravi", ClassStudy="Class 3",DOB=new DateTime(day:03,month:04,year:2006)},
       new Students(){ Id=104, Name="Kumar", ClassStudy="Class 4",DOB=new DateTime(day:06,month:10,year:2007)},
        };
        public List<Students> AllStudent()
        {
            return students;
        }

        List<Subjects> subjects = new List<Subjects>() { 
        new Subjects(){Id="MA112",SubjectName="Maths"},
         new Subjects(){Id="SC112",SubjectName="Science"},
          new Subjects(){Id="PY112",SubjectName="Physics"},
          new Subjects(){Id="EN112",SubjectName="English"},

        };
        public List<Subjects> AllSubjects()
        {
            return subjects;
        }
    }
}
