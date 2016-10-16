using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using GymManager.Entities;



namespace GymManager.Repositories
{
    public class SqlCustomerRepository : SqlBaseRepository, ICustomerRepository
    {
        public SqlCustomerRepository(string connection) : base(connection)
        {
        }
        /// <summary>
        /// Select and return information about all customers. 
        /// </summary>
        public IEnumerable<Customer> SelectAllCustomers()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT Id, Name, Surname, Street, HouseNumber, PhoneNumber, Email, CardNumber FROM tblCustomer", connection))
                {
                    var customerList = new List<Customer>();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customerList.Add(new Customer
                            {
                             Id = reader["Id"] is DBNull 
                             ? 0 
                             : Convert.ToInt32(reader["Id"], 
                                CultureInfo.CurrentCulture),

                             Name = reader["Name"] is DBNull 
                             ? String.Empty
                             : reader["Name"].ToString(),

                             Surname = reader["Surname"] is DBNull 
                             ? String.Empty
                             : reader["Surname"].ToString(),

                             Street = reader["Street"] is DBNull 
                             ? String.Empty
                             : reader["Street"].ToString(),

                             HouseNumber = reader["HouseNumber"] is DBNull 
                             ? 0 
                             : Convert.ToInt32(reader["HouseNumber"],
                                CultureInfo.CurrentCulture),

                             PhoneNumber = reader["PhoneNumber"] is DBNull 
                             ? String.Empty
                             : reader["PhoneNumber"].ToString(),

                             Email = reader["Email"] is DBNull 
                             ? String.Empty
                             : reader["Email"].ToString(),

                             CardNumber =  reader["CardNumber"] is DBNull 
                             ? 0 
                             : Convert.ToInt32(reader["CardNumber"], 
                                CultureInfo.CurrentCulture)
                            });
                        }
                    }
                    return customerList;
                }
            }
        }
        /// <summary>
        /// Add new customer and informatoin about his card. 
        /// </summary>
        public int AddNewCustomer(Customer obj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spAddNewCustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", obj.Name);
                    command.Parameters.AddWithValue("@Surname", obj.Surname);
                    command.Parameters.AddWithValue("@Street", obj.Street);
                    command.Parameters.AddWithValue("@HouseNumber", obj.HouseNumber);
                    command.Parameters.AddWithValue("@PhoneNumber", obj.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", obj.Email);
                    command.Parameters.AddWithValue("@AdminId", obj.AdminId);
                    command.Parameters.AddWithValue("@Type", obj.CardType);
                    command.Parameters.AddWithValue("@ValidityInMonth", obj.Validaty);
                    command.Parameters.AddWithValue("@Price", obj.Price);
                    var resultValue = command.Parameters.Add("@CardNumber", SqlDbType.Int);
                    resultValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    return obj.CardNumber = (int)command.Parameters["@CardNumber"].Value;
                }
            }
        }
        /// <summary>
        /// Change customer's phone number 
        /// </summary>
        public int ChangePhoneNumber(Customer obj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spChangePhoneNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PhoneNumber", obj.PhoneNumber);
                    command.Parameters.AddWithValue("@CardNumber", obj.CardNumber);
                    var resultValue = command.Parameters.Add("@Result", SqlDbType.Int);
                    resultValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    return (int)command.Parameters["@Result"].Value;
                }
            }
        }
        /// <summary>
        /// Change customer's e-mail
        /// </summary>
        public int ChangeEmail(Customer obj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spChangeEmail", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Email", obj.Email);
                    command.Parameters.AddWithValue("@CardNumber", obj.CardNumber);
                    var resultValue = command.Parameters.Add("@Result", SqlDbType.Int);
                    resultValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    return (int)command.Parameters["@Result"].Value;
                }
            }
        }
        /// <summary>
        /// Change customer's address
        /// </summary>
        public int ChangeAddress(Customer obj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spChangeAddress", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Street", obj.Street);
                    command.Parameters.AddWithValue("@HouseNumber", obj.HouseNumber);
                    command.Parameters.AddWithValue("@CardNumber", obj.CardNumber);
                    var resultValue = command.Parameters.Add("@Result", SqlDbType.Int);
                    resultValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    return (int)command.Parameters["@Result"].Value;
                }
            }
        }
    }
}
