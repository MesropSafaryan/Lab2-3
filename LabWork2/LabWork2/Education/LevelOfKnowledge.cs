using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2.Education
{
    public class LevelOfKnowledge
    {
        double level = 0;
        public double Level 
        {
            get
            {
                return level;
            }
            set
            {
                if(value < 0)
                {
                    value = 0;
                }
                if(value > 100)
                {
                    value = 100;
                }
                level = value;
            }
        }
    }
}
