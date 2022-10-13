/*
   ___      _                                     __                      
  / _ \__ _| |_ _ __ ___  _ __   ___  ___        /__\ ___  __ _  _____  __
 / /_)/ _` | __| '__/ _ \| '_ \ / _ \/ __|_____ / \/// _ \/ _` |/ _ \ \/ /
/ ___/ (_| | |_| | | (_) | | | |  __/\__ \_____/ _  \  __/ (_| |  __/>  < 
\/    \__,_|\__|_|  \___/|_| |_|\___||___/     \/ \_/\___|\__, |\___/_/\_\
                                                          |___/                   

// Documentación NET 6 --> https://aka.ms/new-console-template
// Simulador de REGEX --> OP1: https://regexr.com/ OP2: https://regex101.com/
*/


//Libreria de expresiones regulares
using System.Text.RegularExpressions;

/* 🔷---TEXTO---🔷 */
string Texto_Codigo = "int  valor1, valor2; float  Total_Factura_1, Descuento; valor1 = 2000; valor2 = -178; if (valor2 >= valor1) { Total_Factura_1 = +10780.25; Descuento = -107.80; } else { valor1++; valor2 = valor1 * 30; } print(“Factura = {0} Descuento {1}”, Total_Factura_1,  Descuento); ";


/* 🔷---PATRONES---🔷 */

// ◼-- Palabra reservada --◼ 
string patron_1 = @"(int)|(float)|(double)|(char)|(string)|(for)|(if)|(while)|(else)|(do)|(then)|(print)";

// ◼-- Variable --◼  NOTA: La formula proporcionada por el profesor unicamente funciona correctamente en el simulador, por lo cual esta se ha desactivado por ahora, sin embargo si la gustas probar puedes utilizar el simulador de tu preferencia
//string patron_2 = @"[a-zA-Z]\w*";
//string patron_2 = @"[a-zA-Z_$][a-zA-Z_$0-9]*";

// ◼-- Número decimal --◼ 
string patron_3 = @"[+-]?[0-9]+\.[0-9]+";

// ◼-- Número entero --◼ 
string patron_4 = @".\d[0-9]+";

// ◼--  Coma , --◼ 
string patron_5 = @",";

// ◼-- Punto y coma ; --◼ 
string patron_6 = @";";

// ◼-- Asignación  = --◼ 
string patron_7 = @" = ";

// ◼-- Paréntesis izquierdo ( --◼ 
string patron_8 = @"[(]";

// ◼-- Paréntesis derecho  ) --◼ 
string patron_9 = @"[)]";

// ◼-- Operador Relacional  >= --◼ 
string patron_10 = @"(>)(=)";

// ◼-- Llave izquierda  { --◼ 
string patron_11 = @"{";

// ◼-- Llave derecha  { --◼ 
string patron_12 = @"}";

// ◼-- Operador incremento  ++ --◼ 
string patron_13 = @"[+]([+])";

// ◼-- Operador aritmético  * --◼ 
string patron_14 = @"[*]";

// ◼-- Cadena (texto encerrado entre comillas) ejemplo “Hola” --◼ 
string patron_15 = @"(“)[\w\W]*(”)"; // (")[\w\W]*(")


/* 🔷---EXPRESIONES---🔷 */

Regex exp_1 = new Regex(patron_1);
//Regex exp_2 = new Regex(patron_2);
Regex exp_3 = new Regex(patron_3);
Regex exp_4 = new Regex(patron_4);
Regex exp_5 = new Regex(patron_5);
Regex exp_6 = new Regex(patron_6);
Regex exp_7 = new Regex(patron_7);
Regex exp_8 = new Regex(patron_8);
Regex exp_9 = new Regex(patron_9);
Regex exp_10 = new Regex(patron_10);
Regex exp_11 = new Regex(patron_11);
Regex exp_12 = new Regex(patron_12);
Regex exp_13 = new Regex(patron_13);
Regex exp_14 = new Regex(patron_14);
Regex exp_15 = new Regex(patron_15);


/* 🔷---LISTA DE PATRONES---🔷 */
string Patrones = patron_1 + "|" + patron_3 + "|" + patron_4 + "|" + patron_5 + "|" + patron_6 + "|" + patron_7 + "|" + patron_8 + "|" + patron_9 + "|" + patron_10 + "|" + patron_11 + "|" + patron_12 + "|" + patron_13 + "|" + patron_14 + "|" + patron_15;
//string Patrones = patron_1 + "|" + patron_2 + "|" + patron_3 + "|" + patron_4 + "|" + patron_5 + "|" + patron_6 + "|" +patron_7 + "|" + patron_8 + "|" + patron_9  + "|" + patron_10 + "|" + patron_11 + "|" + patron_12 + "|" + patron_13 + "|" + patron_14 + "|" + patron_15;



Match match = Regex.Match(Texto_Codigo, Patrones);

while (match.Success)
{

    if (exp_1.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-1: Palabra reservada -> {match.Value}");
        match = match.NextMatch();
    }

    /*
    else if (exp_2.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-2: Variable -> {match.Value}");
        match = match.NextMatch();
    }
    */

    else if (exp_3.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-3: Numero decimal -> {match.Value}");
        match = match.NextMatch();
    }

    else if (exp_4.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-4: Numero entero -> {match.Value}");
        match = match.NextMatch();
    }

    else if (exp_5.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-5: Coma -> {match.Value}");
        match = match.NextMatch();
    }

    else if (exp_6.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-6: Punto y coma -> {match.Value}");
        match = match.NextMatch();
    }

    else if (exp_7.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-7: Asignación -> {match.Value}");
        match = match.NextMatch();
    }

    else if (exp_8.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-8: Parentesis izquierdo -> {match.Value}");
        match = match.NextMatch();
    }

    else if (exp_9.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-9: Parentesis derecho -> {match.Value}");
        match = match.NextMatch();
    }

    else if (exp_10.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-10: Operador relacional -> {match.Value}");
        match = match.NextMatch();
    }

    else if (exp_11.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-11: Llaves izquierda -> {match.Value}");
        match = match.NextMatch();
    }

    else if (exp_12.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-12: Llaves derecha -> {match.Value}");
        match = match.NextMatch();
    }

    else if (exp_13.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-13: Operador incremento -> {match.Value}");
        match = match.NextMatch();
    }

    else if (exp_14.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-14: Operador aritmético -> {match.Value}");
        match = match.NextMatch();
    }

    else if (exp_15.IsMatch(match.Value))
    {
        Console.WriteLine($"Patron-15: Cadena -> {match.Value}");
        match = match.NextMatch();
    }

    else
    {
        match = match.NextMatch();
    }

}