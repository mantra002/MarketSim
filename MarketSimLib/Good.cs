using System;

public class Good
{
	public int Value { 
		get
		{
			return this.intrinsicValue;
		}
	}
	public string Name { get; set; }
	private int intrinsicValue;

	public Good(int intrinsicValue)
    {
        this.intrinsicValue = intrinsicValue;
    }
}
