   M S B A M L   `   `   `  ����J  FPasswordManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PasswordManagerPasswordManager  5   	        PasswordManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PasswordManager     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��600��6)   .��5	      �� .+�5
   
   �� $��20��6   $	��600��6   ���	#FFACACAC$��0,0,0,1q�6A   ._�5      ]� ���	#FFDDDDDD$��	0,0,0,0.2q�6/   .+�5      o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� -   5        $��_Exit��5   #   62   5      m� 5      $��_Help��6   .@�5      m� -   5        $��	_About...��5   #   66   5      5      5      5      �� 5   
   -   5        $��connectButton��5      $��80��6&   $��80��61    �� Left$ 35.73��5   -   
 �� Top$ 51.459��6A   
�������.��5      ��  �� Orientation$ Vertical=�6   .+�5      �� -   5        $��imageConnect��5      $��Images/imageConnect.png��5      $��40��66    �� BitmapScalingMode$ HighQuality=�5      �� 5      -   5        $��textblockConnect��5      	Connect6=   5       5!      �� 5"   
   -   5        $��insertButton��5"      $��80��6%   $��80��60   $ 157.459��5#   ,   $ 35.73��6A   
�������.��5%      �� $ Vertical=�6   .+�5&      �� $��Images/imageInsert.png��6   $��40��68   $ HighQuality=�5'      �� 5(      $��Center=�6   Insert6A   5)      5*      �� 5,   
   -   5         ��Name$ deleteButton��5,      $��80��6'   $��80��62   $ 265.459��5-   (   $ 35.73��6=   
�������.��5/      �� $ Vertical=�6   .+�50      �� $��Images/imageDelete.PNG��6   $��40��68   $ HighQuality=�51      �� 52      $��Center=�6   �� 6:   $�Delete��6>   6O   53      54      �� 56   
   -   5        $��listViewAccount��56      $	��400��6*   $	��352��66    �� SelectionMode$ Extended=�57      $	 152��60   $ 34.989��6B   $ �� IsSynchronizedWithCurrentItem$
 TrueY�58      $��Disabled=�59       �� View 5;      �� 5<      .P�5=      �� $	��STT��6%   	 �� Width$	 30��62   
 �� DisplayMemberBinding
 6=   �� *ID+�� 5>      $��	Email/SDT��6%   $		 170��68   
 6D   �� *Email+�� 5?      $��Password��6%   $		 120��67   
 6C   �� *Pass+�� 5@      $
��Type��6%   $	 80��63   
 6>   �� *Type+5B       � ContextMenu 5D      �� 5E      5I      5K      5M      5N      