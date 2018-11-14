using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using FinancialPlanner.BusinessLogic.Clients;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class FestivalsController : ApiController
    {
        [Route("api/Festivals/GetAll")]
        [HttpGet]
        public Result<IList<Festivals>> GetAll()
        {
            var result = new Result<IList<Festivals>>();
            FestivalsService FestivalsService = new FestivalsService();

            var lstClient = FestivalsService.Get();
            result.Value = (IList<Festivals>)lstClient;
            result.IsSuccess = true;
            return result;
        }
              
        [Route("api/Festivals/Add")]
        [HttpPost]
        public Result Add(Festivals festivals)
        {
            var result = new Result();
            try
            {
                FestivalsService FestivalsService = new FestivalsService();
                FestivalsService.Add(festivals);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        //[Route("api/Festivals/Update")]
        //[HttpPost]
        //public Result Update(Festivals Festivals)
        //{
        //    var result = new Result();
        //    try
        //    {
        //        FestivalsService FestivalsService = new FestivalsService();
        //        FestivalsService.Update(Festivals);
        //        result.IsSuccess = true;
        //    }
        //    catch (Exception exception)
        //    {
        //        result.IsSuccess = false;
        //        result.ExceptionInfo = exception;
        //    }
        //    return result;
        //}

        [Route("api/Festivals/Delete")]
        [HttpDelete]
        public Result Delete(Festivals Festivals)
        {
            var result = new Result();
            try
            {
                FestivalsService FestivalsService = new FestivalsService();
                FestivalsService.Delete(Festivals);
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
