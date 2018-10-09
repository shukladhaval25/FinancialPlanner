using FinancialPlanner.BusinessLogic.ProspectClients;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class ProspectClientController : ApiController
    {
        // GET: api/ProspectClient
        [HttpGet]
        [Route("api/ProspectClient/GetAll")]
        public Result<IList<ProspectClient>> GetAll()
        {
            var result = new Result<IList<ProspectClient>>();
            ProspectClientService prospClientService = new ProspectClientService();
            
            var lstPropClients = prospClientService.GetAll();
            result.Value = (IList<ProspectClient>)lstPropClients;
            result.IsSuccess = true;
            return result;
        }

        [HttpGet]
        [Route("api/ProspectClient/GetByName")]
        public Result<IList<ProspectClient>> GetByName(string name)
        {
            var result = new Result<IList<ProspectClient>>();
            ProspectClientService prospClientService = new ProspectClientService();

            var lstPropClients = prospClientService.GetByName(name);
            result.Value = (IList<ProspectClient>)lstPropClients;
            result.IsSuccess = true;
            return result;
        }

        [HttpGet]
        [Route("api/ProspectClient/GetById")]
        public Result<IList<ProspectClient>> GetById(int id)
        {
            var result = new Result<IList<ProspectClient>>();
            ProspectClientService prospClientService = new ProspectClientService();

            var lstPropClients = prospClientService.GetById(id);
            result.Value = (IList<ProspectClient>)lstPropClients;
            result.IsSuccess = true;
            return result;
        }

        [HttpGet]
        [Route("api/ProspectClient/Conversation/GetByProspectClientId")]
        public Result<IList<ProspectClientConversation>> GetByProspectClientId(int id)
        {
            var result = new Result<IList<ProspectClientConversation>>();
            ProspectClientConversationService prospClientConvService = new ProspectClientConversationService();

            var lstPropClients = prospClientConvService.GetByProspectClientId(id);
            result.Value = (IList<ProspectClientConversation>)lstPropClients;
            result.IsSuccess = true;
            return result;
        }

        [HttpPost]
        [Route("api/ProspectClient/Add")]
        public Result Add(ProspectClient prospectClient)
        {
            var result = new Result();
            try
            {
                ProspectClientService prospClientService = new ProspectClientService();
                prospClientService.AddProspectClient(prospectClient);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }

            return result;
        }
        [HttpPost]
        public Result Update(ProspectClient prospectClient)
        {
            var result = new Result();
            try
            {
                ProspectClientService prospClientService = new ProspectClientService();
                prospClientService.UpdateProspectClient(prospectClient);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }

            return result;
        }
        [HttpDelete]
        [Route("api/ProspectClient/Delete")]
        public Result Delete(ProspectClient prospectClient)
        {
            var result = new Result();
            try
            {
                ProspectClientService prospClientService = new ProspectClientService();
                prospClientService.DeleteProspectClient(prospectClient);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }

            return result;
        }

        [HttpPost]
        [Route("api/ProspectClient/AddConversation")]
        public Result Add(ProspectClientConversation prospectClientConversation)
        {
            var result = new Result();
            try
            {
                ProspectClientConversationService prospClientConvService = new ProspectClientConversationService();
                prospClientConvService.AddProspectClientConversation(prospectClientConversation);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }

            return result;
        }

        [HttpPost]
        [Route("api/ProspectClient/UpdateConversation")]
        public Result UpdateConversation(ProspectClientConversation prospectClientConversation)
        {
            var result = new Result();
            try
            {
                ProspectClientConversationService prospClientConvService = new ProspectClientConversationService();
                prospClientConvService.UpdateProspectClientConversation(prospectClientConversation);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }

            return result;
        }
        
        [HttpDelete]
        [Route("api/ProspectClient/DeleteConversation")]
        public Result DeleteConversation(ProspectClientConversation prospectClientConversation)
        {
            var result = new Result();
            try
            {
                ProspectClientConversationService prospClientConvService = new ProspectClientConversationService();
                prospClientConvService.DeleteConversation(prospectClientConversation);
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
