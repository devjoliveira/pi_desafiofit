using WellBeingWorkout.Models.Enuns;

namespace WellBeingWorkout.Models.ViewModels
{
    public class ChallengeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompleted {  get; set; }
        public int TotalXp { get; set; }
        public ChallengeLevel ChallengeLevel { get; set; }

        public ChallengeViewModel(int id, string name, string description, bool isCompleted, int totalXp, ChallengeLevel challengeLevel)
        {
            Id = id;
            Name = name;
            Description = description;
            IsCompleted = isCompleted;
            ChallengeLevel = challengeLevel;
            TotalXp = totalXp;
        }
    }
}
