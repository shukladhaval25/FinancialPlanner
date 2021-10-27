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
    public class ReportPageSettingController : ApiController
    {
        [Route("api/ReportPageSetting/GetAll")]
        [HttpGet]
        public Result<IList<ReportPageSetting>> GetAll()
        {
            var result = new Result<IList<ReportPageSetting>>();
            ReportPageSettingService reportPageSettingService = new ReportPageSettingService();

            var reportPageSettings = reportPageSettingService.Get();
            result.Value = (IList<ReportPageSetting>)reportPageSettings;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ReportPageSetting/Update")]
        [HttpPost]
        public Result Update(ReportPageSetting reportPageSetting)
        {
            var result = new Result();
            try
            {
                ReportPageSettingService bankService = new ReportPageSettingService();
                bankService.Update(reportPageSetting);
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
