   M S B A M L   `   `   `  ����L  HPersonalBankerWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PersonalBankerWPFPersonalBankerWPF  5      #    PersonalBankerWPF.OpenAccount   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:PersonalBankerWPF     5        N� Title$  OpenAccount��5	       � 	Resources 5
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
 �����6+   �� 5>       �@��TextAlignment$ Center=�68   �� 5?       � �� 5@      �� 5A      " ��6&   .R�5B      �� $ 3,3,3,3��6!   ���#F7B519���#ccc$��0,0,0,0q�6`   ._�5C      �� $ contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6  5D      5E      5G      5H      5I      .��5K      � -   5         �Name$ rootGrid��5K      $��
10,0,10,10q�6    � ColumnDefinitions 5L   
   �� 5M      $	��145 �6   �� 5N      $	��490 �6   �� 5O      $	��145 �6   �� 5P       � RowDefinitions 5R   
   �� 5S      �� 5T      $
��Auto �6   �� 5U      �� 5V      $
��Auto �6   ��5X   
   �� 5Y       �� ImageSource$ 	bgRed.png��6   .+�5\   
   �� $��1��6   $
��Left=�6$   $��
123,60,0,0q�6?   $
��Wrap=�6S   $2��,What Kind of Account would you like to open?��6g   $	��Top=�6�   �� 5^   
   -   5         ��Name$ InterestButton��5^      $��Interest��6*   $��1��6=   $
��Left=�6M   $��123,112,0,0q�6h   $	��Top=�6}   $��75��6�   6�   �� 5_   
   -   5         ��Name$ InterestOpenBlock��5_      $��1��6/   $
��Left=�6?   $��60,7,0,0q�6Z   $
��Wrap=�6l   $(��"How Much Would You Like To Deposit��6�   $y�hidden=�6�   $	��Top=�6�   $��2��6�   �� 5`   
   -   5         ��Name$ InterestOpenBox��5`      $��1��6+   $
��Left=�6;   $��23��6V   $��
123,28,0,0q�6b   $
 Wrap=�6v   $	��Top=�6�   $��75��6�   $y�hidden=�6�     TextBoxStyle2#���  6�   $��2��6�   �� 5a   
   -   5        $ InterestOpenButton��5a      $
��Open��6-   
��� ���$��1��6P   $
��Left=�6`   $��
123,80,0,0q�6{   $	��Top=�6�   $��75��6�   $y�hidden=�6�   $��2��6�   �� 5b   
   -   5        $ InterestNameBlock��5b      $��1��6/   $
��Left=�6?   $��
40,145,0,0q�6Z   $
��Wrap=�6n   $/��)What Would You Like To Name Your Account?��6�   $y�hidden=�6�   $	��Top=�6�   $	��244��6�   �� 5c   
   -   5        $ InterestNameBox��5c      $��1��6+   $
��Left=�6;   $��23��6V   $��123,166,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $��75��6�   $y�hidden=�6�   #���  6�   �� 5e   
   -   5        $ SavingsButton��5e      $��Savings��6(   $��1��6:   $
��Left=�6J   $��294,112,0,0q�6e   $	��Top=�6z   $��75��6�   6�   �� 5f   
   -	   5        $ SavingsOpenBlock��5f      $��1��6.   $
��Left=�6>   $��	235,7,0,0q�6Y   $
��Wrap=�6l   $(��"How Much Would You Like To Deposit��6�   $	��Top=�6�   $y�hidden=�6�   $��2��6�   �� 5g   
   -
   5        $ SavingsOpenBox��5g      $��1��6*   $
��Left=�6:   $��23��6U   $��
294,28,0,0q�6a   $
 Wrap=�6u   $	��Top=�6�   $��75��6�   $y�hidden=�6�   #���  6�   $��2��6�   �� 5h   
   -   5        $ SavingsOpenButton��5h      $
��Open��6,   $��1��6;   $
��Left=�6K   $��
294,80,0,0q�6f   $	��Top=�6z   $��75��6�   $y�hidden=�6�   $��2��6�   6�   �� 5i   
   -   5        $ SavingsNameBlock��5i      $��1��6.   $
��Left=�6>   $��211,145,0,0q�6Y   $
��Wrap=�6n   $/��)What Would You Like To Name Your Account?��6�   $y�hidden=�6�   $	��Top=�6�   $	��244��6�   �� 5j   
   -   5        $ SavingsNameBox��5j      $��1��6*   $
��Left=�6:   $��23��6U   $��294,166,0,0q�6a   $
 Wrap=�6v   $	��Top=�6�   $��75��6�   $y�hidden=�6�   #���  6�   5k      5l      