   M S B A M L   `   `   `  ����G  CInteticsTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:InteticsTestInteticsTest  5   	       InteticsTest.CarsList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:InteticsTest     5   	   -   5          � Title$  CarsList��5   	   $��304.121��6   $��385.715��6+    � 	Resources 5	      (   "InteticsTest.ServiceStationDataSet   serviceStationDataSet  carViewSource �� Source �� Source��%T   &	        &	      7     5
   
   6&   �� 5   
    65   �� *Car+8   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ carDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��10,41,10,32q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6c   �� # [ 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        
makeColumn��,  &System.Windows.Controls.DataGridColumn
   Header$

 make��5   R      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *make+6`     5      -   5        modelColumn��$
 model��5   T   $	 100 6c    6:   �� *model+6c     5      -   5        
yearColumn��$

 year��5   R   $ 50 6`    69   �� *year+6`     5      -   5        	vinColumn��$	
 vin��5   P   $	 100 6]    68   �� *vin+6]     5      -   5        is_clientColumn��$
 	id_client��5         
Visibility$ Hidden=�6�    6>   �� *	id_client+   ClipboardContentBinding 6\   Z� 6�   5      �� 5   
   -   5         ��Name$ 
clientName��5      $
��Left=�6&   $��23��6A   $��	59,10,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $
��Name��6t   $	��Top=�6�   $	��152��6�   {�.  6�   �� 5   
   -	   5        $ clientSurname��5      $
��Left=�6)   $��23��6D   $��
214,10,0,0q�6P   $
 Wrap=�6d   $��Surname��6x   $	��Top=�6�   $	��154��6�   {�.  6�   �� 5   
   -
   5         ��Name$ label��5      $��Client:��6   $
��Left=�61   $��	10,10,0,0q�6L   $	��Top=�6_   $��43��6w   �� 5   
   -   5         ��Name$ addCar��5      $	��Add��6!   $
��Left=�6/   $��
10,246,0,0q�6J   $	��Top=�6^   $��41��6v   6�   �� 5   
   -   5        $ 	deleteCar��5      $��Delete��6$   $
��Left=�65   $��
98,246,0,0q�6P   $	��Top=�6d   $��42��6|   6�   �� 5   
   -   5        $ editCar��5      $
��Edit��6"   $
��Left=�61   $��
54,246,0,0q�6L   $	��Top=�6`   $��41��6x   6�   �� 5   
   -   5        $ 	chooseCar��5      $��Choose��6$   $
��Left=�65   $��293,246,0,0q�6P   $	��Top=�6e   $��75��6}   {�.  6�   5      5       