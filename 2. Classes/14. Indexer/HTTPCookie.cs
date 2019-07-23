using System;
using System.Collections.Generic;

namespace Indexer
{
    public class HTTPCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expire { get; set; }

        public HTTPCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        // create an indexer
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
