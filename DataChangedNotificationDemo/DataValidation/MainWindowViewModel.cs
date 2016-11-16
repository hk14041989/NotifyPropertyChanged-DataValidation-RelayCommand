using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataValidation
{
    public class MainWindowViewModel : IDataErrorInfo
    {
        public MainWindowViewModel()
        {
        }
        //property to bind to textbox
        public string ValidateInputText
        {
            get;
            set;
        }
        //ICommand to bind to button
        public ICommand ValidateInputCommand
        {
            get { return new RelayCommand(); }
            set { }
        }
        private int age = 20;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        #region IDataErrorInfo
        //In this region we are implementing the properties defined in //the IDataErrorInfo interface in System.ComponentModel
        public string this[string columnName]
        {
            get
            {
                if ("ValidateInputText" == columnName)
                {
                    if (String.IsNullOrEmpty(ValidateInputText))
                    {
                        return "Please enter a Name";
                    }
                }
                else if ("Age" == columnName)
                {

                    if (Age < 0)
                    {
                        return "age should be greater than 0";
                    }
                }
                return "";
            }
        }
        public string Error
        {
            get { throw new NotImplementedException(); }
        }
    }
        #endregion
    class RelayCommand : ICommand
    {
        public void Execute(object parameter)
        {
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
    }
}
