   M S B A M L   `   `   `  ����K  GCustomMessageBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CustomMessageBoxCustomMessageBox  5   	       CustomMessageBox.MsgBox   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CustomMessageBox     5   	     � AllowsTransparency  .  � WindowStyle$
 None=�5   4    � WindowStartupLocation$ CenterScreen=�6G   
������  � SizeToContent$ WidthAndHeight=�6�    � 	Resources 5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background	 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 CustomButtonStyle
 �� 
TargetType �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%X  &	        &	 �     &	 �     &	 �     &	     &	 2    &	 U    &	 x    &	 �    &		 �    &	
 �    7  7  7  7  7  7  7  7  7 	 �� 5	   
   .�5
      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $	 
WhiteSmoke��6;   �� 5   
   $
	 Gray��67   �� 5   
   $	 	#FFBEE6FD��6>   �� 5   
   $	 	#FF3C7FB1��6:   �� 5   
   $	 	#FFC4E5F6��6<   �� 5   
   $	 	#FF2C628B��68   �� 5   
   $	 	#FFF4F4F4��6=   �� 5   
   $	 	#FFADB2B5��69   �� 5   
   $	 	#FF838383��6=   �� 5   
   "
 ��6*   .�5      ��  �@�FocusVisualStyle 61   Z� �� 5       � ��8   6+   �� 5       � ��8  6,   �� 5       � ��# � ��6+   �� 5        � ��$ 1q�60   �� 5!       � ��$ Center=�6;   �� 5"       � ��$ Center=�69   �� 5#       � ��$ Center=�64   �� 5$       � ��$ Center=�62   �� 5%       � ��$ 25��6'   �� 5&       � ��$ 75��6&   �� 5'       � ��$ 10,15,10,15q�6'   �� 5(       � ��$ 12(�6)   �� 5)       � ��$ Verdana)�6+   �� 5*       � ��$ 1q�6(   �� 5+       � �� 5,      �� 5-      " ��6&   .R�5.      �� $ border��6!   $ 10��61   #��z��6C   #��z��6o   #��z��6�    . ._�5/      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  50       51      P� 52       �@��IsDefaulted . . �53   "   �� $ border��6@   # � ��6T    � ��54      P� 55       �@J�IsMouseOver . . �56   "   �� $ border��6?   8   � ��6S   �� 57   "   $ border��6@   8   � ��6T   58      P� 59       � �� . . �5:   "   �� $ border��6?   8   � ��6S   �� 5;   "   $ border��6@   8   � ��6T   5<      P� 5=       � {� .  . �5>   "   �� $ border��6?   8   � ��6S   �� 5?   "   $ border��6@   8   � ��6T   �� 5@   "   $ contentPresenter��6K   8   � ��6i   5A      5C      5E      5F      5G      .��5H      �� 
�������$
��Auto��6    $	��800��6.   $
��Auto��6>   $	��600��6K   $ 25��6Z   $��Center=�6l   $��Center=�6�   $��20,50,20,20q�6�    J� Effect 5I   
   3  -System.Windows.Media.Effects.DropShadowEffect  5J         
BlurRadius$ 30Q�6      ShadowDepth$ 0Q�6/      Color$
 Gray��6?      RenderingBias$ Quality=�6L   ._�5L   
   �  � RowDefinitions 5M      �� 5N      $
��Auto �6    �� 5O      $
��Auto �6    �� 5P      $
��Auto �6    �� 5Q      $
��Auto �6    .+�5S      �� -   5         ��Name$ 
Img_MsgBox��5S      $��80��6(   $	��150��64   $��	0,-40,0,0q�6@   �� 5T      -   5         ��Name$ Txt_Caption��5T      $��1��6-    �� TextAlignment$ Center=�6:   $��16(�6Q   $
��Bold"�6_   
�������$��Verdana)�6�   $��
20,20,20,0q�6�   �� 5U      -   5        $ Txt_Content��5U      $��2��6-   $ Justify=�6:   $��30,20,30,10q�6R    �� Padding$ 0q�6g   $��12(�6s   $��Verdana)�6�   $
��Wrap=�6�   � 5V      $��3��6   $��	15,0,15,5q�6     � ColumnDefinitions 5W      �� 5X      �� 5Y      $
��Auto �6'   �� 5Z      $
��Auto �6'   �� 5[      $
��Auto �6'   �� 5\      $
��Auto �6'   �� 5]      .+�5_      �� -   5         ��Name$ Btn_Ok��5_      $��Ok��6)   $��1��66   #��� 
 6F   6r   �� 5`      -   5        $ Btn_Yes��5`      $	��Yes��6*   $��2��68   #��� 
 6H   6t   �� 5a      -   5        $ Btn_No��5a      $��No��6)   $��3��66   #��� 
 6F   6r   �� 5b      -   5        $ 
Btn_Cancel��5b      $��Cancel��6-   $��4��6>   #��� 
 6N   6z   5c      5d      5e      5f      