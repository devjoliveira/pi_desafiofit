using WellBeingWorkout.Data;

public class UserChallengeService : IUserChallengeService
{
    private readonly WellBeingWorkoutContext _context;

    public UserChallengeService(WellBeingWorkoutContext context)
    {
        _context = context;
    }

    public async Task MarkChallengeAsDoneAsync(int userId, int challengeId)
    {

        var challenge = _context.Challenge.FirstOrDefault(x => x.Id == challengeId);
        var user = _context.User.FirstOrDefault(x => x.Id == userId);

        if (user == null)
            throw new Exception("User not found");
        
        if (challenge == null)
            throw new Exception("Challenge not found");
       
        var userChallenge = new UserChallenge();
        userChallenge.UserId = userId;
        userChallenge.ChallengeId = challengeId;
        userChallenge.DtCompleted = DateOnly.FromDateTime(DateTime.Now);

        _context.Add(userChallenge);
        await _context.SaveChangesAsync();

        await this.UpdateUserLevelAsync(user, challenge);

    }

    private async Task UpdateUserLevelAsync(User user, Challenge challenge)
    {
        user.TotalXpEarned += challenge.TotalXp;
        user.Level = user.TotalXpEarned / 100;
        _context.Update(user);
        await _context.SaveChangesAsync();
    }
}
