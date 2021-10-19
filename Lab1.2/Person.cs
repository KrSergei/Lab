using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    class Person
    {
        private readonly int _personID;

        public Person(int id, Publisher pub)
        {
            _personID = id;
            pub.RewardEvent += HandleRewardEvent;
        }

        void HandleRewardEvent(object sender, RewardEventArgs e)
        {
            Console.WriteLine($" {_personID} recived meaasage: {e.Message}");
        } 

        void Unsubscribe(Publisher pub)
        {
            pub.RewardEvent -= HandleRewardEvent;
        }
    }
}
