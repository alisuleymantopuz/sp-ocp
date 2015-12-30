using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Violations.Scenario1
{
    public class SuperProcess
    {
        private GrowlNotificationService _notifier;

        public SuperProcess(GrowlNotificationService notifier)
        {
            _notifier = notifier;
        }

        public void StartProcess()
        {
            //do long running process;

            _notifier.Growl();
        }
    }
}
