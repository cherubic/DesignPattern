using System;
using System.Collections.Generic;

namespace DesignPattern.FilterPattern
{
    public class OrCriteria : ICriteria
    {
        private ICriteria criteria;
        private ICriteria otherCriteria;

        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> peoples)
        {
            var firstCriteria = criteria.MeetCriteria(peoples);
            var secondCriteria = otherCriteria.MeetCriteria(peoples);

            foreach (var item in secondCriteria)
            {
                if (!firstCriteria.Contains(item))
                {
                    firstCriteria.Add(item);
                }
            }

            return firstCriteria;
        }
    }
}
