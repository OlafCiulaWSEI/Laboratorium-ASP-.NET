using WebApplication1.Controllers;

namespace WebApplication1.Models;

public class Calculator
{
    public Operators Operator{ get; set; }
    public double? A { get; set; }
    public double? B { get; set; }

    public String Op
    {
        get
        {
            switch (Operator)
            {
                case Operators.Add:
                    return "+";
                case Operators.Sub:
                    return "-";
                case Operators.Mul:
                    return "*";
                case Operators.Div:
                    return "/";
                default:
                    return "";
            }
        }
    }

    public bool IsValid()
    {
        return Operator != null && A != null && B != null;
    }

    public double Calculate() {
        switch (Operator)
        {
            case Operators.Add:
                return (double) (A + B);
            case Operators.Sub:
                return (double) (A - B);
            case Operators.Mul:
                return (double) (A * B);
            case Operators.Div:
                return (double) (A / B);
            default: return double.NaN;
        }
    }
    
    public enum Operators
    {
        Add, Sub, Mul, Div
    }
}
