using System.ComponentModel.DataAnnotations;

namespace Aula13_UmParaMuitos.Models
{
    public class Grade
    {/*
        //Convencao 1
        public int GradeId { get; set; }
        public string? GradeName { get; set;}
        public string? GradeDescription { get; set;}
        */

        
        //Convenção 2
        public int GradeId { get; set; }
        public string? GradeName { get; set; }
        public string? GradeDescription { get; set; }
        
        public ICollection<Student> Students { get; set; } //propriedade de navegação


    }
}
