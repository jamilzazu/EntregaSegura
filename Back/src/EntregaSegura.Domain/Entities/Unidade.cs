namespace EntregaSegura.Domain.Entities;

public class Unidade : BaseEntity
{
    private readonly IList<Morador> _moradores;

    public Unidade(int numero, int andar, string bloco, int condominioId)
    {
        Numero = numero;
        Andar = andar;
        Bloco = bloco;
        CondominioId = condominioId;
        
        _moradores = new List<Morador>();
    }

    public int Numero { get; private set; }
    public int Andar { get; private set; }
    public string Bloco { get; private set; }
    
    public int CondominioId { get; private set; }
    public Condominio Condominio { get; private set; }

    public IReadOnlyCollection<Morador> Moradores => _moradores.ToArray();
}