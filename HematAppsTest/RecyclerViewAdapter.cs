using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Views;
using Android.Support.V7.Widget;

namespace HematAppsTest
{
    class RecyclerViewAdapter : RecyclerView.Adapter
    {
        private Activity activity;
        private List<TransactionData> mData;
        public RecyclerViewAdapter(Activity activity, List<TransactionData> mData) {
            this.mData = mData;
            this.activity = activity;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var id = Resource.Layout.item;
            var itemView = LayoutInflater.From(parent.Context).Inflate(id, parent, false);

            return new RecyclerViewHolder(itemView);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var item = mData.ElementAt(position);
            var holder = viewHolder as RecyclerViewHolder;
            holder.txtCost.Text = item.
        }

        public override int ItemCount => mData.Count;
    }
}