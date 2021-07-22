using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public static StatsGetSet CalculateStatistics(List<double> numbers) {
            //Implement statistics here
            StatsGetSet model = new StatsGetSet();

            if (numbers.Count == 0)
                return model;
            model.max = numbers[0];
            model.min = numbers[0];
            double average = 0;
            foreach (float number in numbers)
            {
                if (number > model.max)
                    model.max = number;
                if (number < model.min)
                    model.min = number;
                model.average += number;
            }
            average /= numbers.Count;
            return model;

        }
    }
}
