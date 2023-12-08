using System.Numerics;
using System.Text.RegularExpressions;

namespace LAB_interfaces;

public partial class MyFrac
{
    private BigInteger nom;
    private BigInteger denom;
    
    public MyFrac(BigInteger nom, BigInteger denom)
    {
        this.nom = nom;
        this.denom = denom;
    }    
    
    public MyFrac(char nom, char denom)
    {
        BigInteger denomBig =  BigInteger.Parse(nom.ToString());
        BigInteger nomBig =  BigInteger.Parse(denom.ToString());
        
        DivisionCheck(nomBig);

        this.nom = nomBig;
        this.denom = denomBig;
    }
    
    public MyFrac(string frac)
    {
        if (!Regex.IsMatch(frac, "\\d+/\\d+"))
        {
            throw new Exception("Provided string is not compatible.");
        }

        BigInteger[] values = Array.ConvertAll(frac.Split("/"), BigInteger.Parse);

        nom = values[0];
        denom = values[1];
    }

}