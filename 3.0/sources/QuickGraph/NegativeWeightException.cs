using System;

namespace QuickGraph
{
#if !SILVERLIGHT
    [System.Serializable]
#endif
    public class NegativeWeightException 
        : QuickGraphException
    {
        public NegativeWeightException() { }
        public NegativeWeightException(string message) : base(message) { }
        public NegativeWeightException(string message, Exception inner) : base(message, inner) { }
    }
}
