using System;
public class Program
{
	public static void Main()
	{
		Console.WriteLine("limit");
		int n=Convert.ToInt32(Console.ReadLine());
	int [] a= new int[n];
		int[] b=new int[n-1];
	Console.WriteLine("position");
		int p=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("elements");
		for(int i=0;i<n;i++)
		{
		a[i]=Convert.ToInt32(Console.ReadLine());
		}
		for(int i=0;i<n;i++)
		{
			if(i<p)
				
			   {
				
				b[i]=a[i];
				
				
				  
			   }
			else
			{
				goto f;
					
			}
		
	
			Console.WriteLine(b[i]);
		}
		f:
		for(int i=p;i<n-1;i++)
		{
			int t=a[i+1];
			b[i]=t;
			
			Console.WriteLine(b[i]);
		}
	}
}
