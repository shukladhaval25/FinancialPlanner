using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.ApplicationMaster;

namespace FinancialPlanner.Controllers.Master
{
    public class OrganisationTypeController : ApiController
    {

        [Route("api/OrganisationType/GetAll")]
        [HttpGet]
        public Result<IList<OrganisationType>> GetAll()
        {
            var result = new Result<IList<OrganisationType>>();
            OrganisationTypeService OrganisationTypeService = new OrganisationTypeService();

            var lstClient = OrganisationTypeService.Get();
            result.Value = (IList<OrganisationType>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/OrganisationType/Add")]
        [HttpPost]
        public Result Add(OrganisationType OrganisationType)
        {
            var result = new Result();
            try
            {
                OrganisationTypeService OrganisationTypeService = new OrganisationTypeService();
                OrganisationTypeService.Add(OrganisationType);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/OrganisationType/Update")]
        [HttpPost]
        public Result Update(OrganisationType OrganisationType)
        {
            var result = new Result();
            try
            {
                OrganisationTypeService OrganisationTypeService = new OrganisationTypeService();
                OrganisationTypeService.Update(OrganisationType);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/OrganisationType/Delete")]
        [HttpDelete]
        public Result Delete(OrganisationType OrganisationType)
        {
            var result = new Result();
            try
            {
                OrganisationTypeService OrganisationTypeService = new OrganisationTypeService();
                OrganisationTypeService.Delete(OrganisationType);
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
