using Microsoft.AspNetCore.Mvc;

/* Este arquivo servira apenas como um exemplo para as proximas Controllers
 * Como regra em todos os arquivos, vamos utilizar o namespace por arquivo
 *
 * Ou seja, como esta abaixo:
 */
namespace MoneyMapAPI.Controllers;

// esse [controller] e apenas um prefixo para o nome da classe, no caso de agora, e ControllerTemplate

// TODOS os controllers herdam de ControllerBase, tem um Controller que serve apenas para projetos blazor, entao cuidado
[Route("template/[controller]")]
[ApiController]
public class ControllerTemplate : ControllerBase
{
    // GET template/ControllerTemplate/get-template-value
    [HttpGet("get-template-value")]
    public int GetTemplate()
    {
        /*  Declaracoes de variaveis em que o tipo esta implicito, usaremos var para deixar o codigo mais sucinto
         *
         *  Nao somos javeiros para fazer Random random = new Random();
         */
        var random = new Random();

        /* Nesse momento, pode surgir a duvida na sua cabeca se int ou var deve ser utilizado...
         * 
         *  Nos so iremos tipar as variaveis quando necessario
         *
         *  E nao se esqueca: com o uso do var, temos a responsabilidade de ter um nome de variavel muito bem descritiva
         *
         *  Alem de tudo isso, random.Next() retorna obrigatoriamente um int
         */
        var number = random.Next(1, 50);

        return number;
    }

    // POST template/ControllerTemplate/post-template-value
    [HttpPost("post-template-value")]
    public IActionResult PostTemplate([FromBody] string value)
    {
        // IActionResult retorna codigos padroes do protocolo HTTP
        if (string.IsNullOrWhiteSpace(value)) return BadRequest();

        // return Ok() seria 200, e o valor dentro () é o corpo retornado em JSON (da uma olhada no retorno pq ele e bem interessante)
        return Ok(value.Concat(" template test"));

        // IActionResult retorna o valor em JSON, se voce fornecer dentro do Ok("conteudo") ou de outro metodo que encapsula o http
        // Voce pode retornar tambem apenas Ok(), que sera apenas um codigo 200 para o sistema
    }
}