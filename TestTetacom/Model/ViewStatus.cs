namespace TestTetacom.Model
{
    public record ViewStatusActivity
    {
        public required string StatusName { get; set; }
        public float Percentage { get; set; }
        public int Hour { get; set; }
    }
}
