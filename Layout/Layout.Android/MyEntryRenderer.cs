using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using Layout.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]
namespace Layout.Droid
{
    public class MyEntryRenderer : EntryRenderer
    {

        public MyEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control?.SetIncludeFontPadding(false);
            Control?.SetPadding(0, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}