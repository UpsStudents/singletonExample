using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCalificacion.Entities
{
    public class AcademicSystem
    {
        public void WriteGrade(string area, int grade)
        {
            var gradeRegistration = GradeRegistration.GetInstance();
            gradeRegistration.WriteGrade(area, grade);
            Console.WriteLine($"{area}: {grade}");
        }
    }
}
