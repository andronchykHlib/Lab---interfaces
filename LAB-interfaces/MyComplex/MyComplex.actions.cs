using System.Numerics;

namespace LAB_interfaces;

public partial class MyComplex
{
    public MyComplex Add(MyComplex b)
    {
        BigInteger rePart = b.re + re;
        BigInteger imPart = b.im + im;

        return new MyComplex(rePart, imPart);
    }

    public MyComplex Subtract(MyComplex b)
    {
        BigInteger rePart = re - b.re;
        BigInteger imPart = im - b.im;

        return new MyComplex(rePart, imPart);
    }

    public MyComplex Multiply(MyComplex b)
    {
        (BigInteger ac, BigInteger bd, BigInteger ad, BigInteger bc) = GetDivision(b);

        BigInteger rePart = ac - bd;
        BigInteger imPart = ad + bc;

        return new MyComplex(rePart, imPart);
    }

    public MyComplex Divide(MyComplex b)
    {
        BigInteger div = b.re * b.re + b.im * b.im;

        DivisionCheck(div);
        
        (BigInteger ac, BigInteger bd, BigInteger ad, BigInteger bc) = GetDivision(b);
        
        BigInteger rePart = (ac + bd) / div;
        BigInteger imPart = (bc - ad) / div;
        
        return new MyComplex(rePart, imPart);
    }
}