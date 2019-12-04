using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal.Classes
{
    public class UserService
    {
        private readonly UserDS _ds;

        public UserService(string cstr)
        {
            _ds = UserDS.getInstance(cstr);
        }

        public bool createStory(Story s)
        {
            return _ds.createStory(s);
        }

        public List<string> getStories(User u)
        {
            return _ds.getStory(u);
        }

        public void deleteStory()
        {
            _ds.deleteStory();
        }

        public bool liked(string id, User u)
        {
            return _ds.liked(id, u.username);
        }

        public bool giveLike(User u, Publication p)
        {
            return _ds.giveLike(u, p);
        }

        public void removeLike(User u, Publication p)
        {
            
            _ds.deleteLike(u, p);
        }

        public List<string> getPosts(User user)
        {
            return _ds.getUserPublication(user.username);
        }

        public bool createPublication(Publication pub)
        {
            return _ds.createPublication(pub);
        }

        public void updatePicture(User u)
        {
            _ds.updatePPicture(u);
        }
        public void updateDesc(User u)
        {
            _ds.updateDesc(u);
        }
        public long getLikes(Publication p)
        {
            return _ds.getLikeCount(p);
        }

        public List<string> getFollowers(User u)
        {
            return _ds.getFollowers(u.username);
        }

        public List<string> getFollowing(User u)
        {
            return _ds.getFollowing(u.username);
        }

        public User getUser(string mail)
        {
            return _ds.getUser(mail);
        }

        public string AddUser(User u)
        {
            try
            {
                if(_ds.getUser(u.username)==null) return _ds.AddUser(u) ? "User registered correctly" : "Failed adding user ";
                else
                {
                    return "User already registered";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }



        public bool follow(string user, string followed)

        {
            try
            {
                if (_ds.getUser(user) != null && _ds.getUser(followed)!= null&& followed!=user)
                {
                    return _ds.follow(user, followed);
                
                }

                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;

            }
            return _ds.follow(user, followed);
        }

        public Publication getPost(string id)
        {
            return _ds.getPublication(id);
        }

        public void unFollow(string user, string followed)
        {
            _ds.unfollow(user, followed);
        }

        public bool loginUser(string username, string password)
        {
            if (_ds.loginUser(username, password) != null) return true;
            else return false;
        }
    }
}
