namespace TestTetacom.Model
{
    static class WellStatusExtensions
    {
        public static String ToStringView(this WellStatus wellStatus)
        {
            switch (wellStatus)
            {
                case WellStatus.NotDefined:
                    break;
                case WellStatus.RotaryDrilling:
                    break;
                case WellStatus.SlideDrilling:
                    break;
                case WellStatus.Connection:
                    break;
                case WellStatus.CirculationWithoutRotation:
                    break;
                case WellStatus.RunInHole:
                    return "Спуск";
                case WellStatus.PullOutOfHole:
                    return "Подъем";
                case WellStatus.StandBy:
                    return "Неподвижно";
                case WellStatus.WirelineLogs:
                    break;
                case WellStatus.Cementing:
                    break;
                case WellStatus.FishingOperations:
                    break;
                case WellStatus.Repair:
                    break;
                case WellStatus.CirculationWithRotation:
                    break;
                case WellStatus.InSlips:
                    return "В клиньях";
                case WellStatus.OnSurface:
                    return "На поверхности";
                case WellStatus.DirectReaming:
                    break;
                case WellStatus.ReverseReaming:
                    break;
                case WellStatus.CirculationWoRotationWithPacing:
                    break;
                case WellStatus.CirculationWithRotationWoPacing:
                    break;
                case WellStatus.CirculationWoRotationWoPacing:
                    break;
                case WellStatus.NoData:
                    break;
                case WellStatus.IncorrectData:
                    break;
                case WellStatus.Drilling:
                    break;
                case WellStatus.PullOfHoleWithRotationWoPacing:
                    break;
                case WellStatus.RunInHoleWithRotationWoPacing:
                    break;
                case WellStatus.CirculationInPlaceWithPacing:
                    break;
                case WellStatus.CirculationInPlaceWoPacing:
                    break;
                default:
                    break;
            }
            return "";
        }
    }
}
