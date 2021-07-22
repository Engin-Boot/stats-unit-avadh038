using System;
namespace Statistics
{
    public class LEDAlert:IAlerter
    {
        public bool ledGlows;
        public LEDAlert()
        {
            ledGlows = false;
        }
        public void done()
        {
            ledGlows = true;
        }
    }
}
