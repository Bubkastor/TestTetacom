using TestTetacom.Model;

namespace TestTetacom.Repository
{
    public interface IGroupedWellStatusRepository
    {
        List<GroupedWellStatus> GetGroupedWellStatusAll();
    }
}
