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
    /// Interaction logic for JobPostingWindow.xaml
    /// </summary>
    public partial class JobPostingWindow : Window
    {
        private IJobPostingService jobPostingService;
        private int? RoleID = 0;

        public JobPostingWindow()
        {
            InitializeComponent();
            jobPostingService = new JobPostingService();
        }

        public JobPostingWindow(int? roleID)
        {
            InitializeComponent();
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
        public void loadAfter()
        {
            dtgJobPosting.ItemsSource = jobPostingService.GetJobPostings();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtgJobPosting.ItemsSource = jobPostingService.GetJobPostings();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            JobPosting jobPosting = new JobPosting();
            jobPosting.PostingId = txtJobPostingID.Text;
            jobPosting.Description = txtDescription.Text;
            jobPosting.JobPostingTitle = txtTitle.Text;
            jobPosting.PostedDate = DateTime.Parse(txtJobPostingDate.Text);

            if (jobPostingService.AddJobPosting(jobPosting))
            {
                MessageBox.Show("Added Successfully!!");
                loadAfter();
            }
            else
            {
                MessageBox.Show("Error adding data!");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            JobPosting selectedJobPosting = new JobPosting();

            selectedJobPosting.PostingId = txtJobPostingID.Text;
            selectedJobPosting.Description = txtDescription.Text;
            selectedJobPosting.JobPostingTitle = txtTitle.Text;
            selectedJobPosting.PostedDate = DateTime.Parse(txtJobPostingDate.Text);

            bool update = jobPostingService.UpdateJobPosting(selectedJobPosting);

            if (update)
            {
                MessageBox.Show("Updated Successfully!!");
                loadAfter();
            }
            else
            {
                MessageBox.Show("Error updating data!");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dtgJobPosting.SelectedItem != null)
            {
                JobPosting selectedJobPosting = dtgJobPosting.SelectedItem as JobPosting;

                if (selectedJobPosting != null)
                {
                    bool isDeleted = jobPostingService.DeleteJobPosting(selectedJobPosting);

                    if (isDeleted)
                    {
                        MessageBox.Show("Deleted Successfully!!");
                        loadAfter();
                    }
                    else
                    {
                        MessageBox.Show("Error delecting data!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select job posting to delete.");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
