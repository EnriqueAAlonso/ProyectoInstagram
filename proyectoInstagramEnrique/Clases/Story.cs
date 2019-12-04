using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using proyectoFinal.Classes;
namespace proyectoFinal.Classes
{
    public class Story:PubBuilder
    {
        public string id;
        public string username;
        public DateTime date;
        public string imgPath;
        public string description;
        private Adapter adapt = new Adapter();
        public void createPublication(string desc, Image img, User user)
        {
            this.date = DateTime.Now;
            this.username = user.username;

            this.id = user.username +"Story"+ (DateTime.Now.DayOfYear).ToString()+ (DateTime.Now.Hour).ToString()+DateTime.Now.Minute.ToString();
            this.imgPath = adapt.ImageToPath(img, this.id);
            
        }
    }
}
