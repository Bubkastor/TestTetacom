namespace TestTetacom.Model;

public partial class GroupedWellStatus
{
    public int Id { get; set; }

    public WellStatus Val { get; set; }

    public int WellId { get; set; }

    public double FullDuration { get; set; }

    public DateTime StartDt { get; set; }

    public DateTime EndDt { get; set; }

    public bool IsDayChange { get; set; }

    public DateTime? NewDayStartDt { get; set; }

    public double? NewDayDuration { get; set; }

    public DateTime? OldDayEndDt { get; set; }

    public double? OldDayDuration { get; set; }

    public double? MdAfter { get; set; }

    public double? MdBefore { get; set; }

    public double? BitDepthAfter { get; set; }
}
