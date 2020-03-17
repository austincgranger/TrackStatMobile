using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackStatMobile.Models;
using TrackStatMobile.Views;
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

        public Command LoginCommand { get; set; }


        public Command SignUpCommand { get; set; }

        public Command ForgotPasswordCommand { get; set; }

 
        public Command SocialMediaLoginCommand { get; set; }
        public User UserProp { get; set; }

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
            LoginCommand = new Command<User>(async (UserProp) => await LoginClicked(UserProp));
            SignUpCommand = new Command(SignUpClicked);
            ForgotPasswordCommand = new Command(ForgotPasswordClicked);
            SocialMediaLoginCommand = new Command(SocialLoggedIn);
        }

        #endregion

        #region Methods

        // Ask calvin
        private async Task LoginClicked(User userProp)
        {
            string email = Email;
            string password = Password;
            //var keyValues = new List<KeyValuePair<string, string>>
            //{
            //    new KeyValuePair<string, string>(Email, userProp.UserEmail),
            //    new KeyValuePair<string, string>(Password, userProp.UserPassword)
            //};

            if (userProp.UserEmail.Contains(email) && userProp.UserPassword.Contains(password))
            {
                // Navigation to HomePage
            }
        }
        private async void SignUpClicked()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }


        private async void ForgotPasswordClicked(object obj)
        {
            var label = obj as Label;
            label.BackgroundColor = Color.FromHex("#70FFFFFF");
            await Task.Delay(100);
            label.BackgroundColor = Color.Transparent;
        }


        private void SocialLoggedIn(object obj)
        {
            // TODO
        }

        #endregion
    }
}
