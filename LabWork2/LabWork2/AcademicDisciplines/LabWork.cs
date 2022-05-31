using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.Education;
namespace LabWork2.AcademicDisciplines
{
    internal class LabWork
    {
        Group group;
        Subgroup subgroup;
        Mark labWorkMark = new Mark();
        public string Name { get; set; }
        public Subgroup SubgroupLab { get => subgroup; set => subgroup = value; }
        public List<Student> LabWorkMarking(Subgroup subint, int reqLevel, bool availabilityOfALaboratory, int levelUp)
        {
            if(availabilityOfALaboratory == false)
            {
                throw new Exception("laboratories are missing");
            }
            else
            {
                subgroup = subint;
                for (int i = 0; i < subgroup.Size; i++)
                {
                    labWorkMark.Marking(subgroup.GetStudent(i).PhysicKnowledgeLevel, reqLevel);
                    SaveMarks save = new SaveMarks();
                    save.Save(Name, labWorkMark, subgroup.GetStudent(i).Course, subgroup.GetStudent(i).Semestr,
                        subgroup.GetStudent(i).Module);
                    subgroup.GetStudent(i).LabWorksMarks.Add(save);
                    subgroup.GetStudent(i).PhysicKnowledgeLevel.Level += levelUp;
                }
                return subgroup.GetAllStudent();
            }
        }       
    }

}
