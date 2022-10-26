// main file
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
using Sys = Cosmos.System;

namespace sphere_os
{
    public class Kernel : Sys.Kernel
    {
        filesystem.Dir currentDir;
        Sys.FileSystem.CosmosVFS fs;

        protected override void BeforeRun()
        {

            // this will be used to keep track of the current sessions dir
            currentDir = new filesystem.Dir();

            // filesytem
            fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);

            Console.WriteLine("Sphere OS Copyright(C) 2021  Dinuda Yaggahavita, Tarith Jayasooriya");
            Console.WriteLine("This program comes with ABSOLUTELY NO WARRANTY;  This is free software, and you are welcome to redistribute it");

        }

        protected override void Run()
        {
            Console.Write(currentDir.dir+": ");
            var input = Console.ReadLine();
            // tokens
            var tokens = input.Split(" ");
            var ci = new CommandInput { dir = currentDir, input = tokens, vfs = fs };
            switch (tokens[0])
            {            
                // commands here
                case "cd":
                    new commands.CD().Run(ci);
                    break;
                case "echo":
                    new commands.echo().Run(ci);
                    break;
                case "ls":
                    new commands.Ls().Run(ci);
                    break;
                case "shutdown":
                    new commands.Shutdown().Run(ci);
                    break;
                case "mkdir":
                    new commands.Mkdir().Run(ci);
                    break;
                case "mkfile":
                    new commands.Mkfile().Run(ci);
                    break;
                case "clear":
                    new commands.Clear().Run(ci);
                    break;
                case "read":
                    new commands.Read().Run(ci);
                    break;
                default:
                    Console.WriteLine("command not found");
                    break;
            }
            Console.WriteLine();
        }
    }
}