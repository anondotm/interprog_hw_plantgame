// SUMMARY - this file stores enums, structs associated with plants

// states for plants
public enum PlantStates
{
    Dead,
    Underwatered,
    Healthy,
    Overwatered,
}

// struct which contains a Min, Max
public struct MinMax
{
    public int min, max;

    public MinMax(int min, int max)
    {
        this.min = min;
        this.max = max;
    }
}