using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


    internal class validaciones
    {
    public bool validarnum(string edad)
    {
        bool numeros = Regex.IsMatch(edad, @"^[0-9]+$");
        return numeros;
    }
    public bool validarlet(string nom)
    {
        bool letras = Regex.IsMatch(nom, @"^[a-zA-Z _]+$");
        return letras;
    }
    public bool correoelectronico(string corr)
    {
        bool correo = Regex.IsMatch(corr,@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"); //Correos electronicos
        return correo;
    }
    public bool telefono(string tel)
    {
        bool tele = Regex.IsMatch(tel, @"^\+?[1-9]\d{9}$");
        return tele;
    }
    
}
