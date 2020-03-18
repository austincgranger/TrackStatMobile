using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TrackStatMobile.Models;
using Xamarin.Forms;

namespace TrackStatMobile.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        #region Fields
        public ObservableCollection<Stats> listItems;
        public ObservableCollection<HomeModules> cardItems;
        #endregion

        #region Props

        // only get
        public User ThisUser { get; }
        public string Greeting { get; set; }
        #endregion


        #region Constructor
        public HomeViewModel(User thisUser)
        {
            ThisUser = thisUser;

            if (thisUser != null) {
                var name = thisUser.Username;
                Greeting = string.Format("Hello [0]", name);
            } else
            {
                Greeting = "Hello!";

            }

            cardItems = new ObservableCollection<HomeModules>()
            {
                new HomeModules
                {
                    Id = "1",
                    Text = "Settings",
                    Image = null
                },

                new HomeModules
                {
                    Id = "2",
                    Text = "How to Use",
                    Image = null
                },
                new HomeModules
                {
                    Id = "3",
                    Text = "Premium",
                    Image = null
                },
                new HomeModules
                {
                    Id = "4",
                    Text = "Add Statistic",
                    Image = null
                }
            };

            listItems = new ObservableCollection<Stats>()
            {
                new Stats
                {
                    StatisticName = "Vertical Jump",
                    StatisticMonth = "January",
                    ExpectedValue = 20,
                    ActualValue = 25,
                },

               new Stats
                {
                    StatisticName = "Child's Height",
                    StatisticMonth = "October",
                    ExpectedValue = 6,
                    ActualValue = 7,
                }
            };
        }

        #endregion

        #region Properties
        public ObservableCollection<HomeModules> CardItems
        {
            get
            {
                return cardItems;
            }

            set
            {
                SetProperty(ref cardItems, value);
            }
        }


        public ObservableCollection<Stats> ListItems
        {
            get
            {
                return listItems;
            }

            set
            {
                SetProperty(ref listItems, value);
            }
        }

        #endregion

        #region Commands

        #endregion

        #region Methods

        #endregion
    }
}
