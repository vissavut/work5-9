namespace runLED
{


    public interface IHomework05
    {
         string [] Leds();
         string  LED();
         string DisplayLEDOnScreen(string ledNo);
       
    }
    
    public class Homework0 : IHomework05

    {
         public int set = 10;
        public string DisplayLEDOnScreen(string ledNo)
        {
             IHomework05 inputkey = new Homework0();
              
            
            return ledNo;

        }
        public  string [] Leds()
        {
          
            string[] led = new string[set];
           
            for (int i = 0; i < led.Length; i++)
            {
                led[i] = "[ ]";
                
            } return led;   
            
          
        } 

       public string  LED()
        {
             string NumberLed = null;
             for (int i = 0; i < set; i++)
             {
             if (i < set - 1)
                {
                    int numbers;
                    numbers = i + 1;
                    NumberLed += " " + numbers + " ";
                    numbers++;
                }
                else
                {
                    NumberLed += " " + "A";
                }
                 
             }
            return NumberLed;

        }
            

    }
}