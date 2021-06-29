#nullable enable

using AttributeConsumer;
using System;

Console.WriteLine(new R1(1));
Console.WriteLine(new C1 { X = 1 });
Console.WriteLine(SkipLocalsInit.M());
//Console.WriteLine(Nrt.M(null).Length);
Console.WriteLine(Nrt.M("").Length);
Console.WriteLine(Nrt.P);
Nrt.P = "abc";
Console.WriteLine(Nrt.P);
