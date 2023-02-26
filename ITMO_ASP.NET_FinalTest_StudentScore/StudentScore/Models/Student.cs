using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentScore.Models
{
    public class Student
    {
        public virtual int StudentId { get; set; }
        [DisplayName("Имя")]

        public virtual string FirstName { get; set; }
        [DisplayName("Фамилия")]
        public virtual string LastName { get; set; }
        [DisplayName("Учебная группа")]        
        public virtual string Group { get; set; }
        [DisplayName("Баллы за теорию")]
        public virtual int ScoreTask1 { get; set; }
        [DisplayName("Баллы за практику")]
        public virtual int ScoreTask2 { get; set; }
        [DisplayName("Итоговый балл")]
        public virtual int FinalScore { get; set; }
    }
}