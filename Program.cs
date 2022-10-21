using RegistroCalificacion.Entities;

Console.WriteLine("Grades Singleton");

var academicSystem = new AcademicSystem();
var webSite = new WebSite();


Console.WriteLine("------Academic System (Write)------");
academicSystem.WriteGrade("Lenguaje", 89);
Console.WriteLine("------Web Site (Read)------");
webSite.ReadGrades();
Console.WriteLine("------------------------------------");



Console.WriteLine("------Academic System (Write)------");
academicSystem.WriteGrade("Matemáticas", 91);
Console.WriteLine("------Web Site (Read)------");
webSite.ReadGrades();
Console.WriteLine("-------------------------------------");



Console.WriteLine("------Academic System (Write)------");
academicSystem.WriteGrade("Sociales", 78);
Console.WriteLine("------Web Site (Read)------");
webSite.ReadGrades();
Console.WriteLine("-------------------------------------");



Console.WriteLine("------Academic System (Write)------");
academicSystem.WriteGrade("Naturales", 71);
Console.WriteLine("------Web Site (Read)------");
webSite.ReadGrades();
Console.WriteLine("------------------------------------");

Console.ReadLine();
