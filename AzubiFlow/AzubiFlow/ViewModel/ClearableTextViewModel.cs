using AzubiFlow.Utilities;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AzubiFlow.ViewModel
{
    public class ClearableTextViewModel : BaseViewModel
    {
        //private readonly EventAggregator _eventAggregator;
        //public ClearableTextViewModel(EventAggregator eventAggregator)
        //{
        //    _eventAggregator = eventAggregator;
           
        //    btnClearTextOnClick = new RelayCommand(BtnClearTextOnClick);
        //    taskInputTextChanged = new RelayCommand(TaskInputTextChanged);
        //}
        //public string TaskInput { get; set; }
        //private string _placeholder;
        //public string Placeholder
        //{
        //    get { return _placeholder; }
        //    set 
        //    { 
        //        SetProperty(ref _placeholder, value);
        //    }
        //}
        //public ICommand btnClearTextOnClick;
        //public ICommand taskInputTextChanged;

        //private void BtnClearTextOnClick(object sender)
        //{
        //    TaskInput = "";
        //    _eventAggregator.OnTextCleared(this);
        //}

        //private void TaskInputTextChanged(object sender)
        //{
        //    //if (string.IsNullOrEmpty(TaskInput))
        //    //{
        //    //    Placeholder.Visibility = Visibility.Visible;
        //    //}
        //    //else
        //    //{
        //    //    Placeholder.Visibility = Visibility.Hidden;
        //    //}
        //    _eventAggregator.OnTaskInputTextChanged(this);
        //}
    }
}
