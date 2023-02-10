using FinancialPlanner.BusinessLogic.Approval;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.Approval;
using FinancialPlanner.Common.Model.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Approval
{
    public class ApprovalController : ApiController
    {
        [Route("api/Approval/GetAll")]
        [HttpGet]
        public Result<IList<ApprovalDTO>> GetAll(ApprovalType approvalType, string userId)
        {
            var result = new Result<IList<ApprovalDTO>>();
            ApprovalService approvalService = new ApprovalService();
            result.Value = approvalService.GetApprovals(approvalType, userId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Approval/GetApprovalItemsById")]
        [HttpGet]
        public Result<IList<ApprovalDTO>> GetApprovalItemsById(int itemId)
        {
            var result = new Result<IList<ApprovalDTO>>();
            ApprovalService approvalService = new ApprovalService();
            result.Value = approvalService.GetApprovals(itemId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Approval/Add")]
        [HttpPost]
        public Result Add(ApprovalDTO approval)
        {
            var result = new Result();
            try
            {
                ApprovalService approvalService = new ApprovalService();
                approvalService.Add(approval);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Approval/Approve")]
        [HttpPost]
        public Result<bool> Approve(ApprovalDTO approval)
        {
            Result<bool> result = new Result<bool>();
            try
            {
                ApprovalService approvalService = new ApprovalService();
                result.Value = approvalService.Approved(approval);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Approval/Reject")]
        [HttpPost]
        public Result Reject(ApprovalDTO approval)
        {
            Result<bool> result = new Result<bool>();
            try
            {
                ApprovalService approvalService = new ApprovalService();
                result.Value = approvalService.Reject(approval);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Approval/Reassign")]
        [HttpPost]
        public Result<bool> Reassign(ApprovalDTO approval)
        {
            Result<bool> result = new Result<bool>();
            try
            {
                ApprovalService approvalService = new ApprovalService();
                result.Value =  approvalService.Reassign(approval);
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