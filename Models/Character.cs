namespace dotnet_Web_API_Tutorial.Models
{
    public class Character
    {
        public int ID {get; set;}
        public string Name {get; set;} = "Alf";
        public int HP {get; set;} = 100;
        public int SP {get; set;} = 50;
        public int DP {get; set;} = 50;
        public int IP {get; set;} = 80;

        public RpgClass Class = RpgClass.Typographer;
    }
}