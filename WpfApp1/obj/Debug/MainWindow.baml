   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:WpfApp1  5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5	   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ 
MainWindow��5   	   $	��300��6   $
��Auto��6)    � WindowStartupLocation$ CenterScreen=�66    � 	Resources 5        	Converter��%   &	       �� 5   
   6'   5      .��5      ]� .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Bottom=�6.   $	��2,5q�6F   .+�5      �� -   5        $��btnPreviousTab��5      .��6H   Prev.6O   �� 5      -   5        $��
btnNextTab��5      .��6@   Next6F   �� 5      -   5        $��btnSelectedTab��5      .��6H   
Selected6R   �� 5      -   5        $��btnModificar��5      
���i��$��50,0,0,0q�6@   .��6S   	Modificar6^   �� 5      -   5        $��btnTraer��5      
���i��$��5,0,0,0q�6=   .��6e   Traer6l   �� 5      -   5        $��	btnCargar��5      
���i��$��5,0,0,0q�6>   .��6g   Cargar6o   �� 5      -   5        $��btnEliminar��5      
���i��$��5,0,0,0q�6@   .��6k   
Eliminar6u   5      �� 5!   
   -   5        $��tcSample��5!       �� TabStripPlacement$
 Left=�6%   .@�5"      �� $��General��6   .��5#      �� $��Content goes here...��6   5$      �� 5%      $��Items Control��6   .��5&      �� .@�5'      �� .��6"   	Item #16+   �� 5(      .��6"   	Item #26+   �� 5)      .��6"   	Item #36+   5*      5+      �� 5,      $��ListBox��6   .��5-      � $��10q�6   .+�5.      �� -	   5        $��
lbTodoList��5.      $��Stretch=�60   ��5/      �� 50      .R�51   "   � $	��0,2q�6'    � ColumnDefinitions 52   &   �� 53   *   $��* �6;   �� 54   *   $	��100 �6;   .+�56   &   �� ��60   �� *Title+� 57   &   $��1��62    � Minimum$ 0Q�6B   	 � Maximum$		 100Q�6N   
 � Value
 6\   �� *
Completion+58   #   59      5;      5<      5=      �� 5?      $��5q�6   $��ComboBox��6"   .��5@      �� $��10q�6   .+�5A      �� -
   5        $��	cmbColors��5A      ��5B      �� 5C      .R�5D   "   �� $ 
Horizontal=�6-   .+�5E   &   �� $��16��6F   $��16��6Q   $��0,2,5,2q�6]   ��60   �� *Name+6]   �� 5F   &   ��60   �� *Name+5G   #   5H      5J      � 5K      $��15q�6    $��Center=�6,   .+�5L      �� -   5        $��btnNext��5L   !   $	��5,0q�6F   $
��Auto��6S   .��6`   Next6f   �� 5M      -   5        $��btnBlue��5M   !   $
��Auto��6F   .��6S   Blue6Y   5N      5O      5P      �� 5R      $��5q�6   $��
ListV Grid��6"   .��5S      �� -   5        $��lvUsers��5S   '   $��10q�6    5T       �� 
TargetType �� Property �� Value��%T   '��       �� 5U      " ��6    .�5V      ��  � ��$
 Left=�6K   5W      5X       �� View 5Y      �� 5Z      .P�5[      �� $��ID��6-    �� Width$ 50��69    �� DisplayMemberBinding 6D   �� *ID+�� 5\      $
��Name��6-   $	 200��6;    6G   �� *Name+�� 5]      $	��Age��6-   $ 50��6:    6E   �� *Age+�� 5^      $
��Mail��6-   $	 300��6;    �� CellTemplate 5_   "   �� 5`   &   .R�5a   *   �� $��	Underline{�6J   
����  � � Cursor$
 Hand��6x   ��64   �� *Mail+6x   5b   '   5d      5e      5g      5h      �� 5j      $��TreeView��6   .��5k      R� -   5        $��trvStructure��5k      $��10q�6]   5l      �� 5n      $��EventTrigger��6   .��5o      �� -   5        $��	lblStyled��5o      $��Hello, styled world!��6-   $��18(�6I   $��Center=�6W   $��Center=�6t   ��5p      �� 5q      " ��6     �� Triggers 5r      :� 5s   "    :� RoutedEvent$ 
MouseEnter��6/   [�5t   &   �� 5u   *   .��5v   .   �� .��5w   2   W�  g� Duration$ 	0:0:0.300D�6B    �� TargetProperty$ FontSize�6W   	 W� To$ 28X�6|   5x   /   5y   +   5{   #   :� 5|   "   $ 
MouseLeave��6/   [�5}   &   �� 5~   *   .��5   .   �� .��5�   2   W� $ 	0:0:0.800D�6B   $ FontSize�6W   $ 18X�6|   5�   /   5�   +   5�   #   5�      5�      5�      5�      5�      5�      