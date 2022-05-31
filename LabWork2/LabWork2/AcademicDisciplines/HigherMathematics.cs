using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.Education;
namespace LabWork2.AcademicDisciplines
{
    public class HigherMathematics
    {
        public List<Student> PracticeWorks(int reqLevel, int levelUp, Subgroup subgroup)
        {
            PracticeWorkMath practiceWorkMath = new PracticeWorkMath();
            return practiceWorkMath.PracticeWorkMarking(subgroup, reqLevel, levelUp);
        }
        public void ModuleControlWork(int reqLevel, Subgroup subgroup, int module)
        {
            ModuleControlWork moduleControlWork = new ModuleControlWork();
            moduleControlWork.ControleWork(subgroup, "Higher Mathematics", reqLevel, module);
        }
        public void ModuleMark(Subgroup subgroup, int module)
        {
            ModuleMark moduleMark = new ModuleMark();
            moduleMark.MarkOfModule(subgroup, "Higher Mathematics", module);
        }
        public void Coursework(int reqLevel, Subgroup group)
        {
            CourseWork coursework = new CourseWork();
            coursework.CourseMarking(reqLevel, "Higher Mathematics", group);
        }
        public void Exam(int reqLevel, Subgroup group)
        {
            Exam exam = new Exam();
            exam.Examenation(reqLevel, "Higher Mathematics", group);
        }
        public void SemestrMark(Subgroup subgroup)
        {
            SemestrMark semestrMark = new SemestrMark();
            semestrMark.SemestrMarking(subgroup, "Higher Mathematics");
        }
    }
}
