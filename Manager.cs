using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharp1
{
    [Serializable]
    class Manager
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }
    }

    [Serializable]
    class Department
    {
        public string DeptName { get; set; }
        public Manager Manager { get; set; }

        public Department(string deptName, Manager manager)
        {
            DeptName = deptName;
            Manager = manager;
        }

        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }

        public Department DeepCopy()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Seek(0, SeekOrigin.Begin);
                return (Department)formatter.Deserialize(ms);
            }
        }
    }
}