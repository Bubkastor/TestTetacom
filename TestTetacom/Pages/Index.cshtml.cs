using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestTetacom.Model;
using TestTetacom.Repository;
using TestTetacom.Service;

namespace TestTetacom.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ISeachFirstSolution _seachFirstSolution;
        private readonly ISeachSecondSolution _seachSecondSolution;
        private readonly IGroupedWellStatusRepository _groupedWellStatusRepository;

        public List<ViewStatusActivity> ModelActivity { get; private set; }
        public Dictionary<int, List<GroupedWellStatus>> GroupedWellStatusesRunInHole { get; private set; }
        public double SumPercentage { get; private set; } = 0;
        public double SumHour { get; private set; } = 0;
        public SelectList WellIdsData { get; private set; }


        public IndexModel(ILogger<IndexModel> logger, ISeachFirstSolution seachFirstSolution, ISeachSecondSolution seachSecondSolution, IGroupedWellStatusRepository groupedWellStatusRepository)
        {
            _logger = logger;
            _seachFirstSolution = seachFirstSolution;
            _seachSecondSolution = seachSecondSolution;
            _groupedWellStatusRepository = groupedWellStatusRepository;
            ModelActivity = new List<ViewStatusActivity>();
            GroupedWellStatusesRunInHole = new Dictionary<int, List<GroupedWellStatus>>();
            var wellIds = _groupedWellStatusRepository.GetWellIds();

            List<SelectListItem> selectListItems = new List<SelectListItem>();
            for (var i = 0; i < wellIds.Count; i++)
            {
                selectListItems.Add(new SelectListItem()
                {
                    Text = wellIds[i].ToString(),
                    Value = i.ToString(),
                    Selected = false
                });

            }

            WellIdsData = new SelectList(selectListItems, "Value", "Text");
        }

        public void OnGet()
        {
            if (Request.QueryString.HasValue)
            {
                try
                {
                    var wellId = int.Parse(Request.Query["id"]);
                    var startDateTime = DateTime.Parse(Request.Query["start"]);
                    var endDateTime = DateTime.Parse(Request.Query["end"]);

                    ModelActivity = _seachFirstSolution.FirstSolution(wellId, startDateTime, endDateTime);
                    SumHour = ModelActivity.Sum(x => x.Hour);
                    SumPercentage = ModelActivity.Sum(x => x.Percentage);
                    GroupedWellStatusesRunInHole = _seachSecondSolution.SecondSolution();
                }
                catch (Exception ex)
                {
                    _logger.LogError(0, ex, ex.Message);
                }
            }
        }
    }
}
