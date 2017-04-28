using System;
using seven.trumpets.Domain;

namespace seven.trumpets.iOS
{
    public class OmegaFactory : AlphaFactory
    {
        public static void MakeSureInit()
        {
            if (null == AlphaFactory.Get())
            {
                AlphaFactory.Init(new OmegaFactory());
            }
        }

        public override AlphaApp MakeOmegaApp()
        {
            return new AlphaApp();
        }

        public override AlphaDomain MakeOmegaDomain()
        {
            return new AlphaDomain();
        }
    }
}
