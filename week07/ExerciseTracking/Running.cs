public class Running : Exercise
{
    private float distance;

    public Running(string date, float length, float _distance) : base(date, length)
    {
        distance = _distance;
    }

    public override float getdistance()
    {
        return distance;
    }

    public override float getspeed()
    {
        return (distance / getlength()) * 60;
    }

    public override float getpace()
    {
        return getlength() / distance;
    }
}