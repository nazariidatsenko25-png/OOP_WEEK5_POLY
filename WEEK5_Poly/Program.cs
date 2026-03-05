namespace WEEK5_Poly;

public class Program
{
    static void Main(string[] args)
    {
        var student1 = new GraduateStudent("korotenko", "superstudent");
        var student2 = new UndergraduateStudent("ivan", "124543");
        var professor1 = new Professor("Brik", "rector");
        var registry = new UniversityRegistry();
        registry.AddMember(student1);
        registry.AddMember(student2);
        registry.AddMember(professor1);
        registry.PlayAllDuties();
        Console.WriteLine(registry.GetMembersStatistics());
        registry.GetMembersStatistics();
        professor1.ConductResearch("Grants");
        professor1.PerformDuties();
    }
}