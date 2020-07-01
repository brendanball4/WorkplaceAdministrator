using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkplaceAdministrator.Blazor.Repositories;
using WorkplaceAdministrator.Common;
using WorkplaceAdministrator.Common.Dtos;

namespace WorkplaceAdministrator.Blazor
{
    public interface ISchedulingService
    { 
        Task<List<ShiftReadEditDto>> GetAllShifts();
        Task<List<AccountAdminListDto>> GetAllAccounts();
        Task<List<Position>> GetAllPositions();
    }

    public class SchedulingService : ISchedulingService
    {
        private readonly IShiftRepo _shiftRepo;
        private readonly IAccountRepo _accountRepo;
        private readonly IPositionRepo _positionRepo;

        public Task<List<AccountAdminListDto>> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public Task<List<Position>> GetAllPositions()
        {
            throw new NotImplementedException();
        }

        public Task<List<ShiftReadEditDto>> GetAllShifts()
        {
            throw new NotImplementedException();
        }
    }
}
