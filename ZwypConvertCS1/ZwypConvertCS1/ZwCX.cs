using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

using Xamarin.Forms;

using KonVertObjs;

namespace ZwypConvertCS1
{
    class ZwCX
    {
        public static KonVertSet TheSet;

        //public static List<ZwImageButton> ConversionButtons;
#if EDREM
        public static ZwImageButton btnCurrency = new ZwImageButton
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.curr600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //normalSource = ImageSource.FromResource("ZwypConvertCS1.images.curr600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //clickedSource = ImageSource.FromResource("ZwypConvertCS1.images.currsel600.png", typeof(MainPage).GetTypeInfo().Assembly),
            isClicked = false,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            conversionName = "Currency",
            Margin = new Thickness(0, 0, 0, 0)
        };
        public static ZwImageButton btnDistance = new ZwImageButton
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.dist600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //normalSource = ImageSource.FromResource("ZwypConvertCS1.images.dist600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //clickedSource = ImageSource.FromResource("ZwypConvertCS1.images.distsel600.png", typeof(MainPage).GetTypeInfo().Assembly),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            conversionName = "Distance",
            Margin = new Thickness(0, 0, 0, 0)
        };
        public static ZwImageButton btnLength = new ZwImageButton
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.length600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //normalSource = ImageSource.FromResource("ZwypConvertCS1.images.length600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //clickedSource = ImageSource.FromResource("ZwypConvertCS1.images.lengthsel600.png", typeof(MainPage).GetTypeInfo().Assembly),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            conversionName = "Length",
            Margin = new Thickness(0, 0, 0, 0)
        };
        public static ZwImageButton btnLoad = new ZwImageButton
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.load600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //normalSource = ImageSource.FromResource("ZwypConvertCS1.images.load600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //clickedSource = ImageSource.FromResource("ZwypConvertCS1.images.loadsel600.png", typeof(MainPage).GetTypeInfo().Assembly),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            conversionName = "Load",
            Margin = new Thickness(0, 0, 0, 0)
        };
        public static ZwImageButton btnPressure = new ZwImageButton
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.pressure600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //normalSource = ImageSource.FromResource("ZwypConvertCS1.images.pressure600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //clickedSource = ImageSource.FromResource("ZwypConvertCS1.images.pressuresel600.png", typeof(MainPage).GetTypeInfo().Assembly),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            conversionName = "Pressure",
            Margin = new Thickness(0, 0, 0, 0)
        };
        public static ZwImageButton btnSpace = new ZwImageButton
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.space600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //normalSource = ImageSource.FromResource("ZwypConvertCS1.images.space600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //clickedSource = ImageSource.FromResource("ZwypConvertCS1.images.spacesel600.png", typeof(MainPage).GetTypeInfo().Assembly),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            conversionName = "Space",
            Margin = new Thickness(0, 0, 0, 0)
        };
        public static ZwImageButton btnSurface = new ZwImageButton
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.surface600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //normalSource = ImageSource.FromResource("ZwypConvertCS1.images.surface600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //clickedSource = ImageSource.FromResource("ZwypConvertCS1.images.surfacesel600.png", typeof(MainPage).GetTypeInfo().Assembly),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            conversionName = "Surface",
            Margin = new Thickness(0, 0, 0, 0)
        };
        public static ZwImageButton btnTemp = new ZwImageButton
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.temp600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //normalSource = ImageSource.FromResource("ZwypConvertCS1.images.temp600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //clickedSource = ImageSource.FromResource("ZwypConvertCS1.images.tempsel600.png", typeof(MainPage).GetTypeInfo().Assembly),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            conversionName = "Temperature",
            Margin = new Thickness(0, 0, 0, 0)
        };
        public static ZwImageButton btnTime = new ZwImageButton
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.time600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //normalSource = ImageSource.FromResource("ZwypConvertCS1.images.time600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //clickedSource = ImageSource.FromResource("ZwypConvertCS1.images.timesel600.png", typeof(MainPage).GetTypeInfo().Assembly),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            conversionName = "Time",
            Margin = new Thickness(0, 0, 0, 0)
        };
        public static ZwImageButton btnVolume = new ZwImageButton
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.volume600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //normalSource = ImageSource.FromResource("ZwypConvertCS1.images.volume600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //clickedSource = ImageSource.FromResource("ZwypConvertCS1.images.volumesel600.png", typeof(MainPage).GetTypeInfo().Assembly),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            conversionName = "Volume",
            Margin = new Thickness(0, 0, 0, 0)
        };
        public static ZwImageButton btnWeight = new ZwImageButton
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.weight600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //normalSource = ImageSource.FromResource("ZwypConvertCS1.images.weight600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //clickedSource = ImageSource.FromResource("ZwypConvertCS1.images.weightsel600.png", typeof(MainPage).GetTypeInfo().Assembly),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            conversionName = "Weight",
            Margin = new Thickness(0, 0, 0, 0)
        };

        public static ZwImageButton btnLeftRight = new ZwImageButton
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.weight600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //normalSource = ImageSource.FromResource("ZwypConvertCS1.images.weight600.png", typeof(MainPage).GetTypeInfo().Assembly),
            //clickedSource = ImageSource.FromResource("ZwypConvertCS1.images.weightsel600.png", typeof(MainPage).GetTypeInfo().Assembly),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            conversionName = "Weight",
            Margin = new Thickness(0, 0, 0, 0)
        };
#endif

        public static Label lblConversionCaption = new Label
        {
            Text = "Select Conversion",
            FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.CenterAndExpand
        };
        public static Label lblSelectedConversion = new Label
        {
            Text = "No Selection",
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.CenterAndExpand
        };

        public static Grid ConversionsGrid;
        public static List<ZwImageButton> conversionButtons = new List<ZwImageButton>();
        public static int leftButtonIdx = 0;
        public static ZwImageButton selectedButton = null;

        // fields for work space
        public static Picker unitLeftPicker = new Picker
        {
            Title = "Select Unit",
            FontAttributes = FontAttributes.None,
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Picker)),
            TextColor = Color.Black,
            HorizontalOptions = LayoutOptions.FillAndExpand//,
        };
        public static Picker unitRightPicker = new Picker
        {
            Title = "Select Unit",
            FontAttributes = FontAttributes.None,
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Picker)),
            TextColor = Color.Black,
            HorizontalOptions = LayoutOptions.FillAndExpand//,
        };
        public static Entry convertValue = new Entry
        {
            Text = "",
            FontAttributes = FontAttributes.Bold,
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)),
            TextColor = Color.Black,
            Keyboard = Keyboard.Numeric,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            HorizontalTextAlignment = TextAlignment.End
        };


        public static StackLayout buildMainScreen()
        {
            // build array of ZwImageButtons based on read in Set
            if (ZwCX.TheSet == null)
                return null;

            conversionButtons = new List<ZwImageButton>();

            var leftSwipeGesture = new SwipeGestureRecognizer { Direction = SwipeDirection.Left };
            leftSwipeGesture.Swiped += OnConversionGridSwiped;
            var rightSwipeGesture = new SwipeGestureRecognizer { Direction = SwipeDirection.Right };
            rightSwipeGesture.Swiped += OnConversionGridSwiped;

            Assembly avoidReCalc = typeof(MainPage).GetTypeInfo().Assembly;
            foreach (KonVersionGroup aKVG in TheSet.KonVersionGroups)
            {
                ZwImageButton aGrpButton = new ZwImageButton
                {
                    conversionGroup = aKVG,
                    Source = ImageSource.FromResource(ZwTools.imageLoc + aKVG.myVersionGroupID.ToLower() + ZwTools.imageTag, avoidReCalc),
                    isClicked = false,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    conversionName = aKVG.myDisplayText,
                    Margin = new Thickness(0, 0, 0, 0)
                };
                aGrpButton.Clicked += OnSelectConversion;
                aGrpButton.GestureRecognizers.Add(leftSwipeGesture);
                aGrpButton.GestureRecognizers.Add(rightSwipeGesture);

                conversionButtons.Add(aGrpButton);
            }


            // Full body on screeen
            StackLayout myBody = new StackLayout
            {
                Margin = new Thickness(0),
                Padding = new Thickness(5, 5, 5, 5),
                VerticalOptions = LayoutOptions.Start,
                BackgroundColor = Color.Transparent
            };

            StackLayout SwipeConversion = new StackLayout
            {
                Margin = new Thickness(0),
                Padding = new Thickness(0),
                VerticalOptions = LayoutOptions.Start,
                BackgroundColor = Color.Transparent
            };

            ConversionsGrid = new Grid
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Start
            };
            ConversionsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ConversionsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ConversionsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ConversionsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ConversionsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            ConversionsGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });

            loadGrid(0);            // should be 0 to start, will set leftButtonIdx

            ConversionsGrid.GestureRecognizers.Add(leftSwipeGesture);
            ConversionsGrid.GestureRecognizers.Add(rightSwipeGesture);

            SwipeConversion.GestureRecognizers.Add(leftSwipeGesture);
            SwipeConversion.GestureRecognizers.Add(rightSwipeGesture);

            lblConversionCaption.GestureRecognizers.Add(leftSwipeGesture);
            lblConversionCaption.GestureRecognizers.Add(rightSwipeGesture);

            lblSelectedConversion.GestureRecognizers.Add(leftSwipeGesture);
            lblSelectedConversion.GestureRecognizers.Add(rightSwipeGesture);

            SwipeConversion.Children.Add(ConversionsGrid);
            SwipeConversion.Children.Add(lblConversionCaption);
            SwipeConversion.Children.Add(lblSelectedConversion);

            StackLayout workSpace = buildWorkSpace();
            myBody.Children.Add(SwipeConversion);
            myBody.Children.Add(workSpace);

            return myBody;
        }

        public static StackLayout buildWorkSpace()
        {
            StackLayout workSpace = new StackLayout
            {
                Margin = new Thickness(0),
                Padding = new Thickness(5, 5, 5, 5),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.Transparent
            };

            Grid UnitsGrid = new Grid
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Start
            };

            UnitsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            UnitsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            UnitsGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });

            UnitsGrid.Children.Add(unitLeftPicker, 0, 0);
            UnitsGrid.Children.Add(unitRightPicker, 1, 0);

            workSpace.Children.Clear();
            workSpace.Children.Add(UnitsGrid);
            workSpace.Children.Add(convertValue);

            Grid SwipeToConvertGrid = new Grid
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Start
            };
            SwipeToConvertGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            SwipeToConvertGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            SwipeToConvertGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            SwipeToConvertGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });



            return workSpace;
        }

        public static void loadGrid(int lftIdx)
        {
            // first check to see if fewer buttons than columns to put them in
            if (conversionButtons.Count < ConversionsGrid.ColumnDefinitions.Count)
            {
                for (int i = 0; i < conversionButtons.Count; i++)
                {
                    ConversionsGrid.Children.Add(conversionButtons[i], i, 0);
                }
                return;
            }

            // check to see if have enough buttons to fill the grid from this index
            if (lftIdx + ConversionsGrid.ColumnDefinitions.Count > conversionButtons.Count)
            {       // not enought buttons to fill to right  (lftIdx == 6 => 7th button, can load 7 into 0 col, 11 into col 4 (for 5 columns))
                return;
            }

            if (leftButtonIdx < lftIdx)     // current left cell is going off to left so remove element 0 from grid children
                ConversionsGrid.Children.Remove(conversionButtons[leftButtonIdx]);
            else
            {                               // current left cell is moving to right, current right end cell must be removed
                ConversionsGrid.Children.Remove(conversionButtons[leftButtonIdx + 4]);
            }

            leftButtonIdx = lftIdx;     // do this here but lftIdx is NOT incremented below

            // somehow the last button to the right stays there, so try something different
            ConversionsGrid.Children.Add(conversionButtons[lftIdx + 4], 4, 0);
            ConversionsGrid.Children.Add(conversionButtons[lftIdx + 3], 3, 0);
            ConversionsGrid.Children.Add(conversionButtons[lftIdx + 2], 2, 0);
            ConversionsGrid.Children.Add(conversionButtons[lftIdx + 1], 1, 0);
            ConversionsGrid.Children.Add(conversionButtons[lftIdx + 0], 0, 0);
        }

        public static void OnSelectConversion(object sender, EventArgs e)
        {
            ZwImageButton clickedBtn = (ZwImageButton)sender;
            lblSelectedConversion.Text = clickedBtn.conversionName;

            if (selectedButton != null)
                selectedButton.isClicked = false;

            selectedButton = clickedBtn;
            selectedButton.isClicked = true;
        }

        public static void OnConversionGridSwiped(object sender, SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    loadGrid(leftButtonIdx + 1);
                    break;
                case SwipeDirection.Right:          // swipe right appears to be moving finger from right to left in relation to user
                    if (leftButtonIdx > 0)
                        loadGrid(leftButtonIdx - 1);
                    break;
                case SwipeDirection.Up:
                    // Handle the swipe
                    break;
                case SwipeDirection.Down:
                    // Handle the swipe
                    break;
                default:
                    loadGrid(leftButtonIdx + 1);
                    break;
            }
        }
    }
}
