using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityServiceLibrary.Services
{
    public class UtilityService : IUtilityService
    {

        public string ConvertToLocaleDateTime(DateTime dateInput)
        {
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
            var localTime = TimeZoneInfo.ConvertTimeFromUtc(dateInput, localTimeZone);

            return localTime.ToString("yyyy-M-d HH:mm");

        }

        public string ConvertSecondsToCompleteDuration(int durationInSeconds)
        {
            var duration = TimeSpan.FromSeconds(durationInSeconds);
            string formattedDuration = $"{duration.Hours:D2}:{duration.Minutes:D2}:{duration.Seconds:D2}";
            return formattedDuration;
        }
    }
}
