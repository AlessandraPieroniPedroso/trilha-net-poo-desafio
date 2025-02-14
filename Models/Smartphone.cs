namespace DesafioPOO.Models
{   
    // TODO: Implementar as propriedades faltantes de acordo com o diagrama
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }

        private int Memoria { get; set; }

        

        // TODO: Passar os parâmetros do construtor para as propriedades
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}