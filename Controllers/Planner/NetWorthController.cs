using FinancialPlanner.Common.Model;
using FinancialPlanner.BusinessLogic.PlanOption;
using System.Collections.Generic;
using System.Web.Http;
using System;

namespace FinancialPlanner.Controllers.Planner
{
    public class NetWorthController : ApiController
    {
        [Route("api/NetWorth/GetByClient")]
        [HttpGet]
        public Result<IList<NetWorth>> GetByClient(int clientId)
        {
            var result = new Result<IList<NetWorth>>();
            NetWorthService NetWorthService = new NetWorthService();

            var lstNetWorth = NetWorthService.Get(clientId);
            result.Value = (IList<NetWorth>)lstNetWorth;
            result.IsSuccess = true;
            return result;
        }

        //    [Route("api/NetWorth/GetAll")]
        //    [HttpGet]
        //    public Result<IList<NetWorth>> GetAll(int amcId)
        //    {
        //        var result = new Result<IList<NetWorth>>();
        //        NetWorthService NetWorthService = new NetWorthService();

        //        result.Value = NetWorthService.GetAll(amcId);
        //        result.IsSuccess = true;
        //        return result;
        //    }

        //    //[Route("api/NetWorth/GetNetWorthCount")]
        //    //[HttpGet]
        //    //public Result<int> GetCount(int amcId)
        //    //{
        //    //    var result = new Result<int>();
        //    //    NetWorthService NetWorthService = new NetWorthService();
        //    //    result.Value = NetWorthService.Get(amcId);
        //    //    result.IsSuccess = true;
        //    //    return result;
        //    //}

        [Route("api/NetWorth/Add")]
        [HttpPost]
        public Result Add(NetWorth NetWorth)
        {
            var result = new Result();
            try
            {
                NetWorthService NetWorthService = new NetWorthService();
                NetWorthService.Add(NetWorth);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/NetWorth/Update")]
        [HttpPost]
        public Result Update(NetWorth NetWorth)
        {
            var result = new Result();
            try
            {
                NetWorthService NetWorthService = new NetWorthService();
                NetWorthService.Update(NetWorth);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/NetWorth/Delete")]
        [HttpDelete]
        public Result Delete(NetWorth NetWorth)
        {
            var result = new Result();
            try
            {
                NetWorthService NetWorthService = new NetWorthService();
                NetWorthService.Delete(NetWorth);
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
