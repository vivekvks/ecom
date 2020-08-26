namespace Ecom.Utility
{
    public class ConfigurationOption
    {
        public Jwt Jwt { get; set; }
        public Settings Settings { get; set; }
    }
    public class Jwt
    {
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
    public static class ConnectionStringHelper
    {
        public static string EComDatabase { get; set; }
    }
    public class Settings
    {
        public string SaltKey { get; set; }
    }
}
