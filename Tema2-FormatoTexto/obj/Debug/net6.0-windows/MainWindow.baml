   M S B A M L   `   `   `  ����M  ITema2-FormatoTexto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Tema2_FormatoTextoTema2_FormatoTexto  5   	   #    Tema2_FormatoTexto.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Tema2_FormatoTexto     5   	     � Title$  Formato de texto��5   	   $	��250��6"   $	��620��6/   .��5	      � .+�5
   
   �� -   5         ��Name$ textoTextBox��5
      $
��Left=�5      $��	30,45,0,0q�5       �� TextWrapping$
 Wrap=�5      $�� ��5      $	��Top=�5      $��60��5      $	��150��5      6   �� 5   
   $
��Left=�5      $��	30,25,0,0q�5      $
��Wrap=�5      $��Texto��5      $	��Top=�5      $��20��5      $��15(�6   �� 5   
   -   5         ��Name$ negritaCheckBox��5      $��Negrita��5      $
��Left=�5      $��
220,45,0,0q�5      $	��Top=�5      $��15(�5       $��75��5!      $
��Bold"�5"      5#      �� 5%   
   -   5        $ cursivaCheckBox��5%      $��Cursiva��5&      $
��Left=�5'      $��
315,45,0,0q�5(      $	��Top=�5)      $��15(�5*      $��75��5+      $��Italic$�5,      5-      �� 5/   
   $
��Left=�50      $��
410,60,0,0q�51      $
��Wrap=�52      $��Color del texto��53      $	��Top=�54      $��15(�55      $	��105��56      	� 58   
   -   5         	�Name$ rojoRadioButton��58       	� 	GroupName$ Colores��59      $
��Rojo��5:      $
��Left=�5;      $��
525,65,0,0q�5<      $	��Top=�5=      6%   	� 5?   
   -   5        $ azulRadioButton��5?      $ Colores��5@      $
��Azul��5A      $
��Left=�5B      $��
525,45,0,0q�5C      $	��Top=�5D       d� 	IsChecked$
 TrueY�5E      6   	� 5G   
   -   5        $ verdeRadioButton��5G      $ Colores��5H      $��Verde��5I      $
��Left=�5J      $��
525,85,0,0q�5K      $	��Top=�5L      6%   �� 5N   
   -   5         ��Name$  textoTransformadoTextBlock��5N      $��Center=�5O      $��	0,142,0,0q�5P      $
��Wrap=�5Q      $�� ��5R      $	��Top=�5S      $��60��5T      $	��560��6    �� TextAlignment$ Center=�5U      ���	#FFF7E48A5V      5X      5Y      