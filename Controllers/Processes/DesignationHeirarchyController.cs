using FinancialPlanner.BusinessLogic.Process;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Planning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Processes
{
    public class DesignationHeirarchyController : ApiController
    {
        [Route("api/DesignationHierarchy/GetAll")]
        [HttpGet]
        public Result<IList<DesignationHierarchy>> GetAll()
        {
            var result = new Result<IList<DesignationHierarchy>>();
            DesignationHeirarchyService designationHeirarchyService = new DesignationHeirarchyService();
            result.Value = designationHeirarchyService.GetAll();
            result.IsSuccess = true;
            return result;
        }

        [Route("api/DesignationHierarchy/Add")]
        [HttpPost]
        public Result Add(DesignationHierarchy designationHeirarchy)
        {
            var result = new Result();
            try
            {
                DesignationHeirarchyService designationHeirarchyService = new DesignationHeirarchyService();
                designationHeirarchyService.Add(designationHeirarchy);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/DesignationHierarchy/Update")]
        [HttpPost]
        public Result Update(DesignationHierarchy designationHeirarchy)
        {
            var result = new Result();
            try
            {
                DesignationHeirarchyService designationHeirarchyService = new DesignationHeirarchyService();
                designationHeirarchyService.Update(designationHeirarchy);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/DesignationHierarchy/Delete")]
        [HttpDelete]
        public Result Delete(int Id)
        {
            var result = new Result();
            try
            {
                DesignationHeirarchyService designationHeirarchyService = new DesignationHeirarchyService();
                designationHeirarchyService.Delete(Id);
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
