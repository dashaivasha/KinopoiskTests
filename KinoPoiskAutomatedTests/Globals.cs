using System;
using System.IO;

namespace KinoPoiskAutomatedTests
{ 
    static class Globals
    {
        private static string _workingDirectory = Environment.CurrentDirectory;
        private static string _projectDirectory = Directory.GetParent(_workingDirectory).Parent.Parent.FullName;
        public static string LoginPath = $"{_projectDirectory}{Path.DirectorySeparatorChar}TestData{Path.DirectorySeparatorChar}Login.json";
        public static string PasswordPath = $"{_projectDirectory}{Path.DirectorySeparatorChar}TestData{Path.DirectorySeparatorChar}Password.json";
        public static string MoviePath = $"{_projectDirectory}{Path.DirectorySeparatorChar}TestData{Path.DirectorySeparatorChar}Movie.json";
    } 
}
