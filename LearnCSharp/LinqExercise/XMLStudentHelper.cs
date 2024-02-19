using System.Xml.Linq;

public class XMLStudentHelper
{
    private string filePath;

    public XMLStudentHelper(string filePath)
    {
        this.filePath = filePath;
    }

    // Truy vấn sinh viên có điểm cao
    public void QueryHighScoreStudents(int minScore)
    {
        XDocument studentsDoc = XDocument.Load(filePath);
        var highScoreQuery = from student in studentsDoc.Descendants("Student")
                             where (int)student.Element("Score") > minScore
                             select new
                             {
                                 Id = student.Attribute("Id").Value,
                                 Name = student.Element("Name").Value,
                                 Score = student.Element("Score").Value
                             };

        foreach (var student in highScoreQuery)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Score: {student.Score}");
        }
    }

    // Thêm một sinh viên mới
    public void AddNewStudent(string id, string name, string score)
    {
        XDocument studentsDoc = XDocument.Load(filePath);
        studentsDoc.Root.Add(
            new XElement("Student", new XAttribute("Id", id),
                new XElement("Name", name),
                new XElement("Score", score)
            )
        );

        studentsDoc.Save(filePath);
    }

    // Cập nhật điểm số cho sinh viên
    public void UpdateStudentScore(string name, string newScore)
    {
        XDocument studentsDoc = XDocument.Load(filePath);
        var studentToUpdate = studentsDoc.Descendants("Student")
                                         .Where(s => s.Element("Name").Value == name)
                                         .FirstOrDefault();
        if (studentToUpdate != null)
        {
            studentToUpdate.SetElementValue("Score", newScore);
        }

        studentsDoc.Save(filePath);
    }
}
