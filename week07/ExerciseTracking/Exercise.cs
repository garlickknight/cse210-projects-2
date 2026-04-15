using System.Runtime.CompilerServices;

public abstract class Exercise
{
    private string date;
    private float length;

    public Exercise(string _date, float _minutes)
    {
        date = _date;
        length = _minutes;
    }

    public string getdate()
    {
        return date;
    }
    public float getlength()
    {
        return length;
    }

    public abstract float getdistance();
    public abstract float getspeed();
    public abstract float getpace();

    public string getSummary(string type)
    {
        return $"{getdate()} {type} {getlength()}min: Distance {getdistance()} miles, Speed {getspeed()}mph, pace: {getpace()} min per mile";
    }



}