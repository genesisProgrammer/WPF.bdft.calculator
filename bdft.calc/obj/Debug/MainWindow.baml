   M S B A M L   `   `   `  ����D  @bdft.calc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:bdft.calc	bdft.calc  5   	       bdft.calc.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:bdft.calc     5   	     � Title$  Board Foot Calculator��5   	   $��384.314��6'   $	��525��68   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ Species_ComboBox��5      $
��Left=�6-   $��	21,22,0,0q�6H   $	��Top=�6[   $	��143��6s    J� RenderTransformOrigin$ 1.048,0.473&�6    �� Text$ Choose Species��6�    �� 
IsEditable . ��. 4  .System.Windows.Automation.AutomationProperties   IsRequiredForForm . ��6�   Z� 6�   �� 5   
   -   5         ��Name$ cost_textBox��5      $
��Left=�6(   $��23��6C   $��	21,60,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $��Cost per bd/ft [0.00]��6v   $	��Top=�6�   $	��143��6�   $ 0.264,0.177&�6�   	 �� TextAlignment$	 Center=�6�   6  �� 5   
   -   5        $ length_textBox��5      $
��Left=�6*   $��23��6E   $��	21,96,0,0q�6Q   $
 Wrap=�6d   $��Board Length [Inches]��6x   $	��Top=�6�   $	��143��6�   $ 0.362,0.573&�6�   $	 Center=�6�   6  �� 5   
   -   5        $ width_textBox��5      $
��Left=�6)   $��23��6D   $��
21,135,0,0q�6P   $
 Wrap=�6d   $��Board Width [Inches]��6x   $	��Top=�6�   $	��143��6�   $ 
-0.315,1.3&�6�   $	 Center=�6�   6  �� 5   
   -   5        
 ��Name$
 
list_total��5      $
��Left=�6&   $	��178��6A   $��
192,22,0,0q�6N   $	��Top=�6b   $	��254��6z   �� 5   
   -   5        $��	Add_Board��5      $
��Left=�6%   $��
21,219,0,0q�6@   $	��Top=�6T   $	��120��6l   6x   �� 5   
   -   5        $ Board_Thickness��5      $
��Left=�6,   $��
21,178,0,0q�6G   $	��Top=�6[   $	��143��6s   $ -0.117,0&�6    . $ Board Thickness��6�    �� 
IsReadOnly .  . ��6�   Z� 6  5      5      