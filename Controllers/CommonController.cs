using FinancialPlanner.BusinessLogic;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class CommonController : ApiController
    {
        [Route("api/CommonController/GetFileString")]
        [HttpGet]
        public Result<string> GetString(string filePath)
        {
            var result = new Result<string>();
            result.Value = new CommonService().GetString(filePath);
            result.IsSuccess = true;
            return result;
        }
    }
}
