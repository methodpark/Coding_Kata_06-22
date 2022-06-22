using static System.Console;
using CSharpKata;
using FSharpKata;

WriteLine("Hello, C#!");
WriteLine(new Example().GetRandomString());
WriteLine(Kata.ImplementStuff);

WriteLine();

WriteLine("Hello, F#!");
FizzBuzz.getSequence(10).ToList().ForEach(WriteLine);
