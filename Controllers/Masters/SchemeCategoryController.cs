using FinancialPlanner.BusinessLogic.ApplicationMaster;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Masters
{
    public class SchemeCategoryController : ApiController
    {
        [Route("api/SchemeCategory/GetAll")]
        [HttpGet]
        public Result<IList<SchemeCategory>> GetAll()
        {
            var result = new Result<IList<SchemeCategory>>();
            SchemeCategoryService SchemeCategoryService = new SchemeCategoryService();

            var lstClient = SchemeCategoryService.Get();
            result.Value = (IList<SchemeCategory>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/SchemeCategory/Add")]
        [HttpPost]
        public Result Add(SchemeCategory schemeCategory)
        {
            var result = new Result();
            try
            {
                SchemeCategoryService AreaService = new SchemeCategoryService();
                AreaService.Add(schemeCategory);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/SchemeCategory/Delete")]
        [HttpDelete]
        public Result Delete(SchemeCategory schemeCategory)
        {
            var result = new Result();
            try
            {
                SchemeCategoryService schemeCategoryService = new SchemeCategoryService();
                schemeCategoryService.Delete(schemeCategory);
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
