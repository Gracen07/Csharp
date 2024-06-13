using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Mob
{
    public abstract class Ab_Mob
    {
        protected string brand;
        protected string model;
        protected int batteryLevel;

        public Ab_Mob(string brand,string model,int batterLevel)
        {
            this.brand = brand;
            this.model = model; 
            this.batteryLevel = batterLevel;    
        }

        public abstract void StartDevice();
        public abstract void UseDevice();
        public virtual void ShowDetails()
        {
            Console.WriteLine($"Brand:{ brand},model:{ model},batterLevel:{batteryLevel}");
        }
    }
}
