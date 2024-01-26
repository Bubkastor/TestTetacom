using TestTetacom.Model;

namespace TestTetacom.Repository
{
    public class GroupedWellStatusRepository : IGroupedWellStatusRepository
    {
        private readonly ApplicationDbContext dbContext;

        public GroupedWellStatusRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<int> GetWellIds()
        {
            return dbContext.GroupedWellStatuses.DistinctBy(x => x.WellId).Select(x => x.WellId).ToList();
        }

        public List<GroupedWellStatus> GetGroupedWellStatusByWellStatus(List<WellStatus> wellStatuses)
        {
            return dbContext.GroupedWellStatuses.Where(x => wellStatuses.Contains(x.Val)).ToList();
        }

        public List<GroupedWellStatus> GetGroupedWellStatus(int wellId, DateTime startDateTime, DateTime endDateTime)
        {
            return dbContext.GroupedWellStatuses.Where(x => x.WellId == wellId && x.StartDt >= startDateTime && x.EndDt <= endDateTime).ToList();
        }

        public List<GroupedWellStatus> GetGroupedWellStatusToWellStatus(int wellId, DateTime startDateTime, WellStatus inSlips)
        {
            return dbContext.GroupedWellStatuses.Where(x => x.WellId == wellId && x.StartDt >= startDateTime && x.Val <= inSlips).ToList();
        }
    }
}
