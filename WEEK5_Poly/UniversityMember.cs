namespace WEEK5_Poly;

public class UniversityMember
{
    private string name;
    public string Name { get => name;
        private set
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentException("name cannot be empty");
            name = value;
        }
    }
    private string memberID;
    public string MemberID { get => memberID; private set => memberID = value; }

    protected List<string> Actionlog = new List<string>();
    public UniversityMember(string name, string memberID)
    {
        Name = name;
        MemberID = memberID;
    }
    public virtual void PerformDuties()
    {
        if (Actionlog.Count >= 5)
        {
            throw new Exception("daily limit was reached");
        }
    }
    public int GetActionlogCount()
    {
        return Actionlog.Count;
    }
}


