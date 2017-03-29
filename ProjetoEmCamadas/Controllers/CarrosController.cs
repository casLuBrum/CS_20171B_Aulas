using Models;
using System.Collections.Generic;

namespace Controllers
{
    class CarrosController
    {
        private static List<Carro> listaCarros = new List<Carro>();

        public void Adicionar(string modelo, int ano)
        {
            Carro car = new Carro();
            car.CarroID = listaCarros.Count + 1;
            car.Modelo = modelo;
            car.Ano = ano;

            listaCarros.Add(car);
        }

        private Carro BuscaPorID(int id)
        {
            foreach(Carro car in listaCarros)
            {
                if(car.CarroID == id)
                {
                    return car;
                }
            }
            return null;
        }

        public Carro Detalhes(int id)
        {
            return BuscaPorID(id);
        }

        public void Editar(int id, string novoModelo, int novoAno)
        {
            Carro car = BuscaPorID(id);

            if(car != null)
            {
                car.Modelo = novoModelo;
                car.Ano = novoAno;
            }
        }

        public void Excluir(int id)
        {
            foreach (Carro car in listaCarros)
            {
                if (car.CarroID == id)
                {
                    listaCarros.Remove(car);
                }
            }
        }

        public List<Carro> Listar()
        {
            return listaCarros;
        }
    }
}
