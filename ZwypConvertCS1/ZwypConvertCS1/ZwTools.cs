using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

using Xamarin.Forms;
using Newtonsoft;
using Newtonsoft.Json;

using KonVertObjs;

namespace ZwypConvertCS1
{
    class ZwTools
    {
        public static string ZwypConvertAppDirectory = "ZwypConvertCS1.resources.";
        public static string ZwypConvertAppFile = "zwypconverttraveler_txt";

        public static string imageLoc = "ZwypConvertCS1.images.";
        public static string imageTag = "600.png";
        public static string imageSel = "sel600.png";


        public static string jsonErr;
        public static string readErr;

        public static bool readAppData()
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = ZwypConvertAppDirectory + ZwypConvertAppFile;
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    string result = reader.ReadToEnd();
                    ZwCX.TheSet = JsonConvert.DeserializeObject<KonVertSet>(result, buildSetting());
                }
                return true;
            }
            catch (JsonException jExp)
            {
                jsonErr = jExp.ToString();
                return false;
            }
            catch (Exception exp)
            {
                readErr = exp.ToString();
                return false;
            }
        }

        public static JsonSerializerSettings buildSetting()
        {
            JsonSerializerSettings mySettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                MaxDepth = 10,
                ObjectCreationHandling = ObjectCreationHandling.Auto,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                TypeNameHandling = TypeNameHandling.Auto
            };
            return mySettings;
        }

    }


    class ZwImageButton : ImageButton
    {
        public ImageSource normalSource {
            get {
                if (conversionGroup == null)
                    return null;
                if (String.IsNullOrEmpty(conversionGroup.myVersionGroupID))
                    return null;
                return ImageSource.FromResource(ZwTools.imageLoc + conversionGroup.myVersionGroupID.ToLower() + ZwTools.imageTag, typeof(MainPage).GetTypeInfo().Assembly);
            }
        }

        public ImageSource clickedSource {
            get {
                if (conversionGroup == null)
                    return null;
                if (String.IsNullOrEmpty(conversionGroup.myVersionGroupID))
                    return null;
                return ImageSource.FromResource(ZwTools.imageLoc + conversionGroup.myVersionGroupID.ToLower() + ZwTools.imageSel, typeof(MainPage).GetTypeInfo().Assembly);
            }
        }

        private bool _isClicked = false;
        public bool isClicked {
            get {
                return _isClicked;
            }

            set {
                _isClicked = value;
                if (_isClicked)
                    Source = clickedSource;
                else
                    Source = normalSource;
            }
        }

        public string conversionName { get; set; }

        public KonVersionGroup conversionGroup { get; set; }
    }

}
