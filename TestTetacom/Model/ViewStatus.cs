namespace TestTetacom.Model
{
    public record ViewStatusActivity
    {
        public required string StatusName { get; set; }
        public double Percentage { get; set; }
        public double Hour { get; set; }
    }
}
