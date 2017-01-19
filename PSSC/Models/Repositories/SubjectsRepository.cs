using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class SubjectsRepository : Repositories.ISubjectsRepository
    {
        private static List<Models.Subject.Subject> _subjects = new List<Models.Subject.Subject>();

        public SubjectsRepository()
        {
        }

        public void AddSubjects(Models.Subject.Subject subject)
        {

        }
    }
}
