using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTravel
{
    class TimeUtils
    {
        /// <summary>
        /// Berechnet den Zeit unterschied von einem Datum(Parameter) und der aktuellen Zeit.
        /// </summary>
        /// <returns>True if Timedifference is bigger or equal 1 Second</returns>
        public static Boolean checkTime(DateTime lastSelect, out DateTime currentTime)
        {
            if (lastSelect.Equals(new DateTime(1999)))
            {
                currentTime = DateTime.Now;

                return true;
            }
            else
            {
                String result = calcTimeDifference(lastSelect.ToString(), DateTime.Now.ToString());
                String[] ary = result.Split(':');
                result = ary[0] + ary[1] + ary[2];
                double value = Convert.ToDouble(result);

                if (value >= 1)
                {
                    currentTime = DateTime.Now;
                    return true;
                }
                else {
                    currentTime = lastSelect;
                    return false; }
            }
        }

        /// <summary>
        /// Berechnet den Zeitunterschied der zwei Zeiten die per Parameter übergeben wurden.
        /// </summary>
        /// <param name="endTime">Endtime as String</param>
        /// <param name="startTime">Starttime as String</param>
        /// <returns>Timedifference as String</returns>
        public static String calcTimeDifference(String endTime, String startTime)
        {
            DateTime endDate = Convert.ToDateTime(endTime);
            DateTime startDate = Convert.ToDateTime(startTime);
            TimeSpan span = startDate.Subtract(endDate);
            return span.ToString();
        }
    }
}
