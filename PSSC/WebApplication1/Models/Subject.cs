using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        public string RegistrationNumber { get; set; }

        public string Name { get; set; }

        public int StudyYear { get; set; }
    }

    internal class KeyAttribute : Attribute
    {
    }
}