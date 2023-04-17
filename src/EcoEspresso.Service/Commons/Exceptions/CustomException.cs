namespace EcoEspresso.Service.Commons.Exceptions
{
    public class CustomException : Exception
    {
        public short Code { get; set; }
        public CustomException(short code,string message) : base(message)
        {
            this.Code = code;
        }

    }
}
