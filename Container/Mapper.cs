using Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public static class Mapper
    {
        private static Assembly storeAssembly = typeof(IRobot).Assembly;
        public static dynamic Map (string name)
        {       
            try
            {
                Type t = storeAssembly.GetType($"Store.{name}");
                var x = t.GetConstructor(new Type[] { }).Invoke(new object[] { });
                return x;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// Zwraca obiekt po nazwie 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>

        public static dynamic Map<T>() where T : IRobot
        {
            string name = typeof(IRobot).Name;
            //name = name.Replace("I", "");
            name = name.Substring(1, name.Length - 1);
            Type t = storeAssembly.GetType($"Store.{name}");        
            return t.GetConstructor(new Type[] { }).Invoke(new object[] { });
        }

        public static dynamic Map<TInterface, TClass>() 
        {
            var t = storeAssembly.GetType($"Store.{typeof(TClass).Name}");
            return t.GetConstructor(new Type[] { }).Invoke(new object[] { });

        }

        static T GetObject<T>()
        {
            return (T)typeof(T).GetConstructor(new Type[] { }).Invoke(new object[] { });
        }
    }


}
