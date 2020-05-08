using System;
using System.IO;
using System.Linq;
using System.Timers;
using System.Collections.Generic;

namespace MathTest
{
	public class MathTestLogic
    {
        //QuestionVariables
            public string Question1 = "What is ten plus two?"; //12
            public string Question2 = "What is four times twenty?"; //80
            public string Question3 = "what is a hundred times twelve?";  //1200
            public string Question4 = "what is five hundred times twenty?"; //10000
            public string Question5 = "what is one hundred eighty seven times sixty divided by 2?"; //5610
            public string Question6 = "What is one hundred twenty times four?"; //480
            public string Question7 = "Divide five hundred from ten thousand."; //20
            public string Question8 = "What is fifty times sixty?"; //3000
            public string Question9 = "What is five times five?"; //25
            public string Question10 = "What is six times six?"; //36
        
        //UserResponseVariables
            public int UserResponse1;
            public int UserResponse2;
            public int UserResponse3;
            public int UserResponse4;
            public int UserResponse5;
            public int UserResponse6;
            public int UserResponse7;
            public int UserResponse8;
            public int UserResponse9;
            public int UserResponse10;
            
        //Answers
            public int Answer1 = 12;
            public int Answer2 = 80;
            public int Answer3 = 1200;
            public int Answer4 = 10000;
            public int Answer5 = 5610;
            public int Answer6 = 480;
            public int Answer7 = 20;
            public int Answer8 = 3000;
            public int Answer9 = 25;
            public int Answer10 = 36;
        
        //Timer
            public static Timer timer;
        
        //Methods
        
            static void Main()
            {
        	  MathTestLogic MTL = new MathTestLogic();
        	  timer = new System.Timers.Timer();
        	  timer.Interval = 5000;
        	  Console.WriteLine("Hello and Welcome To MathTest!");
        	  Console.WriteLine("Press Enter To Continue...");
        	  Console.ReadLine();
        	  Console.Clear();
              timer.Enabled = true;
        	  MTL.TakeInput();
        	  
            }
             
            public void TakeInput()
            {
                //Question 1
                Console.WriteLine(Question1);
                UserResponse1 = Convert.ToInt32(Console.ReadLine());
                                                                      
       	        if(UserResponse1 == Answer1)
        	    {
        		    Console.Clear();
        		    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
        	    else
        	    {
        	        while(UserResponse1 != Answer1)
        	        {
        	            Console.Clear();
        	    	    Console.WriteLine("False. Try Again...");
        	    	    UserResponse1 = Convert.ToInt32(Console.ReadLine());
        	        }
        	        Console.Clear();
        	        Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
                //Question 2                                
                Console.WriteLine(Question2);
                UserResponse2 = Convert.ToInt32(Console.ReadLine());	
       	        
                if(UserResponse2 == Answer2)
        	    {
        		    Console.Clear();
        		    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
        	    else
                {
        	        while(UserResponse2 != Answer2)
        	        {
        	    	    Console.Clear();
        	    	    Console.WriteLine("False. Try Again...");
        	    	    UserResponse2 = Convert.ToInt32(Console.ReadLine());
        	        }
        	        Console.Clear();
        	        Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
                //Question 3    
                Console.WriteLine(Question3);
                UserResponse3 = Convert.ToInt32(Console.ReadLine());
                                                                      
       	        if(UserResponse3 == Answer3)
        	    {
        		    Console.Clear();
        		    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
        	    else
        	    {
        	        while(UserResponse3 != Answer3)
        	        {
        	            Console.Clear();
        	    	    Console.WriteLine("False. Try Again...");
        	    	    UserResponse3 = Convert.ToInt32(Console.ReadLine());
        	        }
        	        Console.Clear();
        	        Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
                //Question4                                
                Console.WriteLine(Question4);
                UserResponse4 = Convert.ToInt32(Console.ReadLine());	
       	        
                if(UserResponse4 == Answer4)
        	    {
        		    Console.Clear();
        		    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
        	    else
                {
        	        while(UserResponse4 != Answer4)
        	        {
        	    	    Console.Clear();
        	    	    Console.WriteLine("False. Try Again...");
        	    	    UserResponse2 = Convert.ToInt32(Console.ReadLine());
        	        }
        	        Console.Clear();
        	        Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }     
                //Question5     
                Console.WriteLine(Question5);
                UserResponse5 = Convert.ToInt32(Console.ReadLine());
                                                                      
       	        if(UserResponse5 == Answer5)
        	    {
        		    Console.Clear();
        		    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
        	    else
        	    {
        	        while(UserResponse5 != Answer5)
        	        {
        	            Console.Clear();
        	    	    Console.WriteLine("False. Try Again...");
        	    	    UserResponse5 = Convert.ToInt32(Console.ReadLine());
        	        }
        	        Console.Clear();
        	        Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
                //Question6                                
                Console.WriteLine(Question6);
                UserResponse6 = Convert.ToInt32(Console.ReadLine());	
       	        
                if(UserResponse6 == Answer6)
        	    {
        		    Console.Clear();
        		    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
        	    else
                {
        	        while(UserResponse6 != Answer6)
        	        {
        	    	    Console.Clear();
        	    	    Console.WriteLine("False. Try Again...");
        	    	    UserResponse6 = Convert.ToInt32(Console.ReadLine());
        	        }
        	        Console.Clear();
        	        Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }     
                //Question7     
                Console.WriteLine(Question7);
                UserResponse7 = Convert.ToInt32(Console.ReadLine());                                                     
       	        if(UserResponse7 == Answer7)
        	    {
        		    Console.Clear();
        		    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
        	    else
        	    {
        	        while(UserResponse7 != Answer7)
        	        {
        	            Console.Clear();
        	    	    Console.WriteLine("False. Try Again...");
        	    	    UserResponse7 = Convert.ToInt32(Console.ReadLine());
        	        }
        	        Console.Clear();
        	        Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
                //Question8                                
                Console.WriteLine(Question8);
                UserResponse8 = Convert.ToInt32(Console.ReadLine());	

                if(UserResponse8 == Answer8)
        	    {
        		    Console.Clear();
        		    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
        	    else
                {
        	        while(UserResponse8 != Answer8)
        	        {
        	    	    Console.Clear();
        	    	    Console.WriteLine("False. Try Again...");
        	    	    UserResponse8 = Convert.ToInt32(Console.ReadLine());
        	        }
        	        Console.Clear();
        	        Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }     
                //Question9     
                Console.WriteLine(Question9);
                UserResponse9 = Convert.ToInt32(Console.ReadLine());
                                                                      
       	        if(UserResponse9 == Answer9)
        	    {
        		    Console.Clear();
        		    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
        	    else
        	    {
        	        while(UserResponse9 != Answer9)
        	        {
        	            Console.Clear();
        	    	    Console.WriteLine("False. Try Again...");
        	    	    UserResponse9 = Convert.ToInt32(Console.ReadLine());
        	        }
        	        Console.Clear();
        	        Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
                //Question10                                
                Console.WriteLine(Question10);
                UserResponse10 = Convert.ToInt32(Console.ReadLine());	
       	        
                if(UserResponse10 == Answer10)
        	    {
        		    Console.Clear();
        		    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }
        	    else
                {
        	        while(UserResponse10 != Answer10)
        	        {
        	    	    Console.Clear();
        	    	    Console.WriteLine("False. Try Again...");
        	    	    UserResponse10 = Convert.ToInt32(Console.ReadLine());
        	        }
        	        Console.Clear();
        	        Console.WriteLine("Correct!");
                    Console.ReadLine();
                    Console.Clear();
        	    }     

                Console.WriteLine("Thanks for Playing!!!");
                System.Console.WriteLine("Press Enter to exit");
                Console.ReadLine();
                Console.Clear();     
            }
            
    }
}
