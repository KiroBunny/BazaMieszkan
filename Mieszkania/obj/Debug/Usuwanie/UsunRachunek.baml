   M S B A M L   `   `   `  ����E  AMieszkania, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Mieszkania.UsuwanieMieszkania.Usuwanie  5      &     Mieszkania.Usuwanie.UsunRachunek   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Mieszkania.Usuwanie     5      .��5	      � 
�������.+�5
   
   �� -   5          ��Name$  txt_id��5
      $
��Left=�6"   $��23��6=   $��195,169,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $��TextBox��6r   $	��Top=�6�   $	��120��6�   {�.  6�   �� 5   
   $��ID Umowy��6   $
��Left=�6#   $��
80,165,0,0q�6>   $	��Top=�6R   �� 5   
   $��Termin Rozliczenia��6   $
��Left=�6-   $��
80,249,0,0q�6H   $	��Top=�6\   �� 5   
   $��	Opłacony��6   $
��Left=�6#   $��
80,280,0,0q�6>   $	��Top=�6R   �� 5   
   -   5        $  	txt_Kwota��5      $
��Left=�6%   $��23��6@   $��195,209,0,0q�6L   $
 Wrap=�6a   $��TextBox��6u   $	��Top=�6�   $	��120��6�   {�.  6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
txt_termin��5      $
��Left=�6)   $��23��6D   $��195,249,0,0q�6P      Text$ TextBox��6e   $	��Top=�6t   $	��120��6�   {�.  6�   �� 5   
   -   5         ��Name$ btn_usun��5      $��Usuń��6#   $
��Left=�62   $��202,344,0,0q�6M   $	��Top=�6b   $��87��6z   $��23��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.114Q�6&   T� 5      5      5      �� 5   
   -   5         ��Name$ cbox_oplacone��5      $
��Left=�6*   $��195,284,0,0q�6E   $	��Top=�6Z   $	��120��6r    �� SelectedValuePath$	 Key��6~   	 �� DisplayMemberPath$	 Value��6�   {�.  6�   �� 5   
   -   5        $  
txt_idrach��5      $
��Left=�6&   $��23��6A   $��195,138,0,0q�6M   $
 Wrap=�6b   $��TextBox��6v   $	��Top=�6�   $	��120��6�   {�.  6�   �� 5   
   $��ID Rachunku��6   $
��Left=�6&   $��
80,134,0,0q�6A   $	��Top=�6U   �� 5   
   -   5        $ btn_wybierzrach��5      $��Wybierz rachunek��6*   $
��Left=�6E   $��334,138,0,0q�6`   $	��Top=�6u   $	��119��6�   $��23��6�   $ 0.5,0.5&�6�   z�5      V� 5      .~�5       �� �� 5!      �� 5"      $ -0.114Q�6&   T� 5#      5$      5&      5(      5)      