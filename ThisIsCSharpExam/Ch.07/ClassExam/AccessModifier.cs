using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._07.ClassExam
{
    class WaterHeater
    {
        protected int temperature;

        // SetTemperature() 메소드는 -5 ~ 42 사이의 값만 받아들이고,
        // 이 범위를 벗어난 값에 대해서는 예외를 발생시킵니다.
        public void SetTemperature(int temperature)
        {
            if (temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }
            // temperature 필드는 protected로 수식됐으므로 외부에서 직접 접근할 수 없습니다.
            // 이렇게 public 메소드를 통해 접근해야 합니다.
            this.temperature = temperature;
        }
        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
    }
    class AccessModifier
    {
        public void Main()
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);  // 39행에서 예외가 발생하며, 40행은 실행되지 않고
                heater.TurnOnWater();   //  42행의 catch 블록으로 실행 위치가 이동합니다.
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
