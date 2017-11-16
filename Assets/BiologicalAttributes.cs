using System;


public class BiologicalAttributes 
{
    float  RunningSpeed;
    float MaxRunningSpeed;
    int AverageLife;
    bool FlightAbility;
    string Classification;
    bool NightVision;

    public BiologicalAttributes(string CreatureType , bool Flightability , float CurrentSpeed , int EstimatedLife)
    {
        CreatureType = Classification;
        Flightability = FlightAbility;
        CurrentSpeed = RunningSpeed;
        EstimatedLife = AverageLife;



        
    }

    public virtual float  SetSpeed()
    {
        return RunningSpeed;
    }

    public float RunningSpeedPrecentage()
    {
        return RunningSpeed / MaxRunningSpeed;
    }

    

}
