using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Better.Scenario1
{
    public class SuperProcess
    {
        private INotificationService _notifier;

        public SuperProcess(INotificationService notifier)
        {
            _notifier = notifier;
        }

        public void StartProcess()
        {
            //do long running process;

            _notifier.Notify("SuperProcess is all done!");
        }
    }
}
