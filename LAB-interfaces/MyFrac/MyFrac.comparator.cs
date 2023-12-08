using System.Numerics;

namespace LAB_interfaces;

public partial class MyFrac : IComparable<MyFrac>
{
    public int CompareTo(MyFrac? other)
    {
        if (other == null)
        {
            throw new NullReferenceException("Comparable value is null.");
        }

        BigInteger thisNumerator = nom * other.denom;
        BigInteger otherNumerator = other.nom * denom;

        return thisNumerator.CompareTo(otherNumerator);
    }
}