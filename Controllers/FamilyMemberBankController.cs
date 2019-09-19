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
    public class FamilyMemberBankController : ApiController
    {
        [Route("api/FamilyMemberBank/GetAll")]
        [HttpGet]
        public Result<IList<FamilyMemberBank>> GetAll(int accountHolderId)
        {
            var result = new Result<IList<FamilyMemberBank>>();
            FamilyMemberBankService familyMemberService = new FamilyMemberBankService();

            var lstClient = familyMemberService.Get(accountHolderId);
            result.Value = (IList<FamilyMemberBank>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/FamilyMemberBank/GetAll")]
        [HttpGet]
        public Result<IList<FamilyMemberBank>> GetAll(int accountHolderId,int id)
        {
            var result = new Result<IList<FamilyMemberBank>>();
            FamilyMemberBankService familyMemberService = new FamilyMemberBankService();

            var lstClient = familyMemberService.Get(accountHolderId,id);
            result.Value = (IList<FamilyMemberBank>)lstClient;
            result.IsSuccess = true;
            return result;
        }
        [Route("api/FamilyMemberBank/Add")]
        [HttpPost]
        public Result Add(FamilyMemberBank familyMemberBank)
        {
            var result = new Result();
            try
            {
                FamilyMemberBankService familyMemberService = new FamilyMemberBankService();
                familyMemberService.Add(familyMemberBank);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/FamilyMemberBank/Update")]
        [HttpPost]
        public Result Update(FamilyMemberBank familyMemberBank)
        {
            var result = new Result();
            try
            {
                FamilyMemberBankService familyMemberService = new FamilyMemberBankService();
                familyMemberService.Update(familyMemberBank);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/FamilyMemberBank/Delete")]
        [HttpDelete]
        public Result Delete(FamilyMemberBank familyMemberBank)
        {
            var result = new Result();
            try
            {
                FamilyMemberBankService familyMemberService = new FamilyMemberBankService();
                familyMemberService.Delete(familyMemberBank);
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
