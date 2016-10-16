using System.Collections.Generic;
using GymManager.Entities;

namespace GymManager.Repositories
{
    interface ICustomerRepository
    {
        IEnumerable<Customer> SelectAllCustomers();

        int AddNewCustomer(Customer obj);

        int ChangePhoneNumber(Customer obj);

        int ChangeEmail(Customer obj);

        int ChangeAddress(Customer obj);
    }
}
