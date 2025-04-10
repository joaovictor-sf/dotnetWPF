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

### Backend
Para adicionar lógica ao seu projeto, você pode usar o arquivo `MainWindow.xaml.cs`. Este arquivo contém a lógica de código por trás da janela principal. Você pode adicionar métodos, manipuladores de eventos e outras funcionalidades aqui.

<img src="images/Run.png" alt="Backend" width="400"/>
<img src="images/!Run.png" alt="Debug" width="400"/>

*xaml*
```xaml
<Grid>
    <TextBlock x:Name="tbHello" Text="Hello World!" FontSize="50" HorizontalAlignment="Center" VerticalAlignment="Center"/>
    <Button x:Name="btnRun" Content="Run" Width="100" Height="50" FontSize="20" HorizontalAlignment="Center" Margin="0,300,0,0" VerticalAlignment="Center" Click="btnRun_Click"/>
</Grid>
```

*C#*
```csharp
private void btnRun_Click(object sender, RoutedEventArgs e) {
        if (isRunning) {
            tbHello.Text = "Hello World!";
        } else {
            tbHello.Text = "Goodbye World!";
        }
        isRunning = !isRunning;
}
```

### Grids
O Grid é um dos contêineres mais comuns usados em WPF. Ele permite que você organize os controles em linhas e colunas, facilitando o layout da interface do usuário. Você pode definir a quantidade de linhas e colunas que deseja usar e, em seguida, adicionar controles a essas células.
```xaml
<Grid>
    <Grid.RowDefinitions>
            <RowDefinition/>
            <RowDefinition/>
            <RowDefinition/>
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition/>
            <ColumnDefinition/>
        </Grid.ColumnDefinitions>

        <Rectangle Grid.Row="0" Grid.Column="0" Fill="Red" Margin="10"/>
        <Rectangle Grid.Row="1" Grid.Column="1" Fill="Green" Margin="10"/>
        <Rectangle Grid.Row="2" Grid.Column="0" Fill="Blue" Margin="10"/>
</Grid>
```

img src="images/Grid.png" alt="Grid" width="400"/>

#### Linhas e Colunas
Você pode definir linhas e colunas no Grid usando as propriedades `RowDefinitions` e `ColumnDefinitions`. Cada linha e coluna pode ter uma altura ou largura fixa, automática ou proporcional. Você pode usar a propriedade `Height` ou `Width` para definir o tamanho de cada linha ou coluna.
```xaml
<Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="70"/>
            <RowDefinition/>
            <RowDefinition Height="20"/>
        </Grid.RowDefinitions>
        
        <!--Menu Bar-->
        <Rectangle Grid.Row="0" Fill="Red"/>

        <!--Content Pane-->
        <Grid Grid.Row="1">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width=".2*"/><!--20%-->
                <ColumnDefinition Width=".6*"/>
                <!--Pode ser .6* ou 60*-->
                <ColumnDefinition Width=".2*"/>
            </Grid.ColumnDefinitions>

            <Rectangle Grid.Column="0" Fill="Green"/>
            <Rectangle Grid.Column="1" Fill="Yellow"/>
            <Rectangle Grid.Column="2" Fill="Purple"/>

        </Grid>

        <!--Footer-->
        <Rectangle Grid.Row="2" Fill="Blue"/>
</Grid>
```

As "* " e "Auto" são usados para definir o tamanho proporcional e automático, respectivamente. O "*" significa que a linha ou coluna ocupará o espaço restante disponível na janela. O "Auto" significa que a linha ou coluna terá o tamanho necessário para acomodar seu conteúdo."

<img src="images/Grid2.png" alt="Row" width="400"/>>

### UserControls
Os UserControls são uma maneira de criar componentes reutilizáveis em WPF. Eles permitem que você agrupe controles e lógica em um único controle que pode ser usado em várias partes da sua aplicação. Isso ajuda a manter o código organizado e facilita a manutenção.

Para criar um UserControl, clique com o botão direito do mouse na pasta do projeto e selecione "Adicionar" > "Novo Item". Escolha "User Control (WPF)" e dê um nome ao seu controle. O Visual Studio criará dois arquivos: um arquivo XAML para a interface do usuário e um arquivo C# para a lógica de código por trás do controle.

```xaml
<UserControl x:Class="WPFTutorial.View.UserControls.MenuBar"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:local="clr-namespace:WPFTutorial.View.UserControls"
             mc:Ignorable="d" 
             Height="70" d:DesignWidth="800">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="30"/>
            <RowDefinition Height="40"/>
        </Grid.RowDefinitions>

        <Menu>
            <MenuItem Header="File" FontSize="16">
                <MenuItem Header="Exit" FontSize="16"/>
            </MenuItem>
            <MenuItem Header="Edit" FontSize="16"/>
        </Menu>

        <Grid Grid.Row="1">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="auto"/>
                <ColumnDefinition Width="auto"/>
            </Grid.ColumnDefinitions>

            <Button Width="50" Margin="5"/>
            <TextBox Width="150" Grid.Column="1" Margin="5"/>
        </Grid>
    </Grid>
</UserControl>
```

Para usar o UserControl em sua aplicação, você pode copiar o xmlns:local, que é o namespace do UserControl, e colar no arquivo XAML onde você deseja usar o controle. Em seguida, mude o nome de local para o nome do userControl.
Depois basta colocar a tag do UserControl no local desejado.

```xaml
<Window x:Class="WPFTutorial.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WPFTutorial"
        xmlns:userControls="clr-namespace:WPFTutorial.View.UserControls"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height=".2*"/>
            <RowDefinition Height=".7*"/>
            <RowDefinition Height=".1*"/>
        </Grid.RowDefinitions>

        <userControls:MenuBar/>
    </Grid>
</Window>
```

<img src="images/UserControls.png" alt="UserControl" width="400"/>