using System;

namespace CSharp1
{
    class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private static readonly object _lock = new object();

        private ConfigurationManager() { }

        public static ConfigurationManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurationManager();
                    }
                    return _instance;
                }
            }
        }
        public void ShowMessage()
        {
            Console.WriteLine("Configuration Manager Instance Accessed");
        }
    }
}