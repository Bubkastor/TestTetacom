using TestTetacom.Model;

namespace TestTetacom.Service
{
    public interface ISeachSecondSolution
    {
        Dictionary<int, List<GroupedWellStatus>> SecondSolution();
    }
}
