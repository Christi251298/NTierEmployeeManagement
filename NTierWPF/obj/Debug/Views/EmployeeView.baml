   M S B A M L   `   `   `  ����  NTierWPF!    NTierWPF.Views.EmployeeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � $��5,8,5,8q�6     � ColumnDefinitions  5	   
   �� 5
      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Employee Management��6   $��0��5      $��1��6!   $��20(�5      $
��Bold"�6"   $��Center=�5      $��5,8,5,8q�61   �� 5   
   $��Enter Id��6   $��1��5      $��0��5      $��5,8,5,8q�6$   �� 5   
   $��
Enter Name��6   $��2��5       $��0��5!      $��5,8,5,8q�6$   �� 5"   
   $��Enter Email��6   $��3��5#      $��0��5$      $��5,8,5,8q�6$   �� 5%   
   $��Enter Gender��6   $��4��5&      $��0��5'      $��5,8,5,8q�6$   �� 5(   
   $��Enter Status��6   $��5��5)      $��0��5*      $��5,8,5,8q�6$   �� 5+   
   -   5        $��txtid��5+      $��1��5,      $��1��5-      $��5,8,5,8q�6W   ��6"   ��  �� Path$ CurrentEmployee.id� �� Mode$ TwoWay=�6W   �� 5.   
   -   5        $��txtname��5.      $��2��5/      $��1��50      $��5,8,5,8q�6Y   ��6"   �� $ CurrentEmployee.name�$ TwoWay=�6Y   �� 51   
   -   5        $��txtemail��51      $��3��52      $��1��53      $��5,8,5,8q�6Z   ��6"   �� $ CurrentEmployee.email�$ TwoWay=�6Z   �� 55   
   $��4��6   $��1��6    $��5,8,5,8q�60    �� SelectedValuePath$ Content��57       �� SelectedValue 56      �� *CurrentEmployee.gender+.@�59      �� $��Choose your gender��6   �� 5:      $
��male��6   �� 5;      $��female��6   5<      �� 5?   
   $��5��6   $��1��5@      $��5,8,5,8q�6"   $ Content��5B       5A      �� *CurrentEmployee.status+.@�5D      �� $��please select��6   �� 5E      $��active��6   �� 5F      $��inactive��6   5G      �� 5I   
    �� Orientation$ 
Horizontal=�6   $��6��5J      $��1��5K      $��5,8,5,8q�6%   .+�5L      �� -   5        $	��add��5L      $	��ADD��5M      $��3q�6H   ��6#   �� $ SaveCommand�6H   �� 5N      -   5        $
��edit��5N      $
��EDIT��5O      $��3q�6$   ��6/   �� $ UpdateCommand��� 5P      -   5        $��delete��5P      $��DELETE��5Q      $��3q�6&   ��61   �� $ DeleteCommand��� 5T      -   5        $��clear��5T      $��CLEAR��5U      $��3q�6%   61   5V      �� 5W   
   -   5        $��messgae��5W      $��1��5X      $��7��5Y      $	��5,8q�6!    �� Padding$ 3q�6.   ��6:   �� $ Message�&   System.Windows.Controls.DataGrid  5[   
   -	   5          Name$ EmployeeList��5[      	   AutoGenerateColumns	 .  $��8��5]      $��1��6    $��5,8,5,8q�5_   O   ��5^      �� $ EmployeeList�$ TwoWay=�
 �� SelectedItem
 5_      �� $ CurrentEmployee�$ TwoWay=�   Columns 5`      0  *System.Windows.Controls.DataGridTextColumn  5b      ,  &System.Windows.Controls.DataGridColumn   Header$ Employee Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 5c   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5d   %   �� $ id�  5e      $ Employee Name��6%   $
 Auto 5f   %    5g   %   �� $
 name�  5h      $ Employee Email��6%   $
 Auto 5i   %    5j   %   �� $ email�  5k      $ Employee Gender��6%   $
 Auto 5l   %    5m   %   �� $ gender�  5n      $ Employee Status��6%   $ * 5o   %    5p   %   �� $ status�5v      5w      5x      