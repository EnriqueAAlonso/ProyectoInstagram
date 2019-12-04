using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal.Classes
{
    public class ProfileIterator
    {
        public List<string> profileList=new List<string>();
        private int current = 0;
        private int jumps = 0;
        public ProfileIterator(List<string> profiles, int jump)
        {
            current = 0;
            jumps = jump;
            foreach (var profile in profiles)
            {
                profileList.Add(profile);
            }
        }

        public List<string> getProfiles()
        {
            List<string> getProf=new List<string>();
            for (int i = current; i < profileList.Count; i++)
            {
                getProf.Add(profileList[i]);
                if (getProf.Count == jumps)
                {
                    return getProf;
                }
            }

            return getProf;
        }
        public bool back()
        {
            if (current > jumps - 1) 
            {
                
                return true;
            }

            return false;
        }

        

        public void navigateBack()
        {
            current -= jumps;
        }

        public void navigateFront()
        {
            current += jumps;
        }

        public bool next()
        {
            if (current+jumps < profileList.Count)
            {
                
                return true;
                
            }

            return false;
            

        }

        public void resetIterator()
        {
            current = 0;
        }

    }
}
