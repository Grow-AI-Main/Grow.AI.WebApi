namespace Grow.AI.WebApi.Models
{
    public class PersonInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<EducationInfo> Educations { get; set; }
    }

    public class EducationInfo
    {
        public int DegreeLevel { get; set; }
        public string Degree { get; set; }
        public string DegreeField { get; set; }
        public string DegreeInstitutionName { get; set; }
    }
}
