   M S B A M L   `   `   `  ����K  GTeamProject_Beta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TeamProject_Beta.PagesTeamProject_Beta.Pages  5      4    .TeamProject_Beta.Pages.DescrtiptionSupportPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:TeamProject_Beta.Pages     5      b ^SharpVectors.Converters.Wpf, Version=1.8.2.0, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  6:     N� Title$  DescrtiptionSupportPage��5	      .��5      � ���#1E2F43 � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $
��2.5* �6   6.    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $
��Auto �6   6,   .+�5   
   �� $��0��6   $��10q�6%   .+�5      �� $��0��6   ���#1A2738$��10q�6>   .+�5      ��  �� Orientation$ 
Horizontal=�6   
���   �$��5q�6I   .+�5      (  "SharpVectors.Converters.SvgViewbox  $
��Left=�6&   $��Center=�6A   $��30��6\   $��10q�6g   $��30��6s      Source$T NC:\Users\VerlWent\source\repos\TeamProject_Beta\Resources\Images\SteamLogo.svg?�6   �� 5      -   5        $��	TitleInfo��5       $��CodeFlow��61   
�������$��Center=�6T   $��Center=�6o   $��30(�6�   6�   5      �� 5      -   5         ��Name$ TextBlockUserID��5      $��10q�65   $��30��6A   
�������$��20(�6`   6p   �� 5      -   5        $ TextBlockUserName��5      $��10q�67   $��30��6C   
�������$��20(�6b   6r   �� 5      -   5        $ TextBlockEmail��5      $��10q�64   $��30��6@   
�������$��20(�6_   6o   �� 5      -   5        $ TextBlockTypeProblem��5      $��10q�6:   $��30��6F   
�������$��20(�6e   6u   5      5       �� 5!   
   -   5         ��Name$ 	BtnCancel��5!   z   $��0��6   $��1��6!      ButtonNavigationCancel#��[  6.   $��
Назад��6^   $��10q�6n   6�   �� 5$   
   $��1��6   $��10q�6%   .+�5%      �� $'��!Описание проблемы��6   
�������$��25(�6D   $��10q�6R   6`   �� 5&      $��Hidden=�6   $	��100��6@   $��10q�6M   .��5'      �� -   5        $��DescriptionProblem��5'      $��5q�66   
�������$��20(�6T   ���#1A27386y   5(      �� 5*      $��Ответ:��6   
�������$��25(�69   $��10q�6G   6U   �� 5+      -   5        $��TextBoxAnswer��5+      ���#1A2738$��10q�6@   
������ $	��120��6f   
�������$��20(�6�   6�   5-      �� 5/   
   -	   5        $ BtnSend��5/   ~   $��1��6   $��1��6     ButtonNavigationAccept#��[ 6.   $��Отправить��6^   $��20q�6r   $��Right=�6�   6�   50      51      