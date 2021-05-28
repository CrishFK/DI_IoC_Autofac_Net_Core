using DI_IoC_Autofac_Net_Core.Common;

namespace DI_IoC_Autofac_Net_Core.Models
{
    public class Singleton
    {
        public readonly int _Number;

        public Singleton()
        {
            _Number = Utils.randNumber();
        }
        public int getRandNumber()
        {
            return _Number;
        }
    }
}