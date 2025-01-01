using Football.Models.ApiFootballResponseDtos;
using Microsoft.AspNetCore.Mvc;

namespace Football.Views.Shared.Components.MatchCard
{
    public class MatchCardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Match match)
        {
            return View(match);
        }
    }
}
