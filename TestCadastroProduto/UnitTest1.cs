
using CadastroProduto.Classes;

namespace TestCadastroProduto;

public class UnitTest1
{
    private EventoDeCadastro e = new EventoDeCadastro();
    
    [Theory]
    [InlineData (23)]
    [InlineData (-23)]
    public void VerificaSeValorNegativo(int cdProduto){
        //Act
        var result = e.VerificaCodigoProduto(cdProduto);

        //Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData ("Bruno")]
    [InlineData ("")]
    public void VerificaSeNomeEstaVazio( string nmProduto){     
        //Act        
        var result = e.VerificaNomeProduto(nmProduto);

        //Assert
        Assert.False(result);
    }
}
