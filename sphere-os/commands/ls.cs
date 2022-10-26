// ls file
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

using Cosmos.System.FileSystem;
using System;
using System.Collections.Generic;
using System.Text;


namespace sphere_os.commands
{
    class Ls : command
    {
        public override void getInfo()
        {
            throw new NotImplementedException();
        }

        public override void Run(CommandInput ci)
        {
            try
            {
                var l = ci.vfs.GetDirectory("/");
                var output = new System.IO.DirectoryInfo(ci.dir.dir);

                // files
                foreach (var i in output.GetFiles())
                {
                    Console.WriteLine("name: " + i.Name + " type: file " + "size: " + i.Length);
                }

                // directories
                foreach (var i in output.GetDirectories())
                {
                    Console.WriteLine("name: " + i.Name + " type: dir " + "size: N/A");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Command not found: : " + e.Message);
            }
        }
    }
}
    