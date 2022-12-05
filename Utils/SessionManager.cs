namespace TheMall.Utils
{
    public class SessionManager : ISessionManager
    {
        private Dictionary<string, string> SessionMall { get; set; } = new Dictionary<string, string>();
        /// <summary>
        /// Returns the string value based on key input
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetStringValue(string key)
        {
            string temp = string.Empty;
            if (SessionMall.ContainsKey(key))
                temp = SessionMall[key];
            return temp;
        }
        /// <summary>
        /// Returns the int value based on the key input
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int GetKey(string key)
        {
            string tempStr = GetStringValue(key);
            int tempInt;
            if (Int32.TryParse(tempStr, out tempInt))
                return tempInt;
            return 0;
        }
        /// <summary>
        /// Sets the key value to Dictonary
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private void SetKey(string key, int? value)
        {
            SessionMall[key] = value.ToString();
        }
        /// <summary>
        /// Sets the value to the dictonary
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private void SetValue(string key, string value)
        {
            SessionMall[key] = value;
        }
        /// <summary>
        /// Set the Mall value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void SetMall(int key,string value)
        {
            SetKey("MallID",key);
            SetValue("MallLocation",value);
            NotifyStateChange();
        }
        public event Action OnChange;
        private void NotifyStateChange() => OnChange?.Invoke();
    }
}
