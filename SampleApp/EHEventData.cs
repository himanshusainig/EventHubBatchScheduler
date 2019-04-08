using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    class EHEventData
    {
        public String VmId;
        public long Timestamp { get; set; }
        public EHEventData(String vmId, long time)
        {
            this.VmId = vmId;
            this.Timestamp = time;
        }

        public override string ToString()
        {
            return "VM: " + VmId + " at: " + Timestamp;
        }
    }
}
