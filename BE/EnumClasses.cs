﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public static class EnumClasses
    {
        public enum E_days { SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SABBATH };
        public enum E_type { CHILD, CONTRACT, MOTHER, NANNY };
        public enum E_gender { BOY, GIRL };
        public enum E_InstanceType { XML , LIST};
        public enum E_Status {NEW, OLD, UPDATED};
    }
}
