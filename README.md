# PDV Quality

<p>Projeto criado para automação de casos de teste de uma aplicação PDV em Windows Forms.</p>

## Ferramentas utilizadas

- Csharp
- NUnit
- Selenium
- Winnium Driver

## Preparação do ambiente
Para rodar o projeto, utlize a IDE que você mais se identifique **(no meu caso, utilizo o Visual Studio Community)**, em seguida, altere a classe **Tests.cs** para que o projeto se adeque a ao 
executável **mais recente do PDV**:

**Trecho da classe que deve ser alterado**:

````csharp
    public class Tests
    {
        public static RemoteWebDriver Driver { get; set; }

        [SetUp]
        [Obsolete]
        public void Setup()
        {
            var dc = new DesiredCapabilities();
            dc.SetCapability("app", @"C:\PDV\PDV.UI.exe");
            Driver = new RemoteWebDriver(new Uri("http://localhost:9999"), dc);
        }
````

Em seguida, basta rodar a classe Tests.cs. Lembrando que este é apenas um projeto utilizado como modelo, tendo sua versão do PDV não disponibilizada pela empresa para detentora do mesmo, com este projeto servindo apenas como portfólio.
