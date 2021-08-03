using Modding;

namespace MoreGeo
{
    class MoreGeo : Mod
    {
        private int Multiplier = 2;
        private int GeoTarget;

        private string VerNumber;

        public MoreGeo() : base("MoreGeo Multiplier ")
        {
            VerNumber = Multiplier.ToString();
        }

        public override string GetVersion() => VerNumber;

        public override void Initialize()
        {
            On.HeroController.AddGeo += AddGeo;
        }

        private void AddGeo(On.HeroController.orig_AddGeo orig, HeroController self, int amount)
        {
            GeoTarget = amount * Multiplier;
            orig(self, GeoTarget);
        }
    }
}