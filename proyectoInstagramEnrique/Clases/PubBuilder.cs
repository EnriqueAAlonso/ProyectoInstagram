using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace proyectoFinal.Classes
{
    public interface PubBuilder
    {
        void createPublication(string desc, Image img, User user);
    }
}
