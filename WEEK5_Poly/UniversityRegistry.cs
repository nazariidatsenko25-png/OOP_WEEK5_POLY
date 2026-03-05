namespace WEEK5_Poly;

public class UniversityRegistry
{
    private List<UniversityMember> members = new List<UniversityMember>();
    public void AddMember(UniversityMember member)
    {
        members.Add(member);
    }
    public void PlayAllDuties()
    {
        foreach (UniversityMember member in members)
        {
            member.PerformDuties();
        }
    }

    public string GetMembersStatistics()
    {
        int totalActions = 0;
        foreach (UniversityMember member in members)
        {
            totalActions += member.GetActionlogCount();
        }
        return $"Total actions: {totalActions}";
    }
}