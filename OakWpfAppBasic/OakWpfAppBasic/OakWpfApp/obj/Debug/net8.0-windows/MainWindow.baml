   M S B A M L   `   `   `  ����D  @OakWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:OakWpfApp	OakWpfApp  5   	       OakWpfApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:OakWpfApp     5   	   -   5          �Name$  WinMain��5   	    � Title$ 	OakWpfApp��5   	   $	��432��6   $	��761��6(   .��5	      � -   5         �Name$ 	firstgrid��5	      $��0,0,0,-6q�6   ��5
   
   �� 5       �� Color$ 	#FFB4B4B4��6    � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ btnFirst��5      $��First Button��6#   $
��Left=�6:   $��310,302,0,0q�6U   $	��Top=�6j   $��20(�6�   $��66��6�   $	��220��6�   6�   �� 5   
   -   5         ��Name$ lblFirst��5      $��First Label��6"   $��
472,54,0,0q�68   $	��Top=�6L   $��66��6d   $	��253��6p   $��48(�6|   $��Times New Roman)�6�   ${�False��6�   $
��Left=�6�   �� 5   
   -   5         ��Name$ txtFirst��5      $
��Left=�6$    �� 	IsEnabled$
 True��6?   $��472,154,0,0q�6[   	 �� TextWrapping$
	 Wrap=�6p   $��Please enter value��6�   $	��Top=�6�   $	��231��6�   $��42��6�   $��18(�6�   
 �� AcceptsReturn$

 True��6�   6  �� 5   
   -   5        $ 	txtSecond��5      $
��Left=�6%   $��
195,54,0,0q�6@   $
	 Wrap=�6T   $	��Top=�6h   $	��253��6�   $��83��6�   $

 True��6�   �� 5   
   -   5         ��Name$ chkFirst��5      $��Remember Me��6%   $
��Left=�6;   $��432,251,0,0q�6V   $	��Top=�6k    J� RenderTransformOrigin$ 0.552,-11.892&�6�   �� 5   
   $#��Please select your age range.��6   $
��Left=�68   $��
56,282,0,0q�6S   $	��Top=�6g   	� 5   
   -   5         	�Name$ rbFirst��5       	� 	GroupName$	 Age��6'   $��18-30��67   $
��Left=�6G   $��
56,313,0,0q�6b   $	��Top=�6v    d� 	IsChecked$
 TrueY�6�   	� 5   
   -	   5        $ rbSecond��5      $	 Age��6(   $��31-45��68   $
��Left=�6H   $��
56,333,0,0q�6c   $	��Top=�6w   	� 5   
   -
   5        $ rbThird��5      $	 Age��6'   $��46-60��67   $
��Left=�6G   $��
56,353,0,0q�6b   $	��Top=�6v   �� 5   
   -   5         ��Name$ cmbFirst��5      $
��Left=�6%   $��585,240,0,0q�6@   $	��Top=�6U   $	��140��6m   5      �� 5   
   -   5         ��Name$ lbFirst��5      $��35,48,596,211q�6#    �� SelectionMode$ Multiple=�6:   ��5      �� 5      .R�5      �� .+�5      �� ��6$   �� *Name+5       5!      5#      �� 5$   
   -   5        $ 
btnListBox��5$      $��Selected Item��6%   $
��Left=�6=   $��
56,220,0,0q�6X   $	��Top=�6l   $ -3.318,0.596&�6�   $��30��6�   $��88��6�   6�   5%      5&      