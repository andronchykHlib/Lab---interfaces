using System.Numerics;
using System.Text.RegularExpressions;

namespace LAB_interfaces;

public partial class MyFrac
{
    public MyFrac Add(MyFrac f)
    {
        BigInteger nomPart = nom * f.denom + denom * f.nom;
        BigInteger denomPart = denom * f.denom;

        return GetNewFrac(nomPart, denomPart);
    }

    public MyFrac Subtract(MyFrac f)
    {
        BigInteger nomPart = nom * f.denom - denom * f.nom;
        BigInteger denomPart = denom * f.denom;

        return GetNewFrac(nomPart, denomPart);
    }

    public MyFrac Multiply(MyFrac f)
    {
        BigInteger nomPart = nom * f.nom;
        BigInteger denomPart = denom * f.denom;

        return GetNewFrac(nomPart, denomPart);
    }

    public MyFrac Divide(MyFrac f)
    {
        BigInteger nomPart = nom * f.denom;
        BigInteger denomPart = denom * f.nom;

        return GetNewFrac(nomPart, denomPart);
    }
}