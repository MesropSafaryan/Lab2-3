using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.Education;

namespace LabWork2.AcademicDisciplines
{
    public class English
    {
        public List<Student> PracticeWorks(int reqLevel, bool equipment, int levelUp, Subgroup subgroup, string intellect)
        {
            PracticeWorkEnglish practiceWorkEnglish = new PracticeWorkEnglish();
            return practiceWorkEnglish.PracticeWorkMarking(subgroup, reqLevel, equipment, levelUp);
        }
        public void ModuleControlWork(int reqLevel, Subgroup subgroup, int module)
        {
            ModuleControlWork moduleControlWork = new ModuleControlWork();
            moduleControlWork.ControleWork(subgroup, "English", reqLevel, module);
        }
        public void ModuleMark(Subgroup subgroup, int module)
        {
            ModuleMark moduleMark = new ModuleMark();
            moduleMark.MarkOfModule(subgroup, "English", module);
        }
        public void SemestrMark(Subgroup subgroup)
        {
            SemestrMark semestrMark = new SemestrMark();
            semestrMark.SemestrMarking(subgroup, "English");
        }
    }
}
