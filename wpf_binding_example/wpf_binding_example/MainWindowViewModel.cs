using System.Collections.ObjectModel;
using System.Collections.Specialized;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Linq;

namespace wpf_binding_example
{
    public class MainWindowViewModel : ViewModelBase
    {
        //======================================================
        #region _Constructors_

        public MainWindowViewModel()
        {
            ValidateCmd = new RelayCommand(DoValidate);
            Initialize();
        }

        #endregion

        //======================================================
        #region _Public properties_

        private string _input;
        public string Input
        {
            get { return _input; }
            set { Set("Input", ref _input, value); }
        }

        public ObservableCollection<string> List { get; protected set; } 

        public RelayCommand ValidateCmd { get; protected set; }

        #endregion

        //======================================================
        #region _Private, protected, internal methods_

        protected void Initialize()
        {
            if (Properties.Settings.Default.strings_list == null)
                Properties.Settings.Default.strings_list = new StringCollection();

            List = new ObservableCollection<string>(Properties.Settings.Default.strings_list.OfType<string>().ToList());
        }

        protected void DoValidate()
        {
            if (!string.IsNullOrWhiteSpace(Input))
            {
                // valid
                Properties.Settings.Default.strings_list.Add(Input);
                List.Add(Input);

                Input = string.Empty;
            }
        }

        #endregion
    }
}