using Exiled.API.Interfaces;

namespace CI_Replacer
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; }
        static public int ReplacementChancePercent { get; set; } = 50;
    }
}
