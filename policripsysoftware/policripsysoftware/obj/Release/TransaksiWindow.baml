   M S B A M L   `   `   `  ���� M  Ipolicripsysoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:policripsysoftwarepolicripsysoftware  (    "policripsysoftware.TransaksiWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:policripsysoftware       � Title$	  plw��$	��505��$��626.667�� � WindowStyle$
 None=�.��� 
���   �.+�]� $
��Left=�$��57��$	��Top=�$��618.667��.+��� $��	Transaksi��$��Center=�$��Center=�$��89��$
��0,10q�$��37��
�������$��20(��� $
��Left=�$	��255��$	��Top=�$	��213��$��0,62,0,0q�.+��� $��Pasien��$
��Left=�$	��Top=� J� RenderTransformOrigin$ -1.513,-1.462&�
�������$��	40,0,0,10q�$��16(�$	��150��$��35���� $��Harga Periksa��$
��Left=�$	��Top=�
�������$��	40,0,0,10q�$��16(�$	��150��$��35���� $��Tanggal Transaksi��$
��Left=�$	��Top=�$ -1.988,-3.462&�
�������$��	40,0,0,10q�$��16(�$	��150��$��35���� $��Riwayat��$
��Left=�$	��Top=�
�������$��	40,0,0,10q�$��16(�$	��150��$��35���� $��213,62,0,180q� �� Orientation$ Vertical=�.+��� -    ��Name$ 	pasientxt��$
��Left=�$	��Top=�$	��180��$��	40,0,0,10q�$��35���� -    ��Name$ hargatxt��$
��Left=�$��35�� �� TextWrapping$
 Wrap=�$	��Top=�$	��180��$��	40,0,0,10q�(  "System.Windows.Controls.DatePicker  -     Name$ tanggaltransaksitxt��$
��Left=�$	��Top=�$	��180��$��	40,0,0,10q�$��35���� -    ��Name$ 
Riwayattxt��$��93��$��	40,0,22,0q�. �/� �� $
��Left=�$��86��$��0,317,-0.333,0q�$	��Top=�$	��619��.+�&   System.Windows.Controls.DataGrid  -   	  Name$	 transaksidata��$��85��$
��10,0q�]� $
��Left=�$��89����.  $	��Top=�$��618.667��$��	0,408,0,0q�.+��� -   
 ��Name$
 Input_Transaksi��$��Input Transaksi��$��Center=�$	��263��$��20,0,0,0q�
�������
���   �$��22(�$
��Bold"�$��Center=��� -   $

 view��$��View Transaksi��$	��263��$��20,0,0,0q�
�������
���   �$��22(�$
��Bold"�$��Center=�$��Center=�