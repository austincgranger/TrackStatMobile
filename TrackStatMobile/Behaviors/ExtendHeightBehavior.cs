using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Control.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrackStatMobile.Behaviors
{
    class ExtendHeightBehavior : Behavior<SfListView>
    {
        #region Field

   
        private VisualContainer container;

        #endregion

        #region Properties

        public SfListView ListView { get; private set; }

        #endregion

        #region Methods
        protected override void OnAttachedTo(SfListView listView)
        {
            base.OnAttachedTo(listView);
            this.ListView = listView;
            this.container = listView.GetVisualContainer();
            this.container.PropertyChanged += this.Container_PropertyChanged;
        }
        protected override void OnDetachingFrom(SfListView listView)
        {
            base.OnDetachingFrom(listView);
            this.container.PropertyChanged -= this.Container_PropertyChanged;
            this.container = null;
            this.ListView = null;
        }

        /// <summary>
        /// Invoked when the container property is changed.
        /// </summary>
        /// <param name="sender">The VisualContainer</param>
        /// <param name="eventArgs">The property changed event args</param>
        private async void Container_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs eventArgs)
        {
            if (eventArgs.PropertyName == "Height")
            {
                await Task.Delay(500);
                var extent = (double)this.container.GetType().GetRuntimeProperties()
                    .FirstOrDefault(container => container.Name == "TotalExtent").GetValue(this.container);
                this.ListView.HeightRequest = extent + 1;
            }
        }

        #endregion
    }
}
