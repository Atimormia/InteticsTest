   M S B A M L   `   `   `  ����G  CInteticsTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:InteticsTestInteticsTest  5   	       InteticsTest.OrdersList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:InteticsTest     5   	   -   5          � Title$  
OrdersList��5   	   $��289.286��6   $��491.209��6-    � 	Resources 5	      (   "InteticsTest.ServiceStationDataSet   serviceStationDataSet  orderViewSource �� Source �� Source��%V   &	        &	      7     5
   
   6&   �� 5   
    67   �� *Order+8   5      .��5      �  � DataContext# [ 6   .+�5   
   �� -   5         ��Name$ label��5      $��	Car(VIN):��6   $
��Left=�63   $��	10,10,0,0q�6N   $	��Top=�6a   �� 5   
   -   5         ��Name$ 
carVinFind��5      $
��Left=�6&   $��23��6A   $��	72,13,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $	��VIN��6t   $	��Top=�6   $	��319��6�   �� 5   
   -   5         ��Name$
 find��5      $
��Find��6   $
��Left=�6.   $��
396,13,0,0q�6I   $	��Top=�6]   $��75��6u   $��23��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 orderDataGrid��5      
   AutoGenerateColumns
 .     EnableRowVirtualization . $��10,41,12,40q�6}      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�      CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly . ��6e   ��    Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        
dateColumn��,  &System.Windows.Controls.DataGridColumn   Header$
 date��5   =      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6K      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *date+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        amountColumn��$ amount��5   V   $ SizeToHeader 6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *amount+6f     5      -   5        statusColumn��$ status��5   V   $	 100 6f    6;   �� *status+6f     5      $	 Car��6`   $	 100 6m    6%   �� *car+   ClipboardContentBinding 6=   Z� 6m     5      $ Client��6c   $	 100 6s    6%   �� *client+ 6@   Z� 6s   5      �� 5    
   -	   5        $ addOrder��5       $	��Add��6#   $
��Left=�61   $��
10,223,0,0q�6L   $	��Top=�6`   $��41��6x   6�   �� 5!   
   -
   5        $ deleteOrder��5!      $��Delete��6&   $
��Left=�67   $��
98,223,0,0q�6R   $	��Top=�6f   $��42��6~   6�   �� 5"   
   -   5        $ 	editOrder��5"      $
��Edit��6$   $
��Left=�63   $��
54,223,0,0q�6N   $	��Top=�6b   $��41��6z   6�   �� 5#   
   -   5        $ showAll��5#      $��Show all��6"   $
��Left=�65   $��145,223,0,0q�6P   $	��Top=�6e   $��62��6}   $��20��6�   6�   5%      5&      