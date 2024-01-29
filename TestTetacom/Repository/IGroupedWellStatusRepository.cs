using TestTetacom.Model;

namespace TestTetacom.Repository
{
    public interface IGroupedWellStatusRepository
    {
        List<int> GetWellIds();
        List<GroupedWellStatus> GetGroupedWellStatusByWellStatus(List<WellStatus> wellStatuses);
        List<GroupedWellStatus> GetGroupedWellStatus(int wellId, DateTime startDateTime, DateTime endDateTime);
    }
}
