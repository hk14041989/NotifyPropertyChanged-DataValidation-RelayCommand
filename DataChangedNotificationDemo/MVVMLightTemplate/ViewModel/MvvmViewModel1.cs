using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Windows.Input;

namespace MVVMLightTemplate.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MvvmViewModel1 : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MvvmViewModel1 class.
        /// </summary>
        public MvvmViewModel1()
        {
            StartCommand = new RelayCommand(VoidStart);
        }

        public ICommand StartCommand
        {
            get;
            private set;
        }

        public void VoidStart()
        {
            Console.WriteLine("Hello");
            Console.ReadLine();
        }
    }
}