using DI_IoC_Autofac_Net_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace DI_IoC_Autofac_Net_Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DIController : ControllerBase
    {
        private readonly Scoped _Scoped;
        private readonly Singleton _Singleton;
        private readonly Transient _Transient;

        public DIController(
            Scoped Scoped, 
            Singleton Singleton, 
            Transient Transient)
        {
            this._Scoped = Scoped;
            this._Singleton = Singleton;
            this._Transient = Transient;
        }

        [HttpGet]
        public string Get()
        {
            return string.Format("Scoped: {0} \nSingleton: {1} \nTransient: {2}", _Scoped._Number.ToString(), _Singleton._Number.ToString(), _Transient._Number.ToString());
        }
    }
}
