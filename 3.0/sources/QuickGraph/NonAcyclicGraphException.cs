using System;

namespace QuickGraph
{
#if !SILVERLIGHT
    [Serializable]
#endif
    public class NonAcyclicGraphException
        : QuickGraphException
    {
        public NonAcyclicGraphException() { }
        public NonAcyclicGraphException(string message) : base( message ) { }
        public NonAcyclicGraphException(string message, System.Exception inner) : base( message, inner ) { }
    }
}


