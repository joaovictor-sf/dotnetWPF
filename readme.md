# WPF
WPF é um framework para desenvolvimento de aplicações desktop no Windows. Ele é baseado no .NET e permite criar interfaces de usuário ricas e interativas. O WPF utiliza o XAML (Extensible Application Markup Language) para definir a interface do usuário, o que facilita a separação entre a lógica de negócios e a apresentação.

## WPF ou Avalonia
WPF é uma tecnologia específica para o Windows, enquanto Avalonia é um framework multiplataforma que permite criar aplicações desktop que podem ser executadas em diferentes sistemas operacionais, como Windows, macOS e Linux. Se você está desenvolvendo uma aplicação que precisa ser executada em várias plataformas, Avalonia pode ser a melhor escolha. No entanto, se você está focado apenas no Windows e deseja aproveitar os recursos específicos do sistema operacional, o WPF é uma excelente opção.

## Estrutura do projeto
O projeto WPF é organizado em várias pastas e arquivos, cada um com uma função específica. Abaixo está uma breve descrição da estrutura típica de um projeto WPF:

- **App.xaml**: Este arquivo contém a definição da aplicação e é o ponto de entrada para o aplicativo WPF. Ele também pode conter recursos globais, como estilos e dicionários de recursos.
- **App.xaml.cs**: Este arquivo contém a lógica de inicialização da aplicação. Ele é gerado automaticamente pelo Visual Studio e contém o código para iniciar a aplicação e carregar a janela principal.
- **MainWindow.xaml**: Este arquivo contém a definição da janela principal da aplicação. Ele é escrito em XAML e define a interface do usuário, incluindo botões, caixas de texto e outros controles.
- **MainWindow.xaml.cs**: Este arquivo contém a lógica de código por trás da janela principal. Ele é gerado automaticamente pelo Visual Studio e contém o código para manipular eventos, como cliques de botão e alterações de texto.

## O que é XAML
XAML (Extensible Application Markup Language) é uma linguagem de marcação usada para definir a interface do usuário em aplicações WPF. Ele permite que os desenvolvedores descrevam a aparência e o comportamento dos controles de forma declarativa, separando a lógica de negócios da apresentação. O XAML é semelhante ao HTML, mas é projetado especificamente para criar interfaces de usuário ricas e interativas em aplicações desktop.

## Apreendendo
### Criando um novo projeto WPF
1. Abra o Visual Studio e clique em "Criar um novo projeto".
2. Selecione "Aplicativo WPF (.NET Core)" ou "Aplicativo WPF (.NET Framework)" e clique em "Avançar".
3. Dê um nome ao seu projeto e escolha um local para salvá-lo. Clique em "Criar".
4. O Visual Studio criará um novo projeto WPF com a estrutura básica de arquivos e pastas.

### Hello World
<img src="images/HelloWorld.png" alt="Hello World" width="400"/>

Há duas maneiras de criar e modificar um projeto WPF: Você pode ultilizar a ToolBox do Visual Studio ou pode escrever o código manualmente. A escolha é por preferencia pessoal, muito provavelmente você irá utilizar as duas maneiras em algum momento.
Mesmo que você utilize a ToolBox, você provavelmente terá que modificar o código manualmente em algum momento, então é bom ter uma noção de como funciona.

```xaml
<Window x:Class="WPFTutorial.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WPFTutorial"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <TextBlock Text="Hello World" FontSize="50" HorizontalAlignment="Center" VerticalAlignment="Center"/>
    </Grid>
</Window>
```
