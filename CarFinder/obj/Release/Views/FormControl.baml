   M S B A M L   `   `   `  ���� N  JCarFinder.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulllIclr-namespace:CarFinder.ViewModel.ViewModels;assembly=CarFinder.ViewModelCarFinder.ViewModel.ViewModels  D @CarFinder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CarFinder.ConvertersCarFinder.Converters !   CarFinder.Views.FormControl   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _	viewmodelIclr-namespace:CarFinder.ViewModel.ViewModels;assembly=CarFinder.ViewModel     8	converter"clr-namespace:CarFinder.Converters       � 	Resources  1   +CarFinder.ViewModel.ViewModels.CarViewModel   	ViewModel0  *CarFinder.Converters.BoolToStringConverter  boolToStringConv�  �CarFinder.Converters.BoolToValueConverter`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   	TrueValue   
FalseValue ! boolToStringFoundNotFoundConv��%j   &	        &	      &	 *         $ 
Running...��$ Stopped!��  $ Found��$ 
Not Found!��.���  � DataContext ��  �� Source# [   � ColumnDefinitions �� $
��Auto ��� $��* ��� $
��Auto � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��0��$��Initial Position��  LabelTextBlockStyle#��[ �� $��1��$��0������ *CarModel.InitialPosition+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors . �� $��0��$��1��$��Velocity��#��[ $��0,5,10,0q��� $��1��$��1��$��0,5,0,0q����� *CarModel.InitialVelocity+$ TwoWay=� . �� $��1��$��2��$��2��$
��Left=�$��Center=�$��0,5,0,5q�._��� $��Random Values��$��10q����� *RandomValues+�� $��1��$��3��$��2��$
��Left=�$��Center=�$��0,5,0,5q�	 �� Orientation$	 
Horizontal=�.+��� $
��Stop��
���""��$��10q����� *StopCommand+�� $
��Play��$��5,0,0,0q�
��� � �$��10q����� *PlayCommand+�� $��0��$��4��$��Game status: ��#��[ �� $��1��$��4������ *CarModel.IsGameRunning+
 �� 	Converter#
 [ � $��5��$��3�� �� $
��Auto �.+�&   System.Windows.Controls.DataGrid  $��0��   AutoGenerateColumns .  ���� *CarModel.CarFoundResults+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
Agent Name��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
FinderName+  $ 
Found Car?�� �� *
IsCarFound+#
 [   $ 	Time (tk)�� �� *CarFoundTime+  $ Position�� �� *
Position+