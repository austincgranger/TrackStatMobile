using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TrackStatMobile.ViewModels
{
    class RegisterViewModel: BaseViewModel
    {
        #region Fields

        private string name;

        private string password;

        private string confirmPassword;

        #endregion

        #region Constructor

        public RegisterViewModel()
        {
            this.LoginCommand = new Command(this.LoginClicked);
            this.SignUpCommand = new Command(this.SignUpClicked);
        }

        #endregion

        #region Property

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (this.name == value)
                {
                    return;
                }

                SetProperty(ref name, value);
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
                    SetProperty(ref name, value);
                }
                
            }
        }

        public string ConfirmPassword
        {
            get
            {
                return confirmPassword;
            }

            set
            {
                if (confirmPassword == value)
                {
                    return;
                }

                
                else
                {
                    SetProperty(ref confirmPassword, value);
                }
            }
        }

        #endregion

        #region Command

        public Command LoginCommand { get; set; }


        public Command SignUpCommand { get; set; }

        #endregion

        #region Methods


        private void LoginClicked(object obj)
        {
            // Do something
        }

        private void SignUpClicked(object obj)
        {
            // Do something
        }

        #endregion
    }
}
