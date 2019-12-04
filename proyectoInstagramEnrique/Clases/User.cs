using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal.Classes
{
    public class User
    {
        public string username;
        public string email;
        public string password;
        public string bio;
        public string pPicturePath;
        public List<string> publication;
        public List<string> followers;
        public List<string> following;
        public List<string> story;

        public User(string u, string p, string e)
        {
            username = u;
            email = e;
            password = p;
            publication = new List<string>();
            followers = new List<string>();
            following = new List<string>();
            story=new List<string>();
        }

        public void updatePublications(UserService us)
        {
            this.publication = us.getPosts(this);
        }

        public User()
        {
        }

        public void Publish(Publication pub, UserService us)
        {
            us.createPublication(pub);
        }
        public void PublishStory(Story story, UserService us)
        {
            us.createStory(story);
        }

        //Prototype clone
        public void Clone(List<string> pub, List<string> follower, List<string> followee)
        {
            this.publication = new List<string>();
            foreach (var p in pub)
            {
                this.publication.Add(p);
            }
            this.followers = new List<string>();
            foreach (var fol in follower)
            {
                this.followers.Add(fol);
            }

            this.following = new List<string>();
            foreach (var f in followee)
            {
                this.following.Add(f);
            }

        }

        public void follow(User user)
        {
            if (this.followers.Contains(user.username))
            {
                user.followers.Remove(this.username);
                this.followers.Remove(user.username);
            }
            else
            {
                user.followers.Add(this.username);
                this.followers.Add(user.username);
            }

            
        }

        public void Publish(Publication pub)
        {
            publication.Add(pub.id);
            pub.username = this.username;
        }
        public void PublishStory(Story pub)
        {
            story.Add(pub.id);
            pub.username = this.username;
        }




        public void setImg(Image i)
        {
            
            Adapter ad=new Adapter();
            this.pPicturePath = ad.ImageToPath((Image)i.Clone(),"profilePicture"+this.username);
            

        }

    }
}
