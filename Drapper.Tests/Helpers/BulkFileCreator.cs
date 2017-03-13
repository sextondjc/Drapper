using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drapper.Tests.Helpers
{
    public class BulkFileCreator
    {
        public static string CreateBulkFile()
        {
            var fileName = $"{DateTime.UtcNow.ToString("yyyy-MM-dd")}.csv";

            if (!File.Exists(fileName))
            {
                var builder = new StringBuilder();
                for (int i = 0; i < 1000; i++)
                {
                    builder.Append($"{i}, FirstName, LastName \r\n");
                }

                File.WriteAllText(fileName, builder.ToString());
            }            
            var file = new FileInfo(fileName);
            return file.FullName;
        }



    }
}
