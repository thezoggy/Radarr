﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NzbDrone.Core.Model
{
    public class SabnzbdInfoModel
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string ApiKey { get; set; }
    }
}
