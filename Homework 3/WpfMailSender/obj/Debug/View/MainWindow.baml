   M S B A M L   `   `   `  ����H  DTabSwitcherRE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:TabSwitcherRE;assembly=TabSwitcherRETabSwitcherRE  5   	   H DWpfMailSender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WpfMailSender.ViewModelWpfMailSender.ViewModel 5   	      WpfMailSender.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   KTabSwitcher12clr-namespace:TabSwitcherRE;assembly=TabSwitcherRE     5   	   4vm%clr-namespace:WpfMailSender.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � DataContext 5
      ' !WpfMailSender.ViewModel.ViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $
��281* �6   �� 5      $	��25* �6   .+�5   
   o� $��0��6   .@�5      m� $��Файл��6   m� 5      $��Помощь��6   5      �� 5   
   -   5        $��tcTabControl��5   "   $��1��6   .@�5      �� $-��'Редактирование писем��6   .��5      �� $	��341��6   $	��776��6*   .+�5      �� -   5         ��Name$ 	tbSubject��5      $	��200��61   $
��Left=�6=   ��6X   ��  �� Path$ EMailInfo.Subject� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWayToSource=��� 5      $#��Название письма��6   $
��Auto��66   �� 5      $'��!Содержимое письма��6   $
��Auto��68   �� 5      -   5        $ tbBody��5   +   $��1��6   $��Stretch=�6;   $��Stretch=�5      $	��100��6:    �� AcceptsReturn . $
��Auto=�5      ��6N   �� $ EMailInfo.Body�$ PropertyChanged=�$ OneWayToSource=��� 5       $
��From��6   �� 5!      -   5         ��Name$ cbFrom��5!      	 �� Text	 6/   �� $ EMailInfo.From�$ PropertyChanged=�$ OneWayToSource=�.@�5"      �� .��6'   tallon300@yandex.ru6<   5#      �� 5$      $��To��6   �� 5%      -   5        $
 cbTo��5%      	 6-   �� $ EMailInfo.To�$ PropertyChanged=�$ OneWayToSource=�.@�5&      �� .��6'   tallon300@yandex.ru6<   5'      �� 5(      -   5        
 ��Name$
 btnSend��5(      $
��Auto��6.   $-��'Отправить немедленно��6;   ��6Z   �� *	ClickSend+�� 5)      -   5        $
 btnSendbyRecipients��5)      $
��Auto��6:   $!��Отправить всем��6G   ��6`   �� *ClickSendAll+5*      5+      �� 5,      $��Настойки��6   .��5-      � $
��auto��6   $	��Top=�6*   $	��350��6B   $
��Left=�6N   .+�5.      �� $��Сервер��6   $
��Auto��6-   �� 5/      -   5        $ tbServer��5/   +   $��1��6   $	��200��6=   $
��Left=�6I   ��6d   �� $ EMailInfo.SmtpClient�$ PropertyChanged=�$ OneWayToSource=��� 50      $��Порт��6   $
��Auto��6+   �� 51      -	   5        $ tbPort��51   +   $��1��6   $��30��6;   ��6F   �� $ EMailInfo.Port�$ PropertyChanged=�$ OneWayToSource=��� 52      6   �� 53      $%��Имя пользователя��6   $
��Auto��67   �� 54      -
   5        $ 
tbUserName��54   +   $��1��6   $	��350��6?   ��6K   �� $ EMailInfo.Sender�$ PropertyChanged=�$ OneWayToSource=��� 55      $��Пароль��6   $
��Auto��6-   �� 56      -   5        $ 
tbPassword��56   +   $��1��6   $	��350��6?   ��6K   �� $ EMailInfo.Password�$ PropertyChanged=�$ OneWayToSource=�57      58      �� 59      $��Журнал��6   .��5:      �� $��Center=�6   $��Center=�69   $	��309��6T   $	��773��6a   $��CharacterEllipsis=�6m   $
��Wrap=�6�   ��6�   �� $	 Log�5;      �� 5<      $��Списки��6   .��5=      &   System.Windows.Controls.DataGrid  -   5          Name$ dgListRecipients��5=      $	��758��65   $	��293��6A   $��10q�6N   5>      5?      `� 5@   
   -   5         `�Name$ sbStatus��5@      $��2��6(   .�5A      c� .@�5B      &    TabSwitcherRE.TabSwitcherControl  -   5          Name$ tscTabSwitcherControl��5B   2      PrevText$
 Prev��5C   D      NextText$
 Next��6T   �� 5D      -   5         ��Name$ lbStatus��5D      5E      5F      5G      5H      