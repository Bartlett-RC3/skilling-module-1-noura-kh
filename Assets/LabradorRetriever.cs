using System;
using UnityEngine;
namespace MyDogs
{


    public class LabradorRetriever : IDogClass 
    {

        DogClass DogClassManager = new DogClass();
        public int Age
        {
            get
            {
                return DogClassManager.Age;
            }
            set
            {
                DogClassManager.Age = value;
            }
        }

        public int LifeExpectancy
        {
            get
            {
                return DogClassManager.LifeExpectancy ;
            }
            set
            {
                DogClassManager.LifeExpectancy = value;
            }
        }

        public string Type
        {
            get
            {
                return DogClassManager.Type;
            }
            set
            {
                DogClassManager.Type = value;
            }
        }
        
        public string Color
        {
            get
            {
                return DogClassManager.Color;
            }
            set
            {
                DogClassManager.Color = value;
            }
        }

        public int RunningSpeed
        {
            get
            {
                return DogClassManager.RunningSpeed;
            }
            set
            {
                DogClassManager.RunningSpeed = value;
            }
        }

        public int MaxRunningSpeed
        {
            get
            {
                return DogClassManager.MaxRunningSpeed;
            }
            set
            {
                DogClassManager.MaxRunningSpeed = value;
            }
        }



        

        public LabradorRetriever()
	    {
            
            EnhancedRunningSpeed();

	    }
        
        public void  EnhancedRunningSpeed()
        {
            for ( int i = runningSpeed; i<=maxRunningSpeed; i++)
            {
                runningSpeed = i;
                Debug.Log(" The current enhanced speed prcentage is " + runningSpeed + "%");
            }
        }

        public float CurrentAging()
        {
            return DogClassManager.CurrentAging();
        }



    }


}