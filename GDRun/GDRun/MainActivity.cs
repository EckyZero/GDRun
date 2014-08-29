using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace GDRun
{
	[Activity (Label = "Your Stocks", MainLauncher = true, Icon = "@drawable/GDRun_icon")]
	public class MainActivity : Activity
	{
		private ListView listView;
		private TextView cashTextView;
		private TextView valueTextView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);

			listView = FindViewById<ListView> (Resource.Id.listView);
			cashTextView = FindViewById<TextView> (Resource.Id.cashTextView);
			valueTextView = FindViewById<TextView> (Resource.Id.valueTextView);

			Holding holding1 = new Holding();
			holding1.Ticker = "SWTSX";
			holding1.Shares = 46f;
			holding1.Price = 5.46f;
			holding1.Value = 150.15f;
			holding1.GainsNum = 15.56f;
			holding1.GainsPerc = .0864f;

			Holding[] holdings = new Holding[]{ holding1 };

			listView.Adapter = new HoldingsAdapter (this, holdings);

		}
	}
}


