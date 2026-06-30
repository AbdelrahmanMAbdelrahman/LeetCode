using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MyReflection
    {
        public MyInfo getInfo(Type className) {
            Type? type = Type.GetType(className.Name);
            if (type is null) throw new InvalidOperationException();
            return new MyInfo(type.Name,type.IsClass,type.Assembly.GetName().Name!,type.Namespace!);
        }
        public string getStringMethods()
        {
            Assembly? stringAssemply = Assembly.GetAssembly(typeof(string));
            if(stringAssemply is null) throw new InvalidOperationException();
            Type? stringType = stringAssemply.GetType("System.String");
            if(stringType is null) throw new InvalidOperationException();
            MethodInfo[] stringMethods = stringType.GetMethods(BindingFlags.Public|BindingFlags.Instance);
            stringMethods=stringMethods.OrderBy(sm => sm.Name).ToArray();
            string methodsSignature = "";
            foreach (var sm in stringMethods)
            {
                methodsSignature += $"{sm.ReturnType.Name} {sm.Name}();\n";
            }
            return methodsSignature;
        }
        public void callPropertiesAndMethodsAtRunTime(string job)
        {
            Assembly? assembly = Assembly.GetAssembly(typeof(Student));
            if(assembly is null) throw new InvalidOperationException();
            Type? studentType = assembly.GetType(typeof(Student).FullName);
            if (studentType is null) { throw new InvalidOperationException(); }
            object? runtimeObject = Activator.CreateInstance(studentType);
            if (runtimeObject is null) throw new InvalidOperationException();
            var runtimeObjectProps = runtimeObject.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine("++++++++++ Properties of student +++++++++++");
            foreach (var prop in runtimeObjectProps)
            {
                Console.WriteLine(prop.Name + "\n");

            }
            runtimeObjectProps[1].SetValue(runtimeObject, "Abdelrahman");
            Console.WriteLine("++++++++++ Methods of student +++++++++++");
            var runtimeObjectMethods = runtimeObject.GetType().GetMethods(
                                       BindingFlags.Public |
                                       BindingFlags.Instance |
                                       BindingFlags.DeclaredOnly)
                                       .Where(m => !m.IsSpecialName);
            foreach (var method in runtimeObjectMethods)
            {
                string param = method.Name == "presentJob" ? job : "";
                Console.WriteLine(method.Name.ToString());
                studentType.GetMethod(method.Name)!.Invoke(runtimeObject,string.IsNullOrEmpty(param)?null: new object[] { param });
            }
        }
    }
    public record MyInfo(string name ,bool isClass, string assemblyName,string nameSpace);
}
