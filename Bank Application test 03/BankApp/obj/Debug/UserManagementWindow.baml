   M S B A M L   `   `   `  ����B  >BankApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BankAppBankApp  5   	   "    BankApp.UserManagementWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:BankApp     5   	     � Title$  UserManagementWindow��5   	   $	��650��6&   $
��1000��63   .��5	      � ���	#FFF6ECEC.+�5
   
   ��  �� Orientation$ 
Horizontal=�6   $��40��6.   $	��Top=�6:   .+�5      �� -   5        $��   Home Page    ��5      $��0,0,0,0q�60   ���	#FF0DAB8C���	#FF0D0C2B$
��Bold"�6�   $��18(�6�   $	��181��6�   �� 5      -   5        $��    User Managemnet     ��5      $��5,0,0,0q�68   ���	#FF0DAB8C���	#FF0D0C2B$
��Bold"�6�   $��18(�6�   $	��272��6�   �� 5      -   5        $��   Account Management   ��5      $��5,0,0,0q�68   ���	#FF0DAB8C���	#FF0D0C2B$
��Bold"�6�   $��18(�6�   $	��275��6�   �� 5      -   5        $��Transaction Management��5      $��5,0,0,0q�66   ���	#FF0D0C2B���	#FF110202���	#FF0DAB8C$
��Bold"�6�   $��18(�6�   $	��251��6�   5       � 5   
   -   5          �Name$ MainAccountFrame��5      $��0,46,-0.4,0q�6*     � NavigationUIVisibility$ Hidden=�6?    � 5   
   -   5        $ 	UserFrame��5      $��
150,46,0,0q�6#   $ Hidden=�67   ��6W   Z� ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ 	#FFA7E414��6#   $ 1Q�65   � 5      $ 	#FF78A30E��6#   $ 0.719Q�65   � 5      $ 	#FF7BA80E��6#   $ 0.742Q�65   � 5      $ 	#FF506D09��6#   $ 0.481Q�65   5      5      �� 5   
   -   5        $��Create New User��5      $
��Left=�6+   $��	15,60,0,0q�6F   $	��Top=�6Y   $	��110��6q   $��30��6}   ���	#FFF4EEEE6�   �� 5    
   -   5        $��	All Users��5       $
��Left=�6%   $��
15,110,0,0q�6@   $	��Top=�6T   $	��110��6l   $��30��6x   ���	#FFF4ECEC6�   �� 5!   
   -	   5        $��Select Account��5!      $
��Left=�6*   $��
15,160,0,0q�6E   $	��Top=�6Y   $	��110��6q   $��30��6}   ���	#FFF7F4F46�   �� 5"   
   -
   5        $��Set User Name��5"      $
��Left=�6)   $��
15,210,0,0q�6D   $	��Top=�6X   $	��110��6p   $��30��6|   ���	#FFF7F1F16�   �� 5#   
   -   5        $��Get User Name��5#      $
��Left=�6)   $��
15,260,0,0q�6D   $	��Top=�6X   $	��110��6p   $��30��6|   ���	#FFF4ECEC6�   5&      5'      