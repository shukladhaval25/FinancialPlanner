using FinancialPlanner.BusinessLogic.Plans;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class NonFinancialAssetController : ApiController
    {
        [Route("api/NonFinancialAsset/GetAll")]
        [HttpGet]
        public Result<IList<NonFinancialAsset>> GetAll(int plannerId)
        {
            var result = new Result<IList<NonFinancialAsset>>();
            NonFinancialAssetService nonFinanacialAssetService = new NonFinancialAssetService();           
            result.Value = nonFinanacialAssetService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/NonFinancialAsset/GetByID")]
        [HttpGet]
        public Result<NonFinancialAsset> Get(int id, int plannerId)
        {
            var result = new Result<NonFinancialAsset>();
            NonFinancialAssetService nonFinanacialAssetService = new NonFinancialAssetService();
            result.Value = nonFinanacialAssetService.GetByID(id, plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/NonFinancialAsset/Add")]
        [HttpPost]
        public Result Add(NonFinancialAsset nonFinancialAsset)
        {
            var result = new Result();
            try
            {
                NonFinancialAssetService nonFinanacialAssetService = new NonFinancialAssetService();
                nonFinanacialAssetService.Add(nonFinancialAsset);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }


        [Route("api/NonFinancialAsset/Update")]
        [HttpPost]
        public Result Update(NonFinancialAsset nonFinancialAsset)
        {
            var result = new Result();
            try
            {
                NonFinancialAssetService nonFinanacialAssetService = new NonFinancialAssetService();
                nonFinanacialAssetService.Update(nonFinancialAsset);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }


        [Route("api/NonFinancialAsset/Delete")]
        [HttpPost]
        public Result Delete(NonFinancialAsset nonFinancialAsset)
        {
            var result = new Result();
            try
            {
                NonFinancialAssetService nonFinanacialAssetService = new NonFinancialAssetService();
                nonFinanacialAssetService.Delete(nonFinancialAsset);
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
