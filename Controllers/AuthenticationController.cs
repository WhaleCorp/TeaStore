using Microsoft.AspNetCore.Mvc;
using TeaStoreApi.Context;

namespace TeaStoreApi.Controllers
{
    public class AuthenticationController:ControllerBase
    {
        private dbcontext db;
        public AuthenticationController(dbcontext db)
        {
            this.db = db;
        }
    }
}
