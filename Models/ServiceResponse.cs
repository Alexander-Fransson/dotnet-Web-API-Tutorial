namespace dotnet_Web_API_Tutorial.Models
{
    public class ServiceResponse<T>
    {
        public T Data {get; set;}
        public bool Successfulness {get; set;} = true;
        public string Message {get; set;}
    }
}