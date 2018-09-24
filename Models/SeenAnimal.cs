using System;

namespace Safari_Online

{
    public class SeenAnimal
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public string Location { get; set; }
        public int CountOfTimesSeen { get; set; } = 1;  
        public DateTime TimeOfLastSeen { get; set; } = DateTime.Now;
    }
}
