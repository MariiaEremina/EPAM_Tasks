using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Shared;

namespace Data_access_layer
{
    public class DataInDB
    {

        static string connectionString { get; set; }

        public DataInDB(string connectionPath)
        {
            connectionString = connectionPath;
        }

        static void OpenDB()
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }

        public List<User> GetUsers()
        {
            List<User> users;
            users = GetUsersWithoutRewards();
            foreach (User us in users)
            {
                us.reward = GetUserReward(us.ID);
                us.RefreshRewards(us.reward);
            }
            return users;
        }

        public List<Reward> GetUserReward(int ID)
        {
            List<Reward> rewards = new List<Reward>();
            List<int> ids = new List<int>(0);
            string sqlExpression = "GetUsersRewards";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@userId",
                    Value = ID
                };
                command.Parameters.Add(idParam);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        ids.Add(id);
                        //            int id = reader.GetInt32(0);
                        //            string title = reader.GetString(1);
                        //            string description = reader.GetString(2);
                        //            Reward newReward = new Reward(title, description, id);
                        //            rewards.Add(newReward);
                        //        }
                    }
                    reader.Close();
                }
            }
            foreach (int id in ids)
            {
                Reward newReward = GetRewardById(id);
                rewards.Add(newReward);
            }
            return rewards;
        }

        public List<User> GetUsersWithoutRewards()
        {
            List<User> users = new List<User>();
            string sqlExpression = "GetUsers";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string firstName = reader.GetString(1);
                        string lastName = reader.GetString(2);
                        DateTime birthdate = reader.GetDateTime(3);
                        User newUser = new User(firstName, lastName, birthdate, id);

                        users.Add(newUser);
                    }
                }
                reader.Close();
            }
            return users;
        }

        public List<Reward> GetRewards()
        {
            List<Reward> rewards = new List<Reward>();
            Reward newReward;
            string sqlExpression = "GetRewards";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string title = reader.GetString(1);

                        if (!reader.IsDBNull(2))
                        {
                            string description = reader.GetString(2);
                            newReward = new Reward(title, description, id);
                        }
                        else
                        {
                            newReward = new Reward(title, id);
                        }
                        
                        rewards.Add(newReward);
                    }
                }
                reader.Close();
            }
            return rewards;
        }

        //public void AddUser(User user1)
        //{
        //    if (user1.reward.Count != 0 && user1.reward!=null)
        //    {
        //        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //        string sqlExpression = "AddUser";

        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            SqlCommand command = new SqlCommand(sqlExpression, connection);
        //            command.CommandType = System.Data.CommandType.StoredProcedure;
        //            SqlParameter nameParam = new SqlParameter
        //            {
        //                ParameterName = "@newName",
        //                Value = user1.FirstName
        //            };
        //            command.Parameters.Add(nameParam);
        //            SqlParameter lastnameParam = new SqlParameter
        //            {
        //                ParameterName = "@newlastName",
        //                Value = user1.LastName
        //            };
        //            command.Parameters.Add(lastnameParam);
        //            SqlParameter birthdateParam = new SqlParameter
        //            {
        //                ParameterName = "@newBirthdate",
        //                Value = user1.Birthdate
        //            };
        //            command.Parameters.Add(birthdateParam);

        //            SqlParameter rewardsParam = new SqlParameter
        //            {
        //                ParameterName = "@List",
        //                Value = user1.reward
        //            };
        //            command.Parameters.Add(rewardsParam);


        //            //var result = command.ExecuteScalar();

        //            //var result = command.ExecuteNonQuery();

        //        }
        //    }
        //    else
        //    {
        //        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //        string sqlExpression = "AddUserWithoutRewards";

        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            SqlCommand command = new SqlCommand(sqlExpression, connection);
        //            command.CommandType = System.Data.CommandType.StoredProcedure;
        //            SqlParameter nameParam = new SqlParameter
        //            {
        //                ParameterName = "@newName",
        //                Value = user1.FirstName
        //            };
        //            command.Parameters.Add(nameParam);
        //            SqlParameter lastnameParam = new SqlParameter
        //            {
        //                ParameterName = "@newlastName",
        //                Value = user1.LastName
        //            };
        //            command.Parameters.Add(lastnameParam);
        //            SqlParameter birthdateParam = new SqlParameter
        //            {
        //                ParameterName = "@newBirthdate",
        //                Value = user1.Birthdate
        //            };
        //            command.Parameters.Add(birthdateParam);

        //            var result = command.ExecuteNonQuery();
        //        }
        //    }
        //}

        public void AddUser(User user1)
        {
            
                string sqlExpression = "AddUserWithoutRewards";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter nameParam = new SqlParameter
                    {
                        ParameterName = "@newName",
                        Value = user1.FirstName
                    };
                    command.Parameters.Add(nameParam);
                    SqlParameter lastnameParam = new SqlParameter
                    {
                        ParameterName = "@newlastName",
                        Value = user1.LastName
                    };
                    command.Parameters.Add(lastnameParam);
                    SqlParameter birthdateParam = new SqlParameter
                    {
                        ParameterName = "@newBirthdate",
                        Value = user1.Birthdate
                    };
                    command.Parameters.Add(birthdateParam);

                //var result = command.ExecuteNonQuery();
                var userId = command.ExecuteScalar();
                //var userId = command.Parameters[0].Value;
                user1.ID = (int)userId;
            }
            MakeConnection(user1);            
        }

        public void MakeConnection(User user1)
        {
            if (user1.reward.Count != 0 && user1.reward != null)
            {
                List<Reward> rew = user1.reward;
                foreach (Reward reward in rew)
                {
                    string sqlExpression = "MakeConnection";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter userParam = new SqlParameter
                        {
                            ParameterName = "@userId",
                            Value = user1.ID
                        };
                        command.Parameters.Add(userParam);
                        SqlParameter rewardParam = new SqlParameter
                        {
                            ParameterName = "@rewardId",
                            Value = reward.ID
                        };
                        command.Parameters.Add(rewardParam);
                        var result = command.ExecuteNonQuery();
                    }
                }
            }
        }

        public void AddReward(Reward reward1)
        {
            if (reward1.Description != null)
            {
                string sqlExpression = "AddReward";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter titleParam = new SqlParameter
                    {
                        ParameterName = "@newTitle",
                        Value = reward1.Title
                    };
                    command.Parameters.Add(titleParam);

                    SqlParameter desParam = new SqlParameter
                    {
                        ParameterName = "@newDescription",
                        Value = reward1.Description
                    };
                    command.Parameters.Add(desParam);

                    var result = command.ExecuteScalar();
                    
                    reward1.ID = (int)result;

                    //var result = command.ExecuteNonQuery();


                }
            }
            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                string sqlExpression = "AddRewardWithoutDescription";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter titleParam = new SqlParameter
                    {
                        ParameterName = "@newTitle",
                        Value = reward1.Title
                    };
                    command.Parameters.Add(titleParam);

                    //var result = command.ExecuteScalar();

                    //var result = command.ExecuteNonQuery();
                    var result = command.ExecuteScalar();

                    reward1.ID = (int)result;

                }
            }
        }

        public void InitUsers()
        {
            List<Reward> rewards = GetRewards();

            DateTime d1 = new DateTime(1995, 05, 02);
            User user1 = new User("Username", "First", d1);
            AddUser(user1);

            DateTime d2 = new DateTime(1992, 05, 02);
            User user2 = new User("Username", "Second", d2);
            AddUser(user2);

            DateTime d3 = new DateTime(1995, 06, 08);
            List<Reward> rewards3 = new List<Reward>();
            rewards3.Add(rewards[1]);
            User user3 = new User("Anothername", "Third", d3, rewards3);
            AddUser(user3);

            DateTime d4 = new DateTime(1993, 11, 11);
            List<Reward> rewards4 = new List<Reward>();
            rewards4.Add(rewards[0]);
            rewards4.Add(rewards[1]);
            User user4 = new User("Another", "First", d4, rewards4);
            AddUser(user4);

            DateTime d6 = new DateTime(1995, 05, 02);
            User user6 = new User("Strangename", "Fourth", d6);
            AddUser(user6);
        }

        public void InitRewards()
        {
            RefreshBD();

            Reward r1 = new Reward("Firstreward", "Awwwww, so reward!");
            AddReward(r1);

            Reward r2 = new Reward("AnotherAnother", "Double reward!");
            AddReward(r2);

            Reward r3 = new Reward("Another");
            AddReward(r3);
        }

        public void RemoveUser(User user)
        {
            string sqlExpression = "RemoveUser";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@userId",
                    Value = user.ID
                };
                command.Parameters.Add(idParam);
                var result = command.ExecuteNonQuery();
            }
        }

        public void RemoveReward(Reward removeReward)
        {
            string sqlExpression = "RemoveReward";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@rewardId",
                    Value = removeReward.ID
                };
                command.Parameters.Add(idParam);
                var result = command.ExecuteNonQuery();
            }

        }

        //public void EditUser(User user)
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //    string sqlExpression = "RefreshUser";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand(sqlExpression, connection);
        //        command.CommandType = System.Data.CommandType.StoredProcedure;
        //        SqlParameter nameParam = new SqlParameter
        //        {
        //            ParameterName = "@newName",
        //            Value = user.FirstName
        //        };
        //        command.Parameters.Add(nameParam);
        //        SqlParameter lastnameParam = new SqlParameter
        //        {
        //            ParameterName = "@newlastName",
        //            Value = user.LastName
        //        };
        //        command.Parameters.Add(lastnameParam);
        //        SqlParameter birthdateParam = new SqlParameter
        //        {
        //            ParameterName = "@newBirthdate",
        //            Value = user.Birthdate
        //        };
        //        command.Parameters.Add(birthdateParam);

        //        SqlParameter rewardsParam = new SqlParameter
        //        {
        //            ParameterName = "@List",
        //            Value = user.reward
        //        };
        //        command.Parameters.Add(rewardsParam);

        //        SqlParameter idParam = new SqlParameter
        //        {
        //            ParameterName = "@usersId",
        //            Value = user.ID
        //        };
        //        command.Parameters.Add(idParam);

        //        //var result = command.ExecuteScalar();

        //        var result = command.ExecuteNonQuery();

        //    }
        //}

        public void EditUser(User user)
        {
            string sqlExpression = "RefreshUser";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@newName",
                    Value = user.FirstName
                };
                command.Parameters.Add(nameParam);
                SqlParameter lastnameParam = new SqlParameter
                {
                    ParameterName = "@newlastName",
                    Value = user.LastName
                };
                command.Parameters.Add(lastnameParam);
                SqlParameter birthdateParam = new SqlParameter
                {
                    ParameterName = "@newBirthdate",
                    Value = user.Birthdate
                };
                command.Parameters.Add(birthdateParam);

                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@usersId",
                    Value = user.ID
                };
                command.Parameters.Add(idParam);

                //var result = command.ExecuteScalar();

                var result = command.ExecuteNonQuery();
            }
            MakeConnection(user);
        }

        public void EditReward(Reward reward)
        {
            string sqlExpression = "RefreshReward";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter titleParam = new SqlParameter
                {
                    ParameterName = "@newTitle",
                    Value = reward.Title
                };
                command.Parameters.Add(titleParam);

                SqlParameter desParam = new SqlParameter
                {
                    ParameterName = "@newDescription",
                    Value = reward.Description
                };
                command.Parameters.Add(desParam);

                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@rewardId",
                    Value = reward.ID
                };
                command.Parameters.Add(idParam);


                //var result = command.ExecuteScalar();

                var result = command.ExecuteNonQuery();
            }
        }

        public User GetUserById(int id)
        {
            List<User> users = new List<User>();
            User user;
            string sqlExpression = "GetUser";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@userId",
                    Value = id
                };
                command.Parameters.Add(idParam);
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int ID = reader.GetInt32(0);
                        string firstName = reader.GetString(1);
                        string lastName = reader.GetString(2);
                        DateTime birthdate = reader.GetDateTime(3);
                        User newUser = new User(firstName, lastName, birthdate, ID);

                        users.Add(newUser);
                    }
                }
                reader.Close();
            }
            user = users[0];
            return user;

        }

        public Reward GetRewardById(int id)
        {
            List <Reward> reward = new List <Reward> ();
            Reward newReward;
            string sqlExpression = "GetReward";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@rewardId",
                    Value = id
                };
                command.Parameters.Add(idParam);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int ID = reader.GetInt32(0);
                        string title = reader.GetString(1);

                        if (!reader.IsDBNull(2))
                        {
                            string description = reader.GetString(2);
                            newReward = new Reward(title, description, ID);
                        }
                        else
                        {
                            newReward = new Reward(title, ID);
                        }

                        reward.Add(newReward);
                    }
                }
                reader.Close();
            }
            Reward oneReward = reward[0];
            return oneReward;
                }

        public void RefreshBD()
        {
            string sqlExpression = "DeleteEverything";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //var result = command.ExecuteScalar();

                var result = command.ExecuteNonQuery();
            }
        }
    }
}
