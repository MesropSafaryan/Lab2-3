using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.Education;
namespace LabWork2.AcademicDisciplines
{
    public class Physics
    {
        public List<Student> LabWorks(int reqLevel, int levelUp, bool laboratory, Subgroup subgroup)
        {
            LabWork lab = new LabWork();
            return lab.LabWorkMarking(subgroup, reqLevel, laboratory, levelUp);
        }
        public void ModuleControlWork(int reqLevel, Subgroup subgroup, int module)
        {
            ModuleControlWork moduleControlWork = new ModuleControlWork();
            moduleControlWork.ControleWork(subgroup, "Physic", reqLevel, module);
        }
        public void ModuleMark(Subgroup subgroup, int module)
        {
            ModuleMark moduleMark = new ModuleMark();
            moduleMark.MarkOfModule(subgroup, "Physic", module);
        }
        public void Coursework(int reqLevel, Subgroup group)
        {
            CourseWork coursework = new CourseWork();
            coursework.CourseMarking(reqLevel, "Physic", group);
        }
        public void Exam(int reqLevel, Subgroup group)
        {
            Exam exam = new Exam();
            exam.Examenation(reqLevel, "Physic", group);
        }
        public void SemestrMark(Subgroup subgroup)
        {
            SemestrMark semestrMark = new SemestrMark();
            semestrMark.SemestrMarking(subgroup, "Physic");
        }
    }
}