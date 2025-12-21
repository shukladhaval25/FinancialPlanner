using FinancialPlanner.BusinessLogic.Plans;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.MFD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Planner
{
    public class MFDInstumentMappedController : ApiController
    {
        [Route("api/MFDInstrumentMapped/GetAll")]
        [HttpGet]
        public Result<IList<MFDInstrumentMapped>> GetAll(int plannerId,int GoalId)
        {
            var result = new Result<IList<MFDInstrumentMapped>>();
            MFDInstumentMappedService instumentMappedService = new MFDInstumentMappedService();
            result.Value = instumentMappedService.GetAll(plannerId,GoalId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/MFDInstrumentMapped/GetByID")]
        [HttpGet]
        public Result<MFDInstrumentMapped> Get(int id, int plannerId)
        {
            var result = new Result<MFDInstrumentMapped>();
            MFDInstumentMappedService instumentMappedService = new MFDInstumentMappedService();
            result.Value = instumentMappedService.GetById(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/MFDInstrumentMapped/Add")]
        [HttpPost]
        public Result Add(MFDInstrumentMapped instrumentMapped)
        {
            var result = new Result();
            try
            {
                MFDInstumentMappedService instumentMappedService = new MFDInstumentMappedService();
                instumentMappedService.Add(instrumentMapped);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/MFDInstrumentMapped/Update")]
        [HttpPost]
        public Result Update(MFDInstrumentMapped instrumentMapped)
        {
            var result = new Result();
            try
            {
                MFDInstumentMappedService instumentMappedService = new MFDInstumentMappedService();
                instumentMappedService.Update(instrumentMapped);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/MFDInstrumentMapped/Delete")]
        [HttpPost]
        public Result Delete(MFDInstrumentMapped instrumentMapped)
        {
            var result = new Result();
            try
            {
                MFDInstumentMappedService instumentMappedService = new MFDInstumentMappedService();
                instumentMappedService.Delete(instrumentMapped);
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
