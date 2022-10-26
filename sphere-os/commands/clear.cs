// clear file
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
    class Clear: command
    {
        public override void getInfo()
        {
            throw new NotImplementedException();
        }

        public override void Run(CommandInput ci)
        {
            Console.Clear();
        }
    }
}
