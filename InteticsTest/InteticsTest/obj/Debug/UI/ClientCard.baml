   M S B A M L   `   `   `  ����G  CInteticsTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:InteticsTestInteticsTest  5   	       InteticsTest.ClientCard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:InteticsTest     5   	   -   5          � Title$  
ClientCard��5   	   $��308.352��6   $��606.153��6-    � 	Resources 5	      (   "InteticsTest.ServiceStationDataSet   serviceStationDataSet  carViewSource �� Source �� Source  clientViewSource��%�   &	        &	      7   &	 <     7     5
   
   6&   �� 5   
    65   �� *Car+8   �� 5   
    68   �� *Client+8   5      .��5      �  � DataContext# [ 6   $	��291��68   $	��Top=�6E   .+�5   
   �� -   5         ��Name$ 
nameClient��5      $
��Left=�6&   $��23��6A   $��	11,11,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $
��Name��6t   $	��Top=�6�   $	��236��6�   �� 5   
   -   5        $ surnameClient��5      $
��Left=�6)   $��23��6D   $��
252,11,0,0q�6P   $
 Wrap=�6d   $��Surname��6x   $	��Top=�6�   $	��236��6�   �� 5   
   -   5         ��Name$
 find��5      $
��Find��6   $
��Left=�6.   $��
498,11,0,0q�6I   $	��Top=�6]   $��90��6u   $��23��6�   6�   �� 5   
   -   5        $ 	addClient��5      $	��Add��6$   $
��Left=�62   $��
11,244,0,0q�6M   $	��Top=�6a   $��83��6y   $��23��6�   6�   �� 5   
   -   5        $ chooseClient��5      $��Choose��6'   $
��Left=�68   $��498,244,0,0q�6S   $	��Top=�6h   $��90��6�   $��23��6�   {�.  6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ clientDataGrid��5      	   AutoGenerateColumns	 .  
   EnableRowVirtualization
 . $��11,39,10,52q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6f   �� # [    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        first_nameColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 
first name��5   ^      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6r      MinWidth$ 30Q�6~   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *
first_name+6~     5      -	   5        last_nameColumn��$ 	last name��5   \   $	 100 6o    6>   �� *	last_name+6o   4  .System.Windows.Controls.DataGridTemplateColumn  5      -
   5        date_of_birthColumn��$ date of birth��5   F   $ SizeToHeader 6]      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *date_of_birth+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5        5      -   5        addressColumn��$ address��5   X   $	 100 6i    6<   �� *	address+6i     5       -   5        phoneColumn��$ phone��5    T   $	 100 6c    6:   �� *phone+6c     5!      -   5        emailColumn��$ email��5!   T   $	 100 6c    6:   �� *email+6c   5#      �� 5$   
   -   5        $ relatedCars��5$      $��Related cars��6&   $
��Left=�6=   $��405,244,0,0q�6X   $	��Top=�6m   $��83��6�   $��23��6�   6�   �� 5%   
   -   5        $ showAll��5%      $��Show all��6"   $
��Left=�65   $��
99,244,0,0q�6P   $	��Top=�6d   $��83��6|   $��23��6�   6�   5'      5(      