   M S B A M L   `   `   `  ����a  ]CandidateManagement_NguyenPhuongTamTam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:CandidateManagement_NguyenPhuongTamTam&CandidateManagement_NguyenPhuongTamTam  5   	   =    7CandidateManagement_NguyenPhuongTamTam.JobPostingWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:CandidateManagement_NguyenPhuongTamTam     5   	   -   5          � Title$  JobPostingWindow��5   	   $	��800��6"   $
��1250��6/   .��5	      � $��	0,45,0,-6q�6   .+�5
   
   �� -   5         ��Name$ lblJobPostingManagement��5
      $��JOB POSTING MANAGEMENT��61   $��Center=�6R   $��0,38,0,0q�6o   $	��Top=�6�   $��35(�6�   $
��Bold"�6�   �� 5   
   -   5        $ lblJobPostingID��5      $��JobPosting ID��6)   $
��Left=�6A   $��
40,130,0,0q�6\   $	��Top=�6p   $��30(�6�   �� 5   
   -   5        $ lblTitle��5      $��Title��6"   $
��Left=�62   $��
40,200,0,0q�6M   $	��Top=�6a   $��30(�6y   �� 5   
   -   5        $ lblJobPostingDate��5      $��JobPosting Date��6+   $
��Left=�6E   $��
40,270,0,0q�6`   $	��Top=�6t   $��30(�6�   �� 5   
   -   5         ��Name$ txtJobPostingID��5      $
��Left=�5      $��285,135,0,0q�6&    �� TextWrapping$
 Wrap=�6;   $	��Top=�6O   $	��300��6g   $��40��6s   $��25(�6   $��Center=�6�   ��5   +   �� *	PostingId+ � DataContext 6F   �� *SelectedItem+ �� ElementName$ dtgJobPosting��5   �   �� 5   
   -   5        $ txtTitle��5      $
��Left=�6�   $��285,205,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��300��6�   $��40��6�   $��25(�6�   $��Center=�6  ��6$   �� *JobPostingTitle+ 6E   �� *SelectedItem+$ dtgJobPosting��6  (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ txtJobPostingDate��5      $
��Left=�6�   $��285,275,0,0q�6�   $	��Top=�6�   $	��300��6�   $��40��6�   $��20(�6�      Text 60   �� *
PostedDate+ 6L   �� *SelectedItem+$ dtgJobPosting��6�   �� 5   
   -	   5        $ lblDescription��5      $��Description��6(   $
��Left=�6>   $��635,130,0,0q�6Y   $	��Top=�6n   $��30(�6�   �� 5   
   -
   5        $ txtDescription��5      $��637,205,45,425q�6�   $��20(�6�   ��6*   �� *Description+ 6G   �� *SelectedItem+$ dtgJobPosting��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgJobPosting��5      $��40,375,50,221q�6U   �� 5   
   -   5        	 ��Name$	 btnAdd��5      $	��Add��6!   $
��Left=�6/   $��100,580,0,0q�6J   $	��Top=�6_   $��30(�6w   $	��150��6�   $��59��6�   ���	#FFC688EB6�   �� 5   
   -   5        $	 	btnUpdate��5      $��Update��6$   $
��Left=�65   $��400,580,0,0q�6P   $	��Top=�6e   $��30(�6}   $	��150��6�   $��59��6�   ���	#FFFBA2D06�   �� 5   
   -   5        $	 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��700,580,0,0q�6P   $	��Top=�6e   $��30(�6}   $	��150��6�   $��59��6�   ���	#FFFFC4A46�   �� 5   
   -   5        $	 btnClose��5      $��Close��6#   $
��Left=�63   $��1000,580,0,0q�6N   $	��Top=�6d   $��30(�6|   $	��150��6�   $��59��6�   ���	#FF92B9E36�   5      5      