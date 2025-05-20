
using Microsoft.EntityFrameworkCore;
using WellBeingWorkout.Data;
using WellBeingWorkout.Models.ViewModels;

public class ChallengeService : IChallengeService
{
    private readonly WellBeingWorkoutContext _context;

    public ChallengeService(WellBeingWorkoutContext context)
    {
        _context = context;
    }

    public async Task<List<ChallengeViewModel>> GetAllChallenges(int userId)
    {
        var allChallenges = await _context.Challenge.ToListAsync();

        var completedChallenges = await _context.UserChallenge
            .Include(x => x.Challenge)
            .Where(x => x.UserId == userId)
            .ToListAsync();

        List<ChallengeViewModel> result = new List<ChallengeViewModel>();

        foreach (var item in allChallenges)
        {
            bool isCompleted = false;

            var completed = completedChallenges.FirstOrDefault(x => x.ChallengeId == item.Id);
           
            if(completed != null && DateOnly.FromDateTime(DateTime.Now) == completed.DtCompleted )
                isCompleted = true;

            var challengeViewModel = new ChallengeViewModel(item.Id, item.Name, item.Description, isCompleted, item.TotalXp, item.ChallengeLevel); 
            result.Add(challengeViewModel);
        }

        return result;
    }
}
