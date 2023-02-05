
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsChallenge
{
    class Marketing
    {
        public void Start() {
            Program.Posted += HasPosted;
            Program.Finished += HasFinished;

        }
        public void HasPosted() {
            Console.WriteLine("survey finshed");
        }

        public void HasFinished() {
            Console.WriteLine("Thank you for completing the survey. You are now subscribed to ten of our newsletters.");
        }
    }
}
