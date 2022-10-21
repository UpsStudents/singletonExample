using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCalificacion.Entities
{
    public class GradeRegistration
    {
        private static GradeRegistration? _gradeRegistration = null;
        private static Dictionary<string, int> _grades;

        private GradeRegistration()
        {
            _grades= new Dictionary<string, int>()
            {
                {"Lenguaje", 0},
                {"Matemáticas", 0},
                {"Sociales", 0},
                {"Naturales", 0}
            };
        }

        public static GradeRegistration GetInstance()
        {
            if (_gradeRegistration == null)
            {
                _gradeRegistration = new GradeRegistration();
            }
            return _gradeRegistration;
        }

        public void WriteGrade(string area, int grade)
        {
            _grades[area] = grade;
        }

        public List<string> GetGrades()
        {
            return _grades.ToList().Select(x => x.ToString()).ToList();
        }
    }
}
