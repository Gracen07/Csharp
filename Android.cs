using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mob_Inherited
{
    public class Android:Mob,ICamera,IGps
    {
        public int version;
        public Android(string brand,string model,int version): base(brand,model)
        {
            this.version = version;
        }
        public void PrintVersion()
        {
            Console.WriteLine("Version "+version);
        }

        public void TakePhoto()
        {
            Console.WriteLine("Taking photo");
        }

        public void GetGps()
        {
            Console.WriteLine("Current Location");
        }
    }
}
