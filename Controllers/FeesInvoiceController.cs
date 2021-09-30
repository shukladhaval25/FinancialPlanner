using FinancialPlanner.BusinessLogic.Clients;
using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class FeesInvoiceController : ApiController
    {
        [Route("api/FeesInvoice/GetAll")]
        [HttpGet]
        //[Authorize]
        public Result<IList<FeesInvoiceTransacation>> GetAll(int clientId)
        {
            var result = new Result<IList<FeesInvoiceTransacation>>();
            FeesInvoiceService feesInvoice = new FeesInvoiceService();
            result.Value = feesInvoice.GetFeesInvoice(clientId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/FeesInvoiceDetails/Delete")]
        [HttpDelete]
        public Result Delete(int Id)
        {
            var result = new Result();
            try
            {
                FeesInvoiceService momService = new FeesInvoiceService();
                momService.DeleteFeesInvoiceDetails(Id);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }


        [Route("api/FeesInvoice/Add")]
        [HttpPost]
        public Result Add(FeesInvoiceTransacation feesInvoiceTransacation)
        {
            var result = new Result<int>();
            try
            {
                FeesInvoiceService feesInvoiceService = new FeesInvoiceService();
                feesInvoiceService.Add(feesInvoiceTransacation);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/FeesInvoice/Update")]
        [HttpPost]
        public Result Update(FeesInvoiceTransacation feesInvoiceTransacation)
        {
            var result = new Result<int>();
            try
            {
                FeesInvoiceService feesInvoiceService = new FeesInvoiceService();
                feesInvoiceService.Update(feesInvoiceTransacation);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/FeesInvoice/Delete")]
        [HttpDelete]
        public Result Delete(string InvoiceId)
        {
            var result = new Result();
            try
            {
                FeesInvoiceService feesInvoiceService = new FeesInvoiceService();
                feesInvoiceService.Delete(InvoiceId);
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
