using TestTetacom.Model;

namespace TestTetacom.Service
{
    public interface ISeachFirstSolution
    {
        List<ViewStatusActivity> FirstSolution(int wellId, DateTime startDateTime, DateTime endDateTime);
    }
}
