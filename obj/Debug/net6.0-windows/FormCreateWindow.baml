   M S B A M L   `   `   `  ����H  DTaskSearchWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TaskSearchWPFTaskSearchWPF  5   	   $    TaskSearchWPF.FormCreateWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TaskSearchWPF     5   	     � Title$  FormCreateWindow��5   	   $	��450��6"   $	��800��6/   .��5	      � .+�5   
   �� $(��"Расскажите о себе: ��6   $��15(�6/   $	��Top=�6=   $��	0,114,0,0q�6U   �� 5   
   -   5        $��FormDescriptionBox��5      $�� ��6,   $��28,154,28,103q�64   �� 5   
   $ ��Название игры:��6   $��15(�6*   $��Bottom=�69   $
��Left=�6T   $��17��6o   $��
16,0,0,395q�6{   $	��107��6�    J� RenderTransformOrigin$ 0.356,-1.451&�6�   �� 5   
   -   5        $��CreateFormBtn��5      $!��Создать анкету��6&   $��25��6[   $	��150��6g   $��125,366,125,0q�6s   $	��Top=�6�   �� 5   
   -   5        $��
GameSelect��5      $��293,32,244,382q�6%   ��6=   �� *Game+ �� SelectedItem 6Z   �� *UserForm.GameId+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6$   �� *
GameName+5      5      5      �� 5   
   $��15(�6   $��Bottom=�6#   $
��Left=�6>   $��17��6Y   $��
16,0,0,343q�6e   $	��232��6y   $ 0.356,-1.451&�6�   �� 6�    � Language$ ru-ru�6�   $>�8Выберите предпочитаемую роль: ��6�   6�   �� 5   
   -   5         ��Name$ 
RoleSelect��5      $��293,78,244,336q�6'   ��6?   �� *InTeamStatus+ 6d   �� *" UserForm.PreferredInTeamStatusId+��5      �� 5      .R�5      �� $ 
Horizontal=�6!   .+�5      �� ��6$   �� *InTeamStatusName+5      5       5"      5#      5$      