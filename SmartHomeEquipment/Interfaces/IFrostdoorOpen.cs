﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeEquipment
{
    public interface IFrostdoorOpen
    {
        void frostDoorStateOpen();

        void frostDoorStateClose();
    }
}