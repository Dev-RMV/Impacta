namespace Aula13_UmParaMuitos.Models
{
    public class Student
    {/*
       //Convenção 1
        public int StudentId { get; set; }
        public string? Name { get; set;}
        public Grade Grade { get; set; } //propriedade de navegação. Uma Grade pode ter muitos Students
   */     
 
        //Convenção 2
        public int StudentId { get; set; }
        public string? Name { get; set; }
    }
}
