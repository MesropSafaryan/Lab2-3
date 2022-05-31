using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.AcademicDisciplines;
using LabWork2.Education;
namespace LabWork2
{
    public class Student : Human
    {
        English english = new English();
        Physics physics = new Physics();
        HigherMathematics higherMathematics = new HigherMathematics();
        LevelOfKnowledge levelOfKnowledgeEnglish;
        LevelOfKnowledge levelOfKnowledgePhysics;
        LevelOfKnowledge levelOfKnowledgeMath;
        string group, studentID, subgroup;
        bool availabilityOfAComputer;
        int course, semestr, module;
        double intellectCoef;
        public string Group { get => group; set => group = value; }
        public string Subgroup { get => subgroup; set => subgroup = value; }
        public int Semestr { get => semestr; set => semestr = value; }
        public int Module { get => module; set => module = value; }
        public bool AvailabilityOfAComputer { get => availabilityOfAComputer; set => availabilityOfAComputer = value; }
        public int Course { get => course; set => course = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public double IntellectLevel(string str) 
        {
            if (str == "відмінний")
            {
                return intellectCoef = 1;
            }
            else if (str == "хороший")
            {
                return intellectCoef = 0.8;
            }
            else if (str == "середній")
            {
                return intellectCoef = 0.6;
            }
            else if (str == "низький")
            {
                return intellectCoef = 0.3;
            }
            else
            {
                throw new Exception("error");
            }
        }
        public double GetIntellect { get => intellectCoef;}
        public LevelOfKnowledge EnglishKnowledgeLevel { get => levelOfKnowledgeEnglish; set => levelOfKnowledgeEnglish = value; }
        public LevelOfKnowledge PhysicKnowledgeLevel { get => levelOfKnowledgePhysics; set => levelOfKnowledgePhysics = value; }
        public LevelOfKnowledge MathKnowledgeLevel { get => levelOfKnowledgeMath; set => levelOfKnowledgeMath = value; }
        List<SaveMarks> labWorksPhysic;
        List<SaveMarks> moduleControlWorksPhysic;
        List<SaveMarks> moduleMarksPhysic;
        List<SaveMarks> courseWorkPhysic;
        List<SaveMarks> examMarksPhysic;
        List<SaveMarks> semestrMarksPhysic;
        List<SaveMarks> englishPracticeWorks;
        List<SaveMarks> moduleControlWorksEng;
        List<SaveMarks> moduleMarksEng;
        List<SaveMarks> semestrMarksEng;
        List<SaveMarks> mathematicPracticeWorks;
        List<SaveMarks> moduleControlWorksMath;
        List<SaveMarks> moduleMarksMath;
        List<SaveMarks> courseWorkMath;
        List<SaveMarks> examMarksMath;
        List<SaveMarks> semestrMarksMath;
        public List<SaveMarks> LabWorksMarks { get => labWorksPhysic; set => labWorksPhysic = value; }
        public List<SaveMarks> EngPracWorksMarks { get => englishPracticeWorks; set => englishPracticeWorks = value; }
        public List<SaveMarks> MathPracticeWorksMarks { get => mathematicPracticeWorks; set => mathematicPracticeWorks = value; }
        public List<SaveMarks> ModuleControlWorksPhysic { get => moduleControlWorksPhysic; set => moduleControlWorksPhysic = value; }
        public List<SaveMarks> ModuleMarksPhysic { get => moduleMarksPhysic; set => moduleMarksPhysic = value; }
        public List<SaveMarks> CourseWorkPhysic { get => courseWorkPhysic; set => courseWorkPhysic = value; }
        public List<SaveMarks> ExamMarksPhysic { get => examMarksPhysic; set => examMarksPhysic = value; }
        public List<SaveMarks>SemestrMarksPhysic { get => semestrMarksPhysic; set => semestrMarksPhysic = value; }
        public List<SaveMarks> ModuleControlWorksEng { get => moduleControlWorksEng; set => moduleControlWorksEng = value; }
        public List<SaveMarks> ModuleMarksEng { get => moduleMarksEng; set => moduleMarksEng = value; }
        public List<SaveMarks> SemestrMarksEng { get => semestrMarksEng; set => semestrMarksEng = value; }
        public List<SaveMarks> ModuleControlWorksMath { get => moduleControlWorksMath; set => moduleControlWorksMath = value; }
        public List<SaveMarks> ModuleMarksMath { get => moduleMarksMath; set => moduleMarksMath = value; }
        public List<SaveMarks> CourseWorkMath { get => courseWorkMath; set => courseWorkMath = value; }
        public List<SaveMarks> ExamMarksMath { get => examMarksMath; set => examMarksMath = value; }
        public List<SaveMarks> SemestrMarksMath { get => semestrMarksMath; set => semestrMarksMath = value; }

        public English EnglishEdu { get => english; set => english = value; }
        public HigherMathematics Mathematics { get => higherMathematics; set => higherMathematics = value; }
        public Physics PhysicsEdu { get => physics; set => physics = value; }
    }
}
