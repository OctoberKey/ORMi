﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMi.Sample.Models
{
    [WMIClass("Lnl_CardHolder")]
    public class Person
    {
        [WMIIgnoreOnUpdate]
        public string Lastname { get; set; }

        [WMIIgnore]
        public string FirstName { get; set; }

        [WMIProperty( Name = "SSNO", SearchKey = true)]
        public string DocumentNumber { get; set; }

        [WMIProperty("PRIMARYSEGMENTID")]
        public int Segment { get; set; }

        [WMIIgnore]
        public int Age { get; set; }
    }
}
