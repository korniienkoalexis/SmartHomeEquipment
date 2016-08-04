using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeEquipment
{
    public class AirCond : Device, ITemperature, IDeviceChangeMode
    {
        public AirCond(bool state, string name, AirCondModeChng airmode, Temperature temperature)
            : base(state, name)
        {
            aircondmode = airmode;
            aircondtemperature = temperature;
        }
        private AirCondModeChng aircondmode;
        private Temperature aircondtemperature;



        public void UpTemperature()
        {
            aircondtemperature.UpTemperature();
        }

        public void DownTemperature()
        {
            aircondtemperature.DownTemperature();
        }

        public void ChangeMode()
        {
            aircondmode.ChangeMode();
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
                state = "OFF";
            }
            int temperature = aircondtemperature.GetTemperature();
            string mode = aircondmode.GetAirCondMode();
            return "AirConditioner name: " + name + " state: " + state + " Temperature: " + temperature + " Mode: " + mode;
        }
    }
}
