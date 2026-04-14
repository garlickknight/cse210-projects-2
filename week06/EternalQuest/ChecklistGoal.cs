public class ChecklistGoal : Goal
{
    private int currentcount;
    private int targetcount;
    private int bonus;

    public ChecklistGoal(int _targetcount, int _bonus)
    {
        targetcount = _targetcount;
        bonus = _bonus;
        currentcount = 0;
    }

    public override int RecordEvent()
    {
        if (currentcount >= targetcount)
        {
            return 0;
        }

        currentcount++;
        int earned = PointsValue();

        if (currentcount == targetcount)
        {
            earned += bonus;
        }

        return earned;
    }

    public int GetCurrentCount()
    {
        return currentcount;
    }

    public int GetTargetCount()
    {
        return targetcount;
    }

    public int GetBonus()
    {
        return bonus;
    }

    public void SetCurrentCount(int value)
    {
        currentcount = value;
    }

    public bool IsComplete()
    {
        return currentcount >= targetcount;
    }

    public override string GetStatus()
    {
        string box = IsComplete() ? "[X]" : "[ ]";
        return $"{box} {base.GetStatus()} -- completed {currentcount}/{targetcount}";
    }
}