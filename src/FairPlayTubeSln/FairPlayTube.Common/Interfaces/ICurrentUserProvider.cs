﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairPlayTube.Common.Interfaces
{
    public interface ICurrentUserProvider
    {
        string GetUsername();
        string GetObjectId();
    }
}
