using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    static class HoneyVault
    {
        static string StatusReport { get
            {
                string status = "";
                status += $"Honey: {honey} \n Nectar: {nectar}";
                if (honey < LOW_LEVEL_WARNING) status += $"LOW HONEY - ADD A HONEY MANUFACTURER";
                if (nectar < LOW_LEVEL_WARNING) status += $"LOW NECTAR - ADD A NECTAR COLLECTOR";
                return status;
            }
        }
        private static float honey = 25f;
        private static float nectar = 100f;
        public const float NECTAR_CONVERSION_RATIO = .19f;
        public const float LOW_LEVEL_WARNING = .10f;

        public static void ConvertNectarToHoney(float amount)
        {
            float convertedNectar;
            if (amount > nectar) convertedNectar = nectar;
            else convertedNectar = amount;
            nectar -= convertedNectar;
            honey += convertedNectar * NECTAR_CONVERSION_RATIO;
        }
        public static bool ConsumeHoney(float amount)
        {
            if (amount >= honey) {
                honey -= amount;
                return true;
             } else
            {
                return false;
            }
        }
        public static void CollectNectar(float amount)
        {
            if (amount > 0f) nectar += amount;
        }
    }
}
