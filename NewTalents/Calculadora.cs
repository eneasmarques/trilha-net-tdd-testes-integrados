using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> _listaHistorico;
        private string _dataHistorico;

        public Calculadora(string data)
        {
            _listaHistorico = new List<string>();
            _dataHistorico = data;
        }

        public int Somar(int val1, int val2)
        {
            int resultado = val1 + val2;
            _listaHistorico.Insert(0, $"{val1} + {val2} = {resultado} - {_dataHistorico}");

            return resultado;
        }

        public int Subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            _listaHistorico.Insert(0, $"{val1} - {val2} = {resultado} - {_dataHistorico}");
            return resultado;
        }

        public int Multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            _listaHistorico.Insert(0, $"{val1} * {val2} = {resultado} - {_dataHistorico}");

            return resultado;
        }

        public int Dividir(int val1, int val2)
        {   
            int resultado = val1 / val2;
            _listaHistorico.Insert(0, $"{val1} / {val2} = {resultado} - {_dataHistorico}");

            return resultado;
        }

        public List<string> Historico() {
            _listaHistorico.RemoveRange(3, _listaHistorico.Count - 3);
        
            return _listaHistorico;
        }
    }
}