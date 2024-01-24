using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestTetacom.Model;
using TestTetacom.Repository;

namespace TestTetacom.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IGroupedWellStatusRepository GroupedWellStatusRepository;
        public List<ViewStatusActivity> ModelActivity { get; private set; }
        public float SumPercentage { get; private set; }
        public float SumHour { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, IGroupedWellStatusRepository groupedWellStatusRepository)
        {
            _logger = logger;
            GroupedWellStatusRepository = groupedWellStatusRepository;
            ModelActivity = new List<ViewStatusActivity>();

            GroupedWellStatusRepository.GetGroupedWellStatusAll().ForEach(w =>
            {
                if ( w.Val == WellStatus.OnSurface
                || w.Val == WellStatus.InSlips
                || w.Val == WellStatus.PullOutOfHole
                || w.Val == WellStatus.RunInHole
                || w.Val == WellStatus.StandBy)
                {
                    ModelActivity.Add(new ViewStatusActivity() { StatusName = WellStatusToString(w.Val), Percentage = 1, Hour = w.FullDuration / 60 });
                }
            });            
            SumPercentage = 100;
            SumHour = 100;
        }

        public void OnGet()
        {

        }

        public string WellStatusToString(WellStatus wellStatus)
        {
            switch (wellStatus)
            {
                case WellStatus.NotDefined:                    
                    break;
                case WellStatus.RotaryDrilling:
                    break;
                case WellStatus.SlideDrilling:
                    break;
                case WellStatus.Connection:
                    break;
                case WellStatus.CirculationWithoutRotation:
                    break;
                case WellStatus.RunInHole:
                    return "Спуск";                    
                case WellStatus.PullOutOfHole:
                    return "Подъем";
                case WellStatus.StandBy:
                    return "Неподвижно";
                case WellStatus.WirelineLogs:
                    break;
                case WellStatus.Cementing:
                    break;
                case WellStatus.FishingOperations:
                    break;
                case WellStatus.Repair:
                    break;
                case WellStatus.CirculationWithRotation:
                    break;
                case WellStatus.InSlips:
                    return "В клиньях";
                case WellStatus.OnSurface:
                    return "На поверхности";
                case WellStatus.DirectReaming:
                    break;
                case WellStatus.ReverseReaming:
                    break;
                case WellStatus.CirculationWoRotationWithPacing:
                    break;
                case WellStatus.CirculationWithRotationWoPacing:
                    break;
                case WellStatus.CirculationWoRotationWoPacing:
                    break;
                case WellStatus.NoData:
                    break;
                case WellStatus.IncorrectData:
                    break;
                case WellStatus.Drilling:
                    break;
                case WellStatus.PullOfHoleWithRotationWoPacing:
                    break;
                case WellStatus.RunInHoleWithRotationWoPacing:
                    break;
                case WellStatus.CirculationInPlaceWithPacing:
                    break;
                case WellStatus.CirculationInPlaceWoPacing:
                    break;
                default:
                    break;
            }
            return "";
        }
    }
}
