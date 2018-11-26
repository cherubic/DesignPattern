using System;
using System.Collections.Generic;

namespace DesignPattern.FilterPattern
{
    public class CriteriaSingle : ICriteria
    {
        public CriteriaSingle()
        {
        }

        public List<Person> MeetCriteria(List<Person> peoples)
        {
            var singleCriteria = new List<Person>();

            foreach (var people in peoples)
            {
                if (people.GetMaritalStatus().ToLower() == "single")
                {
                    singleCriteria.Add(people);
                }
            }

            return singleCriteria;
        }
    }
}
