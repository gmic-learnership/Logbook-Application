   M S B A M L   `   `   `  ����P  LLogBookWPFApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:LogBookWPFApplicationLogBookWPFApplication  5   	   )    #LogBookWPFApplication.DailyRegister   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:LogBookWPFApplication     5   	     � 
ResizeMode$  CanMinimize=�5       � Title$ Daily Register��5   	   $	��440��6    $	��634��6-    � Icon$ /dvtIcon.ico��69   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF2B398B��6    � Offset$	 0.5Q�61   � 5      $ 	#FFFDBB30��6   $	 0.5Q�61   � 5      $ 	#FFFDBB30��6   $	 0.8Q�61   � 5      $ White��6   $	 0.8Q�6-   � 5      $ White��6   $	 0.2Q�6-   � 5      $ 	#FF2B398B��6   $	 0.2Q�61   5      .+�5   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ dprDate��5      $��Franklin Gothic Demi)�6&   $��16(�6H   $
��Left=�6V   $��
152,90,0,0q�6q   $	��Top=�6�   $	��150��6�   $��28��6�      SelectedDateFormat$ Short=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dgrdInformation��5      $
��Left=�6,   $��
318,90,0,0q�6G   
�������
���   �$	��Top=�6�   $	��222��6�   $	��290��6�   
   AutoGenerateColumns
 .  $��16(�6�   $��Franklin Gothic Demi)�6�      Columns 5      4  .System.Windows.Controls.DataGridComboBoxColumn  5      -   5        Name��,  &System.Windows.Controls.DataGridColumn   Header$
 Name��5   7      Width5  /System.Windows.Controls.DataGridLengthConverter$	 160 6E      SelectedValueBinding 6Q   �� *Name+ �� Mode$ TwoWay=�   DisplayMemberPath 5      �� *Name+0  *System.Windows.Controls.DataGridTextColumn  5      -   5        	Hours��$ Hours Worked��5   4   $	 117 6w   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   ��  �� Path$ Hours�$ TwoWay=�6w   5      �� 5   
   -   5         ��Name$ 	btnCancel��5      $��16(�6$   $��Franklin Gothic Demi)�62   $��Cancel��6T   ���#2b398b���	#FFE0E0E0$
��Left=�6�   $��318,344,0,0q�6�   $	��Top=�6�   $	��109��6�    J� RenderTransformOrigin$ 
1.867,0.95&�6�   $��35��6  6  �� 5   
   -   5        $ btnSave��5      $��16(�6"   $��Franklin Gothic Demi)�60   $
��Save��6R   ���#2b398b���	#FFE0E0E0$
��Left=�6�   $��491,344,0,0q�6�   $	��Top=�6�   $	��117��6�   $��35��6�   6�   �� 5   
   -   5         ��Name$ 
cmbMentors��5      $��Franklin Gothic Demi)�6'   
�������
���   �$
��Left=�6o   $��152,131,0,0q�6�   $	��Top=�6�   $	��150��6�   $��28��6�   $��16(�6�   �� 5    
   -   5         ��Name$ 	lblMentor��5       $��Franklin Gothic Demi)�6#   $��Mentor:��6E   
�������$
��Left=�6j   $��
10,131,0,0q�6�   $	��Top=�6�   $	��137��6�   $��16(�6�   �� 5!   
   -	   5        $ lblDate��5!      $��Franklin Gothic Demi)�6!   $��Date:��6C   
�������$
��Left=�6f   $��	10,90,0,0q�6�   $	��Top=�6�   $	��137��6�   $��16(�6�   �� 5"   
   -
   5        $ lblComments��5"      $��Franklin Gothic Demi)�6%   $��Trained On:��6G   
�������$
��Left=�6p   $��
10,232,0,0q�6�   $	��Top=�6�   $��91��6�   $��16(�6�   �� 5#   
   -   5         ��Name$ txtComments��5#      $��Franklin Gothic Demi)�6'   
���   �$
��Left=�6\   $��80��6w   $��106,232,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��196��6�   $��16(�6�   �� 5$   
   -   5         ��Name$ imgLogo��5$      $��Center=�6"   $��70��6?   $	��Top=�6K   $	��250��6c   $>��8/LogBookWPFApplication;component/Media/Pictures/logo.png��6o   $��180,10,159,0q�6�   �� 5%   
   -   5        $ label7��5%      
���   �$��Daily Register:��63   $
��Left=�6M   $��	10,20,0,0q�6h   $��Franklin Gothic Demi)�6{   $	��Top=�6�   $��24(�6�   $��39��6�   $	��216��6�   �� 5&   
   -   5        $ image��5&      $
��Left=�6   $��39��6:   $��
569,20,0,0q�6F   $	��Top=�6Z   $��39��6r   $ ��/Media/Pictures/Image3.png��6}   $ 0.5,0.5&�6�   z�5'      V� 5(      .~�5)      �� �� 5*      �� 5+       �� Angle$ 179.474Q�6&   T� 5,      5-      5/      50      51      