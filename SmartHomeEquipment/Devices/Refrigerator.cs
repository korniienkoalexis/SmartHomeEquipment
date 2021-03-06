﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeEquipment
{
    public class Refrigerator : Device, IDoorOpen, IFrostdoorOpen, IFrostMode
    {

        private bool doorState;
        private bool frostDoorState;
        private bool ligthState;
        private ChangeFrostMode frostmode;

        public Refrigerator(bool state, string name, ChangeFrostMode frostMode, bool doorState, bool frostDoorState)
            : base(state, name)
        {
            frostmode = frostMode;
            this.doorState = doorState;
            this.frostDoorState = frostDoorState;
        }



        public void RefrigeratDoorOpen()
        {
            doorState = true;
            if (state)
            {
                ligthState = true;
            }
            else
            {
                ligthState = false;
            }
            doorState = true;

        }

        public void RefrigeratDoorClose()
        {
            doorState = false;
            ligthState = false;
        }

        public void GetRefrigeratDoorOpen()
        {
            doorState = true;
            //ligthState = false;
        }

        public void FrostDoorStateOpen()
        {
            if (doorState == true)
            {
                frostDoorState = true;
            }

        }

        public void FrostDoorStateClose()
        {
            if (doorState == true)
            {
                frostDoorState = false;
            }
        }

        public bool DoorState
        {
            get
            {
                return doorState;
            }
        }

        public bool FrostDoorState
        {
            get
            {
                return frostDoorState;
            }
        }

        public void ChangeMode()
        {
            frostmode.FrostMode();
        }

        public override string ToString()
        {

            string state;
            if (this.state)
            {
                state = "ON";
            }
            else
            {
                state = " OFF";
            }


            string doorState;
            if (this.doorState)
            {
                doorState = "Opened";
            }
            else
            {
                doorState = "Closed";
            }


            string ligthState;
            if (this.ligthState)
            {
                ligthState = "ON";
            }
            else
            {
                ligthState = "OFF";
            }

            string frostDoorState;
            if (this.frostDoorState)
            {
                frostDoorState = "Opened";
            }
            else
            {
                frostDoorState = "Closed";
            }

            return "Refregerator name: " + name + " State: " + state + " ,FrostLevel: " + frostmode.GetFrostMode() + " ,Door State: " + doorState + " ,Light: " + ligthState + " ,Frost Door: " + frostDoorState;
        }

    }
}
