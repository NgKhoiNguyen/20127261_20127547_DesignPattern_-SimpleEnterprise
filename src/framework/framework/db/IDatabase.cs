﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.db
{
    public interface IDatabase 
    {
         void Connect();
         void Disconnect();
    }
}
