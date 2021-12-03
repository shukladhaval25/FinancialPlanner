using FinancialPlanner.BusinessLogic.Plans;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class OtherRecommendationSettingController : ApiController
    {
        [Route("api/OtherRecommendationSetting/GetAll")]
        [HttpGet]
        public Result<IList<OtherRecommendationSetting>> GetAll(int planId)
        {
            var result = new Result<IList<OtherRecommendationSetting>>();
            OtherRecommedationSettingService otherRecommedationSettingService = new OtherRecommedationSettingService();

            var otherRecommendationSettings = otherRecommedationSettingService.GetAll(planId);
            result.Value = (IList<OtherRecommendationSetting>)otherRecommendationSettings;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/OtherRecommendationSetting/Update")]
        [HttpPost]
        public Result Update(IList<OtherRecommendationSetting> otherRecommendationSettings)
        {
            var result = new Result();
            try
            {
                OtherRecommedationSettingService otherRecommedationSettingService = new OtherRecommedationSettingService();
                otherRecommedationSettingService.Update(otherRecommendationSettings);
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
