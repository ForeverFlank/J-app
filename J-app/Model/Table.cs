namespace J_app.Model;

/*
public class Table
{
    public Period[] Period { get; set; }
}
*/
public class Period
{
    public char Week { get; set; }
    public int Day { get; set; }
    public int PeriodNumber { get; set; }
    public Subject Subject { get; set; }
    public string Room { get; set; }
    /*
    public Period(char week, int day, int periodNumber, Subject subject, string room)
    {
        Week = week;
        Day = day;
        PeriodNumber = periodNumber;
        Subject = subject;
        Room = room;
    }
    */
}
public class Subject
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Classroom { get; set; }
    public string Sites { get; set; }
    /*
    public Subject(string code, string name, string classroom, string sites)
    {
        Code = code;
        Name = name;
        Classroom = classroom;
        Sites = sites;
    }
    */
}