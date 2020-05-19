using System;

namespace TestApplication{
	class Class{
		public static int num;
		public void count(){
			num ++;
		}
	}
	
	class Test{
		static void Main(string[] args){
			Class c = new Class();
			Console.WriteLine(Class.num);
			c.count();
			c.count();
			Console.WriteLine(Class.num);
			Console.ReadKey();
		}
	}
}