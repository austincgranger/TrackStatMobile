using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Application = Android.App.Application;

[assembly: ExportRenderer(typeof(TrackStatMobile.Controls.BorderlessEntry), typeof(TrackStatMobile.Droid.Controls.DroidBorderlessEntry))]
namespace TrackStatMobile.Droid.Controls
{
    class DroidBorderlessEntry : EntryRenderer
    {
        public DroidBorderlessEntry() : base(Application.Context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (this.Control != null)
            {
                this.Control.SetBackground(null);
                Control.Gravity = GravityFlags.CenterVertical;
                Control.SetPadding(0, 0, 0, 0);
            }
        }
    }
}