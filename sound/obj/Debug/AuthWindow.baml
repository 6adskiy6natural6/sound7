   M S B A M L   `   `   `  ����@  <sound, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:soundsound  5   	       sound.AuthWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:sound     5   	     � Title$  
AuthWindow��5   	   $	��600��6   $	��400��6)   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ White��6    � Offset$ 1Q�6-   5       � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      �� 5      $��6* �6   6,   �� 5      .+�5   
   �� -   5         ��Name$ tbxlogin��5      $��1��6$   $��Center=�64   $��2��6Q    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��220��6�   $��52��6�   	 J� RenderTransformOrigin$	 0.512,1.211&�6�   $��0,35,0,0q�6�   �� 5   
   -   5        $ tbxpass��5      $��1��6#   $��Center=�63   $��3��6P   $
 Wrap=�6]   $	��Top=�6q   $	��220��6�   $��52��6�   $	 0.512,1.211&�6�   $��0,35,0,0q�6�   �� 5   
   -   5        $��1��5      $��
Войти��6!   $
��Left=�61   $��	55,24,0,0q�6L   $��4��6_   $	��Top=�6l   $��45��6�   $	��185��6�   $��20(�6�   �� 5    
   $��1��6   $��Center=�6$   $��20��6A   $��0,10,0,0q�6M   $��2��6_   $
��Wrap=�6l   $��Введите логин��6�   $	��Top=�6�   $	��220��6�   $��16(�6�   �� 5!   
   $��1��6   $��Center=�6$   $��20��6A   $��0,10,0,0q�6M   $��3��6_   $
��Wrap=�6l   $!��Введите пароль��6�   $	��Top=�6�   $	��220��6�   $��16(�6�   5"      5#      