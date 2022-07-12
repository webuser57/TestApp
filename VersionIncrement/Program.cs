using System;
using System.IO;
using VersionIncrementLib;

namespace VersionIncrement
{
    class Program
    {
        static void Main(string[] args)
        {
            string _input = args[0];
            string versionFile = @"ProductInfo.txt";
            string _filename = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "/" + versionFile;
            string _version = File.ReadAllText(_filename);
            string _incrversion = "";

            if (_input == RELEASETYPE.FEATURE.ToString())
                _incrversion = VersionIncrementLib.VersionIncrement.UpdateVersion(RELEASETYPE.FEATURE, _version);

            if (_input == RELEASETYPE.BUGFIX.ToString())
                _incrversion = VersionIncrementLib.VersionIncrement.UpdateVersion(RELEASETYPE.BUGFIX, _version);
            File.WriteAllText(_filename, _incrversion);
            Console.WriteLine($"Previsoud Version : {_version} Update Version : {_incrversion}");

        }
    }
}
