using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.Education;
namespace LabWork2.AcademicDisciplines
{
    internal class PracticeWorkEnglish
    {
        Group group;
        Subgroup subgroup;
        Mark practiceWorkMark = new Mark();
        public string Name { get; set; }
        public Subgroup SubgroupPractice { get => subgroup; set => subgroup = value; }
        public List<Student> PracticeWorkMarking(Subgroup subint, int reqLevel, bool soundEquipment, double levelUp)
        {
            if (soundEquipment == false)
            {
                throw new Exception("Sound equipment are missing");
            }
            else
            {
                subgroup = subint;
                for (int i = 0; i < subgroup.Size; i++)
                {
                    practiceWorkMark.Marking(subgroup.GetStudent(i).EnglishKnowledgeLevel, reqLevel);
                    SaveMarks save = new SaveMarks();
                    save.Save(Name, practiceWorkMark, subgroup.GetStudent(i).Course, subgroup.GetStudent(i).Semestr,
                        subgroup.GetStudent(i).Module);
                    subgroup.GetStudent(i).EngPracWorksMarks.Add(save);
                    subgroup.GetStudent(i).EnglishKnowledgeLevel.Level += levelUp * subgroup.GetStudent(i).GetIntellect;
                    
                    
                }
                return subgroup.GetAllStudent();
            }
        }
    }
}
