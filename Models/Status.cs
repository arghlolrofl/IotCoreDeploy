using IotCoreDeploy.ViewModels;

namespace IotCoreDeploy.Models
{
    public class Status : NotificationBase
    {
        public enum AppState
        {
            Initializing,
            Loaded
        }

        private AppState m_state;
        public AppState State
        {
            get { return m_state; }
            set { m_state = value; RaisePropertyChanged(); }
        }


        private string m_statusMessage;
        public string StatusMessage
        {
            get { return m_statusMessage; }
            set { m_statusMessage = value; RaisePropertyChanged(); }
        }


        public Status()
        {
            State = AppState.Initializing;
        }


        public void SetState(AppState state)
        {
            State = state;
            StatusMessage = State.ToString();
        }
    }
}
