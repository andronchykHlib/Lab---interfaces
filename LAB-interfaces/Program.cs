﻿using LAB_interfaces;

static void testAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
{
    Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
    T aPlusB = a.Add(b);
    Console.WriteLine("a = " + a);
    Console.WriteLine("b = " + b);
    Console.WriteLine("(a + b) = " + aPlusB);
    Console.WriteLine("(a+b)^2 = " + aPlusB.Multiply(aPlusB));
    Console.WriteLine(" = = = ");
    T curr = a.Multiply(a);
    Console.WriteLine("a^2 = " + curr);
    T wholeRightPart = curr;
    curr = a.Multiply(b); // ab
    curr = curr.Add(curr); // ab + ab = 2ab

    Console.WriteLine("2*a*b = " + curr);
    wholeRightPart = wholeRightPart.Add(curr);
    curr = b.Multiply(b);
    Console.WriteLine("b^2 = " + curr);
    wholeRightPart = wholeRightPart.Add(curr);
    Console.WriteLine("a^2+2ab+b^2 = " + wholeRightPart);
    Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
}

testAPlusBSquare(new MyFrac("1/3"), new MyFrac(1, 6));
testAPlusBSquare(new MyComplex(1.2, 2), new MyComplex("1+6i"));