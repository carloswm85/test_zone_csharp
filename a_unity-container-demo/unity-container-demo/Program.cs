using System;
using Unity;

namespace unity_container_demo
{
    // Interfaces
    public interface ICar
    {
        int Run();
    }

    public interface ICarKey
    {

    }

    // CARS
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

    // KEYS
    public class BMWKey : ICarKey
    {

    }

    public class AudiKey : ICarKey
    {

    }

    public class FordKey : ICarKey
    {

    }


    // DRIVER
    public class Driver
    {
        private ICar _car = null;
        
        public Driver(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("D1. Running {0} - {1} mile", _car.GetType().Name, _car.Run());
        }
    }

    // Multiple Parameters Class
    public class Driver2
    {
        private ICar _car = null;
        private ICarKey _key = null;

        public Driver2(ICar car, ICarKey key)
        {
            _car = car;
            _key = key;
        }

        public void RunCar()
        {
            Console.WriteLine("D2. Running {0} with {1} - {2} mile", _car.GetType().Name, _key.GetType().Name, _car.Run());
        }
    }

    // Multiple Constructor Class
    public class Driver3
    {
        private ICar _car = null;

        [InjectionConstructor]
        public Driver3(ICar car)
        {
            _car = car;
        }
        /* As you can see, the Driver3 class includes two constructors.
         * So, we have used the [InjectionConstructor] attribute to
         * indicate which constructor to call when resolving the Driver
         * class.*/

        public Driver3(string name)
        {
        }

        public void RunCar()
        {
            Console.WriteLine("D3. Running {0} - {1} mile", _car.GetType().Name, _car.Run());
        }
    }

    // With primitive type parameter
    public class Driver4
    {
        private ICar _car = null;
        private string _name = string.Empty;

        public Driver4(ICar car, string driverName)
        {
            _car = car;
            _name = driverName;
        }

        public void RunCar()
        {
            Console.WriteLine("{0} is running {1} - {2} mile ",
                            _name, _car.GetType().Name, _car.Run());
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

            // We can register and resolve different types using Unity container.


            /* ==================== MULTIPLE PARAMETERS */
            Console.WriteLine("==================== MULTIPLE PARAMETERS");
            IUnityContainer container5 = new UnityContainer();
            container5.RegisterType<ICar, Audi>();
            container5.RegisterType<ICarKey, AudiKey>();


            Driver2 driver8 = container5.Resolve<Driver2>();
            driver8.RunCar();


            /* ==================== MULTIPLE CONSTRUCTORs */
            Console.WriteLine("==================== MULTIPLE CONSTRUCTORs");
            /* As you can see, the Driver3 class includes two constructors. So,
             * we have used the [InjectionConstructor] attribute to indicate
             * which constructor to call when resolving the Driver3 class. */
            // see Driver3 class.

            /* You can configure the same thing as above at run time instead
             * of applying the [InjectionConstructor] attribute by passing
             * an object of the InjectionConstructor in the RegisterType()
             * method, as shown below.*/
            IUnityContainer container6 = new UnityContainer();
            IUnityContainer container7 = new UnityContainer();
            // use
            container6.RegisterType<Driver3>(new Unity.Injection.InjectionConstructor(new Ford()));

            Driver3 driver9 = container6.Resolve<Driver3>();
            driver9.RunCar();

            //or 
            container7.RegisterType<ICar, Ford>();
            container7.RegisterType<Driver3>(new Unity.Injection.InjectionConstructor(container7.Resolve<ICar>()));

            Driver3 driver10 = container7.Resolve<Driver3>();
            driver10.RunCar();

            /* ==================== WITH PRIMITIVE DATA TYPE PARAMETER */
            Console.WriteLine("==================== WITH PRIMITIVE DATA TYPE PARAMETER ");

            IUnityContainer container8 = new UnityContainer();

            container8.RegisterType<Driver4>(new Unity.Injection.InjectionConstructor(new object[] { new Audi(), "Steve" }));

            Driver4 driver11 = container8.Resolve<Driver4>(); // Injects Audi and Steve
            driver11.RunCar();
        }
    }
}
