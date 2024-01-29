namespace TestTetacom.Attribute
{
    internal class EnumLocaleAttribute : System.Attribute
    {        
        public string Text { get; set; }

        public EnumLocaleAttribute(string text)
        {
            Text = text;
        }
    }
}
