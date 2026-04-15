

using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

public class Cycling : Exercise
{
    private float speed;
    private float minutes;
    public Cycling(string date, float length, float _speed) : base(date, length)
    {
        speed = _speed;
        minutes = length;

    }

    public override float getdistance()
    {
        float distance = (speed * minutes) / 60;
        return distance;
    }

    public override float getpace()
    {
        float pace = 60 / speed;
        return pace;
    }

    public override float getspeed()
    {
        return speed;
    }
    public override string gettype()
    {
        return ("Cycling");
        
    }

    
}