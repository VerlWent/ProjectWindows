   M S B A M L   `   `   `  ����K  GTeamProject_Beta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TeamProject_Beta.PagesTeamProject_Beta.Pages  5      ,    &TeamProject_Beta.Pages.MainSupportPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:TeamProject_Beta.Pages     5      b ^SharpVectors.Converters.Wpf, Version=1.8.2.0, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  5      X TXceed.Wpf.Toolkit, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  6;     N� Title$  MainSupportPage��5
      .��5   
   � -   5        ���#1E2F43 � ColumnDefinitions 5      �� 5      $��1* �6#   60   �� 5      $
��2.5* �6#   62    � RowDefinitions 5      �� 5      $��* �6    6-   �� 5      $
��auto �6    60   .+�5      �� $��0��6   ���#1A2738$��10q�6>   .+�5      ��  �� Orientation$ 
Horizontal=�6   
���   �$��5q�6I   .+�5      (  "SharpVectors.Converters.SvgViewbox  $
��Left=�6&   $��Center=�6A   $��30��6\   $��10q�6g   $��30��6s      Source$T NC:\Users\VerlWent\source\repos\TeamProject_Beta\Resources\Images\SteamLogo.svg?�6   �� 5      -   5        $��	TitleInfo��5       $��CodeFlow��61   
�������$��Center=�6T   $��Center=�6o   $��30(�6�   6�   5      �� 5      -   5        $��AllRequests��5      $��50��6,   ���#445468$��Главная��6M   
�������$��20(�6r   6�   �� 5      -   5        $��NewRequests��5      $��50��6,   ���#445468$��
Новые��6M   
�������$��20(�6p   6�   �� 5      -   5        $��ActiveRequests��5      $��50��6/   ���#445468$��Действующие��6P   
�������$��20(�6y   6�   �� 5      -   5        $��CompletedRequests��5      $��50��62   ���#445468$��Завершённые��6S   
�������$��20(�6|   6�   5      �� 5       -   5         ��Name$ BtnExit��5    |   $��0��6   $��1��6%      ButtonNavigationExit#��[  62   $��
Выход��6`   $��10q�6p   6�   � 5"      $��1��6    5#      �� 5$      $��1* �6$   62   �� 5%      $��6* �6$   62   .+�5(      (  "Xceed.Wpf.Toolkit.WatermarkTextBox  -   5        $��SearthTextBox��5(   (   $��0��6=   ���#1A2738$��10q�6_   $��Center=�6k   
�������$��20(�6�   
������ .��6�      WatermarkTemplate 5)      �� 5*      .R�5+      �� $ 
Horizontal=�6)   .+�5,   "     $
��Left=�62   $��Center=�6M   $��20��6h   $��20��6s   $��	10,0,10,0q�6   $Q KC:\Users\VerlWent\source\repos\TeamProject_Beta\Resources\Images\Searth.svg?�6�   �� 5-   "   $��20(�61   $��
Поиск��6?   
�������$��Center=�6b   5.      5/      .��50   ?   51      �� 53      -	   5        $ ��ListViewSupportAllRequests��53      $��1��6=   ���#1A2738$��10q�6_   
������ ��54      �� 55       �� 
TargetType" ��6    .�56      ��  �� Property � ��	 �� Value$	 Stretch=�6K   -
   5        58      ��5;      �� 5<      .R�5=      � ���#445468 5>   "   �� 5?   &   66   �� 5@   &   66   .+�5C   "   �� $��0��6,   $
��Left=�69   $��5q�6T   $��Логин: Логин��6_   
�������$��20(�6�   6�   �� 5D   "   $��0��6,   $��Right=�69   $��5q�6U   $��Проблема: Тип��6`   
�������$��20(�6�   6�   �� 5F   "   $��1��6,   $
��Left=�69   $��5q�6T   $ ��Статус: Статус��6_   
�������$��20(�6�   6�   5G      5H      5J      5K      5L      5N      