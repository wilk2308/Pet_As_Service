# 🐾 Pet As A Service - #7DaysOfCode

Projeto desenvolvido para o desafio **#7DaysOfCode** da [Alura](https://www.alura.com.br/), com o objetivo de aplicar conhecimentos de C# e Windows Forms criando uma aplicação interativa e divertida sobre raças de gatos. 😺

---

## 🎯 Objetivo

Criar uma aplicação desktop em C# que consome uma API pública de gatos para buscar informações sobre diferentes raças, exibir seus detalhes e permitir marcar raças como favoritas.

---

## 🖼️ Interface

A aplicação possui uma interface simples, construída com **Windows Forms**, contendo:

- Barra superior com logo e navegação (Home, Buscar Raças, Meus Favoritos)
- Campo de busca por nome da raça
- Exibição dos detalhes da raça:
  - Nome
  - Origem
  - Temperamento
  - Tipo de pelo
  - Cuidados
  - Imagem ilustrativa
- Botão para "Favoritar"
- Tela de favoritos salvos

![Pet As A Service - Print do Home](https://github.com/wilk2308/Pet_As_Service/blob/main/img/home.png)
![Pet As A Service - Print do Buscar](https://github.com/wilk2308/Pet_As_Service/blob/main/img/buscar.png)

---

## 🛠️ Tecnologias Utilizadas

- 🧠 **C#**
- 🖥️ **Windows Forms (.NET Framework)**
- 🌐 **Consumo de API REST** ([The Cat API](https://thecatapi.com/))
- 💾 Armazenamento local de favoritos (ex: lista interna em memória ou arquivo)

---

## 📁 Estrutura do Projeto

```
Pet_As_Service/
├── CatApiService.cs          # Serviço para consumir a API de raças
├── RacaGato.cs               # Modelo de dados para a raça
├── Form1.cs                  # Tela principal (home)
├── FormBuscaRacas.cs         # Tela de busca e detalhes da raça
├── FormFavoritos.cs          # Tela para exibir favoritos
├── GerenciadorFavoritos.cs   # Classe auxiliar para gerenciar favoritos
├── Program.cs                # Entry point da aplicação
├── App.config
└── Pet_As_Service.csproj
```

---

## 📦 Como executar o projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/PetAsAService.git
   ```
2. Abra o projeto com o **Visual Studio**.
3. Compile e execute (`F5`).
4. Utilize a interface para buscar raças de gatos e visualizar seus detalhes.

---

## 📌 Funcionalidades

- [x] Buscar raças de gatos pelo nome
- [x] Exibir informações detalhadas da raça
- [x] Exibir imagem ilustrativa
- [x] Marcar raças como favoritas
- [ ] Navegação entre telas *(em desenvolvimento)*
- [ ] Armazenar favoritos de forma persistente *(em desenvolvimento)*

---

## 📚 Aprendizados

Durante esse projeto, foi possível praticar:

- Manipulação de formulários no Windows Forms
- Criação de componentes reutilizáveis
- Integração com APIs REST usando `HttpClient`
- Organização de código por responsabilidade (MVC simplificado)
- Trabalhar com listas, objetos e eventos em C#

---

## 👤 Autor

Desenvolvido por [Will](https://github.com/wilk2308) como parte do desafio **#7DaysOfCode**.


