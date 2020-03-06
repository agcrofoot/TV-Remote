using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab
{
    class Television
    {
        private string manufacturer;
        private int screenSize;
        private bool powerOn;
        private int channel;
        private int volume;


        //Method constructor that bring the data in
        public Television(string brand, int size)
        {
            this.manufacturer = brand;
            this.screenSize = size;
            this.powerOn = false;
            this.channel = 2;
            this.volume = 20;
        }

        //Gets volume and returns the value
        public int GetVolume()
        {
            return volume;
        }

        //Gets channel and returns the value
        public int GetChannel()
        {
            return channel;
        }

        //Gets manufacturer and returns the string
        public string GetManufacturer()
        {
            return manufacturer;
        }

        //Gets screen size and returns the value
        public int GetScreenSize()
        {
            return screenSize;
        }

        //Sets the station in the channel field
        public void SetChannel(int station)
        {
            this.channel = station;
        }

        //Turns off if returns true and turns on if returns false
        public void Power()
        {
            powerOn = !powerOn;
        }

        //Increases volume by one
        public void IncreaseVolume()
        {
            volume++;
        }

        //Decreases volume by one
        public void DecreaseVolume()
        {
            volume--;
        }
        
        //Presents the data in a string format
        public string ToString()
        { 
            if(powerOn == true)
            {
                return "A " + screenSize + " inch " + manufacturer + " has been turned on.";
            }
            else
            {
                return "A " + screenSize + " inch " + manufacturer + " has been turned off.";
            }
        }
    }
}
