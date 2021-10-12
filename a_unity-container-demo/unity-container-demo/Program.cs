using System;
using Unity;

namespace unity_container_demo
{
    public interface ICar
    {
        int Run();
    }

    public class BMW : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }
    }

    public class Ford : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }
    }

    public class Audi : ICar
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }

    }

    public class Driver
    {
        private ICar _car = null;
        
        public Driver(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile", _car.GetType().Name, _car.Run());
        }
    }

    class Program
    {
        static void Main()
        {
            /**/
            Driver driver1 = new Driver(new Audi());
            driver1.RunCar();

            /* ==================== REGISTER AND RESOLVE */
            Console.WriteLine("==================== REGISTER AND RESOLVE");
            IUnityContainer container = new UnityContainer();
            
            /* Here, container.RegisterType<ICar, BMW>() requests Unity to
             * create an object of the BMW class and inject it through a
             * constructor whenever you need to inject an object of ICar.*/
            /* Now, we can instantiate the Driver class using Unity
             * container without using the new keyword as shown below. */
            container.RegisterType<ICar, BMW>(); // Map ICar with BMW 
            container.RegisterType<ICar, Audi>();
            /*ICar is mapped to both BMW and Audi. However, Unity will inject
             * Audi EVERY TIME because it has been registered last. */

            //Resolves dependencies and returns the Driver object 
            Driver drv2 = container.Resolve<Driver>();
            /* The Driver class is a dependency of ICar.
             * The BMW object is created and injected because we register
             * the BMW type with ICar. */
            drv2.RunCar();

            /* ==================== REGISTER NAMED TYPE */
            Console.WriteLine("==================== REGISTER NAMED TYPE");
            IUnityContainer container2 = new UnityContainer();
            container2.RegisterType<ICar, BMW>();
            container2.RegisterType<ICar, Audi>("LuxuryCar");

            ICar bmw = container2.Resolve<ICar>(); // returns the BMW object
            ICar audi = container2.Resolve<ICar>("LuxuryCar"); // returns the BMW object
            /* As you can see above, we have mapped ICar with both the BMW
             * and the Audi class. However, we have given the name "LuxuryCar"
             * to the ICar-Audi mapping. */
            Console.WriteLine(bmw);
            Console.WriteLine(audi);

            /* Long Example */
            IUnityContainer container3 = new UnityContainer();
            container3.RegisterType<ICar, BMW>();
            container3.RegisterType<ICar, Audi>("LuxuryCar2");

            // Registers Driver type            
            container3.RegisterType<Driver>("LuxuryCarDriver",new Unity.Injection.InjectionConstructor(container3.Resolve<ICar>("LuxuryCar2")));

            Driver driver4 = container3.Resolve<Driver>();// injects BMW
            driver4.RunCar();

            Driver driver5 = container3.Resolve<Driver>("LuxuryCarDriver");// injects Audi
            driver5.RunCar();

            /* ==================== REGISTER INSTANCE */
            Console.WriteLine("==================== REGISTER INSTANCE");
            IUnityContainer container4 = new UnityContainer();
            ICar audi2 = new Audi();
            container4.RegisterInstance<ICar>(audi2);

            Driver driver6 = container4.Resolve<Driver>();
            driver6.RunCar();
            driver6.RunCar();

            Driver driver7 = container4.Resolve<Driver>();
            driver7.RunCar();
        }
    }
}
