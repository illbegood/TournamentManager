   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5   	   L HTournamentManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TournamentManagerTournamentManager 5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	   "   TournamentManager.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	   1localclr-namespace:TournamentManager     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	   -   5          � Title$  TournamentManager��5
   	   $	��600��6#   $	��800��60   
��� ���.��5      �� .+�5   
   o� .@�5      m� $��Database��6   .@�5      m� -   5        $��gamesMenuItem��5   *   $��Games��6   6?   m� 5      -   5        $��playersMenuItem��5   ,   $��Players��6   6C   m� 5      -   5        $��teamsMenuItem��5   *   $��Teams��6   6?   m� 5      -   5        $��tournamentsMenuItem��5   0   $��Tournaments��6   6K   m� 5      -   5        $��matchesMenuItem��5   ,   $��Matches��6   6C   m� 5      -   5        $��matchesFormatsMenuItem��5   4   $��Matches Formats��6   6R   m� 5      -   5        $��matchesCategoriesMenuItem��5   7   $��Matches Categories��6   6X   m� 5      -	   5        $��playersTeamsMenuItem��5   2   $��Players-Teams��6   6N   m� 5      -
   5        $��tournamentsTeamsMenuItem��5   6   $��Tournaments-Teams��6   6V   5      m� 5      $	��Add��6   .@�5      m� $
��Game��6   m� 5      -   5        $��	addPlayer��5   +   $��Player��6   6<   m� 5      $
��Team��6   m� 5      $��
Tournament��6   m� 5      $��Player to Team��6   m� 5      $��Team to Tournament��6   5      m� 5       $��Remove��6   .@�5!      m� $
��Game��6   m� 5"      $��Player��6   m� 5#      $
��Team��6   m� 5$      $��
Tournament��6   m� 5%      $��Player From Team��6   m� 5&      $��Team to Tournament��6   5'      m� 5(      $
��Show��6   .@�5)      m� -   5        $��ShowPlayers��5)   ,   $��Players��6   6?   m� 5*      -   5        $��	ShowTeams��5*   *   $��Teams��6   6;   m� 5+      -   5        $��ShowTournaments��5+   0   $��Tournaments��6   6G   5,      5-      � 5.   
   -   5        $��playersGrid��5.      $
��Left=�6"   $y�	Collapsed=�6=    � RowDefinitions 5/      �� 50      6"   �� 51      6"    � ColumnDefinitions 53      �� 54      6%   �� 55      6%   .+�57      �� $��0��6   $��0��6%   $
��Left=�65   Игроки6X   �� 58      $��0��6   $��1��6%   $
��Left=�65   Команды6Y   &   System.Windows.Controls.DataGrid  59      -   5          Name$ playersLeftDataGrid��59   N   $��1��6A   $��0��6k      AutoGenerateColumns .  {�.    
IsReadOnly . $
��Left=�6�      Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� 	 �� Path$	 I�
 �� Mode$
 OneTime=�  5<      $
 name��6)    67   �� $	 S�$
 OneTime=�5>        5?      -   5        $ playersRightDataGrid��5?      $��1��65   $��1��6B    .  {�.  . $
��Left=�6�    5@        5A      $ id��6)    65   �� $	 I�$
 OneTime=�  5B      $
 name��6)    67   �� $	 S�$
 OneTime=�5D      5E      � 5F   
   -   5        $��	teamsGrid��5F      $
��Left=�6    $y�	Collapsed=�6;    5G      �� 5H      6"   �� 5I      6"    5K      �� 5L      6%   �� 5M      6%   .+�5O      �� $��0��6   $��0��6%   $
��Left=�65   Команды6Y   �� 5P      $��0��6   $��1��6%   $
��Left=�65   Игроки6X     5Q      -   5        $ teamsLeftDataGrid��5Q   \   $��1��6?   $��0��6L    .  {�.  . $
��Left=�6�    5R        5S      $ id��6)    65   �� $	 I�$
 OneTime=�  5T      $
 name��6)    67   �� $	 S�$
 OneTime=�5V        5W      -   5        $ teamsRightDataGrid��5W      $��1��63   $��1��6@    .  {�.  . $
��Left=�6�    5X        5Y      $ id��6)    65   �� $	 I�$
 OneTime=�  5Z      $
 name��6)    67   �� $	 S�$
 OneTime=�5\      5]      � 5^   
   -   5        $��tournamentsGrid��5^      $
��Left=�6&   $y�	Collapsed=�6A    5_      �� 5`      6"   �� 5a      6"   �� 5b      6"   �� 5c      6"   �� 5d      6"    5f      �� 5g      6%   �� 5h      $
��Auto �6#   62   �� 5i      6%   .+�5k      �� $��1��6   $��0��6%   $
��Left=�65   Турниры6Y   �� 5l      $��2��6   $��0��6%   $
��Left=�65   Команды6Y   �� 5m      $��3��6   $��0��6%   $
��Left=�65   
Матчи6W     5n      -   5        $ tournamentsLeftDataGrid��5n   z   $	��Top=�6E   $��1��6]   $��1��6j    .  {�.  . $
��Left=�6�    5o        5p      $ id��6)    65   �� $	 O0�$
 OneTime=�  5q      $
 name��6)    67   �� $	 O1�$
 OneTime=�  5r      $ 
begin_date��6)    6=   �� $	 O2�$
 OneTime=�  5s      $ end_date��6)    6;   �� $	 O3�$
 OneTime=�  5t      $ game_id��6)    6:   �� $	 O4�$
 OneTime=�  5u      $ 	game_name��6)    6<   �� $	 O5�$
 OneTime=�5w        5x      -   5        $ tournamentsRightDataGrid��5x      $	��Top=�69   $��2��6Q   $��1��6^    .  {�.  . $
��Left=�6�    5y        5z      $ id��6)    65   �� $	 I�$
 OneTime=�  5{      $
 name��6)    67   �� $	 S�$
 OneTime=�5}        5~      -   5        $ matchesDataGrid��5~   L   $��3��6   $��1��6$   $	��Top=�64    .  {�.  . $��Stretch=�6�    5        5�      $ id��6)    65   �� $	 O0�$
 OneTime=�  5�      $ 
team1score��6)    6=   �� $	 O1�$
 OneTime=�  5�      $ 
team2score��6)    6=   �� $	 O2�$
 OneTime=�  5�      $ team1_id��6)    6;   �� $	 O3�$
 OneTime=�  5�      $ 
team1_name��6)    6=   �� $	 O4�$
 OneTime=�  5�      $ team2_id��6)    6;   �� $	 O5�$
 OneTime=�  5�      $ 
team2_name��6)    6=   �� $	 O6�$
 OneTime=�  5�      $ match_format_id��6)    6B   �� $	 O7�$
 OneTime=�  5�      $ match_format_name��6)    6D   �� $	 O8�$
 OneTime=�  5�      $ match_category_id��6)    6D   �� $	 O9�$
 OneTime=�  5�      $ match_category_id��6)    6D   �� $		 O10�$
 OneTime=�5�      �� 5�      -   5        $��bracketButton��5�      $��Center=�6*   $��4��6G   $��0��6U   $��3��6e   .��6�   Создать сетку6�   5�      � 5�   
   -   5        $��BracketGrid��5�      $��Stretch=�6"   $��Stretch=�6@   $y�	Collapsed=�6\   6u   5�      5�      