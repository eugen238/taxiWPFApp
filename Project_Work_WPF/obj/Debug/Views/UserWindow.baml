   M S B A M L   `   `   `  ����K  GProject_Work_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Project_Work_WPF.ViewsProject_Work_WPF.Views  5   	   '    !Project_Work_WPF.Views.UserWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Project_Work_WPF.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   -   5          �Name$  UserWindow1��5	   	    � Title$ 
UserWindow��5
   	   $	��450��6   $	��426��6)    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   �� 5      $t npack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Blue.xaml?�6%   �� 5      $u opack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Purple.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5    
   �� $	��Top=�6   $��13, 13, 0, 0q�6)   $��40��5!      $
��Left=�6    
������ $��1q�5"      
���   ���6=   �� *Close_Command+��6_   ��  �� ElementName$ UserWindow1��.��5#      �� $��/Resources/Back Icon.png��6   $	��-20q�66   6E   5$      �� 5%   
   -   5         ��Name$ 	MyTextBox��5%      $��0��6&   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Login��5'      $��20(�6B    %  !MaterialDesignFloatingHintTextBox#��[  5(      $��Center=�5)      $	��150��68   ��5&      �� *Login+5)   8   �� 5*   
   -   5        $ 
MyTextBox1��5*      $��1��6'   $ Password��5,      $��20(�6E   #��[  5-      $��Center=�5.      $	��150��68   ��5+      �� *
Password+5.   8   �� 5/   
   -   5        $ 
MyTextBox2��5/      $��2��6'   $
 Name��51      $��20(�6A   #��[  52      $��Center=�53      $	��150��68   ��50      �� *Name+53   8   �� 54   
   -   5        $ 
MyTextBox3��54      $��3��6'   $ Surname��56      $��20(�6D   #��[  57      $��Center=�58      $	��150��68   ��55      �� *	Surname+58   8   �� 59   
   -   5        $ 
MyTextBox4��59      $��4��6'   $ Number��5;      $��20(�6C   #��[  5<      $��Center=�5=      $	��150��68   ��5:      �� *Number+5=   8   �� 5>   
   $��6��6   $
��Save��6   $��Center=�6-   $��Center=�5?      $��0, 10, 0, 0q�64   *  $Microsoft.Xaml.Behaviors.Interaction	   Triggers	 5B      +  %Microsoft.Xaml.Behaviors.EventTrigger  5C      
   	EventName$
 Click��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5D      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *Save_Command+  5E       6,   �� *Close_Command+   CommandParameter 6N   �� $ UserWindow1��5F      5H      5J      5K      