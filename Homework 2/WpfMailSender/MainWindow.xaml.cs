﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfMailSender.Model;

namespace WpfMailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DBclass db = new DBclass();
            dgListRecipients.ItemsSource = db.Recipients;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            EMailInfo info = new EMailInfo();
            info.Sender = cbFrom.Text;
            info.Body = tbBody.Text;
            info.Password = tbPassword.Password;
            info.Port = int.Parse(tbPort.Text);
            info.SmtpClient = tbServer.Text;
            info.Subject = tbSubject.Text;
            info.From = cbFrom.Text;
            info.To = cbTo.Text;
            EMailSendService eMailSendService = new EMailSendService();
            eMailSendService.Send(info);
            tbLog.Text += DateTime.Now + "\r\n";
            tbLog.Text += eMailSendService.Status + Environment.NewLine;
            tbLog.Text += eMailSendService.ErrorInfo + Environment.NewLine;
        }

        private void SendMail(string Recipient)
        {
            EMailInfo info = new EMailInfo();
            info.Sender = cbFrom.Text;
            info.Body = tbBody.Text;
            info.Password = tbPassword.Password;
            info.Port = int.Parse(tbPort.Text);
            info.SmtpClient = tbServer.Text;
            info.Subject = tbSubject.Text;
            info.From = cbFrom.Text;
            info.To = Recipient;
            EMailSendService eMailSendServiceClass = new EMailSendService();
            eMailSendServiceClass.Send(info);
            tbLog.Text += DateTime.Now + "\r\n";
            tbLog.Text += eMailSendServiceClass.Status + Environment.NewLine;
            tbLog.Text += eMailSendServiceClass.ErrorInfo + Environment.NewLine;
        }

        private void tscTabSwitcherControl_btnNextClick(object sender, RoutedEventArgs e)
        {
            if (tcTabControl.SelectedIndex < tcTabControl.Items.Count)
                tcTabControl.SelectedIndex++;
            else
                tcTabControl.SelectedIndex = 0;
        }

        private void btnSendbyRecipients_Click(object sender, RoutedEventArgs e)
        {
            foreach (Emails recipient in dgListRecipients.ItemsSource)
                SendMail(recipient.Email);
        }
    }
}
