// See https://aka.ms/new-console-template for more information


var x = 123;
var tmp = x.ToString();
var reverse = string.Join("", tmp.Reverse());
x = int.Parse(reverse);