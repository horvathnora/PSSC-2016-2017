using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class GradeReportRepository : Repositories.IGradeReportRepository
    {
        private static List<Models.Subject.SubjectSituation> _situation = new List<Models.Subject.SubjectSituation>();

        public GradeReportRepository()
        {
        }

        public void AddSubjectSituation(Models.Subject.SubjectSituation situation)
        {

        }
    }
}
