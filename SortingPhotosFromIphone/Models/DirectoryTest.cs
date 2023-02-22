using SortingPhotosFromIphone.ViewModels.Base;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Net.WebRequestMethods;

namespace SortingPhotosFromIphone.Models
{
    internal class DirectoryTest : ViewModel
    {

        public string Name => directoryInfo.FullName;
        private readonly DirectoryInfo directoryInfo;
        public DirectoryTest(string path)
        {
            directoryInfo = new DirectoryInfo(path);
        }

        public IEnumerable<DirectoryTest> Directorys => directoryInfo
                                                        .EnumerateDirectories()
                                                        .Select(dir => new DirectoryTest(dir.FullName));

       
    }
}
