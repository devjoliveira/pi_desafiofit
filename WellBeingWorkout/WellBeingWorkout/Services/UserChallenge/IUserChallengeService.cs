public interface IUserChallengeService
{
    Task MarkChallengeAsDoneAsync(int userId, int challengeId);
}
