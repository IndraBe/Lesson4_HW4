using System;

namespace Lesson4_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = false;

            if (isTrue)
            {
                Console.WriteLine("I'm in IF condition");
            }
            else
            {
                Console.WriteLine("I'm in ELSE condition");
            }


            int age = 55;

            if (age < 10)
            {
                Console.WriteLine("Tu esi bērns");
            }
            
            else if (age < 18)
            {
                Console.WriteLine("Tu esi jaunietis");
            }
            else if (age >= 70)
            {
                Console.WriteLine("Tu esi seniors");
            }
            else
            {
                Console.WriteLine("Tu esi darbspējīgā vecumā");
            }



            int switchCase = 25;        //25 salīdzina ar '1', '2' un '3'. Salīdzina vai vertiba ir vienada kāda ir pie katra case.

            switch (switchCase)         // Izmanto kad daudzas parslegšana, pie boolean neizmanto, tur ir IF...ELSE...
            {
                case 1:                     // Nevar būt divi case ar vienādām vērtībām
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                default:
                    Console.WriteLine("Do not know what this was");
                    break;

            }

            //int name = "Indra";        //25 salīdzina ar '1', '2' un '3'. Salīdzina vai vertiba ir vienada kāda ir pie katra case.

            //switch (name)
            //{
            //    case "a":                     // Nevar būt divi case ar vienādām vērtībām
            //        Console.WriteLine("Case 1");
            //        break;
            //    case "b":
            //        Console.WriteLine("Case 2");
            //        break;
            //    case "c":
            //        Console.WriteLine("Case 3");
            //        break;
            //    case "Indra":
            //        Console.WriteLine("Case 4");
            //        break;
            //    default:
            //        Console.WriteLine("Do not know what this was");
            //        break;
            //}
        }
    }
}
