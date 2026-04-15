public class Swimming : Exercise
{
    private float laps;

    public Swimming(string date, float length, float _laps) : base(date, length)
    {
        laps = _laps;

    }

    public override float getdistance()
    {
        float distance = (laps * 50 / 1000f) * 0.62f;
        return distance;
    }

    public override float getspeed()
    {
        return (getdistance() / getlength()) * 60;
    }

    public override float getpace()
    {
        return getlength() / getdistance();
    }
}