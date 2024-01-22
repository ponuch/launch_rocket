// See https://aka.ms/new-console-template for more information
var qna = Double.Parse(Console.ReadLine());
var qt = Double.Parse(Console.ReadLine());
var qk = Double.Parse(Console.ReadLine());
var Qc = Double.Parse(Console.ReadLine());
var t = Double.Parse(Console.ReadLine());
var at = Double.Parse(Console.ReadLine());

var Qp = Qc / (2 * t);
var nna = Qp / qna;
Console.WriteLine(Convert.ToInt32(nna));

var Qt = at * Qp;
var nt = Qt / qt;
Console.WriteLine(Convert.ToInt32(nt));



var Qf = (1 - at) * Qp;
var nk = Qf / qk;
Console.WriteLine(Convert.ToInt32(nk));

Console.ReadLine();
