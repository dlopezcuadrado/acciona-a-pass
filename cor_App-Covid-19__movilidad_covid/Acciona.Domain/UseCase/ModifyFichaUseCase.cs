﻿using Acciona.Domain.Model;
using Acciona.Domain.Model.Base;
using Acciona.Domain.Model.Employee;
using Acciona.Domain.Model.Master;
using Acciona.Domain.Repository;
using ServiceLocator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acciona.Domain.UseCase
{
    public class ModifyFichaUseCase
    {
        private IEmployeeRepository employeeRepository;        

        public ModifyFichaUseCase()
        {
            employeeRepository = Locator.Current.GetService<IEmployeeRepository>();
        }

        public async Task<TaskGenericResponse> Execute(string telephone,long? idLocalization)
        {
            try
            {
                var appSession = Locator.Current.GetService<AppSession>();
                await employeeRepository.ModifyFicha(appSession.UserInfo.IdEmpleado,telephone,idLocalization);
                return new TaskGenericResponse();
            }
            catch (Exception e)
            {
                ApiException errorException = e as ApiException;
                if (errorException != null)
                    return new TaskGenericResponse() { ErrorCode = errorException.Code, Message = errorException.Error };
                else
                    return new TaskGenericResponse() { ErrorCode = 600, Message = e.Message };
            }
        }
    }
}
