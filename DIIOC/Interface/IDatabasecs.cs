﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIIOC.Interface
{
    public interface IDatabase
    {
        void Save(int orderId);
    }
}
