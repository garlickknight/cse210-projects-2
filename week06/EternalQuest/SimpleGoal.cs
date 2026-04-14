public class SimpleGoal : Goal
{
    private bool complete;

    public override int RecordEvent()
    {
        if (complete)
        {
            return 0;
        }

        complete = true;
        return PointsValue();
    }

    public bool IsComplete()
    {
        return complete;
    }

    public void SetComplete(bool value)
    {
        complete = value;
    }

    public override string GetStatus()
    {
        string box = complete ? "[X]" : "[ ]";
        return $"{box} {base.GetStatus()}";
    }
}