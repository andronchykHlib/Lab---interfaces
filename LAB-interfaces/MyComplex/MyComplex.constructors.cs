using System.Numerics;
using System.Text.RegularExpressions;

namespace LAB_interfaces;

public partial class MyComplex : IMyNumber<MyComplex>
{
    private BigInteger re;
    private BigInteger im;
    
    public MyComplex(BigInteger re, BigInteger im)
    {
        this.re = re;
        this.im = im;
    }
    
    public MyComplex(double re, double im)
    {
        this.re = (BigInteger) re;
        this.im =  (BigInteger) im;
    }
    
    public MyComplex(string exp)
    {
        if (!Regex.IsMatch(exp, "\\d+(,\\d+)?\\+\\d+(,\\d+)?i"))
        {
            throw new Exception("Provided string is not compatible.");
        }
    
        string[] values = exp.Remove(exp.Length - 1, 1).Replace(".", ",").Split("+");
    
        re = TypeCheck(values[0]);
        im = TypeCheck(values[1]);
    }
}