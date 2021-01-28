using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Controller
    {
        private static Controller OnlyController = null;

        public CarFactory carFactory;

        private Controller()
        {  }

        public static Controller GetController()
        {
            if (OnlyController == null)
            {
                OnlyController = new Controller();
            }
            return OnlyController;
        }

        public void SetCarFactory(CarFactory carFactory)
        {
            this.carFactory = carFactory;
        }

        public void CreateAndMoveCar()
        {
            Motor motor = carFactory.CreateMotor();
            Underframe underframe = carFactory.CreateUnderframe();
            Bulk bulk = carFactory.CreateBulk();

            bulk.CarryLoad();
            underframe.Control();
            motor.StartMotor();
            motor.PutInMotion();
        }
    }
}
