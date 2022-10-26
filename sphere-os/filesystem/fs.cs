// os_system file
/* Copyright (C) 2021 Dinuda Yaggahavita, Tarith Jayasooriya

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace sphere_os.filesystem
{
    public class Dir
    {
        public string dir = "/";
    }

    static class Utils
    {
        public static string[] PathToArray(string p)
        {
            return p.Split("/");
        }

        // returns the path before the current path
        // example
        // string d = "a/b/c/d"
        // string b = fsTrack.GoBackADir(d)
        // Console.WriteLine(d) $ a/b/c
        public static string GoBackADir(string dir)
        {

            string[] a = PathToArray(dir);
            Console.WriteLine(a.Length);
            var v = "";

            for (var i = 0; i < a.Length; i++)
            {
                var divider = "";
                if (i != 1)
                {
                    divider = "/";
                }
                v += divider + a[i];
            }
            return v;
        }
    }

}