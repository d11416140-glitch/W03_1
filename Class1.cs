using System;

public class test
{
	public int mid;
	public int Final;	

	public double GetAvg()
	{
		return (mid+Final)/2.0;
	}

	public void SetGrade(int m , int f)
	{
		mid = m;
		Final = f;
	}



}