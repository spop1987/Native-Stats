using Microsoft.AspNetCore.Mvc;

namespace Football.Views.Shared.Components.LeagueSection
{
    public class LeagueSectionViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(LeagueSectionViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}
