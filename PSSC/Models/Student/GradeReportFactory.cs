using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Student
{
    public class GradeReportFactory
    {
        public static readonly GradeReportFactory Instance = new GradeReportFactory();

        public Subject.SubjectSituation CreateInstance(Generics.Attendance attendance, List<Generics.Grade> examGrades,Generics.Grade activityGrade)
        {

            var SubjectsSituation = new Subject.SubjectSituation(attendance,examGrades,activityGrade);

            return SubjectsSituation;



        }

    }
}
