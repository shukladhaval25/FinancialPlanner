using FinancialPlanner.BusinessLogic.Clients;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class FamilyMemberController : ApiController
    {
        [Route("api/FamilyMember/GetAll")]
        [HttpGet]
        public Result<IList<FamilyMember>> GetAll(int clientId)
        {
            var result = new Result<IList<FamilyMember>>();
            FamilyMemberService familyMemberService = new FamilyMemberService();

            var lstClient = familyMemberService.Get(clientId);
            result.Value = (IList<FamilyMember>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/FamilyMember/GetById")]
        [HttpGet]
        public Result<FamilyMember> Get(int id,int clientId)
        {
            var result = new Result<FamilyMember>();
            FamilyMemberService familyMemberService = new FamilyMemberService();

            var lstClient = familyMemberService.Get(id,clientId);
            result.Value = (FamilyMember)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/FamilyMember/Add")]
        [HttpPost]
        public Result Add(FamilyMember familyMember)
        {
            var result = new Result();
            try
            {
                FamilyMemberService familyMemberService = new FamilyMemberService();
                familyMemberService.Add(familyMember);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/FamilyMember/Update")]
        [HttpPost]
        public Result Update(FamilyMember familyMember)
        {
            var result = new Result();
            try
            {
                FamilyMemberService familyMemberService = new FamilyMemberService();
                familyMemberService.Update(familyMember);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/FamilyMember/Delete")]
        [HttpDelete]
        public Result Delete(FamilyMember familyMember)
        {
            var result = new Result();
            try
            {
                FamilyMemberService familyMemberService = new FamilyMemberService();
                familyMemberService.Delete(familyMember);
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
