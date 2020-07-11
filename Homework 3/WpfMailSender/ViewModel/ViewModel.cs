using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using WpfMailSender.Model;
using System.Windows.Controls;

namespace WpfMailSender.ViewModel
{
    class ViewModel : INotifyPropertyChanged
    {

        DelegateCommand ClickCommand;
        DelegateCommand ClickCommandAll;
        public ViewModel()
        {
            ClickCommand = new DelegateCommand(Execute);
            ClickCommandAll = new DelegateCommand(ExecuteAll);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Model.EMailInfo EMailInfo { get; set; } = new EMailInfo("", 0, "", "", "", "", "", "" );

        Model.EMailSendService EMailSendService = new Model.EMailSendService();

        public ICommand ClickSend
        {
            get
            {
                return ClickCommand;
            }
        }
        public ICommand ClickSendAll
        {
            get
            {
                return ClickCommandAll;
            }
        }


        string log = "";
        public string Log
        {
            get
            { return log; }

            private set
            {
                if (log != value)
                {
                    log = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Log"));
                }
            }
        }

        private void Execute(object obj)
        {
            EMailSendService.Send(EMailInfo);
            Log = DateTime.Now + "\r\n" + EMailSendService.Status + 
                Environment.NewLine + 
                EMailSendService.ErrorInfo + Environment.NewLine;

        }

        DBclass db = new DBclass();
        private void ExecuteAll(object obj)
        {
            foreach (Emails recipient in db.Recipients)
            EMailSendService.SendAll(EMailInfo, recipient.Email);


            Log = DateTime.Now + "\r\n" + EMailSendService.Status +
                Environment.NewLine +
                EMailSendService.ErrorInfo + Environment.NewLine;

        }
    }
}
