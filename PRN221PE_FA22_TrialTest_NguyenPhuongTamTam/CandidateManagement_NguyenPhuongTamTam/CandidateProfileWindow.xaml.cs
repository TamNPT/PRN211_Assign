using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Candidate_BusinessObjects;
using Candidate_Services;

namespace CandidateManagement_NguyenPhuongTamTam
{
    /// <summary>
    /// Interaction logic for CandidateProfileWindow.xaml
    /// </summary>
    public partial class CandidateProfileWindow : Window
    {
        private ICandidateProfileService candidateProfileService;
        private IJobPostingService jobPostingService;
        private int? RoleID = 0;
        public CandidateProfileWindow(int? roleID)
        {
            InitializeComponent();
            candidateProfileService = new CandidateProfileService();
            jobPostingService = new JobPostingService();
            this.RoleID = roleID;
            switch (roleID)
            {
                case 1:
                    break;
                case 2:
                    this.btnAdd.IsEnabled = false;
                    break;
                default:
                    break;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadInitData();
        }
        private void loadInitData()
        {
            dtgCandidateProfile.ItemsSource = candidateProfileService.GetCandidateProfiles();
            this.cmbJobPostingID.ItemsSource = jobPostingService.GetJobPostings();
            this.cmbJobPostingID.DisplayMemberPath = "JobPostingTitle";
            this.cmbJobPostingID.SelectedValuePath = "PostingId";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile candidateProfile = new CandidateProfile();
            candidateProfile.CandidateId = txtCandidateID.Text;
            candidateProfile.Fullname = txtFullName.Text;
            candidateProfile.ProfileShortDescription = txtDescription.Text;
            candidateProfile.Birthday = DateTime.Parse(txtBirthDay.Text);
            candidateProfile.ProfileUrl = txtImageURL.Text;
            var jobPosting = cmbJobPostingID.SelectedValue;
            candidateProfile.PostingId = jobPosting.ToString();

            if (candidateProfileService.AddCandidateProfile(candidateProfile))
            {
                MessageBox.Show("Added Successfully!!");
                loadAfter();
            }
            else
            {
                MessageBox.Show("Error adding data!");
            }
        }

        public void loadAfter()
        {
            dtgCandidateProfile.ItemsSource = candidateProfileService.GetCandidateProfiles();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile candidateProfile = new CandidateProfile();

            candidateProfile.CandidateId = txtCandidateID.Text;
            candidateProfile.ProfileShortDescription = txtDescription.Text;
            candidateProfile.Fullname = txtFullName.Text;
            candidateProfile.Birthday = DateTime.Parse(txtBirthDay.Text);
            var jobPosting = cmbJobPostingID.SelectedValue;
            candidateProfile.PostingId = jobPosting.ToString();
            candidateProfile.ProfileUrl = txtImageURL.Text;


            bool update = candidateProfileService.UpdateCandidateProfile(candidateProfile);

            if (update)
            {
                MessageBox.Show("Updated Successfully!");
                loadAfter(); 
            }
            else
            {
                MessageBox.Show("Error updating data!");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dtgCandidateProfile.SelectedItem != null)
            {
                CandidateProfile selected = dtgCandidateProfile.SelectedItem as CandidateProfile;

                if (selected != null)
                {
                    bool isDeleted = candidateProfileService.DeleteCandidateProfile(selected);

                    if (isDeleted)
                    {
                        MessageBox.Show("Deleted Successfully!");
                        loadAfter();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting data!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select Candidate to delete.");
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var seacrh = txtSearch.Text;
            if (seacrh != null)
            {
                var list = candidateProfileService.SearchCandidateByName(seacrh);

                dtgCandidateProfile.ItemsSource = list;
            }
        }

        private void btnResearch_Click(object sender, RoutedEventArgs e)
        {
            loadInitData();
        }

        private void dtgJobPosting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var jobPosting = (CandidateProfile)dtgCandidateProfile.SelectedItem;
            if (jobPosting != null)
            {
                cmbJobPostingID.SelectedValue = jobPosting.PostingId;
                txtCandidateID.IsReadOnly = true;
            }
        }

    }
}
