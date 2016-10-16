using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using GymManager.Entities;

namespace GymManager.Repositories
{
    public class SqlAdministratorRepository : SqlBaseRepository, IAdministratorRepository
    {
        public SqlAdministratorRepository(string connection) : base(connection)
        {
        }

        /// <summary>
        /// Select administrator to use.
        /// </summary>
        public Administrator SelectAdministrator(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("spSelectAdmin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Administrator admin = null;
                        if (reader.Read())
                        {
                            admin = new Administrator();
                            admin.Id = (int)reader["Id"];
                            admin.Name = (string)reader["Name"];
                            admin.Surname = (string)reader["Surname"];
                            admin.Login = (string)reader["Login"];
                        }
                        return admin;
                    }
                }
            }
        }

        /// <summary>
        /// Select and return all information about all adminitrators. Passwords don't shows.
        /// </summary>
        public List<Administrator> SelectAllAdministrators()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (
                    var command = new SqlCommand("SELECT Id, [Name], Surname, IsActive, [Login] FROM tblAdministrator",
                        connection))
                {
                    var adminList = new List<Administrator>();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            adminList.Add(new Administrator
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

                                IsActive = Convert.ToBoolean(reader["IsActive"]),

                                Login = reader["Login"] is DBNull
                                    ? String.Empty
                                    : reader["Login"].ToString(),

                                Password = "********"
                            });
                        }

                    }
                    return adminList;
                }
            }
        }
        /// <summary>
        /// Add new administrator. Administrator account is active.
        /// </summary>
        public int AddNewAdministrator(Administrator obj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spAddNewAdministrator", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", obj.Name);
                    command.Parameters.AddWithValue("@Surname", obj.Surname);
                    command.Parameters.AddWithValue("@Login", obj.Login);
                    command.Parameters.AddWithValue("@Password", obj.Password);
                    var resultValue = command.Parameters.Add("@Id", SqlDbType.Int);
                    resultValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    return obj.Id = (int)command.Parameters["@Id"].Value;
                }
            }
            
        }
        /// <summary>
        /// Set activity account administrator. Default: true.
        /// </summary>
        public int SetActivityAdministrator(Administrator obj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spSetActivityAdministrator", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", obj.Id);
                    command.Parameters.AddWithValue("@Status", obj.IsActive);
                    var resultValue = command.Parameters.Add("@Result", SqlDbType.Int);
                    resultValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    return (int)command.Parameters["@Result"].Value;
                }

            }
        }
    }
}
