namespace WEEK5_Poly;

public class Professor : UniversityMember
{
    public Professor(string name, string memberID) : base(name, memberID)
    {
    }
    public override void PerformDuties()
    {
        base.PerformDuties();
        Actionlog.Add("ecture delivered ");
    }
    public void ConductResearch(string topic)
    {
        Actionlog.Add("Research was conducted");
        Console.WriteLine("Conducting " + topic);
    }
}