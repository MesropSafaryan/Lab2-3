using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork2.Education;
namespace LabWork2.AcademicDisciplines
{
    public interface IDiscipline
    {
        bool AdmissionModule();
        Mark ModuleControlWork(int reqLevel);
        Mark ModuleMark();
        Mark SemestrMark();

    }
}
