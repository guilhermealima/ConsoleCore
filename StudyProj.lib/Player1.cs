using StudyProj.Interface;

namespace StudyProj.lib
{    public class Player1 : iPlayer
    {
        public readonly string _Name;

        public Player1(string name = "Ronaldo")
        {
            _Name = name;
        }
        //Kick
        public string Kick()
        {
           return $"{_Name} está chutando \n"; 
        }

        //Run
        public string Run()
        {
            return $"{_Name} está correndo \n";
        }
        //Pass
        public string Pass()
        {
            return $"{_Name} está passando \n";
        }
    }
}