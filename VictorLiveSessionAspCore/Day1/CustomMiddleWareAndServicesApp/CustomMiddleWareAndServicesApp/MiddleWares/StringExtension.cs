namespace CustomMiddleWareAndServicesApp.MiddleWares
{
    public static class StringExtension
    {

        public static string Hello(this string inputValue) {

            return "hello ," + inputValue.ToUpper();
        }

    }
}
