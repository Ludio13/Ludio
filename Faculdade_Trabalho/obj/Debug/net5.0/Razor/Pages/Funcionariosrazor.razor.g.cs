#pragma checksum "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09abc4fb70ca0e321003d53c13ec9bd7658a6a85"
// <auto-generated/>
#pragma warning disable 1591
namespace Faculdade_Trabalho.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\_Imports.razor"
using Faculdade_Trabalho;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\_Imports.razor"
using Faculdade_Trabalho.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\_Imports.razor"
using Faculdade_Trabalho.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CadastroFuncionarios")]
    public partial class Funcionariosrazor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Cadastro Funcionario</h1>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "formulario");
            __builder.AddMarkupContent(3, "<label>RA:</label>\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "number");
            __builder.AddAttribute(6, "class", "campos");
            __builder.AddAttribute(7, "id", "campoRA");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor"
                                                            RA

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => RA = __value, RA, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n    <p></p>\n    ");
            __builder.AddMarkupContent(11, "<label>Nome:</label>\n    ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "class", "campos");
            __builder.AddAttribute(15, "id", "campoNome");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor"
                                                            nome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nome = __value, nome));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n    <p></p>\n    ");
            __builder.AddMarkupContent(19, "<label>Data de nascimento:</label>\n    ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "date");
            __builder.AddAttribute(22, "class", "campos");
            __builder.AddAttribute(23, "id", "campoDataNascimento");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor"
                                                                      nascimento

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nascimento = __value, nascimento, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    <p></p>\n    ");
            __builder.AddMarkupContent(27, "<label>CPF:</label>\n    ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "number");
            __builder.AddAttribute(30, "class", "campos");
            __builder.AddAttribute(31, "id", "campoCPF");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor"
                                                             cpf

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cpf = __value, cpf, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n    <p></p>\n    ");
            __builder.AddMarkupContent(35, "<label>Telefone:</label>\n    ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "number");
            __builder.AddAttribute(38, "class", "campos");
            __builder.AddAttribute(39, "id", "campoTelefone");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor"
                                                                  telefone

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => telefone = __value, telefone, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n    <p></p>\n    ");
            __builder.AddMarkupContent(43, "<label>Endereço:</label>\n    ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "text");
            __builder.AddAttribute(46, "class", "campos");
            __builder.AddAttribute(47, "id", "campoEndereco");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor"
                                                                endereco

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => endereco = __value, endereco));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n    <p></p>\n    ");
            __builder.AddMarkupContent(51, "<label>Salário:</label>\n    ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "number");
            __builder.AddAttribute(54, "class", "campos");
            __builder.AddAttribute(55, "id", "campoSalario");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor"
                                                                 salario

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => salario = __value, salario, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n    <p></p>\n    ");
            __builder.AddMarkupContent(59, "<label>Grau de instrução:</label>\n    ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "type", "text");
            __builder.AddAttribute(62, "class", "campos");
            __builder.AddAttribute(63, "id", "campoGrau");
            __builder.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor"
                                                            grau

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => grau = __value, grau));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n    <p></p>\n    ");
            __builder.AddMarkupContent(67, "<label>Formação:</label>\n    ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "text");
            __builder.AddAttribute(70, "class", "campos");
            __builder.AddAttribute(71, "id", "campoFormacao");
            __builder.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor"
                                                                formacao

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => formacao = __value, formacao));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n    <p></p>\n    ");
            __builder.AddMarkupContent(75, "<label>Setor:</label>\n    ");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "type", "text");
            __builder.AddAttribute(78, "class", "campos");
            __builder.AddAttribute(79, "id", "camposetor");
            __builder.AddAttribute(80, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor"
                                                             setor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => setor = __value, setor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n    ");
            __builder.AddMarkupContent(83, "<label>cargo:</label>\n    ");
            __builder.OpenElement(84, "input");
            __builder.AddAttribute(85, "type", "text");
            __builder.AddAttribute(86, "class", "campos");
            __builder.AddAttribute(87, "id", "campocargo");
            __builder.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor"
                                                             cargo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cargo = __value, cargo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\n    ");
            __builder.AddMarkupContent(91, "<label>chefe:</label>\n    ");
            __builder.OpenElement(92, "input");
            __builder.AddAttribute(93, "type", "text");
            __builder.AddAttribute(94, "class", "campos");
            __builder.AddAttribute(95, "id", "campochefe");
            __builder.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor"
                                                             chefe

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => chefe = __value, chefe));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\n");
            __builder.OpenElement(99, "div");
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "class", "btnCadastrar");
            __builder.AddAttribute(102, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor"
                                           CadastrarFuncionario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(103, "Cadastrar");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\jhona\OneDrive\Área de Trabalho\TrabalhoBlazor\Faculdade-master\Faculdade_Trabalho\Pages\Funcionariosrazor.razor"
        [Parameter] public EventCallback CadastrarFuncionario { get; set; }


    int RA;
    string nome;
    DateTime nascimento;
    int cpf;
    int telefone;
    string endereco;
    float salario;
    string grau;
    string formacao;
    string setor;
    string cargo;
    string chefe;


    public Funcionarios NovoFuncionario()
    {
        Funcionarios novofuncionario = new Funcionarios();

        novofuncionario.RA = RA;
        novofuncionario.nome = nome;
        novofuncionario.dataDeNascimento = nascimento;
        novofuncionario.CPF = cpf;
        novofuncionario.telefone = telefone;
        novofuncionario.endereco = endereco;
        novofuncionario.salario = salario;
        novofuncionario.grau = grau;
        novofuncionario.formacao = formacao;
        novofuncionario.setor = setor;
        novofuncionario.cargo = cargo;
        novofuncionario.chefe = chefe;


        return novofuncionario;
    }

    public void Cadastrar()
    {

        Funcionarios novoFuncionario = NovoFuncionario();


    } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
