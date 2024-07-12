namespace API.Models;

public class Imc
{
    public string ImcId { get; set; } = Guid.NewGuid().ToString();
    public Aluno? Aluno { get; set; }
    public string? AlunoId { get; set; }
    public string? Nome{ get; set; }
    public string? Sobrenome{ get; set; }
    public double? Altura { get; set; }
    public double? Peso { get; set; }

}
