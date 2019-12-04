using FinancialPlanner.BusinessLogic.Permissions;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Permission;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Permissions
{
    public class FormsController : ApiController
    {
        [Route("api/Forms/GetAll")]
        [HttpGet]
        public Result<IList<Forms>> GetAll()
        {
            var result = new Result<IList<Forms>>();
            FormsService formsService = new FormsService();
            result.Value = formsService.GetAll();
            result.IsSuccess = true;
            return result;
        }
    }
}
