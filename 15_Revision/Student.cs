class Trainer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Experience { get; set; }
}

class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public int? TrainerId { get; set; }
}