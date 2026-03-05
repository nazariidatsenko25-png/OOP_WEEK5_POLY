namespace WEEK5_Poly;

public class UndergraduateStudent : UniversityMember
{
    public UndergraduateStudent(string name, string memberID) : base(name, memberID)
    {
    }

    public override void PerformDuties()
    {
        base.PerformDuties();
        Actionlog.Add("Lab work completed");
    }
}