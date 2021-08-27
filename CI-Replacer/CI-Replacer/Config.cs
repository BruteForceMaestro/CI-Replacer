using Exiled.API.Interfaces;

namespace CI_Replacer
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public int ReplacementChancePercent { get; set; } = 50;
    }
}
