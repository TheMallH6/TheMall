namespace TheMall
{
    public interface ISessionManager
    {
        public string GetStringValue(string key);
        public int? GetKey(string key);
        public void SetMall(int key, string value);
        public event Action OnChange;
    }
}
