   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom  5          Diplom.WorkerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Diplom     5      -   5          N� Title$  
WorkerPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��313* �6   �� 5      $
��137* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��DTGridClient��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6(      
IsReadOnly .    AutoGenerateColumns .  $��2��6f      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Логин��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Login+6P     5      $ Пароль��6%    65   �� *
Password+6T     5      $ Роль��6%    63   �� *	Role.Name+6S   5      �� 5   
   -   5         ��Name$ BtnBack��5   <   $��
Назад��6   $
��Left=�6!   $��
312,35,0,0q�6c   $��1��6w   $	��Top=�6�   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   $��55��6�   $	��165��6�   z�5      V� 5      .~�5      �� �� 5      �� 5      
 �� Angle$
 0.275Q�6&   T� 5      5      5!      5"      5#      