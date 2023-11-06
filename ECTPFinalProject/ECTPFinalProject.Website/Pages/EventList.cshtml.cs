using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECTPFinalProject.Website.Pages
{
    public class EventListModel : PageModel
    {
        private readonly ILogger<EventListModel> _logger;

        public EventListModel(ILogger<EventListModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}