using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contratos.Entities.Enums
{
    //criaçao de uma variavel enumeradora, enum é um tipo de dados

    //Um tipo de enumeração (ou tipo enum) é um tipo de valor definido por um conjunto de
    //constantes nomeadas do tipo numérico integral subjacente.
    //Para definir um tipo de enumeração, use a palavra-chave enum
    //e especifique os nomes dos membros de enumeração.

    //Por padrão, os valores constantes associados de enumeração de membros são do tipo int;
    //eles começam com zero e aumentam em um seguindo a ordem de texto de definição.
    //Você pode especificar explicitamente qualquer outro tipo numérico integral
    //como um tipo subjacente de um tipo de enumeração.
    //Você também pode especificar explicitamente os
    //valores constantes associados, como mostra o exemplo a seguir:
    internal enum WorkerLevel
    {
        Junior = 0,
        MidLevel= 1,
        Senior = 2
    }
}
