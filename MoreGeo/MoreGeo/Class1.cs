using Modding;
using GlobalSettings;

namespace MoreGeo
{
    class MoreGeo : Mod
    {
        private int GeoTarget;
        private string VerNumber;

        GlobalSettingsClass Settings = new GlobalSettingsClass();

        public MoreGeo() : base("MoreGeo Multiplier ")
        {
            VerNumber = Settings.Multiplier.ToString();
        }

        public override string GetVersion() => VerNumber;

        public override void Initialize()
        {
            On.HeroController.AddGeo += AddGeo;
        }

        private void AddGeo(On.HeroController.orig_AddGeo orig, HeroController self, int amount)
        {
            GeoTarget = amount * Settings.Multiplier;
            orig(self, GeoTarget);
        }
    }
}