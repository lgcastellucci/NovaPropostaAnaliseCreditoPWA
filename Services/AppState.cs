
using NovaPropostaAnaliseCreditoPWA.Models;

public class AppState
{
    public string cpfPromotor { get; set; }
    public int codEstabelecimento { get; set; }
    public string cpf { get; set; }
    public DateTime nascimento { get; set; }
    public string email { get; set; }
    public string telefone { get; set; }
    public int vencimentoDia { get; set; }
    public int codEstabelecimentoEntrega { get; set; }

    public IniciaPropostaResponse iniciaPropostaResponse { get; set; }
    public ConfirmaPropostaResponse confirmaPropostaResponse { get; set; }
    public AppState()
    {
        cpfPromotor = "";
        codEstabelecimento = 0;
        cpf = "";
        nascimento = DateTime.Now;
        email = "";
        telefone = "";
        vencimentoDia = 0;
        codEstabelecimentoEntrega = 0;
    }
}
