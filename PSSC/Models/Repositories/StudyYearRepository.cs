using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class StudyYearRepository : Repositories.IStudyYearRepository
    {
        private static List<Models.Subject.Subject> _subjects = new List<Models.Subject.Subject>();

        public StudyYearRepository()
        {
        }

        public void AddSubject(Models.Subject.Subject subject)
        {

        }
    }
}
