   M S B A M L   `   `   `  ����@  <sound, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:soundsound  5   	       sound.DataGrid   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:sound     5   	     � Title$  DataGrid��5   	   $	��450��6   $	��800��6'   .��5	      � $��1��6   .+�5
   
   �� -   5        $��1��5
      $��
Выйти��6!   $��45��61   $��10,355,10,0q�6=   $	��Top=�6R   $��18(�6j   $��1��6x   6�   �� 5   
   -   5        $��1��5      $��Добавить��6!   $��45��64   $��
10,30,10,0q�6@   $	��Top=�6T   $��18(�6l   $��1��6z   ���	#FFE2E2E26�   �� 5   
   -   5        $��1��5      $��Удалить��6!   $��45��63   $��10,171,10,0q�6?   $	��Top=�6T   $��18(�6l   $��1��6z   6�   �� 5   
   -   5        $��1��5      $��Изменить��6!   $��45��64   $��10,101,10,0q�6@   $	��Top=�6U   $��18(�6m   $��1��6{   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Products��5       $��1��6      AutoGenerateColumns .     
IsReadOnly .  �� SelectedItem 62   �� *	Product+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	ProductID+6Q     5      $
 Name��6%    63   �� *ProductName+6U     5      $ Price��6%    64   �� *Price+6P     5      $ Description��6%    6:   �� *Description+6\   5      �� 5   
   -   5         ��Name$ 	TextCheck��5      $��1��6'   $��Center=�67   $��	0,298,0,0q�6T   $��1��6g   $
��Wrap=�6t   $	��Top=�6�   $��31��6�   $��94��6�   $��16(�6�   $��Роль��6�   	 �� TextAlignment$	 Center=�6�   �� 5   
   -   5        $��1��5      $��РОЛЬ��6!   $��Center=�60   $��	0,263,0,0q�6M   $��1��6`   $	��Top=�6m   $��30��6�   $��94��6�   
 J� RenderTransformOrigin$
 0.511,1.633&�6�    � ColumnDefinitions 5   
   �� 5      $
��660* �6   6.   �� 5      $
��140* �6   6.    � RowDefinitions 5   
   �� 5      �� 5      $	��410 �6   6+   5$      5&      