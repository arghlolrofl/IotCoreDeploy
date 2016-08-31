using IotCoreDeploy.ViewModels;

namespace IotCoreDeploy.Models
{
    public class Progress : NotificationBase
    {
        private int _Minimum;
        public int Minimum
        {
            get { return _Minimum; }
            set { _Minimum = value; RaisePropertyChanged(); }
        }

        private int _Maximum;
        public int Maximum
        {
            get { return _Maximum; }
            set { _Maximum = value; RaisePropertyChanged(); }
        }

        private int _Value;
        public int Value
        {
            get { return _Value; }
            set { _Value = value; RaisePropertyChanged(); }
        }


        public Progress(int max = 100, int min = 0, int val = 0)
        {
            Minimum = min;
            Maximum = max;
            Value = val;
        }


        public void Reset(int val = -1)
        {
            if (val < Minimum || val > Maximum)
                Value = Minimum;
            else
                Value = val;
        }
    }
}
