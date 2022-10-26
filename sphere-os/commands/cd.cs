// cd command file
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
    class CD: command
    {
        public override void getInfo()
        {
            throw new NotImplementedException();
        }

        public override void Run(CommandInput ci)
        {
            try
            {
                var fDir = ci.input[1];

                if (ci.input[1] == "..")
                {
                    var lastDir = filesystem.Utils.GoBackADir(ci.dir.dir);
                    ci.dir.dir = lastDir;
                } 
                else if (ci.input[1] == "/")
                {
                    ci.dir.dir = "/";
                }
                else
                {
                    var d = System.IO.Directory.Exists(ci.dir.dir + "/" + fDir);
                    if (d) {
                        if (ci.dir.dir == "/")
                        {
                            ci.dir.dir += ci.input[1];
                        }
                        else
                        {
                            ci.dir.dir = ci.dir.dir + "/" + ci.input[1];
                        }
                    } else
                    {
                        Console.WriteLine("cant find directory");
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("cant find directory: " + e.Message);
            }
        }
    }
}
