using System.Numerics;

namespace LAB_interfaces;

public partial class MyFrac
{
    private MyFrac GetNewFrac(BigInteger nomPart, BigInteger denomPart)
    {
        (BigInteger nomWithGCD, BigInteger denomWithGCD) = GetSimplifiedValues(nomPart, denomPart);
        
        return new MyFrac(nomWithGCD, denomWithGCD);
    }


    private (BigInteger nomWithGCD, BigInteger denomWithGCD) GetSimplifiedValues(BigInteger nomPart, BigInteger denomPart)
    {
        DivisionCheck(denomPart);
        BigInteger gcd = GCD(nomPart, denomPart);
        BigInteger nomWithGCD = nomPart / gcd;
        BigInteger denomWithGCD = denomPart / gcd;
        
        return (nomWithGCD, denomWithGCD);
    }
    
    private void DivisionCheck(BigInteger denom)
    {
        if (denom == 0)
        {
            throw new DivideByZeroException();
        }
    }
    
    private BigInteger GCD(BigInteger a, BigInteger b)
    {
        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }


    public override string ToString()
    {
        return $"{nom}/{denom}";
    }
}