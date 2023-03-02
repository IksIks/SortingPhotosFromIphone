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

        public Models.Directory directoryInfo { get; } = new Models.Directory("C:\\");
        

        public MainWindowViewModel()
        {
            
        }


    }
}
