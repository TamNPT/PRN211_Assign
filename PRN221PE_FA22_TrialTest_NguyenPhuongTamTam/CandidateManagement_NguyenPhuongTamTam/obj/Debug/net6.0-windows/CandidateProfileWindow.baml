   M S B A M L   `   `   `  ����a  ]CandidateManagement_NguyenPhuongTamTam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:CandidateManagement_NguyenPhuongTamTam&CandidateManagement_NguyenPhuongTamTam  5   	   C    =CandidateManagement_NguyenPhuongTamTam.CandidateProfileWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:CandidateManagement_NguyenPhuongTamTam     5   	   -   5          � Title$  CandidateProfileWindow��5   	   $	��878��6(   $
��1250��65    � WindowStartupLocation$ CenterScreen=�6B    � WindowStyle$
 None=�6g   .��5	      � .+�5
   
   �� -   5         ��Name$# lblCandidateProfileManagement��5
      $"��CANDIDATE PROFILE MANAGEMENT��67   $��Center=�6^   $��0,38,0,0q�6{   $	��Top=�6�   $	��622��6�   $��35(�6�   $
��Bold"�6�   �� 5   
   -   5        $ lblCandidateID��5      $��Candidate ID��6(   $
��Left=�6?   $��
40,130,0,0q�6Z   $	��Top=�6n   $��30(�6�   �� 5   
   -   5        $ lblBirthDay��5      $��BirthDay��6%   $
��Left=�68   $��
40,340,0,0q�6S   $	��Top=�6g   $��30(�6   �� 5   
   -   5        $ lblFullName��5      $��FullName��6%   $
��Left=�68   $��
40,200,0,0q�6S   $	��Top=�6g   $��30(�6   �� 5   
   -   5        $ lblDescription��5      $��Description��6(   $
��Left=�6>   $��635,200,0,0q�6Y   $	��Top=�6n   $��30(�6�   �� 5   
   -   5        $ lblImageURL��5      $��ImageURL��6%   $
��Left=�68   $��
40,270,0,0q�6S   $	��Top=�6g   $��30(�6   �� 5   
   -   5        $ lblJobPosting��5      $��
JobPosting��6'   $
��Left=�6<   $��635,130,0,0q�6W   $	��Top=�6l   $��30(�6�   �� 5   
   -	   5         ��Name$ txtCandidateID��5      $
��Left=�6�   $��258,135,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��300��6�   $��40��6�   $��25(�6  $��Center=�6  ��6*   �� *CandidateId+ � DataContext 6G   �� *SelectedItem+ �� ElementName$ dtgCandidateProfile��6  �� 5   
   -
   5        $ txtFullName��5      $
��Left=�6�   $��258,205,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��300��6�   $��40��6�   $��25(�6�   $��Center=�6	  ��6'   �� *
Fullname+ 6A   �� *SelectedItem+$ dtgCandidateProfile��6	  �� 5   
   -   5        $ txtImageURL��5      $
��Left=�6�   $��258,275,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��300��6�   $��40��6�   $��25(�6�   $��Center=�6  ��6'   �� *
ProfileUrl+ 6C   �� *SelectedItem+$ dtgCandidateProfile��6  (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ txtBirthDay��5      $
��Left=�6�   $��258,345,0,0q�6�   $	��Top=�6�   $	��300��6�   $��40��6�   $��20(�6�   	   Text	 6*   �� *
Birthday+ 6D   �� *SelectedItem+$ dtgCandidateProfile��6�   �� 5   
   -   5        
 ��Name$
 cmbJobPostingID��5      $
��Left=�6,   $��850,135,0,0q�6G   $	��Top=�6\   $	��300��6t   $��40��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgCandidateProfile��5      $��40,575,50,134q�6[   6r   �� 5   
   -   5         ��Name$ btnAdd��5      $	��Add��6!   $
��Left=�6/   $��100,750,0,0q�6J   $	��Top=�6_   $��30(�6w   $	��150��6�   $��59��6�   ���	#FFC688EB6�   �� 5   
   -   5        $ 	btnUpdate��5      $��Update��6$   $
��Left=�65   $��400,750,0,0q�6P   $	��Top=�6e   $��30(�6}   $	��150��6�   $��59��6�   ���	#FFFBA2D06�   �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��700,750,0,0q�6P   $	��Top=�6e   $��30(�6}   $	��150��6�   $��59��6�   ���	#FFFFC4A46�   �� 5   
   -   5        $ btnClose��5      $��Close��6#   $
��Left=�63   $��1000,750,0,0q�6N   $	��Top=�6d   $��30(�6|   $	��150��6�   $��59��6�   ���	#FF92B9E36�   �� 5   
   -   5        $ 	lblSearch��5      $��Search��6#   $
��Left=�64   $��
40,470,0,0q�6O   $	��Top=�6c   $��30(�6{   �� 5   
   -   5        $ 	txtSearch��5      $
��Left=�6%   $��258,475,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $	��300��6�   $��40��6�   $��25(�6�   $��Center=�6�   �� 5   
   -   5        $ 	btnSearch��5      $��Search��6$   $
��Left=�65   $��700,475,0,0q�6P   $	��Top=�6e   $��30(�6}   $	��150��6�   $��59��6�   ���	#FFC688EB6�   �� 5   
   -   5        $ btnResearch��5      $��Research��6&   $
��Left=�69   $��1000,475,0,0q�6T   $	��Top=�6j   $��30(�6�   $	��150��6�   $��59��6�   ���	#FFFBA2D06�   �� 5   
   -   5        $ txtDescription��5      $��637,265,45,405q�6�   $��20(�6�   $	��120��6�   $
 Wrap=�6�    �� AcceptsReturn$
 True��5    
   " �� VerticalScrollBarVisibility$
 Auto=�5!   
   ��5   *   �� *ProfileShortDescription+ 6S   �� *SelectedItem+$ dtgCandidateProfile��5!   
   5#      5$      