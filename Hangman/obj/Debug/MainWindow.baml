   M S B A M L   `   `   `  ����B  >Hangman, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HangmanHangman  5   	       Hangman.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Hangman     5   	   -   5          �Name$  	main_menu��5   	    � Title$ 
MainWindow��5   	   $��551.144��6   $��474.648��6-    � WindowStartupLocation$ CenterScreen=�6=   ���	#FFDA6A6A��5	      �� 5
   
    j� Stretch$ UniformToFill=�6    �� ImageSource$&  Resources/paper_grid_PNG5405.png��6-   .��5      �  � ColumnDefinitions 5   
   �� 5      $��7* �6   �� 5      $
��100* �6   �� 5      $
��360* �6   .+�5   
   �� $��HangMan��6   $
��Left=�6"   $��71.437,18,0,0q�6=   $	��Top=�6T    J� RenderTransformOrigin$ 0.28,-1.531&�6l   $��60(�6�   $��Snap ITC)�6�   $��2��6�   $��1��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 Black��6#   
 � Offset$
 0Q�61   � 5      $	 	#FF5D89FF��6#   $
 1Q�65   5      5      �� 5   
   $��Choose a category:��6   $
��Left=�6-   $��
54,111,0,0q�6H   $	��Top=�6\   $
��Bold"�6t   $��15(�6�   $��Segoe Print)�6�   $��2��6�   �� 5    
   -   5         ��Name$ 	btn_sport��5       $��Sport��6$   $
��Left=�64   $��
70,151,0,0q�6O   $	��Top=�6c   $	��120��6{   $��28��6�   $ 0.514,2.046&�6�   $��Segoe Script)�6�   $��18(�6�   $��2��6�   6�   �� 5!   
   -   5        $ btn_anim��5!      $��Animals��6#   $
��Left=�65   $��
70,210,0,0q�6P   $	��Top=�6d   $	��120��6|   $��28��6�   $ 0.514,2.046&�6�   $��Segoe Script)�6�   $��18(�6�   $��2��6�   6�   �� 5"   
   -   5        $ btn_food��5"      $
��Food��6#   $
��Left=�62   $��
70,271,0,0q�6M   $	��Top=�6a   $	��120��6y   $��28��6�   $ 0.514,2.046&�6�   $��Segoe Script)�6�   $��18(�6�   $��2��6�   6�   �� 5#   
   -   5        $ btn_cont��5#      $��Сountry��6#   $
��Left=�65   $��
70,329,0,0q�6P   $	��Top=�6d   $	��120��6|   $��28��6�   $ 0.514,2.046&�6�   $��Segoe Script)�6�   $��18(�6�   $��2��6�   6�   �� 5$   
   $��level of difficulty:��6   $
��Left=�6/   $��
65,372,0,0q�6J   $	��Top=�6^   $
��Bold"�6v   $��15(�6�   $��Segoe Print)�6�   $��2��6�   	� 5%   
   -   5         	�Name$ rad_easy��5%      $
��Easy��6(   $��2��67   $
��Left=�6G   $��
67,413,0,0q�6b   $	��Top=�6v   $��Segoe Print)�6�    d� 	IsChecked$
 TrueY�6�   6�   	� 5&   
   -   5        $ rad_hard��5&      $
��Hard��6(   $��2��67   $
��Left=�6G   $��144,414,0,0q�6b   $	��Top=�6w   $��Segoe Print)�6�   6�   5(      5)      