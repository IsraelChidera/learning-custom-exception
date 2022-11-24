using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionhandling
{
    public class CustomException
    {
        
        public class Radio
        {
            public void onSwitch(bool on)
            {
                Console.WriteLine(on? "Scrrr.... Radio is on!" : "Chilling in the silence");
            }
        }

        public class Car
        {
            //fields
            private int _maxSpeed = 100;
            private bool _isCarDead;

            //properties
            public string _name { get; set; } = "";
            public int _currentSpeed { get; set; } = 0;

            //object
            private Radio _radio = new();

            public Car(int currentSpeed, string name)
            {
                _name = name;
                _currentSpeed = currentSpeed;
            }

            public void onRadio(bool state)
            {
                _radio.onSwitch(state);
            }

            public void Accelerate(int speedIncrease)
            {
                if (_isCarDead)
                {
                    Console.WriteLine($"{_name} cannot accelerate. It is packed up");
                }
                else
                {
                    _currentSpeed += speedIncrease;
                    if (_currentSpeed >= _maxSpeed)
                    {
                        Console.WriteLine($"{_name} has overheated");
                        _currentSpeed = 0;
                        _isCarDead = true;
                        //throwing new exception
                        throw new Exception($"{_name} has over heated");
                    }
                    //below else statement was not handling any error
                    /*else
                    {
                        Console.WriteLine($"current speed: {_currentSpeed}");
                    }*/
                    Console.WriteLine($"current speed: {_currentSpeed}");
                }
            }

        }
    }
}
