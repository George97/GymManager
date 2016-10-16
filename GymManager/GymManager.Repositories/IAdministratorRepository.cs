using System.Collections.Generic;
using GymManager.Entities;

namespace GymManager.Repositories
{
    interface IAdministratorRepository
    {
        Administrator SelectAdministrator(string login, string password);

        List<Administrator> SelectAllAdministrators();

        int AddNewAdministrator(Administrator obj);

        int SetActivityAdministrator(Administrator obj);
    }
}
