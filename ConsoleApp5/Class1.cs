using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    
    abstract public class Storage
    {
        public string? Data { get; set; }
        public string? MediaName { get; set ; }
        public string? Model { get; set; }
        public double Size { get ; set; }
        public int filescount { get; set; }
        public double Speed { get; set; }
        virtual public double Freememory()
        {
            return Size-(filescount*780);
        }
        virtual public void Copy(Storage a)
        {
            a.Data = Data;
        }
        virtual public void ShowDeviceInfo()
        {
            Console.WriteLine($"Device name: {MediaName}");
            Console.WriteLine($"Model name: {Model}");
            Console.WriteLine($"Size: {Size}");
        }
        virtual public void Check()
        {
            Console.WriteLine($"{780000/Size}: device lazimdir");
            Console.WriteLine($"{780000/Speed}: saniye vaxt lazimdir");
        }
    }
    public class Flash : Storage
    {
        
        public override void Copy(Storage a)
        {
            base.Copy(a);
        }

        public override double Freememory()
        {
            return base.Freememory();
        }

        public override void ShowDeviceInfo()
        {
            base.ShowDeviceInfo();
        }

        public override void Check()
        {
            base.Check();
        }
    }
    public class DVD : Storage
    {
        public override void Copy(Storage a)
        {
            base.Copy(a);
        }

        public override double Freememory()
        {
            return base.Freememory();
        }

        public override void ShowDeviceInfo()
        {
            base.ShowDeviceInfo();
        }

        public override void Check()
        {
            base.Check();
        }
    }

    public class HDD : Storage
    {
        public override void Copy(Storage a)
        {
            base.Copy(a);
        }

        public override double Freememory()
        {
            return base.Freememory();
        }

        public override void ShowDeviceInfo()
        {
            base.ShowDeviceInfo();
        }

        public override void Check()
        {
            base.Check();
        }
    }

}
