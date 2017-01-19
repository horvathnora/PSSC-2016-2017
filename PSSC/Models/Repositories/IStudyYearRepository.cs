using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    interface IStudyYearRepository
    {
        void AddSubject(Models.Subject.Subject subject);
    }
}
