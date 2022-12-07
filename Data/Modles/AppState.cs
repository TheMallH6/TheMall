namespace TheMall.Data.Modles
{
    //We use this class to parse data from one activity to another by injecting it to the classes.
    public class AppState
    {
        public SessionCredentials Credentials { get; set; }

        public string UserName { get; set; }

    }
}
