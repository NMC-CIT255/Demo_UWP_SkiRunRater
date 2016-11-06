using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_UWP_SkiRunRater
{
    public static class SkiRunManager
    {
        public static List<SkiRun> GetSkiRuns()
        {
            List<SkiRun> SkiRuns = new List<SkiRun>();

            // initialize the IList of high scores - note: no instantiation for an interface
            SkiRuns.Add(new SkiRun() { ID = 1, Name = "Buck", Vertical = 200 });
            SkiRuns.Add(new SkiRun() { ID = 2, Name = "Buckaroo", Vertical = 325 });
            SkiRuns.Add(new SkiRun() { ID = 3, Name = "Hoot Owl", Vertical = 655 });
            SkiRuns.Add(new SkiRun() { ID = 4, Name = "Shelburg's Chute", Vertical = 1023 });

            return SkiRuns;
        }
    }
}
