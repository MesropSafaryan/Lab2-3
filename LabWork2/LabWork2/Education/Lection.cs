using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2.Education
{
    public class Lection
    {
        public void EducationProc(LevelOfKnowledge level, int val, int intellect)
        {
            level.Level += val * intellect;            
        }
    }
}
