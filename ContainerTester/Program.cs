using Container;
using Store;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //IRobot robot = new Robot();
            //IRobot kasia = new Kasia();
            //IRobot kasia = Mapper.Map(ConfigurationManager.AppSettings["class"]);
            //Console.WriteLine(robot.Clean());
            //Console.WriteLine(kasia.GetType().ToString());
            //IRobot robot = Mapper.Map<IRobot>("Irobot");
            IRobot robot = Mapper.Map<IRobot, Kasia>();
            Console.WriteLine(robot.Clean());
            Console.Read();
        }
    }
}
