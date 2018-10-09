using FinancialPlanner.BusinessLogic.DataBase;
using System;
using System.Web.Http;

namespace FinancialPlanner
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public const string CLIENT_Token = "CLIENTToken";
        public const string USERNAME = "UserName";
         
        IDBConfiguration SQLConfig; 
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            string connectionString =  System.Configuration.ConfigurationSettings.AppSettings.Get("connectionString");
            SQLConfig = new BusinessLogic.DataBase.SQLConfiguration(connectionString);
            DBService.setDataBaseConfig(SQLConfig);
        }
    }
    //protected void Application_AcquireRequestState(Object sender, EventArgs e)
    //{
    //}
}
