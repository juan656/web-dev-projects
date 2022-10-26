// command abstract classes
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

using sphere_os.filesystem;

public abstract class command
{
    public abstract void getInfo();
    public abstract void Run(CommandInput ci);

}

public class CommandInput
{
    public Cosmos.System.FileSystem.CosmosVFS vfs;
    public Dir dir;
    public string[] input;
}