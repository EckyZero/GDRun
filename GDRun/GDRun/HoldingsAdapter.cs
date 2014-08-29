using System;
using Android.Widget;
using Android.App;

namespace GDRun
{
	public class HoldingsAdapter : BaseAdapter
	{
		Activity activity;
		Holding[] holdings;

		public HoldingsAdapter (Activity activity, Holding[] holdings)
		{
			this.activity = activity;
			this.holdings = holdings;
		}

		#region implemented abstract members of BaseAdapter

		public override Java.Lang.Object GetItem (int position)
		{
			return null;
		}

		public override long GetItemId (int position)
		{
			return 0;
		}

		public override Android.Views.View GetView (int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			var view = activity.LayoutInflater.Inflate (Resource.Layout.HoldingsListRow, parent, false);
			TextView tickerTextView = view.FindViewById<TextView> (Resource.Id.tickerTextView);
			TextView sharesTextView = view.FindViewById<TextView> (Resource.Id.sharesTextView);
			TextView priceTextView = view.FindViewById<TextView> (Resource.Id.priceTextView);
			TextView valueTextView = view.FindViewById<TextView> (Resource.Id.valueTextView);
			TextView gainsTextView = view.FindViewById<TextView> (Resource.Id.gainsTextView);
			Holding holding = holdings [position];

			tickerTextView.Text = holding.Ticker;
			sharesTextView.Text = holding.Shares.ToString();
			priceTextView.Text = holding.Price.ToString ();
			valueTextView.Text = holding.Value.ToString ();
			gainsTextView.Text = holding.GainsNum.ToString ();

			return view;
		}

		public override int Count {
			get {
				return holdings.Length;
			}
		}

		#endregion
	}
}

