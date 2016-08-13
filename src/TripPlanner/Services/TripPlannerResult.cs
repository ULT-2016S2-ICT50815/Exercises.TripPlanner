using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.Services
{
    // This class is an implementation of the Notification Pattern
    public class TripPlannerResult
    {
        private static readonly TripPlannerResult _success = new TripPlannerResult() { Succeeded = true };
        private List<TripPlannerError> _errors = new List<TripPlannerError>();

        public bool Succeeded { get; protected set; }

        public IEnumerable<TripPlannerError> Errors => _errors;

        public static TripPlannerResult Success => _success;

        public static TripPlannerResult Failed(params TripPlannerError[] errors)
        {
            var result = new TripPlannerResult { Succeeded = false };
            if (errors != null)
            {
                result._errors.AddRange(errors);
            }
            return result;
        }
    }
}