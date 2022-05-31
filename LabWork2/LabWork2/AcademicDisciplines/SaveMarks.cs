using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.Education;
namespace LabWork2.AcademicDisciplines
{
    public class SaveMarks
    {
        string name;
        Mark mark;
        int course, semestr, module;
        public void Save (string Name, Mark Markk, int Course, int Semestr, int Module)
        {
            name = Name;
            mark = Markk;
            course = Course;
            semestr = Semestr;
            module = Module;
        }
        public string GetName() { return name; }
        public int GetCourse() { return course; }
        public int GetSemestr() { return semestr; }
        public int GetModule() { return module; }
        public Mark GetMark() { return mark; }
    }
}
