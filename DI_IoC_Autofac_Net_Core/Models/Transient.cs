using DI_IoC_Autofac_Net_Core.Common;

namespace DI_IoC_Autofac_Net_Core.Models
{
    public class Transient
    {
        public readonly int _Number;

        public Transient()
        {
            _Number = Utils.randNumber();
        }
        public int getRandNumber()
        {
            return _Number;
        }
    }
}