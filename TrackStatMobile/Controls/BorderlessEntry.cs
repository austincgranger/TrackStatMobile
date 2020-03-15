using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace TrackStatMobile.Controls
{
    /// <summary>
    /// This class removes the border for Android
    /// </summary>
    [Preserve(AllMembers = true)]
    public class BorderlessEntry : Entry
    {
        public bool isFocused { get; set; }
        public BorderlessEntry()
        {
            isFocused = IsFocused;
        }
    }

}
