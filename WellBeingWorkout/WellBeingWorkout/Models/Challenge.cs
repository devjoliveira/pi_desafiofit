using WellBeingWorkout.Models.Enuns;

public class Challenge : DefaultEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int TotalXp { get; set; }
    public ChallengeLevel ChallengeLevel { get; set; }
}

