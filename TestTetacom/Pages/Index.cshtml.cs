using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public List<ViewStatusActivity> ModelActivity { get; private set; }
        public List<GroupedWellStatus> GroupedWellStatusesRunInHole { get; private set; }
        public float SumPercentage { get; private set; } = 0;
        public double SumHour { get; private set; } = 0;

        public IndexModel(ILogger<IndexModel> logger, ISeachFirstSolution seachFirstSolution, ISeachSecondSolution seachSecondSolution)
        {
            _logger = logger;
            _seachFirstSolution = seachFirstSolution;

            ModelActivity = new List<ViewStatusActivity>();
            GroupedWellStatusesRunInHole = new List<GroupedWellStatus>();
            _seachSecondSolution = seachSecondSolution;
            GroupedWellStatusesRunInHole = _seachSecondSolution.SecondSolution();
        }

        public void OnGet()
        {

        }
    }
}
