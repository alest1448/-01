   M S B A M L   `   `   `  ����A  =pachka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:pachkapachka  5   	       pachka.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:pachka     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ���	#FFD32B39.+�5
   
   � $��28,36,31,29q�6    � ColumnDefinitions 5      �� 5      $	��35* �6#   �� 5      $
��706* �6#   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ White��6#    � Offset$ 0.492Q�61   � 5      $ 	#FFFFC1C1��6#   $ 1Q�65   5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgClients��5      $��	274,0,0,0q�6*      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6=   $��1��6P   �� 5      -   5         ��Name$ btAdd��5      $�� Добавить ��6$   $
��Left=�69   $��38��6T   $��	22,87,0,0q�6`   $	��Top=�6s   $	��179��6�   $��1��6�   �� 5      -   5        $ btEdit��5      $!��Редактировать ��6%   $
��Left=�6>   $��39��6Y   $��
22,146,0,0q�6e   $	��Top=�6y   $	��179��6�   $��1��6�   �� 5      -   5        $ btDelete��5      $��Удалить��6'   $
��Left=�69   $��37��6T   $��137,210,0,0q�6`   $	��Top=�6u   $	��119��6�   $��1��6�   �� 5      $	��ID:��6   $
��Left=�6"   $��27��6=   $��	8,216,0,0q�6I   $	��Top=�6\   $��36��6t   $��1��6   �� 5      -   5        	 ��Name$
	 tbID��5      $
��Left=�6$   $��37��6?   $��
49,210,0,0q�6K   
 �� TextWrapping$

 Wrap=�6_   $�� ��6s   $	��Top=�6{   $��49��6�   $��1��6�   �� 5      -   5        $ 
btPostavki��5      $��1��6)   $-��'Возможные поставщики��69   $
��Left=�6X   $��48��6s   $��	3,311,0,0q�6   $	��Top=�6�   $	��152��6�   6�   5      5      5      