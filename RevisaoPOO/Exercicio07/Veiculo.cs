bic: 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade07
{
    public class Bicicleta : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("A bicicleta se move pedalando.");
        }
    }
}

carro:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade07
{
    public class Carro : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("O carro se move usando motor.");
        }
    }
}
veic:
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade07;

public class Veiculo
{
    public virtual void Mover()
    {
        Console.WriteLine("O veículo está se movendo...");
    }
}



