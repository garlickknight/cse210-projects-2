

public abstract class Goal()
{
    private string name;
    private string description;
    private int points;

    public void goal(string _name, string _description, int _points)
    {
        points = _points;
        name = _name;
        description = _description;
    }
    public void getNameSetter(string _name)
    {
        name = _name;
    }
    public void getdescriptionSetter(string _description)
    {
        description = _description;
    }

    public void GetPointsSetter(int _points)
    {
        points = _points;
    }
    public string GetName()
    {
        return name;
    }
    public string GetDescription()
    {
        return description;
    }

    public int GetPoints()
    {
        return points;
    }

    protected int PointsValue()
    {
        return points;
    }


    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual string GetStatus()
    {
        return $"{name} ({description})";
    }
    


}