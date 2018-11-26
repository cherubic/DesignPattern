using System;
using System.Collections.Generic;

namespace DesignPattern.FilterPattern
{
    public class CriteriaFemale : ICriteria
    {
        public CriteriaFemale()
        {
        }

        public List<Person> MeetCriteria(List<Person> peoples)
        {
            List<Person> femalePeoples = new List<Person>();

            foreach (var people in peoples)
            {
                if (people.GetGender().ToLower() == "female")
                {
                    femalePeoples.Add(people);
                }
            }

            return femalePeoples;
        }
    }
}
