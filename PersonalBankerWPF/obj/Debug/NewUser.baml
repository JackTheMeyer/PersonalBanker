   M S B A M L   `   `   `  ����L  HPersonalBankerWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PersonalBankerWPFPersonalBankerWPF  5          PersonalBankerWPF.NewUser   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:PersonalBankerWPF     5        N� Title$   Personal Banker - New User��5	       � 	Resources 5
         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyle1 �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType �� TextWrapping �� TextAlignment	 �� Triggers
 P� Property P� Value �� Triggers ]� 
Conditions �� Property �� Value  TabButtonFirst �� CornerRadius ��Name��%�  &	        &	 #     &	 F     &	 i     7   &	 {    '��     �� 5   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   " ��6&   .�5      ��  � ��# � ��6+   �� 5       � ��8   6,   �� 5       � ��# � ��6+   �� 5       � ��$ 1q�60   �� 5       �@ TabNavigation$
 None=�6A   �� 5       � ��$
 Left=�6;   �� 5       �@�FocusVisualStyle 61   Z� �� 5       �@J�	AllowDrop . 6*   �� 5       �@��PanningMode$ VerticalFirst=�69   �� 5       �@��IsFlicksEnabled .  67   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $
��Left=�6"   $��23��6=   $
 Wrap=�6I   $��TextBox��6]   $	��Top=�6l   $	��120��6�   $ Center=�6�   	 5      P� 5      
 � {� .  6;   P� 5      
 �@J�IsMouseOver . 6=   P� 5       
 �@J�IsKeyboardFocused . 6C   5"      5$       5%      ]� 5&       5'      �� 5(      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5)       �@��IsSelectionActive .  6A   ./�5+      ��  �@��SelectionBrush# � /�67   5,      5.      �� 5/   
   " ��6   .�50      ��  � ��
 �����6+   �� 51       �@��TextAlignment$ Center=�68   �� 52       � �� 53      �� 54      " ��6&   .R�55      �� $ 3,0,0,0��6!   
����������#ccc$��0,1,1,0q�6^   ._�56      �� $ contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6  57      58      5:      5;      �� 5<   
   " ��6   .�5=      ��  � ��
 �����6+   �� 5>       �@��TextAlignment$ Center=�68   �� 5?       � �� 5@      �� 5A      " ��6&   .R�5B      �� $ 3,3,3,3��6!   ���#F7B519���#ccc$��0,0,0,0q�6`   ._�5C      �� $ contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6  5D      5E      5G      5H      5I      .��5K      � $��
10,0,10,10q�6    � ColumnDefinitions 5L   
   �� 5M      $	��145 �6   �� 5N      $	��490 �6   �� 5O      $	��145 �6   �� 5P       � RowDefinitions 5R   
   �� 5S      �� 5T      $
��Auto �6   �� 5U      �� 5V      $
��Auto �6   .+�5X   
   �� -   5        $��Create User��5X      $��1��6'   $
��Left=�67   $��
200,85,0,0q�6R   $	��Top=�6f   $��75��6~    J� RenderTransformOrigin$ -1.102,4.13&�6�   $��2��6�   6�   �� 5Y   
   -   5         ��Name$ UsernameTextBox��5Y      $��1��6+   $
��Left=�6;   $��23��6V   $��181,104,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $	��120��6�     TextBoxStyle2#���  6�   �� 5Z   
   -   5        $ PasswordTextBox��5Z      $��1��6+   $
��Left=�6;   $��23��6V   $��181,164,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $	��120��6�   #���  6�   �� 5[   
   -   5         ��Name$ PasswordTextBlock��5[      $��1��6/   $
��Left=�6?   $��190,143,0,0q�6Z   $
��Wrap=�6o   $��Choose a Password��6�   $	��Top=�6�   �� 5\   
   -   5        $ UsernameTextBlock��5\      $��1��6/   $
��Left=�6?   $��212.2,83,0,0q�6Z   $
��Wrap=�6p   $��Username��6�   $	��Top=�6�   ��5]   
   �� 5^       �� ImageSource$ 	bgRed.png��6   5`      5a      