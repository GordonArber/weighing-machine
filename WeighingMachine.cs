using System;

class WeighingMachine
{
    public int Precision { get; }

    double _weight;
    public double Weight
    {
        get => _weight;
        set {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"You cannot have a negative weight.");
            }
            _weight = value;
        }
    }
    public string DisplayWeight => $"{(_weight - _tareAdjustment):0.000} kg";

    double _tareAdjustment = 5.0;
    public double TareAdjustment
    {
        set => _tareAdjustment = value;
    }
    
    public WeighingMachine(int precision)
    {
        Precision = precision;
    }
}
