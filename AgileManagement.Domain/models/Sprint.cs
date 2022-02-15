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
        public int SprintNo { get; set; }

        //public Sprint(string sprintName, int siraNo,DateTime startDate,DateTime endDate)
        //{
        //    Id = Guid.NewGuid().ToString();
        //    SetDate(startDate, endDate);
        //    SprintName = sprintName;
        //    SprintNo = siraNo;
        //}

        //public void SetDate(DateTime startDate, DateTime endDate)
        //{
        //    if (startDate == null)
        //    {
        //        throw new Exception("Tarih boş kalamaz");
        //    }
        //    if (endDate == null)
        //    {
        //        throw new Exception("Tarih boş kalamaz");
        //    }
        //}

        //public void SetSprintName(string sprintName)
        //{
        //    if (string.IsNullOrEmpty(sprintName))
        //    {
        //        throw new Exception("İsim boş kalamaz");
        //    }
        //}

        //public void AddSprintTime(DateTime startDate, DateTime endDate)
        //{

        //    if (endDate.Minute < startDate.Minute)
        //    {
        //        throw new Exception("Bitiş tarihi başlangıç tarihinden önce olamaz.");
        //    }
        //    if (DateTime.Now > startDate)
        //    {
        //        throw new Exception("Geçmiş tarih girilemez.");
        //    }

        //    this.StartDate = startDate;
        //    this.EndDate = endDate;
        //}

    }

}


