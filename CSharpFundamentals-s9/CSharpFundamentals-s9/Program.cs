using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpFundamentals_s9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var path = @"/tmp/Providence-Rhode-Island.jpg";
            
            File.Copy( @"/tmp/Providence-Rhode-Island.jpg", @"/tmp/copy-Providence-Rhode-Island.jpg", true );
            File.Delete( path );

            if (File.Exists( path ))
            {
                Console.WriteLine( "{1} exists!", path );
            }
            else
            {
                Console.WriteLine( "{1} does not exist!", path );
            }

            var content = File.ReadAllText( path );
            
            var fileInfo = new FileInfo( path );
            fileInfo.CopyTo( "/dev/null" );
            
            // takes no parameters
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                Console.WriteLine( @"fileInfo exists!
note that fileInfo lacks the ReadAllText() method

note the verbatim-string usage here" );
            }
        }
    }
}