using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManager.Entities;

namespace GymManager.Repositories
{
    public class SqlViewRepository : SqlBaseRepository, ISqlViewRepository
    {
        public SqlViewRepository(string connection) : base(connection)
        {
        }
        public List<View> SelectView()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (
                    var command = new SqlCommand("SELECT * FROM vAllInfo", connection))
                {
                    var viewList = new List<View>();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            viewList.Add(new View
                            {
                            Id = reader["Id"] is DBNull
                                ? 0
                                : Convert.ToInt32(reader["Id"],
                                    CultureInfo.CurrentCulture),

                            NameSurname = reader["Name Surname"] is DBNull
                                ? String.Empty
                                : reader["Name Surname"].ToString(),

                            Email = reader["E-mail"] is DBNull
                                ? String.Empty
                                : reader["E-mail"].ToString(),

                            Phone = reader["Phone"] is DBNull
                                ? String.Empty
                                : reader["Phone"].ToString(),

                            CardNumber = reader["Card Number"] is DBNull
                                ? 0
                                : Convert.ToInt32(reader["Card Number"]),

                            CardType = reader["Card Type"] is DBNull
                                ? String.Empty
                                : reader["Card Type"].ToString(),

                            RegistrationDate = reader["Registration Date"] is DBNull
                                ? String.Empty
                                : reader["Registration Date"].ToString(),

                            EndDate = reader["End Date"] is DBNull
                                ? String.Empty
                                : reader["End Date"].ToString(),

                            Balance = reader["Balance"] is DBNull
                                ? 0
                                : Convert.ToInt32(reader["Balance"]),

                            AdministratorName = reader["Administrator"] is DBNull
                                ? String.Empty
                                : reader["Administrator"].ToString(),

                            CardStatus = reader["Card Status"] is DBNull
                                ? String.Empty
                                : reader["Card Status"].ToString()
                            });
                        }

                    }
                    return viewList;
                }
            }
        }
    }
}
