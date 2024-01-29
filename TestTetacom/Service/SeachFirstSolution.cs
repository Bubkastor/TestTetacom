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
            var wellIds = _groupedWellStatusRepository.GetWellIds();
            var groupedWellStatuses = _groupedWellStatusRepository.GetGroupedWellStatus(wellId, startDateTime, endDateTime);
            var sum = groupedWellStatuses.Sum(x => x.FullDuration);
            groupedWellStatuses.ForEach(x =>
            {
                var percentage = x.FullDuration / sum;
                result.Add(new ViewStatusActivity() { StatusName = x.Val.ToStringView(), Percentage = percentage, Hour = SecondsToHour(x.FullDuration) });
            });

            return result;
        }

        private double SecondsToHour(double Seconds)
        {
            return Seconds / 60 / 60;
        }
    }
}
