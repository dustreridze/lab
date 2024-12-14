using System;

namespace Health
{
    public class BMI
    {
        public static decimal CalculateBMI(decimal weight, decimal height)
        {
            return weight / (height * height);
        }

        public static string ClassificationBMI(decimal bmi)
        {
            if (bmi < 18.5m)
            {
                return "Недостаточный вес";
            }
            else if (bmi >= 18.5m && bmi < 24.9m)
            {
                return "Нормальный вес";
            }
            else if (bmi >= 25m && bmi < 29.9m)
            {
                return "Избыточный вес";
            }
            else
            {
                return "Ожирение";
            }
        }
    }
}
