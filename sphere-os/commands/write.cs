using System;
using System.Collections.Generic;
using System.Text;

namespace sphere_os.commands
{
    class Write: command
    {
        public override void getInfo()
        {
            throw new NotImplementedException();
        }

        public override void Run(CommandInput ci)
        {
            try
            {
                var file = ci.vfs.GetFile(ci.input[1]);
                var contents = ci.input[2];
                for (var i = 0; i < ci.input.Length; i++)
                {
                    if (i < 3)
                    {
                        continue;
                    }
                    contents +=  " " + ci.input[i];
                }
                var sFile = new System.IO.StreamWriter(file.GetFileStream());
                sFile.Write(contents);
            }
            catch (Exception e)
            {
                Console.WriteLine("cant write to file: " + e.Message);
            }
        }
    }
}
