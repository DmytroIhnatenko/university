namespace university.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public double Date { get; }
        public int RoomId { get; set; }
        public string SubjectName { get; set; }
        public int StudentGroupId { get; set; }

        public virtual Room Room { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual StudentGroup StudentGroup { get; set; }

        public Class()
        {
            ClassId = -1;
            Date = 06.11;
            RoomId = -1;
            SubjectName ="Math";
            StudentGroupId = -1;
        }

        public Class(int classId, double date, int roomId, string subjectName, int studentGroupId)
        {
            ClassId = classId;
            Date = date;
            RoomId = roomId;
            SubjectName = subjectName;
            StudentGroupId = studentGroupId;
           
        }
    }
}
