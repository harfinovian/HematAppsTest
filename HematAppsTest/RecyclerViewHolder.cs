using System;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;

namespace HematAppsTest
{
    public class RecyclerViewHolder : RecyclerView.ViewHolder
    {
        public TextView txtCost { get; private set; }
        public TextView txtDesc { get; private set; }

        public RecyclerViewHolder(View itemView) : base(itemView)
        {
            txtCost = itemView.FindViewById<TextView>(Resource.Id.txt_cost);
            txtDesc = itemView.FindViewById<TextView>(Resource.Id.txt_desc);
        }
    }
}