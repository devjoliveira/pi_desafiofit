public class UserChallenge : DefaultEntity
{
    public User User { get; set; }
    public int UserId { get; set; }
    public Challenge Challenge { get; set; }
    public int ChallengeId { get; set; }
    public DateOnly DtCompleted { get; set; }
}

