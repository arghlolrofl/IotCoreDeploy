using IotCoreDeploy.Models;
using Microsoft.Practices.Prism.Commands;
using System;
using Windows.UI.Popups;

namespace IotCoreDeploy.ViewModels
{
    public class MainViewModel : NotificationBase
    {
        #region Properties

        private Progress m_progress;
        public Progress Progress
        {
            get { return m_progress; }
            set { m_progress = value; RaisePropertyChanged(); }
        }

        private Status m_status;
        public Status Status
        {
            get { return m_status; }
            set { m_status = value; RaisePropertyChanged(); }
        }


        private string m_deviceAddress;
        public string DeviceAddress
        {
            get { return m_deviceAddress; }
            set { m_deviceAddress = value; RaisePropertyChanged(); }
        }

        private string m_projectPath;
        public string ProjectPath
        {
            get { return m_projectPath; }
            set { m_projectPath = value; RaisePropertyChanged(); }
        }

        private string m_devicePath;
        public string DevicePath
        {
            get { return m_devicePath; }
            set { m_devicePath = value; RaisePropertyChanged(); }
        }

        #endregion

        #region Commands

        private DelegateCommand _AnalyzeCommand;
        public DelegateCommand AnalyzeCommand
        {
            get { return _AnalyzeCommand ?? (_AnalyzeCommand = new DelegateCommand(AnalyzeCommand_OnExecute)); }
        }

        private DelegateCommand _DeployCommand;
        public DelegateCommand DeployCommand
        {
            get { return _DeployCommand ?? (_DeployCommand = new DelegateCommand(DeployCommand_OnExecute)); }
        }

        private DelegateCommand _RunCommand;
        public DelegateCommand RunCommand
        {
            get { return _RunCommand ?? (_RunCommand = new DelegateCommand(RunCommand_OnExecute)); }
        }

        #endregion


        #region Initialization

        public MainViewModel()
        {
            Status = new Status();
            Progress = new Progress(100, 0, 0);

            DeviceAddress = "10.34.2.57";
            ProjectPath = @"D:\projects\NavigatorWeb\src\NavigatorWeb.Node";
            DevicePath = @"W:\NavigatorWeb_xd453gdf34523\LocalState";

            Progress.Value = 100;
            Status.SetState(Status.AppState.Loaded);
        }

        #endregion


        #region Command Handler

        private async void AnalyzeCommand_OnExecute()
        {
            await new MessageDialog("Analyzing ...").ShowAsync();
        }

        private async void DeployCommand_OnExecute()
        {
            await new MessageDialog("Deploying ...").ShowAsync();
        }

        private async void RunCommand_OnExecute()
        {
            await new MessageDialog("Running ...").ShowAsync();
        }

        #endregion
    }
}
