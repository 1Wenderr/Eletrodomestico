namespace Eletrodomestico.Models
{
    public class Geladeira : Eletrodomestico
    {
        public int CapacidadeLitros { get; set; }
        public bool TemFreezer { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Consumo Energetico: {ConsumoEnergetico}";
        }
    }
}
