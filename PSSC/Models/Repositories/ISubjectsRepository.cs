using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    interface ISubjectsRepository
    {
        void AddSubjects(Models.Subject.Subject subject);
    }
}
