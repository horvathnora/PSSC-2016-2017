using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum tip { examen, distribuita };

    public class Profesor
    {
        List<Disciplina> listaDiscipline = new List<Disciplina>();
        List<Student> listaStudenti = new List<Student>();

        public string numeProfesor { get; set; }

        public Profesor(string numeProfesor)
        {
            this.numeProfesor = numeProfesor;

        }

    }
    public class Disciplina:Profesor
    {

        tip tipDisciplina;
        public string numeDisciplina { get; set; }
        public int crediteDisciplina { get; set; }

        public Disciplina(string numeDisciplina,int crediteDisciplina,string numeProfesor):base(numeProfesor)
        {
            this.numeDisciplina = numeDisciplina;
            this.crediteDisciplina = crediteDisciplina;
            this.numeProfesor = numeProfesor;
        }

        
    }

    public class Student:Situatie
    {
        List<Disciplina> listaDiscipline = new List<Disciplina>();

        public string nume { get; set; }
        public int an { get; set; }
        public int nrMatricol { get; set; }
       

        public Student(string nume,int an,int nrMatricol)
        {
            this.nume = nume;
            this.an = an;
            this.nrMatricol = nrMatricol;
            
        }
    }

  
    public class Decanat
    {
        List<Disciplina> listaDiscipline=new List<Disciplina>();
        List<Student> listaStudenti = new List<Student>();

    }

    public class Situatie
    {
        public int credite { get; set; }
        public float[] nota_examen { get; set; }
        public int prezenta { get; set; }
        public float[] note_activitate { get; set; }

    }
}
