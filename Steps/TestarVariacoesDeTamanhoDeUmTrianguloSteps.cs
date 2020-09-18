using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace TesteTriangulo.Steps
{
    [Binding]
    public class TestarVariacoesDeTamanhoDeUmTrianguloSteps
    {
        private Triangulo Triangulo { get; set; }
        private string RetornoValidacao { get; set; }
       
        public TestarVariacoesDeTamanhoDeUmTrianguloSteps()
        {
            Triangulo = new Triangulo();

        }
        
        [When(@"informar os valores das arestas de um triangulo (.*) (.*) (.*)")]
        public void QuandoInformarOsValoresDasArestasDeUmTriangulo(int x, int y, int z)
        {
            Triangulo.verificarTipoDoTriangulo(x, y, z);            
        }
        
        [Then(@"a aplicação valida se é um triângulo válido e retorna seu (.*)")]
        public void EntaoAAplicacaoValidaSeEUmTrianguloValidoERetornaSeuEscaleno(string tipo)
        {
            Assert.AreEqual(RetornoValidacao, tipo);
        }
    }
}
