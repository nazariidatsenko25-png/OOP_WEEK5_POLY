namespace WEEK5_Poly;

public class GraduateStudent : UndergraduateStudent
{
    public GraduateStudent(string name, string memberID) : base(name, memberID)
    {
    }
    public override void PerformDuties()
    {
        base.PerformDuties();
        Actionlog.Add("thesis research updated");
    }
}