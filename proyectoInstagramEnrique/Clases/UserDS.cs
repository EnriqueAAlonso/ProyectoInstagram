using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace proyectoFinal.Classes
{
    public class UserDS
    {
        private readonly SQLClient _client;
        private static UserDS _instance;

        private UserDS(string cStr)
        {
            _client = new SQLClient(cStr);
        }

        public static UserDS getInstance(string cStr)
        {
            if (_instance == null) _instance= new UserDS(cStr);
            return _instance;
        }

        public bool liked(string id, string username)
        {
            string user = null;
            if (_client.Open())
            {
                var command = new SqlCommand
                {
                    Connection = _client.connection,
                    CommandText = "getLike",
                    CommandType = CommandType.StoredProcedure
                };

                var par1 = new SqlParameter("@id", SqlDbType.NVarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = id
                };

                var par2 = new SqlParameter("@username", SqlDbType.NVarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = username
                };

                command.Parameters.Add(par1);
                command.Parameters.Add(par2);
                command.ExecuteNonQuery();

                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    user=dataReader["username"].ToString();

                }


            }
            _client.Close();
            return user != null;
        }

        public void deleteStory()
        {
            if (_client.Open())
            {
                var command = new SqlCommand
                {
                    Connection = _client.connection,
                    CommandText = "deleteStory",
                    CommandType = CommandType.StoredProcedure
                };
                var par4 = new SqlParameter("@date", SqlDbType.DateTime)
                {
                    Direction = ParameterDirection.Input,

                    Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
                };
            }

            _client.Close();
        }

        public long getLikes(string id)
        {
            return 0;
        }

        public List<string> getUserPublication(string profile)
        {
            List<string> output= new List<string>();
            if (_client.Open())
            {
                var command = new SqlCommand
                {
                    Connection = _client.connection,
                    CommandText = "getPublication",
                    CommandType = CommandType.StoredProcedure
                };

                var par1 = new SqlParameter("@profile", SqlDbType.NVarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = profile
                };
                var par3 = new SqlParameter("@haserror", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };

                command.Parameters.Add(par1);
                command.Parameters.Add(par3);
                command.ExecuteNonQuery();

                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output.Add(dataReader["ID"].ToString());


                }


            }
            _client.Close();
            return output;
        }

        public User getUser(string email)
        {
            User u = null;
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.connection,
                        CommandText = "getuser",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@user", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = email
                    };
                    

                    command.Parameters.Add(par1);

                    command.ExecuteNonQuery();

                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var user = new User
                        {
                            username= dataReader["username"].ToString(),
                            email =  dataReader["email"].ToString(),
                            password = (dataReader["pwd"].ToString()),
                            pPicturePath = dataReader["pPath"].ToString(),
                            bio = dataReader["descript"].ToString()

                        };
                        u = user;
                    }
                }
            }
            catch
            {
                // ignored
            }
            finally
            {
                _client.Close();
            }

            return u;


        }
        
        public bool createPublication(Publication publication)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.connection,
                        CommandText = "createPublication",
                        CommandType = CommandType.StoredProcedure
                    };
                    
                    var par1 = new SqlParameter("@ID", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = publication.id
                    };

                    var par2 = new SqlParameter("@profile", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = publication.username
                    };
                    var par4 = new SqlParameter("@date", SqlDbType.DateTime)
                    {
                        Direction = ParameterDirection.Input,
                        
                        Value =  publication.date.ToString("yyyy-MM-dd HH:mm:ss.fff")
                    };
                    
                    var par5 = new SqlParameter("@imgPath", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,

                        Value = publication.imgPath
                    };
                    var par6 = new SqlParameter("@description", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,

                        Value = publication.description
                    };
                    var par3 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par4);
                    command.Parameters.Add(par5);
                    command.Parameters.Add(par6);
                    command.Parameters.Add(par3);
                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());


                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _client.Close();
            }

            return result;
        }

        public void updatePPicture(User u)
        {
            if (_client.Open())
            {
                var command = new SqlCommand
                {
                    Connection = _client.connection,
                    CommandText = "updatePicture",
                    CommandType = CommandType.StoredProcedure
                };

                var par1 = new SqlParameter("@profile", SqlDbType.NVarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = u.username
                };
                var par3 = new SqlParameter("@pPath", SqlDbType.NVarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value=u.pPicturePath
                };

                command.Parameters.Add(par1);
                command.Parameters.Add(par3);
                command.ExecuteNonQuery();
                

            }
            _client.Close();
        }
        public void updateDesc(User u)
        {
            if (_client.Open())
            {
                var command = new SqlCommand
                {
                    Connection = _client.connection,
                    CommandText = "updateDesc",
                    CommandType = CommandType.StoredProcedure
                };

                var par1 = new SqlParameter("@profile", SqlDbType.NVarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = u.username
                };
                var par3 = new SqlParameter("@desc", SqlDbType.NVarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = u.bio
                };

                command.Parameters.Add(par1);
                command.Parameters.Add(par3);
                command.ExecuteNonQuery();




            }

            _client.Close();
        }

        public bool giveLike(User usr, Publication pub)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    string pubName = pub.id;
                    var command = new SqlCommand
                    {
                        Connection = _client.connection,
                        CommandText = "createLike",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@ID", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = pub.id
                    };

                    var par2 = new SqlParameter("@profile", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = usr.username
                    };
                    var par4 = new SqlParameter("@date", SqlDbType.DateTime)
                    {
                        Direction = ParameterDirection.Input,

                        Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
                    };
                    var par3 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };


                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);
                    command.Parameters.Add(par4);
                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());


                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _client.Close();
            }

            return result;
        }

        public void deleteLike(User u, Publication p)
        {
            if (_client.Open())
            {
                var command = new SqlCommand
                {
                    Connection = _client.connection,
                    CommandText = "deleteLike",
                    CommandType = CommandType.StoredProcedure
                };

                var par1 = new SqlParameter("@id", SqlDbType.NVarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = p.id
                };

                var par2 = new SqlParameter("@username", SqlDbType.NVarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = u.username
                };



                command.Parameters.Add(par1);
                command.Parameters.Add(par2);
                command.ExecuteNonQuery();
            }

            _client.Close();
        }

        public bool AddUser(User user)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.connection,
                        CommandText = "addUser",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@email", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = user.email
                    };

                    var par2 = new SqlParameter("@pwd", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = user.password
                    };
                    var par4 = new SqlParameter("@username", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = user.username
                    };
                    var par3 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };


                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);
                    command.Parameters.Add(par4);
                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());


                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _client.Close();
            }

            return result;
        }
        public User loginUser(string username, string pwd)
        {
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.connection,
                        CommandText = "logUser",
                        CommandType = CommandType.StoredProcedure
                    };
                    var par1 = new SqlParameter("@username", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = username
                    };

                    var par2 = new SqlParameter("@pwd", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = pwd
                    };
                    var par3 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };


                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var user = new User
                        {
                            username = dataReader["username"].ToString(),
                            email = dataReader["email"].ToString(),
                            password = (dataReader["pwd"].ToString())

                        };
                        return user;
                    }
                }
            }
            catch
            {
                // ignored
            }
            finally
            {
                _client.Close();
            }

            return null;
        }
        
       
        public List<string> getFollowers(string user)
        {
            var result = new List<string>();
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.connection,
                        CommandText = "getFollowing",
                        CommandType = CommandType.StoredProcedure
                    };
                    var par1 = new SqlParameter("@user", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = user
                    };
                    command.Parameters.Add(par1);
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        result.Add(dataReader["follower"].ToString());
                            
                    }
                }
            }
            catch
            {
                // ignored
            }
            finally
            {
                _client.Close();
            }

            return result;
        }


        public List<string> getFollowing(string user)
        {
            var result = new List<string>();
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.connection,
                        CommandText = "getFollowers",
                        CommandType = CommandType.StoredProcedure
                    };
                    var par1 = new SqlParameter("@user", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = user
                    };
                    command.Parameters.Add(par1);
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        result.Add(dataReader["followed"].ToString());

                    }
                }
            }
            catch
            {
                // ignored
            }
            finally
            {
                _client.Close();
            }

            return result;
        }
        public bool follow(string follower, string followwee)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.connection,
                        CommandText = "follow",
                        CommandType = CommandType.StoredProcedure
                    };
                    var par1 = new SqlParameter("@follower", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = follower
                    };
                    var par2 = new SqlParameter("@followee", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = followwee
                    };
                    var par3 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);
                    command.ExecuteNonQuery();
                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());
                }
            }
            catch
            {
                // ignored
            }
            finally
            {
                _client.Close();
            }

            return result;
        }
        public void unfollow(string follower, string followwee)
        {
           
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.connection,
                        CommandText = "unFollow",
                        CommandType = CommandType.StoredProcedure
                    };
                    var par1 = new SqlParameter("@user", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = follower
                    };
                    var par2 = new SqlParameter("@followed", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = followwee
                    };
                    
                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                // ignored
            }
            finally
            {
                _client.Close();
            }
            
        }

        public List<string> getStory(User u)
        {
            List<string> output = new List<string>();
            if (_client.Open())
            {
                var command = new SqlCommand
                {
                    Connection = _client.connection,
                    CommandText = "getStories",
                    CommandType = CommandType.StoredProcedure
                };

                var par1 = new SqlParameter("@profile", SqlDbType.NVarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = u.username
                };
                

                command.Parameters.Add(par1);
                command.ExecuteNonQuery();

                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output.Add(dataReader["imgPath"].ToString());
                    
                }


            }
            _client.Close();
            return output;
        }

        public bool createStory(Story publication)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.connection,
                        CommandText = "createStory",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@ID", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = publication.id
                    };

                    var par2 = new SqlParameter("@profile", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = publication.username
                    };
                    var par4 = new SqlParameter("@date", SqlDbType.DateTime)
                    {
                        Direction = ParameterDirection.Input,

                        Value = publication.date.ToString("yyyy-MM-dd HH:mm:ss.fff")
                    };

                    var par5 = new SqlParameter("@imgPath", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,

                        Value = publication.imgPath
                    };
                   
                    var par3 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par4);
                    command.Parameters.Add(par5);
                    command.Parameters.Add(par3);
                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());


                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _client.Close();
            }

            return result;
        }

        public Publication getPublication(string id)
        {
            Publication p = new Publication();
            if (_client.Open())
            {
                var command = new SqlCommand
                {
                    Connection = _client.connection,
                    CommandText = "getPub",
                    CommandType = CommandType.StoredProcedure
                };

                var par1 = new SqlParameter("@id", SqlDbType.NVarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = id
                };
                


                command.Parameters.Add(par1);
                command.ExecuteNonQuery();

                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                   
                   p.getPub(dataReader["profile"].ToString(), dataReader["ID"].ToString(), dataReader["imgPath"].ToString(), dataReader["description"].ToString());

                }


            }
            _client.Close();
            return p;

        }

        public int getLikeCount(Publication pub)
        {
            var result = 0;
            List<string> likeCount=new List<string>();
            if (_client.Open())
            {
                var command = new SqlCommand
                {
                    Connection = _client.connection,
                    CommandText = "getAllTheLikes",
                    CommandType = CommandType.StoredProcedure
                };

                var par1 = new SqlParameter("@id", SqlDbType.NVarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = pub.id
                };



                command.Parameters.Add(par1);
                var dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    likeCount.Add(dataReader["username"].ToString());

                }



            }
            _client.Close();
            return likeCount.Count();

        }
    }
    
}
