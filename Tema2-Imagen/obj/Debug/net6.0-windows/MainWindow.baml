   M S B A M L   `   `   `  ����G  CTema2-Imagen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Tema2_ImagenTema2_Imagen  5   	       Tema2_Imagen.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Tema2_Imagen     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ imagen��5
      $
��Left=�5      $	��376��5      $��	30,28,0,0q�5      $	��Top=�5      $	��400��5      $��/episodioIV.jpg��5      �� 5   
   -   5         ��Name$ opacidadTextBlock��5      $
��Left=�5      $��
483,28,0,0q�5      $
��Wrap=�5      $��Opacidad��5      $	��Top=�5       J� RenderTransformOrigin$ -0.645,-0.159&�5      $��25��5      $��85��6   $��15(�6$   	� 5   
   -   5         	�Name$ opacidadAltaRadioButton��5       	� 	GroupName$ Opacidad��5      $
��Alta��5      $
��Left=�5      $��
483,58,0,0q�5      $	��Top=�5        d� 	IsChecked$
 TrueY�5!      5"      	� 5$   
   -   5        $ opacidadMediaRadioButton��5$      $ Opacidad��5%      $��Media��5&      $
��Left=�5'      $��
483,78,0,0q�5(      $	��Top=�5)      5*      	� 5,   
   -   5        $ opacidadBajaRadioButton��5,      $ Opacidad��5-      $
��Baja��5.      $
��Left=�5/      $��
483,98,0,0q�50      $	��Top=�51      52      �� 54   
   -   5        $ Ajuste��55      $
��Left=�56      $��483,201,0,0q�57      $
��Wrap=�58      $��Ajuste��59      $	��Top=�5:      $��25��5;      $��85��5<      $��15(�5=      	� 5?   
   -   5        $ rellenoRadioButton��5?      $ Ajuste��5@      $��Relleno (Fill)��5A      $
��Left=�5B      $��483,231,0,0q�5C      $	��Top=�5D      $
 TrueY�5E      6   	� 5G   
   -   5        $ uniformeRadioButton��5G      $ Ajuste��5H      $��Uniforme (Uniform)��5I      $
��Left=�5J      $��483,251,0,0q�5K      $	��Top=�5L      5M      	� 5O   
   -	   5        $  rellenoUniformeRadioButton��5O      $ Ajuste��5P      $&�� Relleno uniforme (UniformToFill)��5Q      $
��Left=�5R      $��483,271,0,0q�5S      $	��Top=�5T      5U      	� 5W   
   -
   5        $ sinAjusteRadioButton��5W      $ Ajuste��5X      $��Sin ajuste (None)��5Y      $
��Left=�5Z      $��483,291,0,0q�5[      $	��Top=�5\      6%   5^      5_      