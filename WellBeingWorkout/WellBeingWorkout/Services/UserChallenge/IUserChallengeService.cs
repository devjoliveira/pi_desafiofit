public interface IUserChallengeService
{
    Task MarkChallengeAsDoneAsync(int userId, int challengeId);
    Task<UserProgressViewModel> GetUserProgress(int userId);
}
