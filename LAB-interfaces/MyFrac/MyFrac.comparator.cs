namespace LAB_interfaces;

public partial class MyFrac : IComparable<MyFrac>
{
    public int CompareTo(MyFrac? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var nomComparison = nom.CompareTo(other.nom);
        if (nomComparison != 0) return nomComparison;
        return denom.CompareTo(other.denom);
    }
}