   M S B A M L   `   `   `  ����K  GProject_Work_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Project_Work_WPF.ViewsProject_Work_WPF.Views  5   	   -    'Project_Work_WPF.Views.Completed_Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc4wpfanimated"http://wpfanimatedgif.codeplex.com  5   	   0local$clr-namespace:Project_Work_WPF.Views  5   	   $	��150��5	   	   $	��170��6     � WindowStyle$  
ToolWindow=�6"   '  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome .    WindowChrome 5        5   
      CaptionHeight$ 34Q�6    � 	Resources 5         CaptionButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType	 �Name
 ��Name �� ClearTypeHint&   System.Windows.Media.TextOptions   TextRenderingMode   TextFormattingMode �� Triggers P� Property P� Value �� 
TargetName  CloseButtonStyle �� BasedOn�� 5   
   %�  &	        &	 G    7   �� 5      " ��6/   .�5      ��  � �� 5      �� 5      " ��6*   .R�5      � $	 
LayoutRoot��6#   
������ $��44��6P   $��25��6[   .+�5   "   �� $	
 txt��6,   #��z��69   $��Segoe MDL2 Assets)�6Z   $��10(�6y   
�������$��Center=�5   7   $��Center=�6T   $
 Auto=�5   $   $ Aliased=�6G   $ Display=�6p   5       5       P� 5!   "    �@J�IsMouseOver . . �5"   &   �� $ 
LayoutRoot��6-    � �� �#E5E5E56[   �� 5#   &   $	 txt��6-    � �� �#0000006T   5$   #   5'      5)      5*      �� 5-      " ��6-   8   .�5.      ��  � ��$	 ��6,   5/      51       J� CommandBindings 55      )  #System.Windows.Input.CommandBinding  56   
   -   5        #  System.Windows.SystemCommands   CloseWindowCommand   Command# Z 56      6w   .��59      �� ._�5:   
   � ���#003241 � RowDefinitions 5;      �� 5<      $
��Auto �6    �� 5=      $��* �6    .+�5A      � $��0��6   $��25��6     K� ZIndex$ 1��6,   .+�5B      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�66   $��Center=�6Q   5C      �� 5F      $ 
Horizontal=�6   $��Right=�66   .+�5G      �� #��[ 6    .  � ToolTip$ Close��6t   #��Z 5H      5I      5J      � 5M      -   5        $	 AppArea��5M       $��1��6   .+�5N      � .+�5O      �� "  WpfAnimatedGif.ImageBehavior   AnimatedSource$/ )pack://application:,,,/Resources/Mark.gif��6      RepeatBehavior$ 3��5P         AnimateInDesignMode .     	AutoStart . $��0,-30,0,-30q�5R   ;   5T      5U      5W      5X      5Y      