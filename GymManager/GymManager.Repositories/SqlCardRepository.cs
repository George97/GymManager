using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;
using GymManager.Entities;

namespace GymManager.Repositories
{
    public class SqlCardRepository : SqlBaseRepository, ICardRepository
    {
        public SqlCardRepository(string connection) : base(connection)
        {
        }
        /// <summary>
        /// Select all card and information about they. 
        /// </summary>
        public IEnumerable<Card> SelectAllCards()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT CardNumber, TypeCard, RegistrationDate, EndDate, IsActive, Price, AdminId FROM tblCard", connection))
                {
                    var cardList = new List<Card>();
                    
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cardList.Add(new Card
                            {
                            CardNumber = reader["CardNumber"] is DBNull 
                            ? 0 
                            : Convert.ToInt32(reader["CardNumber"],
                                CultureInfo.CurrentCulture),

                            TypeCard = reader["TypeCard"] is DBNull 
                            ? String.Empty
                            : reader["TypeCard"].ToString(),

                            RegistrationDate = reader["RegistrationDate"] is DBNull 
                            ? DateTime.MinValue 
                            : (DateTime) reader["RegistrationDate"],

                            EndDate = reader["EndDate"] is DBNull 
                            ? DateTime.MinValue 
                            : (DateTime)reader["EndDate"],

                            IsActive = Convert.ToBoolean(reader["IsActive"]),

                            Price = reader["Price"] is DBNull 
                            ? 0 : Decimal.Round(Convert.ToDecimal(reader["Price"], 
                                CultureInfo.CurrentCulture),0),
                            
                            AdminId = reader["AdminId"] is DBNull 
                            ? 0 
                            : Convert.ToInt32(reader["AdminId"], 
                                CultureInfo.CurrentCulture)
                            });
                        }

                    }
                    return cardList;
                }
            }
        }
        /// <summary>
        /// Return how many days card is active.
        /// </summary>
        public int GetExpirationDate(Card obj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spGetExpirationDate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CardNumber", obj.CardNumber);
                    var resultValue = command.Parameters.Add("@Result", SqlDbType.Int);
                    resultValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    return (int)command.Parameters["@Result"].Value;
                }
            }
        }
        /// <summary>
        /// Change card type.
        /// </summary>
        public int ChangeCardType(Card obj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spChangeCardType", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CardNumber", obj.CardNumber);
                    command.Parameters.AddWithValue("@Type", obj.TypeCard);
                    var resultValue = command.Parameters.Add("@Result", SqlDbType.Int);
                    resultValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    return (int)command.Parameters["@Result"].Value;
                }
            }
        }

        public int ExtendCard(Card obj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spExtendCard", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Month", obj.Month);
                    command.Parameters.AddWithValue("@Price", obj.Price);
                    command.Parameters.AddWithValue("@CardNumber", obj.CardNumber);
                    var resultValue = command.Parameters.Add("@Result", SqlDbType.Int);
                    resultValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    return (int)command.Parameters["@Result"].Value;
                }
            }
        }
        /// <summary>
        /// Get balance of card. 
        /// </summary>
        public int GetBalance(Card obj)
        { 
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spGetBalance", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CardNumber", obj.CardNumber);
                    var resultValue= command.Parameters.Add("@Balance", SqlDbType.Int);
                    resultValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    return Convert.ToInt32(command.Parameters["@Balance"].Value);
                }
            }
            
        }
        /// <summary>
        /// Activate or Disable card.
        /// </summary>
        public int SetCardActive(Card obj)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spSetCardActive", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CardNumber", obj.CardNumber);
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
