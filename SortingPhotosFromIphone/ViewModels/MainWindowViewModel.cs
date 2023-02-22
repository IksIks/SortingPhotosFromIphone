using SortingPhotosFromIphone.Models;
using SortingPhotosFromIphone.ViewModels.Base;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SortingPhotosFromIphone.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        // публичные
        // приватные
        // конструктор
        // методы

        public DirectoryTest directoryInfo { get; } = new DirectoryTest("C:\\");
        

        public MainWindowViewModel()
        {
            
        }


    }
}
