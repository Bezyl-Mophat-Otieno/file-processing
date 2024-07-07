namespace file_processing;

public class UserExcel
{
    // 0	First Name	Last Name	Gender	Country	Age	Date	Id

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    public string Gender { get; set; } = null!;
    public string Country { get; set; } = null!;
    public int Age { get; set; } = 0;
    public DateTime Date { get; set; } = DateTime.Now;
    public int Id { get; set; } = 0;

}
