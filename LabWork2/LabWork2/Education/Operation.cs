using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.AcademicDisciplines;
namespace LabWork2.Education
{
    public class Operation
    {
        List<Subgroup> subgroups;
        public Group CreateGroup(List<Student> students)
        {
            try
            {
                Group group = new Group(students);
                group.SetSubgroups();
                subgroups = group.GetSubgroups;
                return group;
            }
            catch
            {
                return null;
            }           
        }
        public List<Subgroup> Subgroups { get { return subgroups; } }
        public void PracticeWorksEngModule(int pracCountInModule, bool equipment, int levelUp, Subgroup subgroup, int module)
        {
            if (module == 1)
            {
                for (int i = 0; i < pracCountInModule; i++)
                {
                    PracticeWorkEnglish practice = new PracticeWorkEnglish();
                    practice.Name = "Практична робота " + (i + 1);
                    practice.PracticeWorkMarking(subgroup, (5 + (40 / pracCountInModule) * i), equipment, levelUp);
                }
            }
            else if (module == 2)
            {
                for (int i = 0; i < pracCountInModule; i++)
                {
                    PracticeWorkEnglish practice = new PracticeWorkEnglish();
                    practice.Name = "Практична робота " + (i + 1);
                    practice.PracticeWorkMarking(subgroup, (50 + (40 / pracCountInModule) * i), equipment, levelUp);
                }
            }
            else
            {
                throw new Exception("Програма не передбачає більше двох модулів у семестрі");
            }
        }
        public void LabWorksPhysicsModule(int pracCountInModule, bool laboratory, int levelUp, Subgroup subgroup, int module)
        {
            if (module == 1)
            {
                for (int i = 0; i < pracCountInModule; i++)
                {
                    LabWork labs = new LabWork();
                    labs.Name = "Лабораторна робота " + (i + 1);
                    labs.LabWorkMarking(subgroup, (5 + (35 / pracCountInModule) * i), laboratory, levelUp);
                }
            }
            else if (module == 2)
            {
                for (int i = 0; i < pracCountInModule; i++)
                {
                    LabWork labs = new LabWork();
                    labs.Name = "Лабораторна робота " + (i + 1);
                    labs.LabWorkMarking(subgroup, (45 + (35 / pracCountInModule) * i), laboratory, levelUp);
                }
            }
            else
            {
                throw new Exception("Програма не передбачає більше двох модулів у семестрі");
            }
        }
        public void PracticeWorksMathModule(int pracCountInModule, int levelUp, Subgroup subgroup, int module)
        {
            if (module == 1)
            {
                for (int i = 0; i < pracCountInModule; i++)
                {
                    PracticeWorkMath practice = new PracticeWorkMath();
                    practice.Name = "Практична робота " + (i + 1);
                    practice.PracticeWorkMarking(subgroup, (5 + (40 / pracCountInModule) * i), levelUp);
                }
            }
            else if (module == 2)
            {
                for (int i = 0; i < pracCountInModule; i++)
                {
                    PracticeWorkMath practice = new PracticeWorkMath();
                    practice.Name = "Практична робота " + (i + 1);
                    practice.PracticeWorkMarking(subgroup, (50 + (40 / pracCountInModule) * i), levelUp);
                }
            }
            else
            {
                throw new Exception("Програма не передбачає більше двох модулів у семестрі");
            }
        }
        public void SessionEnglish(int pracCountInModule, bool equipment, int levelUp, Subgroup subgroup)
        {
            PracticeWorksEngModule(pracCountInModule, equipment, levelUp, subgroup, 1);
            ModuleControlWork moduleControlWork1 = new ModuleControlWork();
            moduleControlWork1.Name = "Модульна контрольна робота 1";
            moduleControlWork1.ControleWork(subgroup, "English", 48, 1);
            ModuleMark module1Mark = new ModuleMark();
            module1Mark.Name = "Оцінка за перший модуль";
            module1Mark.MarkOfModule(subgroup, "English", 1);
            PracticeWorksEngModule(pracCountInModule, equipment, levelUp, subgroup, 2);
            ModuleControlWork moduleControlWork2 = new ModuleControlWork();
            moduleControlWork2.Name = "Модульна контрольна робота 2";
            moduleControlWork2.ControleWork(subgroup, "English", 93, 2);
            ModuleMark module2Mark = new ModuleMark();
            module2Mark.Name = "Оцінка за другий модуль";
            module2Mark.MarkOfModule(subgroup, "English", 2);
            SemestrMark semestrMark = new SemestrMark();
            semestrMark.SemestrMarking(subgroup, "English");
        }
        public void SessionPhysics(int pracCountInModule, bool laboratory, int levelUp, Subgroup subgroup)
        {
            LabWorksPhysicsModule(pracCountInModule, laboratory, levelUp, subgroup, 1);
            ModuleControlWork moduleControlWork1 = new ModuleControlWork();
            moduleControlWork1.Name = "Модульна контрольна робота 1";
            moduleControlWork1.ControleWork(subgroup, "Physic", 43, 1);
            ModuleMark module1Mark = new ModuleMark();
            module1Mark.Name = "Оцінка за перший модуль";
            module1Mark.MarkOfModule(subgroup, "Physic", 1);
            LabWorksPhysicsModule(pracCountInModule, laboratory, levelUp, subgroup, 2);
            ModuleControlWork moduleControlWork2 = new ModuleControlWork();
            moduleControlWork2.Name = "Модульна контрольна робота 2";
            moduleControlWork2.ControleWork(subgroup, "Physic", 83, 2);
            ModuleMark module2Mark = new ModuleMark();
            module2Mark.Name = "Оцінка за другий модуль";
            module2Mark.MarkOfModule(subgroup, "Physic", 2);
            CourseWork courseWork1 = new CourseWork();
            courseWork1.Name = "Курсова робота";
            courseWork1.CourseMarking(89, "Phisyc", subgroup);
            Exam exam = new Exam();
            exam.Name = "Екзамен з Фізики";
            exam.Examenation(95, "Physic", subgroup);
            SemestrMark semestrMark = new SemestrMark();
            semestrMark.SemestrMarking(subgroup, "Physic");
        }
        public void SessionMath(int pracCountInModule, int levelUp, Subgroup subgroup)
        {
            PracticeWorksMathModule(pracCountInModule, levelUp, subgroup, 1);
            ModuleControlWork moduleControlWork1 = new ModuleControlWork();
            moduleControlWork1.Name = "Модульна контрольна робота 1";
            moduleControlWork1.ControleWork(subgroup, "Physic", 43, 1);
            ModuleMark module1Mark = new ModuleMark();
            module1Mark.Name = "Оцінка за перший модуль";
            module1Mark.MarkOfModule(subgroup, "Higher Mathematics", 1);
            PracticeWorksMathModule(pracCountInModule, levelUp, subgroup, 2);
            ModuleControlWork moduleControlWork2 = new ModuleControlWork();
            moduleControlWork2.Name = "Модульна контрольна робота 2";
            moduleControlWork2.ControleWork(subgroup, "Higher Mathematics", 83, 2);
            ModuleMark module2Mark = new ModuleMark();
            module2Mark.Name = "Оцінка за другий модуль";
            module2Mark.MarkOfModule(subgroup, "Higher Mathematics", 2);
            CourseWork courseWork1 = new CourseWork();
            courseWork1.Name = "Курсова робота";
            courseWork1.CourseMarking(89, "Higher Mathematics", subgroup);
            Exam exam = new Exam();
            exam.Name = "Екзамен з вищої математики";
            exam.Examenation(95, "Higher Mathematics", subgroup);
            SemestrMark semestrMark = new SemestrMark();
            semestrMark.SemestrMarking(subgroup, "Physic");

        }
    }
}
