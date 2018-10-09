using FinancialPlanner.BusinessLogic.Users;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
        public Result<IList<User>> Get()
        {
            var result = new Result<IList<User>>();
            UserService userService = new UserService();

            var lstAppConfig = userService.Get();
            result.Value = (IList<User>)lstAppConfig;
            result.IsSuccess = true;
            return result;
        }

        // GET: api/User/5
        public Result<User> Get(int id)
        {
            var result = new Result<User>();
            UserService userService = new UserService();

            var user = userService.Get(id);
            result.Value = user;
            result.IsSuccess = true;
            return result;
        }
        //[HttpPost]
        //public Result<User> GetUserByName(string username)
        //{
        //    var result = new Result<User>();
        //    UserService userService = new UserService();

        //    var user = userService.GetUserByName(username);
        //    result.Value = user;
        //    result.IsSuccess = true;
        //    return result;
        //}

        // POST: api/
        [HttpPost]
        public Result Add(User user)
        {
            var result = new Result();
            try
            {
                UserService userService = new UserService();
                userService.Add(user);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }

            return result;
        }
        [Route("api/User/SetAdminAccount")]
        [HttpPost]
        public Result SetAdminAccount(User user)
        {
            var result = new Result();
            try
            {
                UserService userService = new UserService();
                userService.SetAdminAccount(user);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }

            return result;
        }

        // PUT: api/User/5
        [HttpPut]
        public Result Update(User user)
        {
            var result = new Result();
            try
            {
                UserService userService = new UserService();
                userService.Update(user);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                //result.ExceptionInfo = new ExceptionInfo(exception);
            }

            return result;
        }

        [Route("api/User/Remove")]
        [HttpPost]
        public Result Remove(User user)
        {
            var result = new Result();
            try
            {
                UserService userService = new UserService();
                userService.Delete(user);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }

            return result;
        }

        [Route("api/User/GetAdminStatus")]
        [HttpGet]
        public Result<User> GetAdminStatus()
        {
            var result = new Result<User>();
            UserService userService = new UserService();

            var user = userService.GetUserByName("Admin");
            result.Value = user;
            result.IsSuccess = true;
            return result;
        }        
    }
}
