using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.Plans;

namespace FinancialPlanner.Controllers
{
    public class DocumentController : ApiController
    {
        [Route("api/Document/GetAll")]
        [HttpGet]
        public Result<IList<Document>> GetAll(int plannerId)
        {
            var result = new Result<IList<Document>>();
            DocumentService DocumentService = new DocumentService();
            result.Value = DocumentService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Document/GetByID")]
        [HttpGet]
        public Result<Document> Get(int id, int plannerId)
        {
            var result = new Result<Document>();
            DocumentService DocumentService = new DocumentService();
            result.Value = DocumentService.GetById(id, plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Document/Add")]
        [HttpPost]
        public Result Add(Document Document)
        {
            var result = new Result();
            try
            {
                DocumentService DocumentService = new DocumentService();
                DocumentService.Add(Document);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Document/Update")]
        [HttpPost]
        public Result Update(Document Document)
        {
            var result = new Result();
            try
            {
                DocumentService DocumentService = new DocumentService();
                DocumentService.Update(Document);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Document/Delete")]
        [HttpDelete]
        public Result Delete(Document Document)
        {
            var result = new Result();
            try
            {
                DocumentService DocumentService = new DocumentService();
                DocumentService.Delete(Document);
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
