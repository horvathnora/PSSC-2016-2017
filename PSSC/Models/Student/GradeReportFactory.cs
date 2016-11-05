using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Student
{
    class GradeReportFactory
    {
        public GradeReport CreateGradeReport(string name, int credits, string professorName, int numerator, int denominator, string type,int count,decimal grade,decimal activityGrade)
        {

            Generics.PlainText Name = new Generics.PlainText(name);
            Generics.Credits Credits = new Generics.Credits(credits);
            Generics.PlainText ProfessorName = new Generics.PlainText(professorName);
            Models.Professor.Professor Professor = new Models.Professor.Professor(ProfessorName);
            Generics.Proportion ActivityProportion = new Generics.Proportion(numerator, denominator);
            Models.Subject.EvaluationType Evaluation;
            if (type.Contains("examen"))
            {
                Evaluation = Models.Subject.EvaluationType.Exam;
            }
            else
            {
                Evaluation = Models.Subject.EvaluationType.Distributed;
            }
            Subject.SubjectInformation SubjectInformation = new Subject.SubjectInformation(Name, Credits, Evaluation, ActivityProportion, Professor);
            Generics.Attendance Count = new Generics.Attendance(count);
            Generics.Grade Grade = new Generics.Grade(grade);
            List<Generics.Grade> Grades = new List<Generics.Grade>();
            Grades.Add(Grade);
            Generics.Grade ActivityGrade = new Generics.Grade(activityGrade);
            Subject.SubjectSituation SubjectSituation = new Subject.SubjectSituation(Count, Grades, ActivityGrade);
            ICollection<KeyValuePair<Models.Subject.SubjectInformation, Models.Subject.SubjectSituation>> GradeReports=new List<KeyValuePair<Models.Subject.SubjectInformation, Models.Subject.SubjectSituation>>();

            GradeReports.Add(new KeyValuePair<Subject.SubjectInformation,Subject.SubjectSituation>(SubjectInformation,SubjectSituation));
            var gradeReport = new GradeReport(GradeReports);

            return gradeReport;



        }

    }
}
