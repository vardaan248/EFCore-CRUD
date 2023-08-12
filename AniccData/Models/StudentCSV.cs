using System.ComponentModel.DataAnnotations;

namespace AniccData.Models
{
    public class StudentCSV
    {
        [Key]
        public string Student_ID { get; set; }
        public string gender { get; set; }
        public string NationalITy { get; set; }
        public string PlaceofBirth { get; set; }
        public string StageID { get; set; }
        public string GradeID { get; set; }
        public string SectionID { get; set; }
        public string Topic { get; set; }
        public string Semester { get; set; }
        public string Relation { get; set; }
        public int raisedhands { get; set; } 
        public int VisITedResources { get; set; }
        public int AnnouncementsView { get; set; }
        public int Discussion { get; set; }
        public string ParentAnsweringSurvey { get; set; }
        public string ParentschoolSatisfaction { get; set; }
        public string StudentAbsenceDays { get; set; }
        public int Student_Marks { get; set; }
        public string Class { get; set; }
    }
}
