   M S B A M L   `   `   `  ����E  APhotoFrame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PhotoFrame
PhotoFrame  5   	       PhotoFrame.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:PhotoFrame     5   	     � Title$  
MainWindow��5   	   $��514.878��6   $	��800��6-    � WindowStartupLocation$ CenterScreen=�69    � WindowStyle$
 None=�6^    � 	Resources 5	       �� 
TargetType �� Property �� Value��%|   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��
 �����6+   5      5      .��5      � 
���   � � ColumnDefinitions 5   
   �� 5      �� 5      $
��1.8* �6    � RowDefinitions 5   
   �� 5      $��30��6   �� 5      $��3* �6   �� 5      $	��120��6   .+�5   
   �� -   5        $��	txtStatus��5   6   $��2��6   $��Status��6(   $
��Left=�6G   $��Center=�6b   �� 5    
   	 �� Orientation$	 
Horizontal=�6   $��1��6.   $��Right=�6>   .+�5!      �� -   5        $��	btnStatus��5!   #   $	��...��6   $��1��64   $��40��6D   $��Right=�6O   $��Stretch=�6k   
���   �$
��Bold"�6�   
�������6�   �� 5"      -   5        $��btnClose��5"   !   $��X��6   $��1��61   $��40��6A   $��Right=�6L   $��Stretch=�6h   
���   �$
��Bold"�6�   
�������6�   5#      �� 5%   
   $��1��6   $��2��6"   .+�5&      �� $��TRENUTNO��6   
�����_�6(   � 5'      .+�5(      �� $��70��6?   $��70��6J   ��6   �� *weatherData.IconUrl+6J   �� 5)      $��50(�6>   ��6   �� *weatherData.Temp+6>   �� 5*      $	 Vertical=�6   .+�5+      �� $��10,0,0,0q�6^   ��6    �� *weatherData.TempMin+
 �� StringFormat$
 
Min: {0:C}��6^   �� 5,      $��10,0,0,0q�6^   ��6    �� *weatherData.TempMax+$
 
Max: {0:C}��6^   �� 5-      $��10,0,0,0q�6`   ��6    �� *weatherData.Pressure+$
 Tlak: {0:C}��6`   �� 5.      $��10,0,0,0q�6a   ��6    �� *weatherData.Humidity+$
 Vlaga: {0:C}��6a   �� 5/      $��10,0,0,0q�6c   ��6    �� *weatherData.WindSpeed+$
 Vjetar: {0:C}��6c   50      51      �� 52      $��25(�6A   $
��Wrap=�6O   $��5,0,0,0q�6c   $��Center=�6t   ��6   �� *weatherData.Description+6t   �� 53      $
��Wrap=�6Z   $��5,0,0,0q�6n   $��Center=�6   ��6   �� *weatherData.Sunrise+$
 Izlazak: {0:C}��6   �� 54      $
��Wrap=�6Y   $��5,0,0,0q�6m   $��Center=�6~   ��6   �� *weatherData.Sunset+$
 Zalazak: {0:C}��6~   �� 56      $��PROGNOZA��6   
�����_�$��0,20,0,0q�6?   &   System.Windows.Controls.DataGrid  57         AutoGenerateColumns .  $��5,5,5,0q�6Y   
���   �
���������6   ��  �� Path$ forecast�   Columns 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn   Header$ Datum i vrijeme��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *Dt+  5:      $
 Desc��6)    67   �� *Description+  5;      $
 Temp��6)    67   �� *Temp+   ColumnHeaderStyle 5=      �� 5>      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5?      ��  � ��
 ���_�67   �� 5@       � ��
 �����67   �� 5A       � ��$ Center=�6G   5B         	CellStyle 5D      �� 5E      *  $System.Windows.Controls.DataGridCell"  6   .�5F      ��  � ��
 �   �67   �� 5G       � ��
 �����67   5H      5J      5K      �� 5M   
   -   5        $��imgPhoto��5M   -   $��1��6   $��1��6    $��5,5,5,5q�6=   $'��!/Resources/Original-JPG-Image.jpg��6N   � 5O   
   $��1��6   $��2��6$   
���   �$��Right=�6D   .+�5P      �� .+�5Q      �� -   5        $��txtDay��5Q      $��Nedjelja��6*   $��20(�6:   �� 5R      -   5        $��txtDate��5R      $��01.01.17��6+   $��40(�6;   $��10,0,0,0q�6I   5S      �� 5T      -   5        $��txtTime��5T      $��00:00��6'   $��60(�64   $
��Bold"�6B   $��	20,0,10,0q�6T   5U      5X      5Y      