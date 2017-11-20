using System;


namespace MyDogs {


    public interface IDogClass
    {

        int Age { get; set; }
        int LifeExpectancy { get; set; }
        string Type { get; set; }
        string Color { get; set; }
        int RunningSpeed { get; set; }
        int MaxRunningSpeed { get; set; }


        float CurrentAging();
        void EnhancedRunningSpeed();
        

    }


    







    public class DogClass : IDogClass
    {

        public int Age { get; set; }
        public int LifeExpectancy { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int RunningSpeed { get; set; }
        public int MaxRunningSpeed { get; set; }


        public DogClass (int _Age , int _LifeExpectancy , string _Type, string _Color , int _RunningSpeed)
        {
            Age = _Age;
            LifeExpectancy = _LifeExpectancy;
            Type = _Type;
            Color = _Color;
            RunningSpeed = _RunningSpeed;
            



        }


        public DogClass()
	    {
            MaxRunningSpeed = 40;
            LifeExpectancy = 10;
        }


        public float CurrentAging()
        {
            return (Age / (float)LifeExpectancy)* 100;
        }

        public virtual void  EnhancedRunningSpeed()
        {
              RunningSpeed = MaxRunningSpeed - (LifeExpectancy / 2);
        }

    



    }

}
