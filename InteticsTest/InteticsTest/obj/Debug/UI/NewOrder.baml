   M S B A M L   `   `   `  ����G  CInteticsTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:InteticsTestInteticsTest  5   	       InteticsTest.NewOrder   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:InteticsTest     5   	     � Title$  NewOrder��5   	   $	��230��6   $	��440��6'    � 	Resources 5	      (   "InteticsTest.ServiceStationDataSet   serviceStationDataSet  orderViewSource �� Source �� Source��%V   &	        &	      7     5
   
   6&   �� 5   
    67   �� *Order+8   5      .��5      � $
��Left=�6   $	��430��6&    � ColumnDefinitions 5   
   �� 5      $
��107* �6   �� 5      $
��108* �6   .+�5   
   �� -   5         ��Name$ label��5      $��Client:��6   $
��Left=�61   $��	10,10,0,0q�6L   $	��Top=�6_   �� 5   
   -   5         ��Name$ 
clientName��5      $
��Left=�6&   $��23��6A   $��	80,12,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $
��Name��6t   $	��Top=�6�   $	��120��6�   {�.  6�   �� 5   
   -   5        $ clientSurname��5      $
��Left=�6)   $��23��6D   $��
205,12,0,0q�6P   $
 Wrap=�6d   $��Surname��6x   $	��Top=�6�   $	��120��6�   {�.  $��2��6�   �� 5   
   -   5         ��Name$ chooseClient��5      $��Choose Client��6'   $
��Left=�6?   $��123.418,12,0,0q�6Z   $	��Top=�6r   $��83��6�   $��23��6�   $��1��6�   6�   �� 5   
   -   5        $ 
label_Copy��5      $
��Car:��6$   $
��Left=�63   $��	10,41,0,0q�6N   $	��Top=�6a   �� 5   
   -   5        $ carVIN��5      $
��Left=�6"   $��23��6=   $��	80,43,0,0q�6I   $
 Wrap=�6\   $	��VIN��6p   $	��Top=�6{   $	��245��6�   {�.  $��2��6�   �� 5   
   -   5        $ 	chooseCar��5      $��
Choose Car��6$   $
��Left=�69   $��123.418,43,0,0q�6T   $	��Top=�6l   $��83��6�   $��23��6�   $��1��6�   6�   �� 5   
   -   5        $ label1��5      $��Date:��6    $
��Left=�60   $��	10,72,0,0q�6K   $	��Top=�6^   (  "System.Windows.Controls.DatePicker  5   
   -	   5        	  Name$	 	orderDate��5      $
��Left=�6(   $��	80,74,0,0q�6C   $	��Top=�6V   $	��245��6n   $��2��6z   �� 5   
   -
   5        $ label2��5      $��Amount:��6    $
��Left=�62   $��
10,103,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        $ orderAmount��5      $
��Left=�6'   $��23��6B   $��
80,106,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��245��6�   $��2��6�   �� 5   
   -   5        $ label3��5      $��Status:��6    $
��Left=�62   $��
10,134,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        
 ��Name$
 orderStatus��5      $
��Left=�6(   $��
80,138,0,0q�6C   $	��Top=�6W   $	��245��6o   $��2��6{   .@�5      �� $��	Completed��6   �� 5       $��In progress��6   �� 5!      $��	Cancelled��6   5"      �� 5#   
   -   5        $ addOrder��5#      $��	Add Order��6#   $
��Left=�67   $��123.418,166,0,0q�6R   $	��Top=�6k   $��83��6�   $��23��6�   $��1��6�   6�   5%      5&      