using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.Education;
namespace LabWork2.AcademicDisciplines
{
    internal class PracticeWorkMath
    {
        Group group;
        Subgroup subgroup;
        Mark practiceWorkMark = new Mark();
        public string Name { get; set; }
        public Subgroup SubgroupPractice { get => subgroup; set => subgroup = value; }
        public List<Student> PracticeWorkMarking(Subgroup subint, int reqLevel, int levelUp)
        {
            subgroup = subint;
            for (int i = 0; i < subgroup.Size; i++)
            {
                practiceWorkMark.Marking(subgroup.GetStudent(i).MathKnowledgeLevel, reqLevel);
                SaveMarks save = new SaveMarks();
                save.Save(Name, practiceWorkMark, subgroup.GetStudent(i).Course, subgroup.GetStudent(i).Semestr,
                    subgroup.GetStudent(i).Module);
                subgroup.GetStudent(i).MathPracticeWorksMarks.Add(save);
                subgroup.GetStudent(i).MathKnowledgeLevel.Level += levelUp;
            }
            return subgroup.GetAllStudent();
        }
    }
}
