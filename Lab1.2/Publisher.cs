using System;

namespace Lab1._2
{
    class Publisher
    {
        public event EventHandler<RewardEventArgs> RewardEvent;

        public void SendReward()
        {
            DefineReward(new RewardEventArgs("You are received reward"));
        }

        protected virtual void DefineReward(RewardEventArgs e)
        {
            EventHandler<RewardEventArgs> rewardEvent = RewardEvent;
            if(rewardEvent !=null)
            {
                e.Message += $" at {DateTime.Now}";
                rewardEvent(this, e);
            }
        }
    }
}
