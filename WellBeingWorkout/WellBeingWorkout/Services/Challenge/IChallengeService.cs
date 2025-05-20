using WellBeingWorkout.Models.ViewModels;

public interface IChallengeService
{
    Task<List<ChallengeViewModel>> GetAllChallenges(int userId);
}
