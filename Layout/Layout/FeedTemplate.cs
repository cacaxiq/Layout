using Layout.Cell;
using Layout.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Layout
{
    public class FeedTemplate : DataTemplateSelector
    {
        private DataTemplate _simpleFeed;
        private DataTemplate _photoFeed;

        public FeedTemplate()
        {
            _simpleFeed = new DataTemplate(typeof(FBCell));
            _photoFeed = new DataTemplate(typeof(FBCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var model = item as Feed;

            if (model is FeedWithImage)
                return _photoFeed;

            return _simpleFeed;
        }
    }
}
