namespace MyApp.Models
{
    class Commputer 
    {
        public int Id { get; set;}
        public string MotherBoard { get; set;} 
        public int cores {get; set;}
        public Boolean HasWifi { get; set;} 
        public Boolean HasLte { get; set;}  
        public DateTime date{ get; set;}
        
        public Decimal price{ get; set;}
        public string VideoCard { get; set;}  
          internal Commputer() 
        {
            if(MotherBoard == null)    
                {
                    MotherBoard = "";
                }
            if(VideoCard == null)    
                {
                    VideoCard = "";
                }
        }
    }
}