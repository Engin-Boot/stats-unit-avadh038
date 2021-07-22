using System;
namespace Statistics
{
    public class LEDAlert:IAlerter
    {
        public bool ledGlows = false;
        public void done()
        {
            ledGlows = true;
        }
    }
}
