namespace Altreal.Motivate.Shared.Models
{
    public class Statistic
    {
        public Guid BehaviorId { get; set; }
        public double Max { get; set; }
        public double MaxRaw { get; set; }
        public double Mean { get; set; }
        public double MeanRaw { get; set; }
        public double Min { get; set; }
        public double MinRaw { get; set; }
        public double NotApply { get; set; }
        public double StandardDeviation { get; set; }
        public double StandardDeviationRaw { get; set; }

        public static List<Statistic> Build(List<PulseSurveyResult> results)
        {
            var response = new List<Statistic>();

            var behaviorResults = results.SelectMany(r => r.Results).ToList();
            var behaviors = behaviorResults.Select(br => br.Behavior.Id).Distinct().ToList();

            foreach (var behavior in behaviors)
            {
                var availableResults = behaviorResults.Where(br => br.Behavior.Id == behavior).ToList();

                var mean = CalculateMean(availableResults.Select(ar => ar.Score).ToList());
                var sd = CalculateStandardDeviation(availableResults.Select(ar => ar.Score).ToList());

                var meanRounded = Math.Round(mean, MidpointRounding.AwayFromZero);
                var sdRounded = Math.Round(sd, MidpointRounding.AwayFromZero);

                var min = mean - sd;
                var max = mean + sd;

                var minRounded = meanRounded - sdRounded;
                var maxRounded = meanRounded + sdRounded;

                // This is to keep the chart from overflowing
                if (minRounded < 1)
                    minRounded = 0.25;
                if (maxRounded > 7)
                    maxRounded = 7.75;

                response.Add(new Statistic
                {
                    BehaviorId = behavior,
                    Min = minRounded,
                    Max = maxRounded,
                    StandardDeviation = sdRounded,
                    MaxRaw = max,
                    MinRaw = min,
                    StandardDeviationRaw = sd,
                    NotApply = CalculateNotApply(availableResults.Select(ar => ar.Score).ToList()),
                    MeanRaw = mean,
                    Mean = meanRounded
                });
            }


            return response;
        }

        public static double CalculateMean(List<int> values)
        {
            if (!values.Any())
                return 0;
            var sum = 0.0;
            var count = 0.0;
            foreach (var v in values)
            {
                if (v != -1)
                {
                    sum += v;
                    count++;
                }
            }

            if (count <= 0)
                return 0;

            return sum / count;
        }

        public static double CalculateStandardDeviation(List<int> values)
        {
            if (values.Count < 2)
                return 0;

            var arr = new List<int>();
            foreach (var v in values)
            {
                if (v != -1)
                {
                    arr.Add(v);
                }
            }

            if (!arr.Any())
                return 0;

            var mu = arr.Sum() / arr.Count;
            var ans = 0.0;
            foreach (var a in arr)
            {
                ans += Math.Pow((a - mu), 2);
            }

            return Math.Sqrt(Math.Sqrt(ans / arr.Count));

        }

        public static double CalculateNotApply(List<int> values)
        {
            var count = 0.0;
            if (!values.Any())
                return 0;
            foreach (var v in values)
            {
                if (v <= 0)
                {
                    count++;
                }
            }

            return count;
        }

    }
}