namespace HematAppsTest
{
    public class TransactionData
    {
        private string mCost;
        private string mDesc;

        public TransactionData(string mCost, string mDesc) {
            this.mCost = mCost;
            this.mDesc = mDesc;
        }

        public string MCost { get => mCost; set => mCost = value; }
        public string MDesc { get => mDesc; set => mDesc = value; }
    }
}