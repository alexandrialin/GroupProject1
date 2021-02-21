using System;

[Serializable]
public class OutOfTimeException : Exception
{
    // A constructor is needed for serialization when an
    // exception propagates from a remoting server to the client.
    public OutOfTimeException() {
        
    }
}