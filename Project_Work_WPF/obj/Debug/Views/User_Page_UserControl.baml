   M S B A M L   `   `   `  ����d  `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF  5      K GProject_Work_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Project_Work_WPF.ViewsProject_Work_WPF.Views 5      2   ,Project_Work_WPF.Views.User_Page_UserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      bmapRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      0local$clr-namespace:Project_Work_WPF.Views  5        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   �� 5      $t npack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Blue.xaml?�6%   �� 5      $u opack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Purple.xaml?�6%   %    5      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      6!   �� 5      $
��2.3* �6   6.   .+�5   
   � $��0��6    � RowDefinitions 5!      �� 5"      $
��1.6* �6    60   �� 5#      6"   .+�5&      � $��0��6   ���#ebebde 5(      �� 5)      $
��0.5* �6$   64   �� 5*      $
��1.5* �6$   64   �� 5+      $
��1.5* �6$   64   �� 5,      $
��1.5* �6$   64   �� 5-      $
��0.6* �6$   64   .+�50      �� $��23(�6   $��Center=�6*   
Eye Taxi6Q   � 52      $��1��6   .+�53      �� -   5        $��From_Textbox��53      $��18(�63   $	��220��6A   $��55��6M   $��Center=�54   "   
������ $��2q�56   "   $��Center=�66   $��SimSun)�57   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 From��58   #   
���   � !  MaterialDesignOutlinedTextBox#��[  5:   #   ��54   @   �� *From+.��5:   Z   5;      5=      � 5?      $��2��6   .+�5@      �� -   5        $��
To_Textbox��5@      $	��220��61   $��55��6=   $��2q�6I   
������ $��18(�5B   "   $��Center=�60   $��Center=�5D   "   
���   �$��SimSun)�5E   #   $ To��5F   #   #��[  5G   #   ��5B   M   �� *To+ �� UpdateSourceTrigger$ PropertyChanged=�.��5G   Z   5H      5J      � 5L      $��3��6   .+�5M      �� -   5        $��Price_Textbox��5M      $	��220��64   $��55��6@   $��2q�6L   
������ 
���   �$��18(�5O   "   $��Center=�60   $��Center=�5P   "   $��SimSun)�5Q   "   $ Price��5R   (   #��[  5S   #   ��5O   M   �� *Price+.��5S   Z   5T      5V      �� 5X      $��4��6   $"��Get Location WithDoubleClick��6(   $��Center=�6O   $��Center=�6j   $��15(�6�    d� 	IsChecked 5Y      �� *GetWithDoubleClick+6F   5Z      � 5\      $��1��6   ���#777764 5^      �� 5_      6&   �� 5`      6&   �� 5a      6&   �� 5b      6&   �� 5c      6&   �� 5d      6&   .+�5g      �� $��0��6   $��30��6&   $	��120��62   ���#4f4747$	��2.2q�6w   ���#ebebde
���   �   MaterialDesignOutlinedButton#��[ 5h   ,   ��5g   >   �� *Rotate_Command+.��5h   b   	Get Price5j      �� 5l      $��1��6   $��30��6&   $	��120��62   ���#ebebde���#4f4747$	��2.2q�6�   
���   ���6>   �� *Get_Taxi_Command+.��5m   -   
Get Taxi5o      �� 5p      $��2��6   $��30��6&   $	��120��62   ���#ebebde���#4f4747$	��2.2q�6�   
���   ���6>   �� *DeleteUser_Command+.��5q   -   Delete User5s      �� 5t      $��3��6   $��30��6&   $	��120��62   ���#ebebde���#4f4747$	��2.2q�6�   
���   ���6>   �� *History_Command+.��5u   -   	History5w      �� 5x      $��4��6   $��30��6&   $	��120��62   ���#ebebde���#4f4747$	��2.2q�6�   
���   ���6>   �� *Account_Command+.��5y   -   Change Info5{      �� 5|      $��5��6   $��30��6&   $	��120��62   ���#ebebde���#4f4747$	��2.2q�6�   
���   ���6>   �� *	Log_Out+.��5}   -   	Log out5      5�      5�      � 5�   
   $��1��6   .+�5�      '   !Microsoft.Maps.MapControl.WPF.Map  -   5        $��m��5�      +   %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProvider 6!   �� *
Provider+	   	ZoomLevel	 5�      �� *	zoomlevel+$ PropertyChanged=�
 �� Mode$
 TwoWay=�   Center 6h   �� *center+$ PropertyChanged=�$
 TwoWay=�   Children. 5�      3   -Microsoft.Maps.MapControl.WPF.MapItemsControl  ��6&   �� *Route+5�      +   %Microsoft.Maps.MapControl.WPF.Pushpin  5�      -   5        $��From_Pushpin��5�      y�62   �� *From_Pushpin_Visibility+   Location 5�      �� *From_Pushpin_Location+6K     5�      -   5        $��
To_Pushpin��5�      y�60   �� *To_Pushpin_Visibility+ 5�      �� *To_Pushpin_Location+6I   5�      5�      5�      5�      