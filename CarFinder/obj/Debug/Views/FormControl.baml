   M S B A M L   `   `   `  ����N  JCarFinder.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulllIclr-namespace:CarFinder.ViewModel.ViewModels;assembly=CarFinder.ViewModelCarFinder.ViewModel.ViewModels  5      D @CarFinder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CarFinder.ConvertersCarFinder.Converters 5      !   CarFinder.Views.FormControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _	viewmodelIclr-namespace:CarFinder.ViewModel.ViewModels;assembly=CarFinder.ViewModel     5      8	converter"clr-namespace:CarFinder.Converters     5        � 	Resources  5
      1   +CarFinder.ViewModel.ViewModels.CarViewModel   	ViewModel0  *CarFinder.Converters.BoolToStringConverter  boolToStringConv�  �CarFinder.Converters.BoolToValueConverter`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   	TrueValue   
FalseValue ! boolToStringFoundNotFoundConv �� 
TargetType  ValidateButtonStyle �� Triggers �� Binding �� ElementName �� Path �� Property	 �� Value��%_  &	        &	      &	 P     &	 �       5   
   6!     5   
   $ 
Running...��6C   $ Stopped!��6Z   6r     5   
   $ Found��6P   $ 
Not Found!��6b   6|   �� 5   
   " ��6    5      �� 5       6   �� $ txtInitialPosition��$ (Validation.HasError)�.a�5      ��  � {�	 .  6B   5      5      5      .��5      � 
 � DataContext
 6   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6   .+�5&   
   �� $��0��6   $��0��5'      $��Initial Position��5(        LabelTextBlockStyle#��[ 5)      �� 5+   
   -   5        $��txtInitialPosition��5,      $��1��5+      $��0��5,      ��5-      �� *CarModel.InitialPosition+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors . �� 5/   
   $��0��6   $��1��50      $��Velocity��51      #��[ 52      $��0,5,10,0q�53      �� 55   
   -   5        $��txtInitialVelocity��56      $��1��55      $��1��56      $��0,5,0,0q�58      ��57      �� *CarModel.InitialVelocity+$ TwoWay=� . 58      �� 5;   
   $��1��6   $��2��5<      $��2��6   $
��Left=�5=      $��Center=�5>      $��0,5,0,5q�5?      ._�5@      �� $��Random Values��6   $��10q�5B   !   ��5A   !   �� *RandomValues+5B   !   5C      �� 5E   
   $��1��6   $��3��5F      $��2��6   $
��Left=�5G      $��Center=�5H      $��0,5,0,5q�5I       �� Orientation$ 
Horizontal=�6.   .+�5J      �� $
��Stop��6   
���""��$��10q�5L   !   ��5K   !   �� *StopCommand+5L   !   �� 5M      $
��Play��6   $��5,0,0,0q�6$   
��� � �$��10q�5O   !   ��5N   !   �� *PlayCommand+5Q      5R      �� 5T   
   $��0��6   $��4��5U      $��Game status: ��5V      #��[ 5W      �� 5Y   
   $��1��6   $��4��5Z      ��5[      �� *CarModel.IsGameRunning+ �� 	Converter# [ � 5]   
   $��5��6   $��3��6    5^      �� 5`      $
��Auto �6#   .+�5c      &   System.Windows.Controls.DataGrid  $��0��6      AutoGenerateColumns .  ��6'   �� *CarModel.CarFoundResults+   Columns 5d      0  *System.Windows.Controls.DataGridTextColumn  5e      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Agent Name��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
FinderName+  5f      $ 
Found Car?��6)    6=   �� *
IsCarFound+# [   5g      $ 	Time (tk)��6)    6<   �� *CarFoundTime+  5h      $ Position��6)    6;   �� *
Position+5j      5u      5w      5x      