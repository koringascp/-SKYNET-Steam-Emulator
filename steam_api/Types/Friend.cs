﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKYNET.Types
{
    public class Friend
    {
        public uint AccountId;
        public ulong SteamId;
        public string PersonaName;

        public uint GameId { get; set; }
    }
}
