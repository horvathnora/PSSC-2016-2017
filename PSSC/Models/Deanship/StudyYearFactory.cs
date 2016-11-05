using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Deanship
{
    class StudyYearFactory
    {
        public StudyYear CreateDefinedSubjects(string name, int credits, string professorName, int numerator, int denominator, string type)
        {
            Contract.Requires<ArgumentNullException>(name != null, "string");
            Generics.PlainText Name = new Generics.PlainText(name);
            Contract.Requires<ArgumentOutOfRangeException>(credits >= 1 && credits <= 60, "number of credits");
            Generics.Credits Credits = new Generics.Credits(credits);
            Contract.Requires<ArgumentNullException>(professorName != null, "string");
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

            Subject.Subject Subject = new Models.Subject.Subject(SubjectInformation);

            List<Models.Subject.Subject> DefinedSubjects = new List<Models.Subject.Subject>();
            DefinedSubjects.Add(Subject);
            var definedSubjects = new StudyYear(DefinedSubjects);

            return definedSubjects;

        }
    }
}
