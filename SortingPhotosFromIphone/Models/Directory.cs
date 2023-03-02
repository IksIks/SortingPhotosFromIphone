using SortingPhotosFromIphone.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace SortingPhotosFromIphone.Models
{
    internal class Directory
    {
        public string Name => dirInfo.Name;
        public string Path => dirInfo.FullName;
        public DateTime CreationTime => dirInfo.CreationTime;

        public IEnumerable<Directory> SubDirectorys => dirInfo.EnumerateDirectories().Select(dir => new Directory(dir.FullName));

        private readonly DirectoryInfo dirInfo;
        public Directory(string path)
        {
            dirInfo = new DirectoryInfo(path);
        }



    }
}
