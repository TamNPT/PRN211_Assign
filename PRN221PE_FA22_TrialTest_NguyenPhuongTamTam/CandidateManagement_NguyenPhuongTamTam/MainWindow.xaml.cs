﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Candidate_BusinessObjects;
using Candidate_Services;

namespace CandidateManagement_NguyenPhuongTamTam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IHRAccountService hRAccountService;
        public MainWindow()
        {
            InitializeComponent();
            hRAccountService = new HRAccountService();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Hraccount hraccount = hRAccountService.GetHraccountByEmail(txtEmail.Text);
            if (hraccount != null && txtPassword.Password.Equals(hraccount.Password) && hraccount.MemberRole == 1 || hraccount.MemberRole == 2)
            {
                this.Hide();
                CandidateProfileWindow jobPostingWindow = new CandidateProfileWindow(hraccount.MemberRole);
                jobPostingWindow.Show();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}