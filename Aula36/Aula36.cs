using System;

class Aula36
{
    class Veiculo
    {
        public int velAtual;
        private int velMax;
        protected bool ligado;
        public Veiculo(int velMax)
        {
            velAtual = 0;
            this.velMax = velMax;
            ligado = false;
        }

        public int getVelMax()
        {
            return velMax;
        }
    }

    class Carro:Veiculo
    {
        public string nome;
        public Carro(string nome, int vm):base(vm)
        {
            this.nome = nome;
            ligado = true;
        }
        public bool getLigado()
        {
            return ligado;
        }
    }

    static void Main(){
        Carro carro = new Carro("Bonitão",120);

        Console.WriteLine("Nome.....: {0}",carro.nome);
        Console.WriteLine("Vel. Max.: {0}",carro.getVelMax());
        Console.WriteLine("Ligado...: {0}",carro.getLigado());
    }
}