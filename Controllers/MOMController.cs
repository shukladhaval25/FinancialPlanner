using FinancialPlanner.BusinessLogic.Clients;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class MOMController : ApiController
    {
        [Route("api/MOM/GetAll")]
        [HttpGet]
        //Authorize]
        public Result<IList<MOMTransaction>> GetAll(int clientId)
        {
            var result = new Result<IList<MOMTransaction>>();
            MOMService momService = new MOMService();
            result.Value = momService.GetMOM(clientId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/MOM/Add")]
        [HttpPost]
        public Result Add(MOMTransaction  mOMTransaction)
        {
            var result = new Result<int>();
            try
            {
                MOMService  momService = new MOMService();
                result.Value = momService.Add(mOMTransaction);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/MOM/Update")]
        [HttpPost]
        public Result Update(MOMTransaction mOMTransaction)
        {
            var result = new Result();
            try
            {
                MOMService momService = new MOMService();
                momService.Update(mOMTransaction);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/MOMPOints/Delete")]
        [HttpDelete]
        public Result Delete(int Id)
        {
            var result = new Result();
            try
            {
                MOMService momService = new MOMService();
                momService.DeleteMOMPoint(Id);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/MOM/Delete")]
        [HttpDelete]
        public Result DeleteMOM(int MId)
        {
            var result = new Result();
            try
            {
                MOMService momService = new MOMService();
                momService.DeleteMOM(MId);
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
