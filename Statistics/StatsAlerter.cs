using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsAlerter
    {
        public double maxThreshold;
        public IAlerter[] alerters;

        public StatsAlerter(double maxThreshold, IAlerter[] alerters)
        {
            this.maxThreshold = maxThreshold;
            this.alerters = alerters;
        }


        public void checkAndAlert(List<double> thresholds)
        {
            for (int i = 0; i < thresholds.Count; ++i)
            {
                if (thresholds[i] > maxThreshold)
                {
                    for (int j = 0; j < alerters.Length; ++j)
                    {
                        alerters[j].done();
                    }
                    break;
                }
            }
        }
    }
            
}
