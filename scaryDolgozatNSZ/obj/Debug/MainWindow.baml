   M S B A M L   `   `   `  ����K  GscaryDolgozatNSZ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:scaryDolgozatNSZscaryDolgozatNSZ  5   	   !    scaryDolgozatNSZ.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:scaryDolgozatNSZ     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	   $��20(�5
   	    � Title$ Rémisztő doga��5   	   $	��450��6   $	��800��6,   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   �� $
��Név��6   $��0��6   $��0��6/   $��5q�6<   6I   �� 5   
   -   5         ��Name$	 nev��5      $��0��6   $��1��6,   6>   �� 5   
   $��Születési dátum��6   $��1��6+   $��0��68   $��5q�6H   6U   �� 5   
   -   5        $ 	szuldatum��5      $��1��6%   $��1��62   6D   �� 5   
   $��Telefonszám��6   $��2��6'   $��0��64   $��5q�6D   6Q   �� 5    
   -   5        $ telefonszam��5       $��2��6'   $��1��64   6F   �� 5"   
   $��E-mail cím��6   $��3��6&   $��0��63   $��5q�6C   6P   �� 5#   
   -   5        $ email��5#      $��3��6!   $��1��6.   6@   �� 5%   
   -   5         ��Name$ saveBtn��5%      $��4��6"   $��1��6/   $��Mentés��6?   
��� � �
�������6�   �� 5'   
   -   5        $ colors��5'      $��5��6!   $��1��6.   $��Színek��6>   
����  �
�������6�   �� 5)   
   -   5        $
 exit��5)      $��5��6   $��0��6,   $��	Kilépés��6<   
���  ��
�������6�   5*      5+      