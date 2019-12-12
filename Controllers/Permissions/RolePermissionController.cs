using FinancialPlanner.BusinessLogic.Permissions;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Permission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Permissions
{
    public class RolePermissionController : ApiController
    {
        [Route("api/RolePermission/GetAll")]
        [HttpGet]
        public async Task<Result<IList<Role>>> GetAll()
        {
            var result = new Result<IList<Role>>();
            RolePermissionService rolePermissionService = new RolePermissionService();
            result.Value = await rolePermissionService.GetAll();
            result.IsSuccess = true;
            return result;
        }

        [Route("api/RolePermission/Add")]
        [HttpPost]
        public async Task<Result> Add(Role role)
        {
            var result = new Result();
            try
            {
                RolePermissionService rolePermissionService = new RolePermissionService();
                await rolePermissionService.Add(role);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/RolePermission/Update")]
        [HttpPost]
        public async Task<Result> Update(Role role)
        {
            var result = new Result();
            try
            {
                RolePermissionService rolePermissionService = new RolePermissionService();
                await rolePermissionService.Update(role);
                result.IsSuccess = true;
                
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/RolePermission/Delete")]
        [HttpPost]
        public async Task<Result> Delete(Role role)
        {
            var result = new Result();
            try
            {
                RolePermissionService rolePermissionService = new RolePermissionService();
                await rolePermissionService.Delete(role);
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
