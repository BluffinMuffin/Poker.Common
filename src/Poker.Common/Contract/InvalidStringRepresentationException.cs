using System;

namespace BluffinMuffin.Poker.Common.Contract
{
    public class InvalidStringRepresentationException : Exception
    {
        public string StringRepresentation { get; }
        public string Reason { get; }

        public InvalidStringRepresentationException(string stringRepresentation, string reason)
            : base($"'{stringRepresentation}' is not a valid string representation of a poker card (Invalid {reason}). Use the 'vs' format where v = [2,3,4,5,6,7,8,9,10,J,Q,K,A] and s = [S,D,H,C]. Ex: 6S for the 6 of spades")
        {
            StringRepresentation = stringRepresentation;
            Reason = reason;
        }
    }
}
