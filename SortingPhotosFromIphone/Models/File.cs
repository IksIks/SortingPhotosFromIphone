using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingPhotosFromIphone.Models
{
    internal class File
    {
        public string Name => fileInfo.Name;
        public string Path => fileInfo.FullName;
        public DateTime CreationTime => fileInfo.CreationTime;

        private readonly FileInfo fileInfo;
        public File(string path)
        {
            fileInfo= new FileInfo(path);
        }    
    }
}
