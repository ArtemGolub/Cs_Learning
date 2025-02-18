
Test t1 = new Test(1,2,3,4,5,6);
Test t2 = t1 with { A = 10 };
Console.WriteLine(t2);

record Test (int A, int B, int C, int D, int E,int F);