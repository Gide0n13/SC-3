   M S B A M L   `   `   `  ����H  DWpfMailSender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null@0clr-namespace:TabSwitcher;assembly=WpfMailSenderTabSwitcher  5   	   -clr-namespace:WpfMailSenderWpfMailSender  5   	   F BTabSwitcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null>.clr-namespace:TabSwitcher;assembly=TabSwitcherTabSwitcher 63       WpfMailSender.MainWindow   5   	   @TabSwitcher0clr-namespace:TabSwitcher;assembly=WpfMailSender  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfMailSender     5   	   GTabSwitcher1.clr-namespace:TabSwitcher;assembly=TabSwitcher     63     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��20* �6   �� 5      $
��281* �6   �� 5      $	��25* �6   .+�5   
   o� $��0��6   .@�5      m� $��Файл��6   m� 5      $��Помощь��6   5      �� 5   
   -   5        $��tcTabControl��5   "   $��1��6   .@�5      �� $-��'Редактирование писем��6   .��5      �� $	��341��6   $	��776��6*   .+�5      �� -   5         ��Name$ 	tbSubject��5      $	��200��61   $
��Left=�6=   �� 5      $#��Название письма��6   $
��Auto��66   �� 5      $'��!Содержимое письма��6   $
��Auto��68   �� 5      -   5        $ tbBody��5   +   $��1��6   $��Stretch=�6;   $��Stretch=�5      $	��100��6:    �� AcceptsReturn . $
��Auto=�5      �� 5      $
��From��6   �� 5      -   5         ��Name$ cbFrom��5       �� Text$ tallon300@yandex.ru��6/   .@�5      �� $��tallon300@yandex.ru��6'   5      �� 5       $��To��6   �� 5!      -   5        $
 cbTo��5!      $ tallon300@yandex.ru��6-   .@�5"      �� $��tallon300@yandex.ru��6'   5#      �� 5$      -   5         ��Name$ btnSend��5$      $
��Auto��6.   $-��'Отправить немедленно��6;   6Z   �� 5%      -   5        $ btnSendbyRecipients��5%      $
��Auto��6:   $!��Отправить всем��6G   6`   5&      5'      �� 5(      $��Настойки��6   .��5)      � $
��auto��6   $	��Top=�6*   $	��350��6B   $
��Left=�6N   .+�5*      �� $��Сервер��6   $
��Auto��6-   �� 5+      -   5        $ tbServer��5+   +   $��1��6   $	��200��6=   $
��Left=�6I   $��smtp.yandex.ru��6d   �� 5,      $��Порт��6   $
��Auto��6+   �� 5-      -	   5        $ tbPort��5-   +   $��1��6   $��30��6;   $��25��6F   �� 5.      6   �� 5/      $%��Имя пользователя��6   $
��Auto��67   �� 50      -
   5        $ 
tbUserName��50   +   $��1��6   $	��350��6?   $��tallon300@yandex.ru��6K   �� 51      $��Пароль��6   $
��Auto��6-   G� 52      -   5         G�Name$ 
tbPassword��52   /   $��1��6"   $	��350��6C    G� PasswordChar$ *��6O   	 G� Password$	 12345678��6`   53      54      �� 55      $��Журнал��6   .��56      �� -   5        $ tbLog��56      $��Stretch=�6)   $��Stretch=�6G    . ��. $
��Auto=�57   ?   $	��785��6o   $	��338��6{   58      �� 59      $��Списки��6   .��5:      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 dgListRecipients��5:      $	��758��65   $	��293��6A   $��10q�6N   5;      5<      `� 5=   
   -   5         `�Name$ sbStatus��5=      $��2��6(   .�5>      c� .@�5?      $  TabSwitcher.TabSwitcherControl  -   5          Name$ tscTabSwitcherControl��5?   2   6Q   �� 5@      -   5         ��Name$ lbStatus��5@      5A      5B      5C      5D      