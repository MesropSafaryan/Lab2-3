using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.Education;
namespace LabWork2.AcademicDisciplines
{
    public class CourseWork
    {
        List<bool> admission;
        List<SaveMarks> saveMarks;
        public string Name { get; set; }
        public string Discipline(string discipline)
        {
            if (discipline == "Physic" || discipline == "Higher Mathematics")
            {
                return discipline;
            }
            else
            {
                throw new Exception("Неправильно вказаний предмет");
            }
        }
        public void CourseMarking(int reqLevel, string discipline, Subgroup group)
        {
            if (Discipline(discipline) == "Physic")
            {
                for (int i = 0; i < group.Size; i++)
                {
                    Mark courseWorkMark = new Mark();
                    SaveMarks saveModule = new SaveMarks();
                    courseWorkMark.Marking(group.GetStudent(i).PhysicKnowledgeLevel, reqLevel);
                    saveModule.Save(Name, courseWorkMark, group.GetStudent(i).Course, group.GetStudent(i).Semestr,
                        group.GetStudent(i).Module);
                    group.GetStudent(i).CourseWorkPhysic.Add(saveModule);
                }
            }
            else if(Discipline(discipline) == "Higher Mathematics")
            {
                for (int i = 0; i < group.Size; i++)
                {
                    Mark courseWorkMark = new Mark();
                    SaveMarks saveModule = new SaveMarks();
                    courseWorkMark.Marking(group.GetStudent(i).MathKnowledgeLevel, reqLevel);
                    saveModule.Save(Name, courseWorkMark, group.GetStudent(i).Course, group.GetStudent(i).Semestr,
                        group.GetStudent(i).Module);
                    group.GetStudent(i).CourseWorkMath.Add(saveModule);
                }
            }
        }
    }
}
