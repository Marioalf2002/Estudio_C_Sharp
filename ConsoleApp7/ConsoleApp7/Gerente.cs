﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Gerente : IEmpleado , IAuditable
    {
        string name = string.Empty;
        string auditoria = string.Empty;
        double salario = 0;

        public Gerente(string name, double salario, string auditoria)
        {
            this.Name = name;
            this.Salario = salario;
            this.Auditoria = auditoria;
        }

        public Gerente() { }

        public string Name { get { return name; } set { name = value; } }
        public double Salario { get {  return salario; } set {  salario = value; } }
        public string Auditoria { get => auditoria; set => auditoria = value; }

        public string ObtenerNombre(string name)
        {
            Console.Write("Digita un nombre: ");
            name = Console.ReadLine();
            this.Name = name;
            return Name;
        }

        public double CalcularSalario(double salario)
        {

            Console.Write("Ingresa pago diario: ");
            salario = int.Parse(Console.ReadLine());
            this.Salario = salario * 30;
            return Salario;
        }

        public string RegistrarAuditoria(string auditoria)
        {

            Console.Write("Ingresa Auditoria: ");
            auditoria = Console.ReadLine();
            this.Auditoria = auditoria;
            return Auditoria;
        }

        public override string ToString()
        {
            return "Nombre: " + Name + "\nSalario: " + Salario + "\nAuditoria: " + Auditoria;
        }
    }
}
