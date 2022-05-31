using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.AcademicDisciplines;
using LabWork2.Education;
namespace LabWork2
{
    internal class ConMenu
    {
        public void StartMenu()
        {
            Console.WriteLine("Оберіть операцію: " +
                "\n1. Переглянути студентів;\n" +
                "2. Сформувати групи та підгрупи;\n" +
                "3. Перейти до симулювати навчання;\n" +
                "4. Завершити;");
        }        
        public int Choice()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public void WriteStudentsBeforeGroups(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(i + ". " + students[i].Name + ", " + students[i].Course + "-го курсу, " + students[i].Age
                    + "років, стать: " + students[i].Gender);
            }
        }
        public void WriteStudentsAfterGroups(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(i + ". " + students[i].Name + ", " + students[i].Course + "-го курсу, група " +
                    "ПІ-101" + ", підгрупа: " + 1 + ", " + students[i].Age + 
                    "років, стать: " + students[i].Gender);
            }
        }
        public void WriteStudentInformation(Student student)
        {
            Console.WriteLine(student.Name + ", " + student.Course + "-го курсу, група " + student.Group
                   + ", підгрупа: " + student + ", " + student.Age + "років, стать: " + student.Gender);
        }
        private string Discipline(string discipline)
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
        public void FirstModuleMarks(List<Student> students)
        {
            for (int i = 0; i < 24; i++)
            {
                WriteStudentInformation(students[i]);
                Console.WriteLine("Оцінки за перший модуль:");
                Console.WriteLine("Англійська мова:");
                for (int j = 0; j < 15; j++)
                {                    
                    Console.WriteLine(students[i].EngPracWorksMarks[j].GetName() + ": " + students[i].EngPracWorksMarks[j].GetMark());
                }
                for (int j = 0; j < students[i].ModuleMarksEng.Count; j++)
                {
                    if (students[i].ModuleMarksEng[j].GetModule() == 1 &&
                        students[i].ModuleMarksEng[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].ModuleMarksEng[j].GetName() + ": " + students[i].ModuleMarksEng[j].GetMark());
                }
                Console.WriteLine("\n======================================================================\n");
                Console.WriteLine("Вища математика:");
                for (int j = 0; j < students[i].EngPracWorksMarks.Count; j++)
                {
                    if (students[i].MathPracticeWorksMarks[j].GetModule() == 1 &&
                        students[i].MathPracticeWorksMarks[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].MathPracticeWorksMarks[j].GetName() + ": " + students[i].MathPracticeWorksMarks[j].GetMark());
                }
                for (int j = 0; j < students[i].ModuleControlWorksMath.Count; j++)
                {
                    if (students[i].ModuleControlWorksMath[j].GetModule() == 1 &&
                        students[i].ModuleControlWorksMath[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].ModuleControlWorksMath[j].GetName() + ": " + students[i].ModuleControlWorksMath[j].GetMark());
                }
                Console.WriteLine("\n======================================================================\n");
                Console.WriteLine("Фізика:");
                for (int j = 0; j < students[i].LabWorksMarks.Count; j++)
                {
                    if (students[i].LabWorksMarks[j].GetModule() == 1 &&
                        students[i].LabWorksMarks[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].LabWorksMarks[j].GetName() + ": " + students[i].LabWorksMarks[j].GetMark());
                }
                for (int j = 0; j < students[i].ModuleControlWorksPhysic.Count; j++)
                {
                    if (students[i].ModuleControlWorksPhysic[j].GetModule() == 1 &&
                        students[i].ModuleControlWorksPhysic[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].ModuleControlWorksPhysic[j].GetName() + ": " + students[i].ModuleControlWorksPhysic[j].GetMark());
                }
            }
        }
        public void SecondModuleMarks(List<Student> students)
        {
            Console.WriteLine("Оцінки за другий модуль:");
            Console.WriteLine("Англійська мова:");
            for (int i = 0; i < students.Count; i++)
            {
                WriteStudentInformation(students[i]);
                
                for (int j = 0; j < students[i].EngPracWorksMarks.Count; j++)
                {
                    if (students[i].EngPracWorksMarks[j].GetModule() == 2 &&
                        students[i].EngPracWorksMarks[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].EngPracWorksMarks[j].GetName() + ": " + students[i].EngPracWorksMarks[j].GetMark());
                }
                for (int j = 0; j < students[i].ModuleMarksEng.Count; j++)
                {
                    if (students[i].ModuleMarksEng[j].GetModule() == 2 &&
                        students[i].ModuleMarksEng[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].ModuleMarksEng[j].GetName() + ": " + students[i].ModuleMarksEng[j].GetMark());
                }
                Console.WriteLine("\n======================================================================\n");
                Console.WriteLine("Вища математика:");
                for (int j = 0; j < students[i].EngPracWorksMarks.Count; j++)
                {
                    if (students[i].MathPracticeWorksMarks[j].GetModule() == 2 &&
                        students[i].MathPracticeWorksMarks[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].MathPracticeWorksMarks[j].GetName() + ": " + students[i].MathPracticeWorksMarks[j].GetMark());
                }
                for (int j = 0; j < students[i].ModuleControlWorksMath.Count; j++)
                {
                    if (students[i].ModuleControlWorksMath[j].GetModule() == 2 &&
                        students[i].ModuleControlWorksMath[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].ModuleControlWorksMath[j].GetName() + ": " + students[i].ModuleControlWorksMath[j].GetMark());
                }
                Console.WriteLine("\n======================================================================\n");
                Console.WriteLine("Фізика:");
                for (int j = 0; j < students[i].LabWorksMarks.Count; j++)
                {
                    if (students[i].LabWorksMarks[j].GetModule() == 2 &&
                        students[i].LabWorksMarks[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].LabWorksMarks[j].GetName() + ": " + students[i].LabWorksMarks[j].GetMark());
                }
                for (int j = 0; j < students[i].ModuleControlWorksPhysic.Count; j++)
                {
                    if (students[i].ModuleControlWorksPhysic[j].GetModule() == 2 &&
                        students[i].ModuleControlWorksPhysic[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].ModuleControlWorksPhysic[j].GetName() + ": " + students[i].ModuleControlWorksPhysic[j].GetMark());
                }
            }
        }
        public void EndOfSemestr(List<Student> students)
        {
            Console.WriteLine("Оцінки за кінцівку семестра:");
            for (int i = 0; i < students.Count; i++)
            {
                WriteStudentInformation(students[i]);
                Console.WriteLine("Англійська мова:");
                Console.WriteLine("Семестрова оцінка з англійської:");
                for (int j = 0; j < students[i].SemestrMarksEng.Count; j++)
                {
                    if(students[i].SemestrMarksEng[j].GetSemestr() == students[i].Semestr)
                    Console.WriteLine(students[i].SemestrMarksEng[j].GetMark());
                }
                Console.WriteLine("\n======================================================================\n");
                Console.WriteLine("Вища математика:");
                Console.WriteLine("Курсова робота:");
                for (int j = 0; j < students[i].CourseWorkMath.Count; j++)
                {
                    if (students[i].CourseWorkMath[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].CourseWorkMath[j].GetMark());
                }
                Console.WriteLine("Екзамен:");
                for (int j = 0; j < students[i].ExamMarksMath.Count; j++)
                {
                    if (students[i].ExamMarksMath[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].ExamMarksMath[j].GetMark());
                }
                Console.WriteLine("Семестрова оцінка:");
                for (int j = 0; j < students[i].SemestrMarksMath.Count; j++)
                {
                    if (students[i].SemestrMarksMath[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].SemestrMarksMath[j].GetMark());
                }
                Console.WriteLine("\n======================================================================\n");
                Console.WriteLine("Фізика:");
                Console.WriteLine("Курсова робота:");
                for (int j = 0; j < students[i].CourseWorkPhysic.Count; j++)
                {
                    if (students[i].CourseWorkMath[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].CourseWorkPhysic[j].GetMark());
                }
                Console.WriteLine("Екзамен:");
                for (int j = 0; j < students[i].ExamMarksPhysic.Count; j++)
                {
                    if (students[i].ExamMarksPhysic[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].ExamMarksPhysic[j].GetMark());
                }
                Console.WriteLine("Семестрова оцінка:");
                for (int j = 0; j < students[i].SemestrMarksPhysic.Count; j++)
                {
                    if (students[i].SemestrMarksPhysic[j].GetSemestr() == students[i].Semestr)
                        Console.WriteLine(students[i].SemestrMarksPhysic[j].GetMark());
                }
            }
        }
        
    }
}
