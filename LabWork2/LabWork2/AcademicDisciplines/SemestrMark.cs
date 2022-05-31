using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.Education;
namespace LabWork2.AcademicDisciplines
{
    public class SemestrMark
    {
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
        public void SemestrMarking(Subgroup subgroup, string discipline)
        {

            if (Discipline(discipline) == "English")
            {
                Mark semestrWork = new Mark();                
                for (int i = 0; i < subgroup.Size; i++)
                {
                    double val = 0;
                    for (int j = 0; j < subgroup.GetStudent(i).ModuleMarksEng.Count; j++)
                    {
                        val += subgroup.GetStudent(i).ModuleMarksEng[j].GetMark().GetMark;
                    }
                    val /= subgroup.GetStudent(i).ModuleMarksEng.Count;
                    semestrWork.GetMark = val;
                    SaveMarks saveModule = new SaveMarks();
                    saveModule.Save(("Оцінка за " + subgroup.GetStudent(i).Semestr + " семестр"), semestrWork,
                        subgroup.GetStudent(i).Course, subgroup.GetStudent(i).Semestr, subgroup.GetStudent(i).Module);
                    subgroup.GetStudent(i).SemestrMarksEng.Add(saveModule);
                }
            }
            else if (Discipline(discipline) == "Physic")
            {
                Mark semestrWork = new Mark();
                for (int i = 0; i < subgroup.Size; i++)
                {
                    double val = 0;
                    for (int j = 0; j < subgroup.GetStudent(i).ModuleMarksPhysic.Count; j++)
                    {
                        val += subgroup.GetStudent(i).ModuleMarksPhysic[j].GetMark().GetMark;
                    }
                    val /= subgroup.GetStudent(i).ModuleMarksPhysic.Count;
                    val = (val * 8 + subgroup.GetStudent(i).CourseWorkPhysic[0].GetMark().GetMark * 4) / 12;
                    val = (val * 6 + subgroup.GetStudent(i).ExamMarksPhysic[0].GetMark().GetMark * 4) / 10;
                    semestrWork.GetMark = val;
                    SaveMarks saveModule = new SaveMarks();
                    saveModule.Save(("Оцінка за " + subgroup.GetStudent(i).Semestr + " семестр"), semestrWork,
                        subgroup.GetStudent(i).Course, subgroup.GetStudent(i).Semestr, subgroup.GetStudent(i).Module);
                    subgroup.GetStudent(i).SemestrMarksPhysic.Add(saveModule);
                }
            }
            else if (Discipline(discipline) == "Higher Mathematics")
            {
                Mark semestrWork = new Mark();
                for (int i = 0; i < subgroup.Size; i++)
                {
                    double val = 0;
                    for (int j = 0; j < subgroup.GetStudent(i).ModuleMarksMath.Count; j++)
                    {
                        val += subgroup.GetStudent(i).ModuleMarksMath[j].GetMark().GetMark;
                    }
                    val /= subgroup.GetStudent(i).ModuleMarksMath.Count;
                    val = (val * 8 + subgroup.GetStudent(i).CourseWorkMath[0].GetMark().GetMark * 4) / 12;
                    val = (val * 6 + subgroup.GetStudent(i).ExamMarksMath[0].GetMark().GetMark * 4) / 10;
                    semestrWork.GetMark = val;
                    SaveMarks saveModule = new SaveMarks();
                    saveModule.Save(("Оцінка за " + subgroup.GetStudent(i).Semestr + " семестр"), semestrWork,
                        subgroup.GetStudent(i).Course, subgroup.GetStudent(i).Semestr, subgroup.GetStudent(i).Module);
                    subgroup.GetStudent(i).SemestrMarksMath.Add(saveModule);
                }
            }
        }
    }
}
