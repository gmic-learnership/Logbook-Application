   M S B A M L   `   `   `  ����P  LLogBookWPFApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:LogBookWPFApplicationLogBookWPFApplication  5   	   %    LogBookWPFApplication.LoginPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:LogBookWPFApplication     5   	   -   5          � 
ResizeMode$  CanMinimize=�5       � Title$ 
Login Page��5   	   $��241.666��6   $��431.25��6-    � Icon$ /dvtIcon.ico��6U   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF2B398B��6    � Offset$	 0.5Q�61   � 5      $ 	#FFFDBB30��6   $	 0.5Q�61   � 5      $ White��6   $	 0.2Q�6-   � 5      $ 	#FF2B398B��6   $	 0.2Q�61   � 5      $ 	#FFFDBB30��6   $	 0.8Q�61   � 5      $ White��6   $	 0.8Q�6-   5       � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ btnLogin��5      $��Log in��6#   ���	#FFE0E0E0���#2b398b$
��Left=�6a   $��151,175,0,0q�6|   $	��Top=�6�   $	��120��6�   $��26��6�   $��Franklin Gothic Demi)�6�   $��16(�6�   �� 5   
   -   5        	 ��Name$	 imgLogo��5      $��Center=�6"   $��43��6?   $	��Top=�6K   $	��141��6c   $>��8/LogBookWPFApplication;component/Media/Pictures/logo.png��6o   $��Uniform=�6�   $��152,0,132,0q�6�   �� 5   
   $��66,62,72,121q�6   .+�5      �� -   5        
 ��Name$
 lblUsername��5      $��	Username:��6)   ���	#FFE0E0E0$
��Left=�6U   $	��Top=�6p   $��Franklin Gothic Demi)�6�   $��16(�6�   �� 5      -   5         ��Name$ txtUserName��5      $��Center=�6,   $��Center=�6I   $��28��6d    �� TextWrapping$
 Wrap=�6p   $�� ��6�   $	��200��6�   $��Franklin Gothic Demi)�6�    �� Left$ 85��6�   $��16(�6�   5      �� 5   
   $��69,126,72,57q�6   .+�5      �� -   5        $
 lblPassword��5      $��	Password:��6)   ���	#FFE0E0E0$
��Left=�6T   $	��Top=�6o   $��Franklin Gothic Demi)�6�   $��16(�6�   G� 5      -   5         G�Name$ txtPassword��5      $
��Left=�6/   $��28��6J   $	��Top=�6W   $	��200��6o   $��Franklin Gothic Demi)�6{   $ 82��6�   $��16(�6�   5       5!      5"      