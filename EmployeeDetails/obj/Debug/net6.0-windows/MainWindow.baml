   M S B A M L   `   `   `  ����J  FEmployeeDetails, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EmployeeDetailsEmployeeDetails  5   	        EmployeeDetails.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:EmployeeDetails     5   	     � Title$  Employee Details��5   	   $	��450��6"   $	��800��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   5      �� 5   
   $ 
Horizontal=�6   $��Right=�6.   $��0 20 0 0q�6J   .+�5      �� -   5        $��Update��5      $��80��6&   $��5q�61   6<   �� 5      -   5        $��Delete��5      $��80��6&   $��5q�61   6<   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $��1��6%      AutoGenerateColumns$ False��62   $��10q�6N      CanUserAddRows$ False��5         CanUserDeleteRows$ False��6*      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 6H   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *Id+6H     5      $
 Name��6%   $		 200 6L   
 63   �� *Name+6L     5       $ Email��6%   $		 200 6N   
 64   �� *Email+6N     5!      $ Gender��6%   $		 200 6P   
 65   �� *Gender+6P     5"      $ Status��6%   $		 200 6P   
 65   �� *Status+6P   5%      5&      5'      