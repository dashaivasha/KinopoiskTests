using System;
using System.IO;

namespace KinoPoiskAutomatedTests
{ 
    static class Globals
    {
        private static string _workingDirectory = Environment.CurrentDirectory;
        private static string _projectDirectory = Directory.GetParent(_workingDirectory).Parent.Parent.FullName;
        public static string LoginPath = $"{_projectDirectory}\\Data\\Login.json";
        public static string PasswordPath = $"{_projectDirectory}\\Data\\Password.json";
    } 
}
