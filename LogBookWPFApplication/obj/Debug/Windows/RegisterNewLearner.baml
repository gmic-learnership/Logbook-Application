   M S B A M L   `   `   `  ����P  LLogBookWPFApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:LogBookWPFApplicationLogBookWPFApplication  5   	   .    (LogBookWPFApplication.RegisterNewLearner   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:LogBookWPFApplication     5   	   -   5          � 
ResizeMode$  CanMinimize=�5       � Title$ Personal information��5   	   $��492.737��6&   $��963.687��67   .��5	      � $��0,0,2,0q�6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$	 0.2Q�6-   � 5      $ 	#FF2B398B��6   $	 0.2Q�61   � 5      $ 	#FF2B398B��6   $	 0.5Q�61   � 5      $ 	#FFFDBB30��6   $	 0.8Q�61   � 5      $ White��6   $	 0.8Q�6-   � 5      $ 	#FFFDBB30��6   $	 0.5Q�61   5       � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgrdAllInfo��5      $��Franklin Gothic Demi)�6(   $��402,100,10,0q�6J   $	��Top=�6`   $	��256��6x   $��16(�6�   �� 5   
   -   5        	 ��Name$	 	btnUpdate��5      $��16(�6$   $��Franklin Gothic Demi)�62   ���#FFF���#2b398b$��Update Learner Info��6{   $
��Left=�6�   $��737,406,0,0q�6�   $	��Top=�6�   $	��207��6�   $��45��6�   6�   �� 5   
   -   5        $	 btnBack��5      $��16(�6"   ���#FFF���#2b398b$��Franklin Gothic Demi)�6W   $
��Back��6z   $
��Left=�6�   $��
10,406,0,0q�6�   $	��Top=�6�   $	��121��6�   $��45��6�   6�   �� 5   
   -   5        
 ��Name$
 txtName��5      $
��Left=�6#   $��Franklin Gothic Demi)�6>   $��28��6a   $��
155,97,0,0q�6m    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��223��6�   $��16(�6�   ��6�   �� *SelectedItem.Name+ �� ElementName$ dgrdAllInfo��6�   �� 5   
   -   5        $
 
txtSurname��5      $
��Left=�6&   $��Franklin Gothic Demi)�6A   $��28��6c   $��155,150,0,0q�6o   $
 Wrap=�6�   $	��Top=�6�   $	��223��6�   $��16(�6�   ��6�   �� *SelectedItem.Surname+$ dgrdAllInfo��6�   �� 5   
   -   5        $
 txtEmail��5      $
��Left=�6$   $��Franklin Gothic Demi)�6?   $��28��6a   $��155,204,0,0q�6m   $
 Wrap=�6�   $	��Top=�6�   $	��223��6�   $��16(�6�   ��6�   �� *SelectedItem.EmailAddress+$ dgrdAllInfo��6�   �� 5    
   -   5        $
 txtPassword��5       $
��Left=�6'   $��Franklin Gothic Demi)�6B   $��28��6d   $��155,257,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��223��6�   $��16(�6�   ��6�   �� *SelectedItem.Password+$ dgrdAllInfo��6�   �� 5!   
   -	   5         ��Name$ label��5!      $��16(�6   ���#FFF$��Name:��6?   $��Franklin Gothic Demi)�6O   $
��Left=�6q   $��	26,97,0,0q�6�   $	��Top=�6�   $��28��6�   $	��138��6�   �� 5"   
   -
   5        $ label1��5"      ���#FFF$��Surname:��62   $��Franklin Gothic Demi)�6E   $
��Left=�6g   $��
26,150,0,0q�6�   $	��Top=�6�   $��28��6�   $	��138��6�   $��16(�6�   �� 5#   
   -   5        $ label3��5#      ���#FFF$��Email Address:��62   $��Franklin Gothic Demi)�6K   $
��Left=�6m   $��
26,204,0,0q�6�   $	��Top=�6�   $��28��6�   $	��138��6�   $��16(�6�   �� 5$   
   -   5        $ label6��5$      ���#FFF$��Role:��62   $
��Left=�6B   $��
26,310,0,0q�6]   $��Franklin Gothic Demi)�6q   $	��Top=�6�   $��28��6�   $	��138��6�   $��16(�6�   �� 5%   
   -   5        $ label4��5%      ���#FFF$��	Password:��62   $
��Left=�6F   $��
26,257,0,0q�6a   $��Franklin Gothic Demi)�6u   $	��Top=�6�   $��28��6�   $	��138��6�   $��16(�6�   �� 5&   
   -   5        $ label7��5&      
���   �$��Learner Details:��63   $
��Left=�6N   $��	26,26,0,0q�6i   $��Franklin Gothic Demi)�6|   $	��Top=�6�   $��24(�6�   $��39��6�   $	��216��6�   �� 5'   
   -   5        $	 	btnDelete��5'      $��16(�6$   ���#FFF���#2b398b$��Delete Learner Info��6Y   $��Franklin Gothic Demi)�6w   $
��Left=�6�   $��525,406,0,0q�6�   $	��Top=�6�   $	��207��6�   $��45��6�   6�   �� 5(   
   -   5        $	 btnAdd��5(      $��16(�6!   ���#2b398b���#FFF$��Franklin Gothic Demi)�6V   $��Add Learner��6z   $
��Left=�6�   $��313,407,0,0q�6�   $	��Top=�6�   $	��207��6�   $��45��6�   6�   �� 5)   
   -   5         ��Name$ imgLogo��5)      $��Center=�6"   $��76��6?   $	��Top=�6K   $	��222��6c   $>��8/LogBookWPFApplication;component/Media/Pictures/logo.png��6o   $
��Fill=�6�   $��	10,10,0,0q�6�   �� 5*   
   -   5         ��Name$ cmbRole��5*      $
��Left=�6$   $��155,310,0,0q�6?   $	��Top=�6T   $	��223��6l   $��28��6x   $��Franklin Gothic Demi)�6�   $��16(�6�    �� Text 6�   �� *SelectedItem.Role+$ dgrdAllInfo����5+      �� 5,      $	 0,1&�6&   $	 0,0&�65   .��5-      � $ 	#FFF0F0F0��6#   $ 0Q�65   � 5.      $ White��6#   $ 1Q�61   5/      51      �� 52   
   -   5        $ image��52      $
��Left=�6   $��39��6:   $��
905,29,0,0q�6F   $	��Top=�6Z   $��39��6r   $ ��/Media/Pictures/Image3.png��6}    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�53      V� 54      .~�55      �� �� 56      �� 57       �� Angle$ 179.474Q�6&   T� 58      59      5;      5<      5=      