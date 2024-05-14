public class Car
{
    public string m;
    public int y;
    public Car(string model, int year)
    {
        this.m = model;
        this.y = year;

    }

    List<string> driver = new List<string>()
    {
        "Lehi", "Nephi", "Lemual", "Lamon"
    }; 

    public void Info()
    {
        Console.WriteLine(this.m);
        Console.WriteLine(this.y);
    }

    public void Driver()
    {
        Random randomGen = new Random();
        int randomNum = randomGen.Next(0,3);
        Console.WriteLine(driver[randomNum]);
    }
}