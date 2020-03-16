using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackStatMobile.Models;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace TrackStatMobile.ViewModels
{
    [Preserve(AllMembers = true)]
    class LoginViewModel : BaseViewModel
    {
        #region Fields
        private string password;

        private string email;

        private bool isInvalidEmail;
        #endregion

        #region Commands

        /// <summary>
        /// Gets or sets the command that is executed when the Log In button is clicked.
        /// </summary>
        public Command LoginCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Sign Up button is clicked.
        /// </summary>
        public Command SignUpCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Forgot Password button is clicked.
        /// </summary>
        public Command ForgotPasswordCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the social media login button is clicked.
        /// </summary>
        public Command SocialMediaLoginCommand { get; set; }
        public User User { get; set; }

        #endregion

        #region Prop

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (email == value)
                {
                    return;
                }
                else
                {
                    SetProperty(ref email, value);
                }
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                if (password == value)
                {
                    return;
                }
                else
                {
                    SetProperty(ref password, value);
                }

            }
        }

        public bool IsInvalidEmail
        {
            get
            {
                return isInvalidEmail;
            }

            set
            {
                if (isInvalidEmail == value)
                {
                    return;
                }
                else
                {
                    // SetProperty based on BaseViewModel and implements INotifyPropChanged
                    SetProperty(ref isInvalidEmail, value);
                }
            }
        }
        #endregion
        #region Ctor
        public LoginViewModel()
        {
            LoginCommand = new Command(LoginClicked);
            SignUpCommand = new Command(SignUpClicked);
            ForgotPasswordCommand = new Command(ForgotPasswordClicked);
            SocialMediaLoginCommand = new Command(SocialLoggedIn);
            User = new User();
        }

        public LoginViewModel(User user)
        {
            LoginCommand = new Command(LoginClicked);
            SignUpCommand = new Command(SignUpClicked);
            ForgotPasswordCommand = new Command(ForgotPasswordClicked);
            SocialMediaLoginCommand = new Command(SocialLoggedIn);
            User = user;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the Log In button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void LoginClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the Sign Up button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void SignUpClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the Forgot Password button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void ForgotPasswordClicked(object obj)
        {
            var label = obj as Label;
            label.BackgroundColor = Color.FromHex("#70FFFFFF");
            await Task.Delay(100);
            label.BackgroundColor = Color.Transparent;
        }

        /// <summary>
        /// Invoked when social media login button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void SocialLoggedIn(object obj)
        {
            // Do something
        }

        #endregion
    }
}
