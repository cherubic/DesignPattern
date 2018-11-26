using System;
using System.Collections.Generic;
namespace DesignPattern.FilterPattern
{
    public class CriteriaMale : ICriteria
    {
        public CriteriaMale()
        {
        }

        public List<Person> MeetCriteria(List<Person> peoples)
        {
            List<Person> malePeoples = new List<Person>();

            foreach (var people in peoples)
            {
                if (people.GetGender().ToLower() == "male")
                {
                    malePeoples.Add(people);
                }
            }

            return malePeoples;
        }
    }
}
