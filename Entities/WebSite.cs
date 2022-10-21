using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCalificacion.Entities
{
    public class WebSite
    {
        public void ReadGrades()
        {
            var gradeRegistration = GradeRegistration.GetInstance();
            foreach (var grade in gradeRegistration.GetGrades())
            {
                Console.WriteLine(grade);
            }

        }
    }
}
