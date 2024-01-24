using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestTetacom.Model;

namespace TestTetacom.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<ViewStatusActivity> ModelActivity { get; private set; }
        public float SumPercentage { get; private set; }
        public float SumHour { get; private set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            ModelActivity =
            [
                new ViewStatusActivity() { StatusName = "�� �����������", Percentage = 1, Hour = 2 },
                new ViewStatusActivity() { StatusName = "� �������", Percentage = 1, Hour = 2 },
                new ViewStatusActivity() { StatusName = "������", Percentage = 1, Hour = 2 },
                new ViewStatusActivity() { StatusName = "�����", Percentage = 1, Hour = 2 },
                new ViewStatusActivity() { StatusName = "����������", Percentage = 1, Hour = 2 },
            ];
            SumPercentage = 100;
            SumHour = 100;
        }

        public void OnGet()
        {

        }
    }
}
