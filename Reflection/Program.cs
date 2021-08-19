using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OverrideAndAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
      
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string assemblyPath = Path.Combine(path, @"..\..\DLLs\DS.dll");
            byte[] bin = File.ReadAllBytes(assemblyPath);
            var assembly = System.Reflection.Assembly.Load(bin);
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                var fields = assembly.GetType(type.FullName).GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                var methods = assembly.GetType(type.FullName).GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                var properties = assembly.GetType(type.FullName).GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

                Console.WriteLine("[+] " + type.FullName);
                foreach (var field in fields)
                {
                    Console.WriteLine("- field: " + field.Name);
                }
                foreach (var method in methods)
                {
                    Console.WriteLine("- method: " + method.Name);
                }
                foreach (var property in properties)
                {
                    Console.WriteLine("- property: " + property.Name);
                }
            }

            Console.WriteLine("---------------------------------");

            var t = assembly.GetType("DS.DS1");
            var ds1 = Activator.CreateInstance(t);

            //Methods
            t.GetMethod("FireTurboLaser").Invoke(ds1, null);

            //Fields
            var realFlag = t.GetField("_RealFlag", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(ds1);
            Console.WriteLine("Real Flag (_RealFlag): " + realFlag);

            //Properties
            Console.WriteLine("Flag Before Overwrite: " + t.GetProperty("Flag").GetValue(ds1));
            t.GetField("_FakeFlag", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(ds1, realFlag);
            Console.WriteLine("Flag After Overwrite: " + t.GetProperty("Flag").GetValue(ds1));

            Console.ReadLine();
        }
    }
}
