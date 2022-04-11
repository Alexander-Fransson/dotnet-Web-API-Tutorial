namespace dotnet_Web_API_Tutorial.Models
{
    public class Character
    {
        public int ID {get; set;} = 0;
        public string Name {get; set;} = "Pigeun";
        public int HP {get; set;} = 100;
        public int SP {get; set;} = 50;
        public int DP {get; set;} = 50;
        public int IP {get; set;} = 80;
        public RpgClass Class {get; set;} = RpgClass.Typographer;
    }
}