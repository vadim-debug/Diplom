   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom  5          Diplom.MainTasks   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Diplom     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5          N� Title$  	MainTasks��5
       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $
��116* �6   �� 5      $
��253* �6   �� 5      $	��81* �6    � ColumnDefinitions 5   
   �� 5      $	��97* �6   �� 5      $
��500* �6   .+�5   
   �� $��1��6   $
��Left=�6$   $��
272,10,0,0q�6?   $
��Wrap=�6S   $��Секретарь��6g   $	��Top=�6x   $	��129��6�   $��24(�6�   $��50��6�   �� 5   
   $��/ico.png��6   6%   �� 5   
   $��0��6   $��1��6%   $��2��62   $��	0,0,670,0q�6F   $��2��6Y   .+�5      �� -   5         ��Name$ AllTask��5   *   $��Список дел��6   $	��110��6Q   $��Center=�6]   $
��0,10q�6z   $��40��6�   �� 5      -   5        $ btnTask1��5   '   $��Встреча��6   $	��110��6P   $��Center=�6\   $
��0,10q�6z   $��40��6�   �� 5      -   5        $ btnTask2��5   &   $��Звонок��6   $	��110��6O   $��Center=�6[   $
��0,10q�6x   $��40��6�   �� 5      -   5        $ btnTask3��5   (   $��Собрание��6   $	��110��6R   $��Center=�6^   $
��0,10q�6{   $��40��6�   �� 5      -   5        $ 	BtnWorker��5   S   $��Сотрудники��6   $	��110��6*   $��Center=�66   $	��Top=�6~   $
��0,10q�6�   $��40��6�   5      &   System.Windows.Controls.DataGrid  5!   
   -   5        $��DTGridClient��5!         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6(   $��1��68   $��1��6H      
IsReadOnly .    AutoGenerateColumns .  $��2��6�      Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Название��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 67   �� *Info+6R     5$      $	 Дата��6%   
 63   �� *Date+6N     5%      $	 Сотрудник��6%   
 68   �� *User.Password+6\     5&      $	 Приоритет��6%   
 68   �� *Priority.Name+6\     5'      $	 Тип задачи��6%   
 69   �� *TaskType.Name+6]   5,      �� 5-   
   -   5        $ 	BtnRemove��5-   !   $��1��6   $��Удалить��6L   $
��Left=�6^   $��
572,65,0,0q�6y   $	��Top=�6�   $��32��6�   $��84��6�   �� 5.   
   -	   5        $ BtnAdd��5.   !   $��1��6   $��Создать��6F   $
��Left=�6X   $��
428,66,0,0q�6s   $	��Top=�6�   $��32��6�   $��84��6�   �� 5/   
   -
   5         ��Name$ cmbPriority��5/   N   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Приоритет��6   $��1��6>    �� DisplayMemberPath$
 Name��6c   $
��Left=�6�   $��9,70,0,0q�6�   $	��Top=�6�   $	��120��6�   $��25��6�   �� 50   
   -   5         ��Name$ 	txtWorker��50   H   $ Дата��6   $��1��68   $
��Left=�6   $��
165,70,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��120��6�   $��25��6�   �� 51   
   -   5        $ BtnBack��51   !   $��1��6   $��
Назад��6I   $
��Left=�6Y   $��	524,0,0,0q�6t   $��2��6�   $��Center=�6�   $��39��6�   $��90��6�   54      55      