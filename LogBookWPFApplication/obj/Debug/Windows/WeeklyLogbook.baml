   M S B A M L   `   `   `  ����P  LLogBookWPFApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:LogBookWPFApplicationLogBookWPFApplication  5   	   )    #LogBookWPFApplication.WeeklyLogbook   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:LogBookWPFApplication     5   	     � Title$  Weekly Logbook��5   	   $	��450��6    $	��575��6-   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$	 0.2Q�6-   � 5      $ 	#FF2B398B��6   $	 0.2Q�61   � 5      $ 	#FF2B398B��6   $	 0.5Q�61   � 5      $ 	#FFFDBB30��6   $	 0.5Q�61   � 5      $ 	#FFFDBB30��6   $	 0.8Q�61   � 5      $ White��6   $	 0.8Q�6-   5      .+�5   
   �� $��320,360,14,10q�6   .+�5      �� -   5         ��Name$ btnCreateNewLogbook��5      ���#2b398b���	#FFE0E0E0$��16(�6`   $��Franklin Gothic Demi)�6n   $��Create New Logbook��6�   $
��Left=�6�   $	��Top=�6�   $	��150��6�   $��35��6�    �� Left$ 80��6�   �� 5      -   5        $ 	btnCancel��5      ���#2b398b���	#FFE0E0E0$��16(�6V   $��Franklin Gothic Demi)�6d   $��Cancel��6�   $
��Left=�6�   $	��Top=�6�   $��75��6�   $��35��6�   6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6&   $��147,116,0,0q�6A   $	��Top=�6V   $	��207��6n   $	��406��6{      Columns 5      4  .System.Windows.Controls.DataGridComboBoxColumn  5      -   5        Date��,  &System.Windows.Controls.DataGridColumn	   Header$
	 Date��5   7   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 Auto 6E      SelectedValueBinding 6R   �� *Name+ �� Mode$ TwoWay=�   DisplayMemberPath 5   	   �� *Name+0  *System.Windows.Controls.DataGridTextColumn  5      -   5        	Tasks��$	 Task Discription��5   4   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6N   �� *Hours+  5      -   5        TimeWorkedInHours��$	 Hours��5   D   $

 Auto 6S    6`   �� *Name+$ TwoWay=� 5   	   �� *Name+  5      -   5        
Compitency��$	 	Compitent��5   9    6L   �� *Hours+  5       -   5        Comments��$	 Comments��5    7    6I   �� *Hours+  5!      -	   5        Sign��$	 	Signature��5!   3    6F   �� *Hours+5#      �� 5$   
   -
   5         ��Name$ MonthOfLogbook��5$      $��Franklin Gothic Demi)�6(   $$��Logbook For: Month/PlaceHolder��6J   $
��Left=�6s   
�������$��16(�6�   $��
313,88,0,0q�6�   $	��Top=�6�   �� 5%   
   -   5         ��Name$ cmbMonth��5%      $
��Left=�6%   $	��Top=�6@   $	��110��6X   $��40��6e   $��
10,121,0,0q�6q    �� DisplayMemberPath 6�   �� *Name+�� 5&   
   -   5        $ lblPickAMonth��5&      $��Franklin Gothic Demi)�6'   $��Pick a Month:��6I   
�������$
��Left=�6t   $��	10,88,0,0q�6�   $	��Top=�6�   $	��110��6�   $��16(�6�   �� 5'   
   -   5         ��Name$ imgLogo��5'      $��Center=�6"   $��75��6?   $	��Top=�6K   $	��206��6c   $>��8/LogBookWPFApplication;component/Media/Pictures/logo.png��6o   $
��Fill=�6�   $��184,0,177,0q�6�   �� 5(   
   -   5         ��Name$ 
textBlock1��5(      $
��Left=�69   $��
359,78,0,0q�6T   $
��Wrap=�6h   $	��Top=�6|   ��6(   �� 6|   5*      5+      