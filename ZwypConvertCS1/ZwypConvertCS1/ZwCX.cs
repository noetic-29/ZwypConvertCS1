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
        public static KonVersion TheKonVersion;

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
#region Conversion Selection display objects
        public static Label HeadLbl = new Label
        {
            Text = "ZwypConvert Traveler",
            FontAttributes = FontAttributes.Bold,
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            TextColor = Color.White,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            HorizontalTextAlignment = TextAlignment.Start,
            Margin = new Thickness(0, 0, 0, 0),
            VerticalOptions = LayoutOptions.FillAndExpand
        };
        public static Image HeadImage = new Image
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.swypconverttraveler512.png", typeof(MainPage).GetTypeInfo().Assembly),
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            VerticalOptions = LayoutOptions.CenterAndExpand,
            Margin = new Thickness(0, 0, 0, 0)
        };

        public static Label lblConversionCaption = new Label
        {
            Text = "Select Conversion",
            FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Center,
            Margin = new Thickness(0, 0, 0, 0),
            HorizontalOptions = LayoutOptions.CenterAndExpand
        };
        public static Label lblSelectedConversion = new Label
        {
            Text = "No Selection",
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Center,
            Margin = new Thickness(0, 0, 0, 0),
            HorizontalOptions = LayoutOptions.CenterAndExpand
        };

        public static Grid ConversionsGrid;
        public static List<ZwImageButton> conversionButtons = new List<ZwImageButton>();
        public static int leftButtonIdx = 0;
        public static ZwImageButton selectedButton = null;
        public static StackLayout Heading = new StackLayout();

#endregion

#region WorkSpace display objects
    // fields for work space
        public static Picker unitLeftPicker = new Picker
        {
            Title = "Select Unit",
            FontAttributes = FontAttributes.None,
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Picker)),
            TextColor = Color.Black,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            Margin = new Thickness(0, 0, 0, 0),
            VerticalOptions = LayoutOptions.CenterAndExpand
        };
        public static Picker unitRightPicker = new Picker
        {
            Title = "Select Unit",
            FontAttributes = FontAttributes.None,
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Picker)),
            TextColor = Color.Black,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            Margin = new Thickness(0, 0, 0, 0),
            VerticalOptions = LayoutOptions.End
        };
        public static Entry convertValue = new Entry
        {
            Text = "",
            FontAttributes = FontAttributes.Bold,
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Entry)),
            TextColor = Color.Black,
            Keyboard = Keyboard.Numeric,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            Margin = new Thickness(0, 0, 0, 0),
            HorizontalTextAlignment = TextAlignment.End
        };
        public static Label resultValue = new Label
        {
            Text = "",
            FontAttributes = FontAttributes.Bold,
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            TextColor = Color.Red,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            HorizontalTextAlignment = TextAlignment.Center,
            Margin = new Thickness(0, 0, 0, 0),
            VerticalOptions = LayoutOptions.FillAndExpand
        };
        public static ZwImageButton btnRight2Left = new ZwImageButton
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.right2left.png", typeof(MainPage).GetTypeInfo().Assembly),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Aspect = Aspect.AspectFit,
            conversionName = "Right2Left",
            //Padding = new Thickness(0),
            Margin = new Thickness(0, 0, 0, 0)
        };
        public static ZwImageButton btnLeft2Right = new ZwImageButton
        {
            Source = ImageSource.FromResource("ZwypConvertCS1.images.left2right.png", typeof(MainPage).GetTypeInfo().Assembly),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Aspect = Aspect.AspectFit,
            conversionName = "Left2Right",
            Margin = new Thickness(0, 0, 0, 0)
        };
#endregion

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
            var imageTapGesture = new TapGestureRecognizer { };
            imageTapGesture.Tapped += OnImageTapped;

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
                aGrpButton.GestureRecognizers.Add(imageTapGesture);
                //aGrpButton.Clicked += OnSelectConversion;
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
                BackgroundColor = Color.Cyan
                //BackgroundColor = Color.Transparent
            };

            StackLayout SwipeConversion = new StackLayout
            {
                Margin = new Thickness(0),
                Padding = new Thickness(0),
                VerticalOptions = LayoutOptions.Start,
                BackgroundColor = Color.Yellow
                //BackgroundColor = Color.Transparent
            };

            Heading = new StackLayout 
            {
                Orientation = StackOrientation.Horizontal,
                Spacing = 0,
                BackgroundColor = Color.Black
            };

            Heading.Children.Add(HeadImage);
            Heading.Children.Add(HeadLbl);

            ConversionsGrid = new Grid
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Start,
                Padding = new Thickness(0),
                Margin = new Thickness(0, 0, 0, 0),
                BackgroundColor = Color.AntiqueWhite
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

            SwipeConversion.Children.Add(Heading);
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
            KonVersion tKV;

            StackLayout workSpace = new StackLayout
            {
                Padding = new Thickness(0),
                Margin = new Thickness(0, 0, 0, 0),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.Transparent
            };

            Grid UnitsGrid = new Grid
            {
                Padding = new Thickness(0),
                Margin = new Thickness(0, 0, 0, 0),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Start
            };

            UnitsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            UnitsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            UnitsGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });

            UnitsGrid.Children.Add(unitLeftPicker, 0, 0);
            UnitsGrid.Children.Add(unitRightPicker, 1, 0);

            unitLeftPicker.SelectedIndexChanged += OnUnitPickerChange;
            unitRightPicker.SelectedIndexChanged += OnUnitPickerChange;

            workSpace.Children.Clear();
            workSpace.Children.Add(UnitsGrid);
            //workSpace.Children.Add(convertValue);

            Grid SwipeToConvertGrid = new Grid
            {
                Padding = new Thickness(0),
                Margin = new Thickness(0, 0, 0, 0),
                BackgroundColor = Color.AntiqueWhite,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Start
            };
            SwipeToConvertGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            SwipeToConvertGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            SwipeToConvertGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            SwipeToConvertGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });

            var leftSwipeGesture = new SwipeGestureRecognizer { Direction = SwipeDirection.Left };
            leftSwipeGesture.Swiped += OnDoConversionSwiped;
            var rightSwipeGesture = new SwipeGestureRecognizer { Direction = SwipeDirection.Right };
            rightSwipeGesture.Swiped += OnDoConversionSwiped;
            var imageTapGesture = new TapGestureRecognizer { };
            imageTapGesture.Tapped += OnImageTapped;

            btnLeft2Right.GestureRecognizers.Add(imageTapGesture);
            //btnLeft2Right.Clicked += OnArrowClick;
            btnRight2Left.GestureRecognizers.Add(imageTapGesture);
            //btnRight2Left.Clicked += OnArrowClick;

            btnRight2Left.GestureRecognizers.Add(leftSwipeGesture);
            btnLeft2Right.GestureRecognizers.Add(rightSwipeGesture);

            SwipeToConvertGrid.GestureRecognizers.Add(leftSwipeGesture);
            SwipeToConvertGrid.GestureRecognizers.Add(rightSwipeGesture);

            SwipeToConvertGrid.Children.Add(btnLeft2Right, 0, 0);
            SwipeToConvertGrid.Children.Add(convertValue, 1, 0);
            SwipeToConvertGrid.Children.Add(btnRight2Left, 2, 0);

            workSpace.Children.Add(SwipeToConvertGrid);

            Label tL1 = new Label
            {
                Text = "Enter Value",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(0, 0, 0, 0),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            workSpace.Children.Add(tL1);
            workSpace.Children.Add(resultValue);

            Grid ButtonGrid = new Grid
            {
                Padding = new Thickness(0),
                Margin = new Thickness(0, 0, 0, 0),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Start
            };

            ButtonGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //UnitsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            ButtonGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            ButtonGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            ButtonGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            ButtonGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });

            for (int i = 0; i < 3; i++)
            {
                string btnText;
                if (TheSet != null && TheSet.myKonVertUserParams.previousKonversions != null)
                {
                    tKV = TheSet.myKonVertUserParams.previousKonversions[i];
                    btnText = tKV.ToString();
                }
                else
                {
                    tKV = null;
                    btnText = "Open";
                }
                ZwKonversionButton tbtn = new ZwKonversionButton
                {
                    btnKonVersion = tKV,
                    Text = btnText,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.Center,
                    Padding = new Thickness(15, 5, 15, 5),
                    Margin = new Thickness(0, 0, 0, 0),
                };
                tbtn.Clicked += OnPreviousKonversionClicked;
                ButtonGrid.Children.Add(tbtn, 0, i);
            }

            Button tb2 = new Button
            {
                Text = "Settings",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness(5, 5, 5, 5),
                Margin = new Thickness(0, 0, 0, 0),
            };
            tb2.Clicked += OnSettingsClicked;
            ButtonGrid.Children.Add(tb2, 0, 3);

            workSpace.Children.Add(ButtonGrid);
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

        public static void OnPreviousKonversionClicked(object sender, EventArgs e)
        {
            ZwKonversionButton aKVBtn = (ZwKonversionButton)sender;
            loadValuesFromKonversion(aKVBtn.btnKonVersion);
        }

        private static void loadValuesFromKonversion(KonVersion aKV)
        {
            if (aKV == null)
                return;
            string txt = aKV.ToString();
            if (String.Compare(txt.ToLower(), "unsafe") == 0)
                return;

            string kGpID = aKV.myVersionGroupID;
            for(int i = 0; i < conversionButtons.Count; i++)
            {
                ZwImageButton aZwIB = conversionButtons[i];
                if (String.Compare(aZwIB.conversionGroup.myVersionGroupID, kGpID) == 0)
                {
                    OnSelectConversion(aZwIB, null);
                    // now make sure the button actually shows on the screen
                    if (i >= leftButtonIdx && i < leftButtonIdx + 5)
                    {
                        // it is showing now
                    } else
                    {
                        // force to middle
                        int intTry = i - 2;
                        if (intTry < 0) intTry = 0;
                        if (intTry > conversionButtons.Count - 1) intTry = conversionButtons.Count - 4;
                        loadGrid(intTry);
                    }

                    // get the right Picker KonVertUnits
                    bool foundLeft = false;
                    bool foundRight = false;
                    foreach(string pStr in unitLeftPicker.Items)
                    {
                        if (!foundLeft && string.Compare(pStr, aKV.LeftUnit.ToString()) == 0)
                        {
                            unitLeftPicker.SelectedItem = pStr;
                            foundLeft = true;
                        }
                        if (!foundRight && string.Compare(pStr, aKV.RightUnit.ToString()) == 0)
                        {
                            unitRightPicker.SelectedItem = pStr;
                            foundRight = true;
                        }
                        if (foundLeft && foundRight)
                            break;
                    }

                    if (aKV.myLeft2Right)
                        convertValue.Text = aKV.myLeftNumber.ToString();
                    else
                        convertValue.Text = aKV.myRightNumber.ToString();
                    resultValue.Text = aKV.ToString();
                    return;
                }
            }
        }

        public static void OnSettingsClicked(object sender, EventArgs e)
        {

        }

        public static void OnUnitPickerChange(object sender, EventArgs e)
        {
            Picker thePicker = (Picker)sender;
            lblSelectedConversion.TextColor = Color.Black;
            resultValue.Text = "";
        }

        private static KonVertUnit getUnitFromPicker(Picker aPicker)
        {
            int i = aPicker.SelectedIndex;
            if (i == -1)
            {
                lblSelectedConversion.TextColor = Color.Red;
                return null;
            }
            return selectedButton.conversionGroup.konVertUnits[i];
        }

        public static void OnArrowClick(object sender, EventArgs e)
        {
            KonVertUnit tmpKVU;
            if (selectedButton == null)
            {
                lblSelectedConversion.TextColor = Color.Red;
                return;
            }

            TheKonVersion = new KonVersion(selectedButton.conversionGroup.myVersionGroupID, TheSet);
            tmpKVU = getUnitFromPicker(unitLeftPicker);
            if (tmpKVU == null)
            {
                //unitLeftPicker.TextColor = Color.Red;
                lblSelectedConversion.TextColor = Color.Red;
                resultValue.Text = "Select Left Unit";
                return;
            }
            TheKonVersion.myVertUnitLeftID = tmpKVU.myVersionUnitID;

            tmpKVU = getUnitFromPicker(unitRightPicker);
            if (tmpKVU == null)
            {
                //unitRightPicker.TextColor = Color.Red;
                lblSelectedConversion.TextColor = Color.Red;
                resultValue.Text = "Select Left Unit";
                return;
            }
            TheKonVersion.myVertUnitRightID = tmpKVU.myVersionUnitID;

            resultValue.Text = "";

            ZwImageButton myBtn = (ZwImageButton)sender;
            if (String.Compare(myBtn.conversionName, "Left2Right") == 0)
            {
                TheKonVersion.myLeft2Right = true;
                TheKonVersion.myLeftNumber = Decimal.Parse(convertValue.Text);
            } else
            {
                TheKonVersion.myLeft2Right = false;
                TheKonVersion.myRightNumber = Decimal.Parse(convertValue.Text);
            }

            TheKonVersion.performKonversion(TheKonVersion.myLeft2Right);
            resultValue.Text = TheKonVersion.ToString();
        }

        public static void OnSelectConversion(object sender, EventArgs e)
        {
            ZwImageButton clickedBtn = (ZwImageButton)sender;
            lblSelectedConversion.Text = clickedBtn.conversionName;
            lblSelectedConversion.TextColor = Color.Black;
            resultValue.Text = "";

            if (selectedButton != null)
                selectedButton.isClicked = false;

            selectedButton = clickedBtn;
            selectedButton.isClicked = true;

            // Now load the Units pickers
            unitLeftPicker.Items.Clear();
            unitRightPicker.Items.Clear();

            KonVersionGroup group = clickedBtn.conversionGroup;
            List<KonVertUnit> grpUnitList = group.konVertUnits;
            foreach (KonVertUnit aKVU in grpUnitList)
            {
                unitLeftPicker.Items.Add(aKVU.ToString());
                unitRightPicker.Items.Add(aKVU.ToString());
            }
        }

        public static void OnImageTapped(object sender, EventArgs e)
        {
            // check for whether selecting conversion or selecting direction
            ZwImageButton tappedButton = (ZwImageButton)sender;
            if (String.Compare(tappedButton.conversionName, "Left2Right") == 0)
            {
                OnArrowClick(sender, e);
                return;
            }
            if (String.Compare(tappedButton.conversionName, "Right2Left") == 0)
            {
                OnArrowClick(sender, e);
                return;
            }
            OnSelectConversion(sender, e);
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

        public static void OnDoConversionSwiped(object sender, SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    OnArrowClick(btnRight2Left, null);
                    break;
                case SwipeDirection.Right:          // swipe right appears to be moving finger from right to left in relation to user
                    OnArrowClick(btnLeft2Right, null);
                    break;
                case SwipeDirection.Up:
                    // Handle the swipe
                    break;
                case SwipeDirection.Down:
                    // Handle the swipe
                    break;
                default:
                    break;
            }
        }
    }
}
