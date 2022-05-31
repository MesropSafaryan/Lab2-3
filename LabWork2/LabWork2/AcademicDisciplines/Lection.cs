using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.Education;
namespace LabWork2.AcademicDisciplines
{
    public class Lection
    {
        List<Group> groups;
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
        public List<Group> Groups { get => groups; set => groups = value; }
        public void ConductingLecture (int levelUp, string discipline)
        {
            if (Discipline(discipline) == "Physic")
            {
                for (int i = 0; i < groups.Count; i++)
                {
                    for (int j = 0; j < groups[i].Size; j++)
                    {
                        groups[i].GetStudent(j).PhysicKnowledgeLevel.Level += levelUp;
                    }
                }
            }
            else if (Discipline(discipline) == "Higher Mathematics")
            {
                for (int i = 0; i < groups.Count; i++)
                {
                    for (int j = 0; j < groups[i].Size; j++)
                    {
                        groups[i].GetStudent(j).MathKnowledgeLevel.Level += levelUp;
                    }
                }
            }
        }
    }
}
