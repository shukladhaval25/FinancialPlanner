using FinancialPlanner.BusinessLogic.LifeInsurance;
using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Reports
{
    public class PremiumReminderController : ApiController
    {
        [Route("api/PremiumReminder/GetLicPremiumDueDate")]
        [HttpGet]
        public Result<IList<LicPremiumReminder>> GetLicPremiumDueDate(DateTime fromDate,DateTime toDate)
        {
            var result = new Result<IList<LicPremiumReminder>>();
            LifeInsuranceService lifeInsuranceService = new LifeInsuranceService();
            result.Value = lifeInsuranceService.GetByPremiumdate(fromDate, toDate);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/PremiumReminder/GetRenewalDueDate")]
        [HttpGet]
        public Result<IList<GeneralInsuranceRenewalReminder>> GetRenewalDueDate(DateTime fromDate, DateTime toDate)
        {
            var result = new Result<IList<GeneralInsuranceRenewalReminder>>();
            GeneralInsuranceService generalInsuranceService = new GeneralInsuranceService();
            result.Value = generalInsuranceService.GetRenewalReminder(fromDate, toDate);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/PremiumReminder/GetLICPolicyMaturity")]
        [HttpGet]
        public Result<IList<LicPremiumReminder>> GetLICPolicyMaturity(DateTime fromDate, DateTime toDate)
        {
            var result = new Result<IList<LicPremiumReminder>>();
            LifeInsuranceService lifeInsuranceService = new LifeInsuranceService();
            result.Value = lifeInsuranceService.GetLICPolicyMaturity(fromDate, toDate);
            result.IsSuccess = true;
            return result;
        }
    }
}
