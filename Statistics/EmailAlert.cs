using System;
namespace Statistics
{
    public class EmailAlert:IAlerter
    {
        public bool emailSent = false;
        public void done()
        {
            emailSent = true;
        }
    }
}
