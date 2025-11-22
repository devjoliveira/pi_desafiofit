using Microsoft.AspNetCore.Mvc;
using WellBeingWorkout.Models.ViewModels;

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

        public async Task<IActionResult> AllChallenges(int userId)
        {
            var allChallenges = await _challengeService.GetAllChallenges(userId);
            var userProgress = await _userChallengeService.GetUserProgress(userId);
            return View(new Tuple<List<ChallengeViewModel>, UserProgressViewModel>(allChallenges, userProgress)); 
        }

        [HttpPost]
        public async Task<IActionResult> MarkChallengeAsDone(int userId, int challenge)
        {
            await _userChallengeService.MarkChallengeAsDoneAsync(userId, challenge);
            var userProgress = await _userChallengeService.GetUserProgress(userId);
            return Json(userProgress);
        }

    }
}
