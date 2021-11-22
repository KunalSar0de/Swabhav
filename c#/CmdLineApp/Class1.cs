using System;
public class CallByRefTest
{

	public static void Main(string[] args)
	{
		int val = 15;
		CallByRefTest t1 = new CallByRefTest();
		Console.WriteLine("value before calling function:" + val);
		t1.m1(ref val);//only value passed which is 15
		Console.WriteLine("value after calling function:" + val);
		//in call by ref variables original value is modified
		Console.ReadLine();
	}

	public void m1(ref int val)
	{
		val = val + 10;
		Console.WriteLine("Value of called function  is: " + val);
	}


}