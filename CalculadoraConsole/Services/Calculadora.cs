namespace CalculadoraConsole.Services
{
    public class Calculadora
    {
        private List<string> _listaHistorico;
        private string _data;
        
        public Calculadora(string data)
        {
            _listaHistorico = new List<string>();
            _data = data;
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;

            _listaHistorico.Insert(0, $"{num1} + {num2} = {resultado} | Data: {_data}");
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;

            _listaHistorico.Insert(0, $"{num1} - {num2} = {resultado} | Data: {_data}");
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;

            _listaHistorico.Insert(0, $"{num1} * {num2} = {resultado} | Data: {_data}");
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;

            _listaHistorico.Insert(0, $"{num1} / {num2} = {resultado} | Data: {_data}");
            return resultado;
        }

        public List<string> Historico()
        {
            _listaHistorico.RemoveRange(3, _listaHistorico.Count-3);
            return _listaHistorico;
            // return new List<string>() {listaHistorico[0], listaHistorico[1], listaHistorico[2]};
        }
    }
}