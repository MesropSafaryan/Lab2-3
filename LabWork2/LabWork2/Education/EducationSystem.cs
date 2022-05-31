using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2.Education
{
    public class EducationSystem
    {
        LevelOfKnowledge levelOfKnowledge;
        Lection lection = new Lection();
        private List<Mark> PracticeWork;
        private List<Mark> PracticeWorkModule1;
        private List<Mark> PracticeWorkModule2;
        private List<Mark> labWork;
        Mark Controlmark, exam, courseWork;
        private List<Mark> moduleMarks;
        private bool admission, soundReproducingEquipment, admissionExam, labWorkRoom;
        private int numOfModule = 1, semestr = 1;
        public int NumOfModule { get => numOfModule; }
        public Lection LectionLesson(int intellect)
        {
            lection.EducationProc(levelOfKnowledge, 2, intellect);
            return lection;
        }
        public List<Mark> GetPracticeWorks { get => PracticeWork; }
        public List<Mark> GetLabWorks { get => labWork; }
        public List<Mark> GetPracticeModule1Marks { get => PracticeWorkModule1; }
        public List<Mark> GetPracticeModule2Marks { get => PracticeWorkModule2; }
        public Mark PracticeWorkMarks(int reqLevel)
        {
            if (soundReproducingEquipment == true)
            {
                Mark mark = new Mark();
                mark.Marking(levelOfKnowledge, reqLevel);
                PracticeWork.Add(mark);
                levelOfKnowledge.Level += reqLevel / 3;
                return mark;
            }
            else
            {
                throw new Exception("Sound Reproducing Equipment don't exist");
            }
        }
        public Mark PracticeWorkMath(int reqLevel)
        {
            Mark mark = new Mark();
            mark.Marking(levelOfKnowledge, reqLevel);
            PracticeWork.Add(mark);
            levelOfKnowledge.Level += reqLevel / 3;
            return mark;           
        }
        public Mark LabWorkMarks(int reqLevel)
        {
            if (labWorkRoom == true)
            {
                Mark mark = new Mark();
                mark.Marking(levelOfKnowledge, reqLevel);
                labWork.Add(mark);
                return mark;
            }
            else
            {
                throw new Exception("Lab Work Room don't exist");
            }
        }
        public List<Mark> LabWorkAll { get => labWork; }
        public List<Mark> ModuleMarksAll { get => moduleMarks; }

        private bool Admission()
        {
            if (PracticeWorkModule1.Count != 0)
            {
                double sum = 0;
                for (int i = 0; i < PracticeWork.Count; i++)
                {
                    sum += PracticeWork[i].GetMark;
                }
                sum /= PracticeWork.Count;
                if (sum < 3 * PracticeWork.Count)
                {
                    admission = false;
                    return false;
                }
                else
                {
                    admission = true;
                    return true;
                }
            }
            else
            {
                admission = false;
                return false;
            }
        }
        private bool AdmissionPhisics()
        {
            if (PracticeWorkModule1.Count != 0)
            {
                double sum = 0;
                for (int i = 0; i < LabWorkAll.Count; i++)
                {
                    sum += PracticeWork[i].GetMark;
                }
                sum /= PracticeWork.Count;
                if (sum < 3 * PracticeWork.Count)
                {
                    admission = false;
                    return false;
                }
                else
                {
                    admission = true;
                    return true;
                }
            }
            else
            {
                admission = false;
                return false;
            }
        }
        public bool SoundReproducingEquipment(bool equipment)
        {
            soundReproducingEquipment = equipment;
            return soundReproducingEquipment;
        }
        public bool LabWorkRoom(bool room)
        {
            labWorkRoom = room;
            return labWorkRoom;
        }
        public Mark ModuleControlWork(int reqLevel, int module)
        {
            if (Admission() == true)
            {
                Controlmark = new Mark();
                Controlmark.Marking(levelOfKnowledge, reqLevel);
                if (module == 1)
                {
                    PracticeWorkModule1 = PracticeWork;
                    PracticeWork.Clear();
                }
                else if (module == 2)
                {
                    PracticeWorkModule2 = PracticeWork;
                    PracticeWork.Clear();
                }
                else
                {
                    throw new Exception("Error module number");
                }
                return Controlmark;
            }
            else
            {
                return null;
            }
        }

        public Mark ModuleMark()
        {
            double sum = 0;
            for (int i = 0; i < PracticeWork.Count; i++)
            {
                sum += PracticeWork[i].GetMark;
            }
            sum = sum / PracticeWorkModule1.Count;
            sum = (sum + Controlmark.GetMark) / 2;
            Mark mark = new Mark();
            mark.GetMark = sum;
            moduleMarks.Add(mark);
            if (numOfModule == 1)
            {
                PracticeWorkModule1 = PracticeWork;
                PracticeWork.Clear();
                numOfModule++;
            }
            else if (numOfModule == 2)
            {
                PracticeWorkModule2 = PracticeWork;
                PracticeWork.Clear();
                numOfModule = 1;
            }
            return mark;
        }
        public Mark CourseWork(int reqLevel)
        {
            courseWork = new Mark();
            courseWork.Marking(levelOfKnowledge, reqLevel);
            return courseWork;
        }
        public bool AdmissionExam()
        {
            double sum = 0;
            for (int i = 0; i < moduleMarks.Count; i++)
            {
                sum += moduleMarks[i].GetMark;
            }
            sum /= moduleMarks.Count;
            sum = (sum * 8 + courseWork.GetMark * 4) / 12;
            if (sum < 3)
            {
                admissionExam = false;
                return false;
            }
            else
            {
                admissionExam = true;
                return true;
            }
        }
        public Mark Exam(int reqLevel)
        {
            if (admissionExam == true)
            {
                exam = new Mark();
                exam.Marking(levelOfKnowledge, reqLevel);
                return exam;
            }
            else
            {
                return null;
            }
        }
        public Mark SemestrMarkForEnglish()
        {
            double sum = 0;
            for (int i = 0; i < moduleMarks.Count; i++)
            {
                sum += moduleMarks[i].GetMark;
            }
            sum /= moduleMarks.Count;
            Mark mark = new Mark();
            mark.GetMark = sum;
            numOfModule = 1;
            if (semestr == 1)
            {
                semestr = 2;
            }
            else if (semestr == 2)
            {
                semestr = 1;
            }
            return mark;
        }
        public Mark SemestrMark()
        {
            double sum = 0;
            for (int i = 0; i < moduleMarks.Count; i++)
            {
                sum += moduleMarks[i].GetMark;
            }
            sum = (sum * 8 + courseWork.GetMark * 4) / 12;
            sum = (sum * 12 + exam.GetMark * 8) / 20;
            Mark mark = new Mark();
            mark.GetMark = sum;
            return mark;
        }
    }
}
