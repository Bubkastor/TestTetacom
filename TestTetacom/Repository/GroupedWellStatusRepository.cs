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

        public List<GroupedWellStatus> GetGroupedWellStatusAll()
        {
            return dbContext.GroupedWellStatuses.ToList();
        }
    }
}
