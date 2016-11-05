using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Models.Professor
{
    public class SubjectsFactory
    {
        public Subjects CreateSubjets(string name,int credits,string professorName, int numerator, int denominator,string type,string number,string studentName)
        {
            Contract.Requires<ArgumentNullException>(name != null, "string");
            Generics.PlainText  Name = new Generics.PlainText(name);
            Contract.Requires<ArgumentOutOfRangeException>(credits>=1 && credits<=60, "number of credits");
            Generics.Credits Credits = new Generics.Credits(credits);
            Contract.Requires<ArgumentNullException>(professorName != null, "string");
            Generics.PlainText ProfessorName = new Generics.PlainText(professorName);
            Professor Professor = new Professor(ProfessorName);
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
            Contract.Requires<ArgumentNullException>(number != null, "string");
            Generics.RegistrationNumber Number = new Generics.RegistrationNumber(number);
            Contract.Requires<ArgumentNullException>(studentName != null, "string");
            Generics.PlainText StudentName = new Generics.PlainText(studentName);
            Student.Student student = new Student.Student(Number, StudentName);
            Generics.Attendance Attendance = new Generics.Attendance(0);
            Generics.Grade Grade = new Generics.Grade(0);
            List<Generics.Grade> Grades = new List<Generics.Grade>();
            
            Models.Subject.SubjectSituation SubjectSituation = new Models.Subject.SubjectSituation(Attendance, Grades, Grade);
            Dictionary<Models.Student.Student, Models.Subject.SubjectSituation> Students = new Dictionary<Student.Student, Subject.SubjectSituation>();
            Students.Add(student,SubjectSituation);

            Models.Subject.Subject subject = new Subject.Subject(Students,SubjectInformation);
            List<Models.Subject.Subject> SubjectsList = new List<Models.Subject.Subject>();
            SubjectsList.Add(subject);

            var subjects = new Subjects(SubjectsList);
           

            return subjects;



        }
    }
}
