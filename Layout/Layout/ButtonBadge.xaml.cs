using Xamarin.Forms;

namespace Layout
{
    public partial class ButtonBadge : AbsoluteLayout
    {
        #region Badge
        public static readonly BindableProperty BadgeProperty = BindableProperty.Create("Badge", typeof(string), typeof(ButtonBadge), string.Empty, BindingMode.Default, null, BadgePropertyChanged);

        private static void BadgePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null)
                return;

            var badge = ((ButtonBadge)bindable).badge;
            var frame = ((ButtonBadge)bindable).frame;
            var badgeValue = newValue as string;

            if (string.IsNullOrEmpty(badgeValue) || badgeValue == "0")
            {
                frame.IsVisible = false;
            }
            else
            {
                badge.Text = badgeValue;
                frame.IsVisible = true;
            }
        }

        public string Badge
        {
            get { return (string)GetValue(BadgeProperty); }
            set { SetValue(BadgeProperty, value); }
        }
        #endregion

        #region IsSelected
        public static readonly BindableProperty IsSelectedProperty = BindableProperty.Create("IsSelected", typeof(bool), typeof(ButtonBadge), false, BindingMode.Default, null, IsSelectedPropertyChanged);

        private static void IsSelectedPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null)
                return;

            var button = ((ButtonBadge)bindable).button;
            var image = button.Image.File;
            if (newValue is bool)
            {
                button.BackgroundColor = Color.FromHex("#243c6d");

                int index = image.IndexOf(".");
                string imageActive = image.Insert(index, "_active");
                button.Image.File = imageActive;
            }
            else
            {
                button.BackgroundColor = Color.FromHex("#3b5998");

                int index = image.IndexOf("_");
                string imageInactive = image.Remove(index, "_active".Length);
                button.Image.File = imageInactive;
            }
        }

        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }
        #endregion

        public ButtonBadge()
        {
            InitializeComponent();
            frame.IsVisible = false;
        }
    }
}