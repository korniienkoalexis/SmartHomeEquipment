using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeEquipment
{
    public interface IDoorOpen
    {
        void RefrigeratDoorOpen();

        void RefrigeratDoorClose();

        void GetRefrigeratDoorOpen();

         bool DoorState { get;}
    }
}
