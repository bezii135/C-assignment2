using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cAssignment
{
    class program
    {
     

        static void Main(String[] args)
        {

            Console.WriteLine("hello Welcome to our  online liqour store");
            Console.Write("enter your name");
            String name = Console.ReadLine();
            Console.Write("enter your age");
            Double age = Convert.ToDouble( Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("hello" + name +"  " +age + " is not legal age to buy Liqour");
                Console.WriteLine("GOOD BYE!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("hello" + name +"   " +age + " is legal age to buy Liqour");

                Console.WriteLine("Here are the list of liqour");
                String[] liqure_cabnet = { "henesey", "burben" ,"Absante", "Absinthe", "Advocaat"};
                int[] price_respectfully = { 140, 200, 123, 245, 167 };
                
                liqure_cabnet[0] = "1.Henesey"; price_respectfully[0] = 140;
                liqure_cabnet[1] = "2.Burben"; price_respectfully[1] = 200;
                liqure_cabnet[2] = "3.Absente"; price_respectfully[2] =123;
                liqure_cabnet[3] = "4.Absinthe"; price_respectfully[3] = 245;
                liqure_cabnet[4] = "5.Advocate"; price_respectfully[3] = 167;


                Console.WriteLine(liqure_cabnet[0]); Console.WriteLine(price_respectfully[0]);
                Console.WriteLine(liqure_cabnet[1]); Console.WriteLine(price_respectfully[1]);
                Console.WriteLine(liqure_cabnet[2]); Console.WriteLine(price_respectfully[2]);
                Console.WriteLine(liqure_cabnet[3]); Console.WriteLine(price_respectfully[3]);
                Console.WriteLine(liqure_cabnet[4]); Console.WriteLine(price_respectfully[4]);

                Console.WriteLine("Enter your choice");
                int answer = Convert.ToInt32(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Henesey");
                        goto default;
                    case 2:
                        Console.WriteLine("Burben");
                        goto default;
                    case 3:
                        Console.WriteLine("Absente");
                        goto default;
                    case 4:
                        Console.WriteLine("Absinthe");
                        goto default;
                    case 5:
                       
                            Console.WriteLine("Advocate");
                        goto default;
                    default:
                        Console.WriteLine("Entered value is: " + answer);
                        break;
                }


              
                Console.WriteLine("Your choice has been recorded delivery is in 15 Days");

                Console.WriteLine("THANK YOU FOR SHOPING WITH US GOOD BYE!");
 


                 Console.ReadLine();
            }








            }




}





}



