using StudyProj.Interface;

namespace StudyProj.lib
{
    public class Player2 : iPlayer
    {
        public string Kick()
        {
            return "Maradona está chutando\n";        
        }

        public string Pass()
        {
            return "Maradona está passando\n";        
        }

        public string Run()
        {
            return "Maradona está correndo\n";        
        }
    }
}