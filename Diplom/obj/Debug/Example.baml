   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom  5          Diplom.Example   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Diplom     5      -   5          N� Title$  Example��5	       N� 
Background
 �����.��5      � 
������� � RowDefinitions 5   
   �� 5      $
��299* �6   �� 5      $
��151* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��DTGridClient��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6(      
IsReadOnly .    AutoGenerateColumns .  $��2��6f      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Info+6R     5      $ Дата��6%    63   �� *Date+6N     5      $ Сотрудник��6%    68   �� *User.Password+6\     5      $ Приоритет��6%    68   �� *Priority.Name+6\     5      $ Тип задачи��6%    69   �� *TaskType.Name+6]   4  .System.Windows.Controls.DataGridTemplateColumn  5      	   Width$
	 auto 6)   
   CellTemplate
 5      �� 5      .R�5      �� $��BtnEdit��6=   -   5        $ ��Редактировать��5   %   6d   5      5      5"      �� 5#   
   -   5         ��Name$ Btn_Add��5#   "   $��Button��6   $��Center=�6I   $��0,53,0,0q�6f   $��1��6x   $	��Top=�6�   $��35��6�   $	��168��6�   5%      5&      