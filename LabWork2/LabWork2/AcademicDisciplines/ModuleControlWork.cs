using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.Education;
namespace LabWork2.AcademicDisciplines
{
    internal class ModuleControlWork
    {
        Subgroup subgroup;
        List<bool> admission;
        List<SaveMarks> saveMarks;       
        public string Discipline(string discipline)
        {
            if(discipline == "English" || discipline == "Physic" || discipline == "Higher Mathematics")
            {
                return discipline;
            }
            else
            {
                throw new Exception("Неправильно вказаний предмет");
            }
        }
        public string Name { get; set; }
        public Subgroup SubgroupPractice { get => subgroup; set => subgroup = value; }
        public void ControleWork(Subgroup sub, string discipline, int req, int module)
        {
            if (Discipline(discipline) == "English")
            {
                Mark moduleWork = new Mark();
                for (int i = 0; i < sub.Size; i++)
                {
                    double val = 0;
                    for (int j = 0; j < sub.GetStudent(i).EngPracWorksMarks.Count; j++)
                    {
                        if (sub.GetStudent(i).EngPracWorksMarks[j].GetModule() == module)
                        {
                            val += sub.GetStudent(i).EngPracWorksMarks[j].GetMark().GetMark;
                        }
                    }
                    if (val <= 0)
                    {
                        throw new Exception("Немає практичних робіт даного модулю");
                    }
                    else
                    {
                        val /= sub.GetStudent(i).EngPracWorksMarks.Count;
                    }
                    if (val > 3)
                    {

                        SaveMarks saveModule = new SaveMarks();
                        moduleWork.Marking(sub.GetStudent(i).EnglishKnowledgeLevel, req);
                        saveModule.Save(Name, moduleWork, sub.GetStudent(i).Course, sub.GetStudent(i).Semestr,
                            module);
                        sub.GetStudent(i).ModuleControlWorksEng.Add(saveModule);
                    }
                }
            }
            else if (Discipline(discipline) == "Higher Mathematics")
            {
                Mark moduleWork = new Mark();
                for (int i = 0; i < sub.Size; i++)
                {
                    double val = 0;
                    for (int j = 0; j < sub.GetStudent(j).MathPracticeWorksMarks.Count; j++)
                    {
                        val += sub.GetStudent(i).MathPracticeWorksMarks[j].GetMark().GetMark;
                    }
                    val /= sub.GetStudent(i).MathPracticeWorksMarks.Count;
                    if (val > 3)
                    {

                        SaveMarks saveModule = new SaveMarks();
                        moduleWork.Marking(sub.GetStudent(i).MathKnowledgeLevel, req);
                        saveModule.Save(Name, moduleWork, sub.GetStudent(i).Course, sub.GetStudent(i).Semestr,
                            sub.GetStudent(i).Module);
                        sub.GetStudent(i).ModuleControlWorksMath.Add(saveModule);
                    }
                }
            }
            else if (Discipline(discipline) == "Physic")
            {
                Mark moduleWork = new Mark();
                for (int i = 0; i < sub.Size; i++)
                {
                    double val = 0;
                    for (int j = 0; j < sub.GetStudent(j).LabWorksMarks.Count; j++)
                    {
                        val += sub.GetStudent(i).LabWorksMarks[j].GetMark().GetMark;
                    }
                    val /= sub.GetStudent(i).LabWorksMarks.Count;
                    if (val > 3)
                    {

                        SaveMarks saveModule = new SaveMarks();
                        moduleWork.Marking(sub.GetStudent(i).PhysicKnowledgeLevel, req);
                        saveModule.Save(Name, moduleWork, sub.GetStudent(i).Course, sub.GetStudent(i).Semestr,
                            sub.GetStudent(i).Module);
                        sub.GetStudent(i).ModuleControlWorksPhysic.Add(saveModule);
                    }
                }
            }

        }

    }
}
