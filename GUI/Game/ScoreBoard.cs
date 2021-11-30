
namespace GUI
{
    public class ScoreBoard
    {
        public int Score { get; set; }
        
        public int FirstDigit 
        { get 
            {
                return (Score - SecoundtDigit - ThirdDigit) / 100;    
            }
        }
        public int SecoundtDigit 
        {
            get 
            {
                return ((Score - ThirdDigit) % 100) / 10;
            }
         }
        public int ThirdDigit 
        {
            get
            {
                return Score % 10;
            }
                
        }

        public void Increase()
        {
            if (Score < 999)
            {
                Score++;
            }
            else
            {
                Score = 0;
            }
        }
        public void Decrease()
        {
            if (Score > 0)
            {
                Score--;
            }
            else
            {
                Score = 0;
            }
        }
    }
}
