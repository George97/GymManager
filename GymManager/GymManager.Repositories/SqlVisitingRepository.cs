using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using GymManager.Entities;

namespace GymManager.Repositories
{
    public class SqlVisitingRepository : SqlBaseRepository, IVisitingRepository
    {
        public SqlVisitingRepository(string connection) : base(connection)
        {
        }

        /// <summary>
        /// Select all Visits from data base.
        /// </summary>
        public IEnumerable<Visiting> SelectAllVisits()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT CardNumber, KeyNumber, DateVisit FROM tblVisiting", connection))
                {
                    var visitsList = new List<Visiting>();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            visitsList.Add(new Visiting
                            {
                                CardNumber = reader["CardNUmber"] is DBNull 
                                ? 0 
                                : Convert.ToInt32(reader["CardNumber"], 
                                    CultureInfo.CurrentCulture),

                                KeyNumber = reader["KeyNumber"] is DBNull 
                                ? 0 
                                : Convert.ToInt32(reader["KeyNumber"], 
                                    CultureInfo.CurrentCulture),

                                DateVisit = reader["DateVisit"] is DBNull 
                                ? "01/01/1753" 
                                : reader["DateVisit"].ToString().Remove(10)
                            });
                        }

                    }
                    return visitsList;
                }

            }
        }

        /// <summary>
        /// Insert information about new visit, user identify by his Card Number.
        /// In Date visit write today date auto.
        /// </summary>
        public int InsertNewVisit(Visiting obj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spAddNewVisit",connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CardNumber", obj.CardNumber);
                    command.Parameters.AddWithValue("@KeyNumber", obj.KeyNumber);
                    var resultValue = command.Parameters.Add("@Result", SqlDbType.Int);
                    resultValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    return (int)command.Parameters["@Result"].Value;
                }
            }
        }

        /// <summary>
        /// Get information about visits what use the selected Key.
        /// </summary>
        public IEnumerable<Visiting> GetVisitsByKeyNumber(Visiting obj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spGetVisitsByKeyNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@KeyNumber", obj.KeyNumber);

                    var visitsList = new List<Visiting>();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           visitsList.Add(new Visiting
                           {
                            CardNumber = reader["CardNumber"] is DBNull 
                            ? 0 
                            : (int) reader["CardNumber"],

                            KeyNumber = reader["KeyNumber"] is DBNull 
                            ? 0 
                            : (int)reader["KeyNumber"],

                            DateVisit = reader["DateVisit"] is DBNull 
                            ? "01/01/1753" 
                            : reader["DateVisit"].ToString().Remove(10)
                           });
                        }
                    }
                    return visitsList;
                }
            }
        }

        /// <summary>
        /// Get information about visits in the selected Date.
        /// </summary>
        public IEnumerable<Visiting> GetVisitsByDateVisit(Visiting obj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spGetVisitsByDateVisit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DateVisit", obj.DateVisit);
                    
                    var visitList = new List<Visiting>();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            visitList.Add(new Visiting
                            {
                                CardNumber = reader["CardNumber"] is DBNull 
                                ? 0 
                                : (int)reader["CardNumber"],

                                KeyNumber = reader["KeyNumber"] is DBNull 
                                ? 0 
                                : (int)reader["KeyNumber"],

                                DateVisit = reader["DateVisit"] is DBNull 
                                ? "01/01/1753" 
                                : reader["DateVisit"].ToString().Remove(10)
                            });
                        }

                    }
                    return visitList;
                }
            }
        }

    }
}
