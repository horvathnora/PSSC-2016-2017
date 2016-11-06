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
        public static readonly SubjectsFactory Instance = new SubjectsFactory();

        public Subject.Subject CreateInstance(Subject.SubjectInformation SubjectInformation)
        {

            var subject = new Subject.Subject(SubjectInformation);
            return subject;
  
        }
    }
}
