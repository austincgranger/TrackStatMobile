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
    // for android? all members of this type are preserved? Q
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

        #endregion

        #region Prop

        public User ThisUser { get; }
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
            LoginCommand = new Command<User>(async (TnisUser) => await LoginClicked(ThisUser));
            SignUpCommand = new Command(SignUpClicked);
            ForgotPasswordCommand = new Command(ForgotPasswordClicked);
            SocialMediaLoginCommand = new Command(SocialLoggedIn);
        }

        #endregion

        #region Methods

        private async Task LoginClicked(User ThisUser)
        {
         
            await Application.Current.MainPage.Navigation.PushAsync(new HomePage(ThisUser));
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

            // TODO perform Nav
        }


        private void SocialLoggedIn(object obj)
        {
            // TODO perform validation stuff
        }

        #endregion
    }
}
