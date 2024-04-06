namespace Agilex
{
    public class AgileValue
    {
        public string? Value { get; set; }
        public string? WordToGuess { get; set; }
        public string? Phrase { get; set; }
        public string? InsteadOf { get; set; }
    }
    public class AppSettings
    {
        public AgileValue[]? AgileValues { get; set; }
    }

    public class AppSettingsDemo : AppSettings;

}
