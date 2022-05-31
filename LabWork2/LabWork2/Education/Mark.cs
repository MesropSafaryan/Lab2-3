using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2.Education
{
    public class Mark
    {
        double mark;
        public double Marking(LevelOfKnowledge level, int reqLevel)
        {
            double levelMatching = reqLevel - level.Level;
            double markCoeff = levelMatching / reqLevel;
            if (markCoeff < 0.1)
            {
                mark = 5;
                return mark;
            }
            else if (markCoeff >= 0.1 && markCoeff < 0.3)
            {
                mark = 4;
                return mark;
            }
            else if (markCoeff >= 0.3 && markCoeff < 0.5)
            {
                mark = 3;
                return mark;
            }
            else
            {
                mark = 0;
                return mark;
            }
        }
        public double GetMark
        {
            get => mark;
            set
            {
                if(value > 0 && value < 5)
                {
                    mark = value;
                }
                else
                {
                    throw new Exception("error mark value");
                }
            }
        }

    }
}
