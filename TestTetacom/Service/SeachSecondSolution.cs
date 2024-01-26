using System.Collections.Generic;
using TestTetacom.Model;
using TestTetacom.Repository;

namespace TestTetacom.Service
{
    public class SeachSecondSolution : ISeachSecondSolution
    {
        private readonly IGroupedWellStatusRepository _groupedWellStatusRepository;

        public SeachSecondSolution(IGroupedWellStatusRepository groupedWellStatusRepository)
        {
            _groupedWellStatusRepository = groupedWellStatusRepository;
        }

        public Dictionary<int, List<GroupedWellStatus>> SecondSolution()
        {
            List<GroupedWellStatus> groupedWellStatus = _groupedWellStatusRepository.GetGroupedWellStatusByWellStatus(new List<WellStatus> { WellStatus.RunInHole, WellStatus.InSlips });
            Dictionary<int, List<GroupedWellStatus>> mapWellIStartEndSlip = new Dictionary<int, List<GroupedWellStatus>>();
            foreach (var item in groupedWellStatus)
            {
                if (mapWellIStartEndSlip.ContainsKey(item.WellId))
                {
                    mapWellIStartEndSlip[item.WellId].Append(item);
                }
                else
                {
                    mapWellIStartEndSlip.Add(item.WellId, new List<GroupedWellStatus>() { item });
                }
            }
            foreach (var key in mapWellIStartEndSlip.Keys)
            {

                DateTime startDateTime = DateTime.MinValue;
                DateTime endDateTime = DateTime.MinValue;
                foreach (var item in mapWellIStartEndSlip[key])
                {

                    if (item.Val == WellStatus.RunInHole)
                    {
                        startDateTime = item.StartDt;
                    }

                    if (item.Val == WellStatus.InSlips)
                    {
                        endDateTime = item.EndDt;
                    }                    
                }
                mapWellIStartEndSlip[key] = _groupedWellStatusRepository.GetGroupedWellStatus(key, startDateTime, endDateTime).OrderBy(x => x.StartDt).ToList();
            }            
            return mapWellIStartEndSlip;
        }
    }
}
