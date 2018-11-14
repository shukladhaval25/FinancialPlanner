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
    public class CRMGroupController : ApiController
    {
        [Route("api/CRMGroup/GetAll")]
        [HttpGet]
        public Result<IList<CRMGroup>> GetAll()
        {
            var result = new Result<IList<CRMGroup>>();
            CRMGroupService CRMGroupService = new CRMGroupService();

            var lstClient = CRMGroupService.Get();
            result.Value = (IList<CRMGroup>)lstClient;
            result.IsSuccess = true;
            return result;
        }
        

        [Route("api/CRMGroup/Add")]
        [HttpPost]
        public Result Add(CRMGroup crmGroup)
        {
            var result = new Result();
            try
            {
                CRMGroupService CRMGroupService = new CRMGroupService();
                CRMGroupService.Add(crmGroup);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/CRMGroup/Delete")]
        [HttpDelete]
        public Result Delete(CRMGroup CRMGroup)
        {
            var result = new Result();
            try
            {
                CRMGroupService CRMGroupService = new CRMGroupService();
                CRMGroupService.Delete(CRMGroup);
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
