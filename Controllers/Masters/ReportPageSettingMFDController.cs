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
    public class ReportPageSettingMFDController : ApiController
    {
        [Route("api/ReportPageSettingMFD/GetAll")]
        [HttpGet]
        public Result<string> GetAll()
        {
            var result = new Result<string>();
            ReportPageSettingForMFD reportPageSettingService = new ReportPageSettingForMFD();

            var reportPageSettings = reportPageSettingService.Get();
            result.Value = (string)reportPageSettings;
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
                ReportPageSettingForMFD reportPageSettingMFD = new ReportPageSettingForMFD();
                reportPageSettingMFD.Update(reportPageSetting);
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
