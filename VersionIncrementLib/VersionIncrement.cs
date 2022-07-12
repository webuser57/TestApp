using System;
using System.Text.RegularExpressions;

namespace VersionIncrementLib
{
    public enum RELEASETYPE {
        FEATURE = 0,
        BUGFIX
    }
    public class VersionIncrement
    {
        static public string UpdateVersion(RELEASETYPE releaseTypem, string currentVersion)
        {
            char seperator = '.';
            string [] _buff = currentVersion.Split(new char[] { seperator }); 
           
            if (releaseTypem == RELEASETYPE.FEATURE) {
                int incr = int.Parse(_buff[2]);
                _buff[2] = (++incr).ToString();
                int minorincr = int.Parse(_buff[3]);
                _buff[3] = "0";
            }

            if (releaseTypem == RELEASETYPE.BUGFIX) {
                int incr = int.Parse(_buff[3]);
                _buff[3] = (++incr).ToString();
            }

            return String.Join(seperator, _buff); ;
        }

    }
}
