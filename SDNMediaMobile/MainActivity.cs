using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;

namespace SDNMediaMobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public static Context context;
        public static List<UserInfo> UserInfoList = new List<UserInfo>();
        public static ListView ListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            ListView = FindViewById<ListView>(Resource.Id.Listview);
            GetList list = new GetList();
            list.Execute();
        }

    }
}