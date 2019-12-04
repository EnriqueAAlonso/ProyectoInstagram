using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal.Classes
{
    public class Publication:PubBuilder
    {
        public string id;
        public string username;
        public DateTime date;
        public string imgPath;
        public string description;
        
        public List<string> comments;
        
        private Adapter adapt=new Adapter();
        public void editPost(string desc)
        {
            this.description = desc;

        }

        public void createPublication(string desc, Image img, User user)
        {
            this.date = DateTime.Now;
            this.username = user.username;
            
            this.id = user.username + (user.publication.Count + 1).ToString();
            this.imgPath = adapt.ImageToPath(img, this.id);
            this.description = desc;
        }

        public void getPub(string username, string id, string impath, string desc)
        {
            this.username = username;
            this.id = id;
            this.imgPath = impath;
            this.description = desc;
        }

    }
    
}
