using Microsoft.AspNetCore.Mvc;

namespace WellBeingWorkout.Controllers
{
    public class ChallengeController : Controller
    {

        private readonly IUserChallengeService _userChallengeService;
        private readonly IChallengeService _challengeService;

        public ChallengeController(IUserChallengeService userChallengeService, IChallengeService challengeService)
        {
            _userChallengeService = userChallengeService;
            _challengeService = challengeService;
        }

        public async Task<IActionResult> AllChallenges()
        {
            var allChallenges = await _challengeService.GetAllChallenges(1);
            return View(allChallenges); 
        }

        [HttpPost]
        public async Task<IActionResult> MarkChallengeAsDone(int userId, int challenge)
        {
            await _userChallengeService.MarkChallengeAsDoneAsync(userId, challenge);
            return View();
        }
    }
}
