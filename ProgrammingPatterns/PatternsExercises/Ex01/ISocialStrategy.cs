﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex01
{
    public interface ISocialStrategy
    {
        SocialNetworkUser[] GetSocialNetworkUser(string UserName);
    }
}
