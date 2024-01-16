using Aula11_EFCoreTutorialConsole;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using (var context = new SchoolContext())
{
    //Criar o DB se não existir
    context.Database.EnsureCreated();
    var grd1 = new Grade() { GradeName = "Full Stack Asp.NET" };
    var std1 = new Student() { FirstName = "Rodrigo", LastName = "Vianna",Grade=grd1 };
    
    //Add student para o context
    context.Students.Add(std1);
    
    //Salvar os dados para a tabela
    context.SaveChanges();

    foreach (var s in context.Students)
    {
        Console.WriteLine($"FIrst NAme: {s.FirstName}, Last Name: {s.LastName}");
    }
}
