namespace Adivinha.Models
{
    public class GeraNumero
    {
        public int NumeroSecreto { get; set; }

        public void GenerateSecretNumber()
        {
            Random random = new Random();
            NumeroSecreto = random.Next(1, 101); // Gera um número aleatório entre 1 e 100
        }
    }
}
