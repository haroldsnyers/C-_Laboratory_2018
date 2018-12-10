using System;

namespace computer
{
    // model of all operations
    public interface Computer
    {
        string Name { get; }
        
        double Compute(params double[] values);
    }
    
}
