using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
			// THESE ARE THE VARIABLES WHICH WERE USED TO IDENTFY THE COST OF THE ITEMS, THE VARIABLES FOR THE QUANTITY, PROFIT, VAT AND PROFIT MARGIN. FURTHERMORE, IT SHOWS THE VARIABLES TO CALCULATE THE COST AT EACH STAGE.

            int Brick = 0;
            int Steel = 0;
            int Metal = 0;
            int quant = 0;
            int tquant = 0;
            int squant = 0;
            int mquant = 0;
            int tvalue = 0;
            int lvalue = 0;
            int rate;
            int labourcost;
            int hours;
            int VAT;
            int Profit;
            int TotalVAT;
            int TotalProf;
        
            Console.WriteLine("\t\t\t\t Welcome Screen");
            Console.ReadLine();
            Console.WriteLine("Program Designed and Developed by Jamie Ajibade. Student ID:4946560");
            Console.ReadLine();
            Console.WriteLine("Please enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("\r\nHello {0}, Welcome to SME Building Service Materials.", name);
            Console.WriteLine("Press the enter key to continue.");
            Console.ReadLine();
            Console.Clear();
            goto Menu;
            

            // THIS IS THE MAIN MENU FOR THE MATERIALS WHICH CAN BE BROUGHT.

           Menu:
            Console.WriteLine("Please choose from the following options");
            Console.WriteLine("1. Bricks");
            Console.WriteLine("2. Steel");
            Console.WriteLine("3. Metals");
            Console.WriteLine("4. Quotation");

           
           // THESE ARE THE CASES WHICH ARE USED WHEN EACH OPTION IS SELECTED FROM THE MAIN MENU ABOVE.

            int UserNum = int.Parse(Console.ReadLine());
            switch (UserNum)

                    // THESE ARE THE OPTIONS FOR TYPES OF BRICKS
            {
                case 1:
                Begin:
                    Console.WriteLine("You have selected Bricks, please choose from the following options");
                    Console.WriteLine("1. Stock Bricks");
                    Console.WriteLine("2. Wirecut Bricks");
                    Console.WriteLine("3. Fletton Bricksd");
                    Console.WriteLine("4. Back to Menu");
                    int UserChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the quantity - ");
                    quant = Convert.ToInt32(Console.ReadLine());

                    // THESE ARE THE PRICES FOR THE BRICKS FOR EACH CASE. IT IS TIMED BY THE QUANTITY WHICH IN INPUT IN BY THE USER AND ADDED TOGETHER TO DISPLAY THE TOTAL PRICE.

                    switch (UserChoice)
                    {
                        case 1:
                            Brick = (2000 * quant);
                            tvalue = (2000 * quant);
                            tquant = tquant + quant;
                            break;
                        case 2:
                           Brick = (1500 * quant);
                            lvalue = (1500 * quant);
                            tquant = tquant + quant;

                            break;
                        case 3:
                            Brick= (1700 * quant);
                            lvalue = (1700 * quant);
                            tquant = tquant + quant;
                            break;
                        case 4:
                            goto Menu;
                        default:
                            Console.WriteLine("Your choice {0} was invalid", UserChoice);
                            goto Begin;
                    }
                    Console.WriteLine("The price of your Bricks costs - {0:C}", Brick);
                    Console.WriteLine("Please press the enter key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    goto Menu;

                // THESE ARE THE OPTIONS FOR TYPES OF STEELS

                case 2:
                Line:
                    Console.WriteLine("You have selected Steels, please choose from the following options");
                    Console.WriteLine("1. Carbon Steel");
                    Console.WriteLine("2. Chromium Stainless Steel");
                    Console.WriteLine("3. Chromium");
                    Console.WriteLine("4. Back to Menu ");
                    int UserDecision = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the quantity - ");
                    quant = Convert.ToInt32(Console.ReadLine());


                    // THESE ARE THE PRICES FOR THE STEELS FOR EACH CASE. IT IS TIMED BY THE QUANTITY WHICH IN INPUT IN BY THE USER AND ADDED TOGETHER TO DISPLAY THE TOTAL PRICE.

                    switch (UserDecision)
                    {
                        case 1:
                            Steel = (2000 * quant);
                            tvalue = (2000 * quant);
                            squant = squant + quant;
                           
                            break;
                        case 2:
                            Steel = (1000 * quant);
                            tvalue = (1000 * quant);
                            squant = squant + quant;
                            break;


                        case 3:
                            Steel = (700 * quant);
                            tvalue = (700 * quant);
                            squant = squant + quant;
                            break;
                        case 4:
                            Steel = (2500 * quant);
                            tvalue = (2500 * quant);
                            squant = squant + quant;
                            break;
                        default:
                            Console.WriteLine("Your choice {0} was invalid", UserDecision);
                            goto Menu;
                    }
                    Console.WriteLine("The price of your Steels costs - {0:C}", Steel);
                    Console.WriteLine("Please press the enter key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    goto Menu;



                // THESE ARE THE OPTIONS FOR TYPES OF METALS

                case 3:
                Found:
                    Console.WriteLine("You have selected Metals, please choose from the following options");
                    Console.WriteLine("1. Silver");
                    Console.WriteLine("2. Copper");
                    Console.WriteLine("3. Lead");
                    Console.WriteLine("4. Back to Menu");
                    int UserPick = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the quantity - ");
                    quant = Convert.ToInt32(Console.ReadLine());

                    // THESE ARE THE PRICES FOR THE METALS FOR EACH CASE. IT IS TIMED BY THE QUANTITY WHICH IN INPUT IN BY THE USER AND ADDED TOGETHER TO DISPLAY THE TOTAL PRICE.

                    switch (UserPick)
                    {
                        case 1:
                            Metal = (1700 * quant);
                            tvalue = (1700 * quant);
                            mquant = mquant + quant;
                            break;
                        case 2:
                            Metal= (300 * quant);
                            tvalue = (300 * quant);
                            mquant = mquant + quant;
                            break;
                        case 3:
                            Metal = (500 * quant);
                            tvalue = (500 * quant);
                            mquant = mquant + quant;
                            break;
                        case 4:
                        goto Menu;
                        default:
                            Console.WriteLine("Your choice {0} was invalid", UserPick);
                            goto Found;
                    }
                    Console.WriteLine("The price of your Metals costs - {0:C}", Metal);
                    Console.WriteLine("Please press the enter key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    goto Menu;



                    // THIS IS THE QUOTATION CODING FOR OPTION 4 FROM THE MAIN MENU. IT CALCULATES THE LABOUR COST WHEN THE HOURS ARE ENTERED. FUTHERMORE, IT DISPLAYS THE ITEMS SELECTED, QUANTITY AND PRICE FOR THE ITEMS.

                case 4:
            Decide:
                    Console.WriteLine("Thank you {0}, please press the enter key to continue to your total price.", name);
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Number of hours required");
                    hours = Convert.ToInt32(Console.ReadLine());
                    labourcost = hours / 8;
                    Console.WriteLine("Number of workers required");
                    Console.WriteLine(labourcost);
                    Console.WriteLine("wages required");
                    rate = labourcost * 10;
                    Console.WriteLine(rate);
                    Console.ReadLine();

                    Console.WriteLine("The price of the labour cost is - {0:C}", +rate);
                    Console.ReadLine();


                    Console.WriteLine("The price of your Brick costs - {0:C}", + Brick); 

                    // THIS IS THE CODING TO SHOW THE THE IF STATEMENT FOR THE QUANTITY.
                    {
                        if (tquant > 0)

             
                        Console.WriteLine("Total Brick quantity is " + tquant);
                        Console.ReadLine();
                    }

                         Console.WriteLine("The price of your Steel costs - {0:C}",  + Steel);

 { 
     if (squant > 0)

     Console.WriteLine("Total Steel  quantity is " + squant);
                        Console.ReadLine();
                        
                    }
                   
                    Console.WriteLine("The price of your Metal costs - {0:C}", + Metal);

  {
      if (mquant > 0)
      Console.WriteLine("Total Metal quantity is " + mquant);
  
                        Console.ReadLine();
                    }

  
                    Console.WriteLine("The Total price - {0:C} ", Brick + Steel + Metal + rate);


                    // ALLOWS USER TO ENTER THE VAT RATE AND IT IS CALCULATED AND DISPLAYED AND ADDED TO THE TOTAL COST
                    
                    Console.WriteLine("What is the VAT rate");
                    VAT = Convert.ToInt32(Console.ReadLine());
                    TotalVAT = (Brick + Steel + Metal + rate) / 100 * VAT;

                    Console.WriteLine("VAT price");
                    Console.WriteLine(TotalVAT);

                    Console.WriteLine("The total after VAT price");
                    Console.WriteLine(Brick + Steel + Metal + rate + TotalVAT);
                    Console.ReadLine();


                    // ALLOWS USER TO ENTER THE PROFIT MARGIN RATE AND IT IS CALCULATED AND DISPLAYED AND ADDED TO THE TOTAL COST

                    Console.WriteLine("What is the profit Margin");
                    Profit = Convert.ToInt32(Console.ReadLine());
                    TotalProf = (Brick + Steel + Metal + rate) / 100 * Profit;

                    Console.WriteLine("Margin Profit price");
                    Console.WriteLine(TotalProf);
                    Console.ReadLine();

                    Console.WriteLine("The total after profit margin");
                    Console.WriteLine(Brick + Steel + Metal + rate + TotalProf); 
                    Console.ReadLine();

                    // THIS DISPLAYS THE TOTAL COST OF THE WHOLE QUOTATION WHICH INDCLUDES VAT, PROFIT AND THE TOTAL COST OF THE ITEMS SELECTED.

                    Console.WriteLine("The outstanding balance is £");
                    Console.WriteLine(Brick + Steel + Metal + rate + TotalProf + TotalVAT);
                    Console.ReadLine();
 
                   
                    // GIVES USER OPTION TO PRINT OUT THE QUOTATION.

                    Console.WriteLine("Would you like to print out your total cost : Yes or No?");
                    string UserLine = Console.ReadLine();

                    switch (UserLine.ToUpper())
                    {
                        case "YES":
                            Console.Clear();
                            goto Menu;
                        case "NO":
                            Console.Clear();
                            goto Menu;
                        default:
                            Console.WriteLine("Your input {0} was invalid, please try again..");
                            goto Decide;
                    }

                    
                // IF INVALID THEN IT WILL DISPLAY THIS MESSAGE.

                default:
                    Console.WriteLine("Invalid choice");
                    Console.ReadLine();
                    goto Menu;
            }
        }
    }
}

// Program Designed and coded by Jamie Ajibade. Student ID:4946560

      