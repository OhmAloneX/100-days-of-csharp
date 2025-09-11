/*
-----------------------STRING METHODS------------------------------

Method	Example	Output

ToUpper()	"hello".ToUpper()	HELLO
ToLower()	"HELLO".ToLower()	hello
Trim()	" hi ".Trim()	hi
TrimStart()	" hi".TrimStart()	hi
TrimEnd()	"hi ".TrimEnd()	hi
Substring(start, length)	"Hello".Substring(1,3)	ell
Replace("a","b")	"cat".Replace("c","b")	bat
Contains("x")	"text".Contains("ex")	True
StartsWith("He")	"Hello".StartsWith("He")	True
EndsWith("lo")	"Hello".EndsWith("lo")	True
Split(' ')	"a b c".Split(' ')[1]	b
Length	"Hello".Length	5
IndexOf("o")	"Hello".IndexOf("o")	4
Remove(start, count)	"Hello".Remove(1,2)	Ho



-----------------------MATH METHODS---------------------------------

Method	Example	Output

Math.Round(x, 2)	Math.Round(12.3456, 2)	12.35
Math.Floor(x)	Math.Floor(12.9)	12
Math.Ceiling(x)	Math.Ceiling(12.1)	13
Math.Abs(x)	Math.Abs(-5)	5
Math.Pow(a,b)	Math.Pow(2,3)	8
Math.Sqrt(x)	Math.Sqrt(16)	4
Math.Max(a,b)	Math.Max(10,20)	20
Math.Min(a,b)	Math.Min(10,20)	10
Math.Sign(x)	Math.Sign(-42)	-1


----------------------DATE TIME METHODS-----------------------------

Method	Example	Output

DateTime.Now	DateTime.Now	2025-09-11 22:15:30
DateTime.Today	DateTime.Today	2025-09-11 00:00:00
AddDays(n)	now.AddDays(5)	adds 5 days
AddYears(n)	now.AddYears(-1)	subtracts 1 year
Day	now.Day	e.g. 11
Month	now.Month	e.g. 9
Year	now.Year	e.g. 2025
DayOfWeek	now.DayOfWeek	e.g. Thursday
ToString("yyyy-MM-dd")	now.ToString("yyyy-MM-dd")	2025-09-11


---------------------BOOLEAN METHODS--------------------------------

Method	Example	Output

ToString()	true.ToString()	"True"
Equals(value)	true.Equals(false)	False


---------------------COMMON OBJECT METHODS--------------------------

Method	Example	Output
ToString()	123.ToString()	"123"
GetType()	"hi".GetType()	System.String
Equals(obj)	"hi".Equals("hi")	True 
*/