using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.Education;
namespace LabWork2.AcademicDisciplines
{
    public class ModuleMark
    {
        public string Name { get; set; }
        public string Discipline(string discipline)
        {
            if (discipline == "English" || discipline == "Physic" || discipline == "Higher Mathematics")
            {
                return discipline;
            }
            else
            {
                throw new Exception("Неправильно вказаний предмет");
            }
        }
        public void MarkOfModule(Subgroup sub, string discipline, int moduleInt)
        {           
            if (Discipline(discipline) == "English")
            {
                
                for(int i = 0; i < sub.Size; i++)
                {
                    Mark module = new Mark();
                    double val = 0;
                    for (int j = 0; j < sub.GetStudent(i).EngPracWorksMarks.Count; j++)
                    {
                        if (sub.GetStudent(i).EngPracWorksMarks[j].GetModule() == moduleInt)
                        {
                            val += sub.GetStudent(i).EngPracWorksMarks[j].GetMark().GetMark;
                        }
                    }
                    double averageModule = 0;
                    for(int j = 0; j < sub.GetStudent(i).ModuleControlWorksEng.Count; j++)
                    {
                        if (sub.GetStudent(i).ModuleControlWorksEng[j].GetModule() == moduleInt)
                        {
                            averageModule += sub.GetStudent(i).ModuleControlWorksEng[j].GetMark().GetMark;
                        }
                    }
                    if(averageModule <= 0 || val <=0)
                    {
                        throw new Exception("Відсутні оцінки за практичні або модульні");
                    }
                    averageModule /= sub.GetStudent(i).ModuleControlWorksEng.Count;
                    val /= sub.GetStudent(i).EngPracWorksMarks.Count;
                    val = (val * 2 + averageModule) / 3;
                    Mark mod = new Mark();
                    mod.GetMark = val;
                    SaveMarks saveModule = new SaveMarks();
                    saveModule.Save(Name, mod, sub.GetStudent(i).Course, sub.GetStudent(i).Semestr,
                        moduleInt);
                    sub.GetStudent(i).ModuleMarksEng.Add(saveModule);
                }
            }
            else if (Discipline(discipline) == "Physic")
            {                
                for (int i = 0; i < sub.Size; i++)
                {
                    Mark module = new Mark();
                    double val = 0;
                    for (int j = 0; j < sub.GetStudent(i).LabWorksMarks.Count; j++)
                    {
                        if (sub.GetStudent(i).LabWorksMarks[j].GetModule() == moduleInt)
                        {
                            val += sub.GetStudent(i).LabWorksMarks[j].GetMark().GetMark;
                        }
                    }
                    double averageModule = 0;
                    for (int j = 0; j < sub.GetStudent(i).ModuleControlWorksPhysic.Count; j++)
                    {
                        if (sub.GetStudent(i).ModuleControlWorksPhysic[j].GetModule() == moduleInt)
                        {
                            averageModule += sub.GetStudent(i).ModuleControlWorksPhysic[j].GetMark().GetMark;
                        }
                    }
                    if (averageModule <= 0 || val <= 0)
                    {
                        throw new Exception("Відсутні оцінки за практичні або модульні");
                    }
                    averageModule /= sub.GetStudent(i).ModuleControlWorksPhysic.Count;
                    val /= sub.GetStudent(i).LabWorksMarks.Count;
                    val = (val * 2 + averageModule) / 3;
                    Mark mod = new Mark();
                    mod.GetMark = val;
                    SaveMarks saveModule = new SaveMarks();
                    saveModule.Save(Name, mod, sub.GetStudent(i).Course, sub.GetStudent(i).Semestr,
                        moduleInt);
                    sub.GetStudent(i).ModuleMarksPhysic.Add(saveModule);
                }
            }
            else if (Discipline(discipline) == "Higher Mathematics")
            {
                
                for (int i = 0; i < sub.Size; i++)
                {
                    Mark module = new Mark();
                    double val = 0;
                    for (int j = 0; j < sub.GetStudent(i).MathPracticeWorksMarks.Count; j++)
                    {
                        if (sub.GetStudent(i).MathPracticeWorksMarks[j].GetModule() == moduleInt)
                        {
                            val += sub.GetStudent(i).MathPracticeWorksMarks[j].GetMark().GetMark;
                        }
                    }
                    double averageModule = 0;
                    for (int j = 0; j < sub.GetStudent(i).ModuleControlWorksMath.Count; j++)
                    {
                        if (sub.GetStudent(i).ModuleControlWorksMath[j].GetModule() == moduleInt)
                        {
                            averageModule += sub.GetStudent(i).ModuleControlWorksMath[j].GetMark().GetMark;
                        }
                    }
                    if (averageModule <= 0 || val <= 0)
                    {
                        throw new Exception("Відсутні оцінки за практичні або модульні");
                    }
                    averageModule /= sub.GetStudent(i).ModuleControlWorksMath.Count;
                    val /= sub.GetStudent(i).MathPracticeWorksMarks.Count;
                    val = (val * 2 + averageModule) / 3;
                    Mark mod = new Mark();
                    mod.GetMark = val;
                    SaveMarks saveModule = new SaveMarks();
                    saveModule.Save(Name, mod, sub.GetStudent(i).Course, sub.GetStudent(i).Semestr,
                        sub.GetStudent(i).Module);
                    sub.GetStudent(i).ModuleMarksMath.Add(saveModule);
                }
            }
        }
    }
}
