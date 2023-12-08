using System.Numerics;

namespace LAB_interfaces;

public partial class MyComplex
{
    private (BigInteger ac, BigInteger bd, BigInteger ad, BigInteger bc) GetDivision(MyComplex b)
    {
        BigInteger ac = re * b.re;
        BigInteger bd = im * b.im;
        BigInteger ad = re * b.im;
        BigInteger bc = im * b.re;

        return (ac, bd, ad, bc);
    }

    private BigInteger TypeCheck(string s)
    {
        return s.Contains(",") ? (BigInteger) double.Parse(s) : BigInteger.Parse(s);
    }

    private void DivisionCheck(BigInteger val)
    {
        if (val == 0)
        {
            throw new DivideByZeroException();
        }
    }

    public override string ToString()
    {
        return $"{re}+{im}i";
    }
}