using System;

namespace Exercises_DesingADataBaseConnection
{
    public abstract class DbConnection
    {
        private readonly string _url;

        public DbConnection(string url)
        {
            if (String.IsNullOrWhiteSpace(url))
                throw new ArgumentException("Error on URL. it is not be null or empty");

            
            this._url = url;
        }

        public abstract void Open();
        public abstract void Closed();
    }
}
