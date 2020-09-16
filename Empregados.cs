using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioEmpregados {
    class Empregados {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Empregados (int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void aumentarSalario (double porc) {
            double incremento = this.Salario * (porc / 100);
            this.Salario += incremento;
        }

        public override string ToString() {
            return $"{Id}, {Nome}, {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
