using AgileManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Domain.models
{
    public class Sprint : Entity
    {
        public string SprintName { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
       // public int SprintNo { get; set; }

        public Sprint(DateTime startDate, DateTime endDate)
        {
            Id = Guid.NewGuid().ToString();
            SetDate(startDate, endDate);
            //SprintName = sprintName;
            //SprintNo = siraNo;
        }

        public void SetDate(DateTime startDate, DateTime endDate)
        {
            if (startDate == null || EndDate == null)
            {
                throw new Exception("start date ve enddate boş geçilemez");
            }
            StartDate = startDate;
            EndDate = endDate;
        }

        public void SetSprintName(int sprintCount)
        {
            //if (string.IsNullOrEmpty(sprintName))
            //{
            //    throw new Exception("İsim boş kalamaz");
            //}
            this.SprintName = "Sprint" + sprintCount;
        }


    }

}


