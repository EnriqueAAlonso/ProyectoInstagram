using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoFinal.Controls;

namespace proyectoFinal.Classes
{
    public class Observer
    {
        private TestForm form;

        public Observer(TestForm form)
        {
            this.form = form;
        }

        public void notifyObserver(int number)
        {
            switch (number)
            {
                case 1:
                    form.userInterface();
                    break;
                case 2:
                    form.makePost();
                    break;
                case 3:
                    form.logout();
                    break;
                case 4:
                    form.updateProfile();
                    break;
                case 5:
                    form.viewStory();
                    break;
                case 6:
                    form.viewPublication();
                    break;
                case 7:
                    form.startSearch();
                    break;
                default:
                    form.userInterface();
                    break;

            }
        }
    }
}
