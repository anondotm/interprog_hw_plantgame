using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantModel
{
    int WateredLevel;

    MinMax Healthy;
    MinMax Dead;

    public PlantModel(int WateredLevel, MinMax Healthy, MinMax Dead)
    {
        this.WateredLevel = WateredLevel;
        this.Healthy = Healthy;
        this.Dead = Dead;
    }

    // Getters

    public PlantStates GetState()
    {
        PlantStates state;
        if (IsUnderwatered())
        {
            state = PlantStates.Underwatered;
        }
        else if (IsHealthy())
        {
            state = PlantStates.Healthy;
        }
        else if (IsOverWatered())
        {
            state = PlantStates.Overwatered;
        }
        else
        {
            state = PlantStates.Dead;
        }
        return state;
    }

    public bool IsUnderwatered()
    {
        return (Dead.min < WateredLevel && WateredLevel < Healthy.min);
    }

    public bool IsHealthy()
    {
        return (Healthy.min < WateredLevel && WateredLevel < Healthy.max);
    }

    public bool IsOverWatered()
    {
        return (Healthy.max < WateredLevel && WateredLevel < Dead.max);
    }

    public bool IsDead()
    {
        return (WateredLevel <= Dead.min || Dead.max <= WateredLevel);
    }
}