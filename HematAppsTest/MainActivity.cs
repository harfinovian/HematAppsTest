using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using System.Collections.Generic;

namespace HematAppsTest
{
    [Activity(Label = "HematAppsTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        RecyclerViewAdapter mAdapter;
        List<TransactionData> mData;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Prepare the data source:
            mData.Add(new TransactionData());

            // Instantiate the adapter and pass in its data source:
            mAdapter = new RecyclerViewAdapter(this, mData);

            // Set our view from the "main" layout resource:
            SetContentView(Resource.Layout.Main);

            // Get our RecyclerView layout:
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.rv_transaction);

            // Plug the adapter into the RecyclerView:
            mRecyclerView.SetAdapter(mAdapter);
        }
    }
}

