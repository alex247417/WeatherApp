🌦️ Clima App em Blazor
Um aplicativo web simples, moderno e funcional, desenvolvido com .NET 9 e Blazor Server, que permite consultar a previsão do tempo em tempo real de qualquer cidade do mundo, utilizando a API da OpenWeather.

Este projeto foi criado como exercício prático para consolidar conhecimentos em desenvolvimento web moderno com o ecossistema .NET.

💡 Dica: Faça um print do app funcionando e adicione ao seu repositório para valorizar ainda mais seu portfólio!

✨ Funcionalidades
🔍 Consulta de clima em tempo real
Digite o nome de uma cidade e receba a temperatura atual e a descrição do clima.

⚡ Interface reativa com Blazor Server
Interações fluídas sem recarregar a página.

📱 Design responsivo
Layout limpo e adaptável para dispositivos móveis, tablets e desktops.

🔒 Chave de API protegida com .NET User Secrets
Segurança garantida — a chave da OpenWeather não fica visível no código-fonte.

🛠️ Tecnologias Utilizadas
.NET 9

C# 13

Blazor Server

Injeção de Dependência (DI)

HttpClient para consumo de APIs REST

System.Text.Json para manipulação de JSON

Bootstrap 5 (para layout)

Bootstrap Icons (para ícones modernos)

🚀 Como Executar o Projeto
✅ Pré-requisitos
.NET 9 SDK instalado

▶️ Passos
Clone o repositório:

bash
Copiar
Editar
git clone 
Navegue até a pasta do projeto:

bash
Copiar
Editar
cd NOME_DA_PASTA_DO_PROJETO
Configure a chave da API da OpenWeather:
Crie uma conta gratuita em openweathermap.org e copie sua chave de API.

Execute no terminal:

bash
Copiar
Editar
dotnet user-secrets set "OpenWeather:ApiKey" "SUA_CHAVE_AQUI"
Execute o projeto:

bash
Copiar
Editar
dotnet run
Acesse no navegador:
http://localhost:5232 (ou a porta exibida no terminal)

🔐 Sobre a Configuração da Chave de API
Este projeto utiliza o recurso .NET User Secrets para proteger dados sensíveis, como a chave de API.

A configuração é feita apenas uma vez e não será adicionada ao repositório, mantendo sua chave segura mesmo em projetos públicos.

📷 Screenshot
<img width="1908" height="681" alt="image" src="https://github.com/user-attachments/assets/20e578da-eb56-4f02-aa80-1b2f45d48206" />


🧠 Aprendizados e Práticas Aplicadas
Integração com serviços externos (APIs REST)

Criação de componentes interativos com Blazor

Organização de código com injeção de dependência

Estilo e responsividade com Bootstrap

Práticas de segurança com User Secrets

✅ Status do Projeto
✔️ Finalizado e funcional
📦 Pronto para adicionar ao portfólio
📱 Compatível com dispositivos móveis

🧑‍💻 Autor
Feito por Alecsandro utilizando Blazor e .NET
Projeto completo, pronto para ser apresentado em entrevistas ou usado como base para novos apps.

