using System;
using System.Collections.Generic;

namespace Infinite.DesignPattern.Singleton
{
    #region Without Singleton Implementation

    //public class CabService
    //{
    //    private List<string> cabDrivers = new List<string>();
    //    private int count = 0;

    //    public CabService()
    //    {
    //        cabDrivers.AddRange(new string[] { "Rajini", "Kamal", "Vijay", "Ajith" });
    //    }

    //    public string GetNextAvailableDriver()
    //    {
    //        string result = cabDrivers[count];
    //        count++;
    //        if (count >= cabDrivers.Count)
    //        {
    //            count = 0;
    //        }
    //        return result;
    //    }
    //}


    #endregion

    public class CabService
    {
        private List<string> cabDrivers = new List<string>();
        private int count = 0;
        private static CabService cabService = new CabService();//Lazy Loading

        public static CabService GetInstance()
        {
            return cabService;
        }

        //Return instance using property
        //public static CabService Instance
        //{
        //    get
        //    {
        //        return cabService;
        //    }
        //}

        private CabService()
        {
            cabDrivers.AddRange(new string[] { "Rajini", "Kamal", "Vijay", "Ajith" });
        }

        public string GetNextAvailableDriver()
        {
            string result = cabDrivers[count];
            count++;
            if (count >= cabDrivers.Count)
            {
                count = 0;
            }
            return result;
        }
    }
    class Program
    {
        static CabService Customer1cabService = CabService.GetInstance();
        static CabService Customer2cabService = CabService.GetInstance();
        public static void Customer1NextDriver()
        {
            Console.WriteLine($"Next Available Driver for Customer 1 :{Customer1cabService.GetNextAvailableDriver()}");
        }

        public static void Customer2NextDriver()
        {
            Console.WriteLine($"Next Available Driver for Customer 2 :{Customer2cabService.GetNextAvailableDriver()}");
        }

        static void Main2(string[] args)
        {
            CabService cabService = CabService.GetInstance();
            //Console.WriteLine($"Next Available Driver :{cabService.GetNextAvailableDriver()}");

            for (int i = 0; i < 4; i++)
            {
                //Console.WriteLine($"Next Available Driver :{cabService.GetNextAvailableDriver()}");
                Customer1NextDriver();
                Customer2NextDriver();
            }
        }
    }
}
