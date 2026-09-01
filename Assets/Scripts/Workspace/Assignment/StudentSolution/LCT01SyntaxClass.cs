using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    public class Car
    {
        public string Name;
        public float Speed;
        public string Color;

        public void Move()
        {
            Debug.Log("Car is moveing");
        }

        public void Turn()
        {
            Debug.Log("Car is turning");
        }

        public void Honk()
        {
            Debug.Log("Car is honking");
        }
    }
    public class LCT01SyntaxClass
    {
        public void Start()
        {
            Car car = new Car();
            Car car2 = new();

            car.Name = "Honda";
            car.Speed = 80;
            car.Color = "Black";

            car.Move();
            car.Turn();
            car.Honk();
        }
    }
}
