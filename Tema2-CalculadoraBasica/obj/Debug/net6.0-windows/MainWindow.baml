   M S B A M L   `   `   `  ����R  NTema2-CalculadoraBasica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Tema2_CalculadoraBasicaTema2_CalculadoraBasica  5   	   (    "Tema2_CalculadoraBasica.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Tema2_CalculadoraBasica     5   	     � Title$  Calculadora básica��5   	   $	��300��6$   $	��650��61   .��5	      � .+�5
   
   �� $
��Left=�5      $��	84,57,0,0q�5      $
��Wrap=�5      $��
Operando 1��5      $	��Top=�5      $��15(�5      �� 5   
   $
��Left=�5      $��	84,99,0,0q�5      $
��Wrap=�5      $��
Operando 2��5      $	��Top=�5      $��15(�5      �� 5   
   $
��Left=�5      $��
84,137,0,0q�5      $
��Wrap=�5      $��Operador��5      $	��Top=�5      $��15(�5       �� 5"   
   $
��Left=�5#      $��
84,174,0,0q�5$      $
��Wrap=�5%      $��	Resultado��5&      $	��Top=�5'      $��15(�5(      �� 5*   
   -   5         ��Name$ operando1TextBox��5*      $
��Left=�5+      $��
221,57,0,0q�5,       �� TextWrapping$
 Wrap=�5-      $�� ��5.      $	��Top=�5/      $	��120��50      $��15(�51      �� 53   
   -   5        $ operando2TextBox��53      $
��Left=�54      $��
221,97,0,0q�55      $
 Wrap=�56      $�� ��57      $	��Top=�58      $	��120��59      $��15(�5:      �� 5<   
   -   5        $ operadorTextBox��5<      $
��Left=�5=      $��221,137,0,0q�5>      $
 Wrap=�5?      $�� ��5@      $	��Top=�5A      $	��120��5B      $��15(�5C      6   �� 5E   
   -   5        $ resultadoTextBox��5E      $
��Left=�5F      $��221,172,0,0q�5G      $
 Wrap=�5H      $�� ��5I      $	��Top=�5J      $	��120��5K      $��15(�5L      �� 5N   
   -   5         ��Name$ calcularButton��5N      $��Calcular��5O      $
��Left=�5P      $��
488,57,0,0q�5Q      $	��Top=�5R      $��15(�5S      $��80��5T      6   �� 5V   
   -   5        $ limpiarButton��5V      $��Limpiar��5W      $
��Left=�5X      $��
488,96,0,0q�5Y      $	��Top=�5Z      $��15(�5[      $��80��5\      6   5^      5_      