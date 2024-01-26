using TestTetacom.Model;
using TestTetacom.Repository;

namespace TestTetacom.Service
{
    public class SeachFirstSolution : ISeachFirstSolution
    {
        private readonly IGroupedWellStatusRepository _groupedWellStatusRepository;

        public SeachFirstSolution(IGroupedWellStatusRepository groupedWellStatusRepository)
        {
            _groupedWellStatusRepository = groupedWellStatusRepository;
        }

        public List<ViewStatusActivity> FirstSolution(int wellId, DateTime startDateTime, DateTime endDateTime)
        {
            List<ViewStatusActivity> result = new List<ViewStatusActivity>();
            var groupedWellStatuses = _groupedWellStatusRepository.GetGroupedWellStatus(wellId, startDateTime, endDateTime);
            groupedWellStatuses.ForEach(x =>
            {
                if (x.Val == WellStatus.OnSurface
                || x.Val == WellStatus.InSlips
                || x.Val == WellStatus.PullOutOfHole
                || x.Val == WellStatus.RunInHole
                || x.Val == WellStatus.StandBy)
                {
                    result.Add(new ViewStatusActivity() { StatusName = x.Val.ToStringView(), Percentage = 1, Hour = SecondsToHour(x.FullDuration)});
                }
            });

            return result;
        }

        private int SecondsToHour (double Seconds) 
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(Seconds);
            return timeSpan.Hours;
        }
    }
}
