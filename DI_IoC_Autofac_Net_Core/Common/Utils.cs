using System;

namespace DI_IoC_Autofac_Net_Core.Common
{
    public static class Utils
    {
        public static int randNumber()
        {
            return new Random().Next(1, 1000);
        }
    }
}
