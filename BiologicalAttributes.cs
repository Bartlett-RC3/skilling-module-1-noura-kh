using System;

public class BiologicalAttributes 
{
    float  RunningSpeed= 7.5f;
    float MaxRunningSpeed = 10;
    int AverageLife;
    bool FlightAbility;
    string Classification;
    bool NightVision;

    public BiologicalAttributes(float_RunningSpeed, int_AverageLife , string_Classification , bool_NightVision)
    {

        RunningSpeed = _RunningSpeed;
        AverageLife = _AverageLife;
        FlightAbility = _FlightAbility;
        Classification = _Classification;
        NightVision = _NightVision;
        MaxRunningSpeed = _MaxRunningSpeed;
    }

    public float RunningSpeedPrecentage()
    {
        return RunningSpeed / MaxRunningSpeed;
    }

    

}
