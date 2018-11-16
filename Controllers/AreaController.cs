using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.ApplicationMaster;

namespace FinancialPlanner.Controllers
{
    public class AreaController : ApiController
    {
        [Route("api/Area/GetAll")]
        [HttpGet]
        public Result<IList<Area>> GetAll()
        {
            var result = new Result<IList<Area>>();
            AreaService AreaService = new AreaService();

            var lstClient = AreaService.Get();
            result.Value = (IList<Area>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Area/Add")]
        [HttpPost]
        public Result Add(Area Area)
        {
            var result = new Result();
            try
            {
                AreaService AreaService = new AreaService();
                AreaService.Add(Area);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Area/Delete")]
        [HttpDelete]
        public Result Delete(Area Area)
        {
            var result = new Result();
            try
            {
                AreaService AreaService = new AreaService();
                AreaService.Delete(Area);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }
    }
}
