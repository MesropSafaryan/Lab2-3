using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2
{
    public class Teacher : Human
    {
        List<string> eduPracticeSubject, lectionSubject;
        string[] practiceGroups, lectionGroups;
        public List<string> EduPracticeSubject { get => eduPracticeSubject; set => eduPracticeSubject = value;}
        public List<string> LectionSubject { get => lectionSubject; set => lectionSubject = value; }
    }
}
