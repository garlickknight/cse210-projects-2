public class EternalGoal: Goal
{

    
    public override int RecordEvent()
    {

        return PointsValue();
    }
    public override string GetStatus()
    {
        return $"[ ] {base.GetStatus()}";
    }
    
}