using System;
using System.Collections.Generic;

namespace DesignPattern.FilterPattern
{
    public class AndCriteria : ICriteria
    {
        private ICriteria criteria;
        private ICriteria otherCriteria;

        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> peoples)
        {
            var firstCriteriaPersons = criteria.MeetCriteria(peoples);
            return otherCriteria.MeetCriteria(firstCriteriaPersons);
        }
    }
}
