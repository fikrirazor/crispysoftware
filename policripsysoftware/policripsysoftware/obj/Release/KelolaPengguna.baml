   M S B A M L   `   `   `  ���� M  Ipolicripsysoftware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:policripsysoftwarepolicripsysoftware  '    !policripsysoftware.KelolaPengguna   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:policripsysoftware       � Title$	  kpw��$	��510��$��626.667��.��� 
���   �.+�]� $
��Left=�$��57��$	��Top=�$��618.667��.+��� $��Kelola Pengguna��$��Center=�$��Center=�$	��159��$
��0,10q�$��37��
�������$��20(��� $
��Left=�$��26��$	��Top=�$	��295��$��0,57,0,0q�.+��� $��Pasien��$��Center=�$	��Top=� J� RenderTransformOrigin$ 3.789,0.808&�$
��Bold"�
��������� $
��Left=�$��26��$	��Top=�$��323.667��$��
295,57,0,0q�.+��� $��Dokter��$��Center=�$	��Top=�$ 3.789,0.808&�$
��Bold"�
��������� $
��Left=�$	��216��$	��Top=�$	��162��$��0,83,0,0q�.+��� $��	No Pasien��$
��Left=�$	��Top=�$ -1.513,-1.462&�
�������$��	40,0,0,10q�$	��102��$��20��$��8(��� $��Nama Pasien��$
��Left=�$	��Top=�$ -1.513,-1.462&�
�������$��	40,0,0,10q�$	��102��$��20��$��8(��� $��Tanggal Lahir��$
��Left=�$	��Top=�$ -1.988,-3.462&�
�������$��	40,0,0,10q�$	��102��$��20��$��8(��� $��Jenis Kelamin��$
��Left=�$	��Top=�
�������$��	40,0,0,10q�$	��102��$��19��$ 0.467,0.143&�$��8(��� $��No Hp��$
��Left=�$	��Top=�
�������$��	40,0,0,10q�$	��102��$��20��$��8(��� $��Alamat��$
��Left=�$	��Top=�
�������$��	40,0,0,10q�$	��102��$��21��$��8(��� $��Dokter��$
��Left=�$	��Top=�
�������$��	40,0,0,10q�$	��102��$��20��$��8(��� $
��Left=�$	��216��$	��Top=�$	��152��$��
162,83,0,0q�.+��� -    ��Name$ nopasientxt��$
��Left=�$	��Top=�$	��102��$��	40,0,0,10q�$��20���� -    ��Name$ namatxt��$��21�� �� TextWrapping$
 Wrap=�$	��Top=�$	��102��$
��Left=�$��	40,0,0,10q�(  "System.Windows.Controls.DatePicker  -     Name$ tanggallahirtxt��$
��Left=�$	��Top=�$	��102��$��	40,0,0,10q�$��20���� -   $ Jenisklamintxt��$
��Left=�$	��Top=�$	��102��$��	40,0,0,10q�$��20��.@��� $
��Pria��$
��Left=�$	��118���� $��Wanita��$
��Left=�$	��118���� -   $ nohptxt��$
��Left=�$��20��$
 Wrap=�$	��Top=�$	��102��$��	40,0,0,10q��� -   $ 	alamattxt��$
��Left=�$��19��$
 Wrap=�$	��Top=�$	��102��$��	40,0,0,10q��� -   $ 	doktertxt��$
��Left=�$	��Top=�$	��102��$��	40,0,0,10q�$��21��&   System.Windows.Controls.DataGrid  -     Name$ datapasiengrid��$
��Left=�$	��109��$��
-3,304,0,0q�$	��Top=�$	��298���� -	    ��Name$ 
viewpasien��$
��View��$
��Left=�$��174,440,0,0q�$	��Top=�$��40���� -
   $ 	addpasien��$	��Add��$
��Left=�$��
14,440,0,0q�$	��Top=�$��41���� -   $ updatepasien��$��Update��$
��Left=�$��
98,440,0,0q�$	��Top=�$��41���� -   $ DeleteButtonPasien��$��Delete��$
��Left=�$��254,440,0,0q�$	��Top=�$��41��  -   $ datagriddokter��$	��109��$	��Top=�$��327.667,304,0,0q��� -   $ 
viewdokter��$
��View��$
��Left=�$��487.667,440,0,0q�$	��Top=�$��40���� -   $ 	adddokter��$	��Add��$
��Left=�$��327.667,440,0,0q�$	��Top=�$��41���� -   $ updatedokter��$��Update��$
��Left=�$��411.667,440,0,0q�$	��Top=�$��41���� -   $ deletedokter��$��Delete��$
��Left=�$��567.667,440,0,0q�$	��Top=�$��41��$ 
0.366,5.21&��� $
��Left=�$	��216��$	��Top=�$��138.667��$��
314,83,0,0q�.+��� $��	No Dokter��$
��Left=�$	��Top=�$ -1.513,-1.462&�
�������$��
40,0,-1,10q�$	��100��$��25���� $��Nama Dokter��$
��Left=�$	��Top=�$ -1.513,-1.462&�
�������$��
40,0,-1,10q�$	��100��$��25���� $��	Spesialis��$
��Left=�$	��Top=�$ -1.988,-3.462&�
�������$��
40,0,-1,10q�$	��100��$��25���� $
��Left=�$	��216��$	��Top=�$	��161��$��457.667,83,0,0q�.+��� -   $ nodoktertxt��$��
40,0,21,10q��� -   $ namadoktertxt��$��24��$
 Wrap=�$	��Top=�$	��100��$
��Left=�$��	40,0,0,10q��� -   $ spesialistxt��$
��Left=�$��24��$
 Wrap=�$	��Top=�$	��100��$��	40,0,0,10q�