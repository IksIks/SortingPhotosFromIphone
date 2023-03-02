using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingPhotosFromIphone.ViewModels
{
    internal class FileSystemViewModel
    {
        public Models.Directory directoryInfo { get; } = new Models.Directory("C:\\");
        public Models.File file { get; } = new Models.File($"C:\\Temp\\");

    }
}
