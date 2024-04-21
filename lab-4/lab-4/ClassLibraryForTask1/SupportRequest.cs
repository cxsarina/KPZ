namespace ClassLibraryForTask1
{
    public enum SupportLevel
    {
        Basic,
        Intermediate,
        Advanced
    }
    public class SupportRequest
    {
        public SupportLevel RequestedLevel { get; set; }
    }
}
