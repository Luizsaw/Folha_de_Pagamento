# 💼 Sistema de Folha de Pagamento

Sistema completo para gestão de folha de pagamento com controle de acesso, cadastro de empresas e funcionários, cálculo automatizado de remunerações, descontos e emissão de holerites em PDF. O projeto atende aos critérios legais e é multiplataforma (desktop, web e mobile).

<p align="center"><img src="\Assets\Banner - 5.png" alt="descrição da imagem" width="600"/></p>

---

## 🏗️ Arquitetura do Sistema

Após o levantamento de todos os requisitos, começamos a trabalhar na arquitetura do sistema. Foi então criado um ecossistema composto por **três aplicações integradas**:

1. **Folha de Pagamento (Desktop)** – voltada à gestão administrativa, cálculo e geração da folha.
2. **Registro de Ponto (Mobile)** – permite ao colaborador registrar seus horários de entrada, saída e pausas.
3. **Portal do Funcionário (Web)** – onde o colaborador pode consultar holerites, dados cadastrais e históricos.

Todas essas aplicações estão **conectadas a um único banco de dados PostgreSQL hospedado na nuvem**, garantindo persistência, consistência e centralização das informações.

Além disso, vale destacar que a **autenticação de usuários** nas plataformas **web e mobile** é realizada por meio do **Firebase Authentication**, um serviço da Google que oferece autenticação segura, escalável e moderna. Embora o Firebase seja um serviço de banco de dados, neste projeto ele foi utilizado exclusivamente para **gerenciar identidade e acesso dos usuários**, enquanto os dados persistentes do sistema permanecem no PostgreSQL.

Essa estrutura modular e integrada garante escalabilidade, segurança e uma experiência contínua ao usuário em diferentes plataformas.

<p align="center"><img src="\Assets\Banner - 1.png" alt="descrição da imagem" width="400"/></p>

---

## 📌 Visão Geral

Este sistema é composto por **três aplicações integradas**, cada uma com uma função específica dentro do fluxo de RH:

<p align="center"><img src="\Assets\Banner - 2.png" alt="descrição da imagem" width="600"/></p>

## 📌 Funcionalidades Principais

- 🔐 **Controle de acesso com login e senha** (perfil Gerente, Administrador e Usuário).


- 🧑‍💼 **Cadastro completo de colaboradores** com dados pessoais, contratuais e bancários.
- 🏢 **Cadastro de empresas clientes**.
- 📊 **Lançamento de dados salariais e variáveis** (horas, faltas, benefícios, descontos, etc.).
- 🧮 **Cálculo automatizado da folha** conforme INSS, IRRF e leis trabalhistas.
- 🔄 **Revisão e aprovação da folha** antes da geração final.
- 📄 **Geração de holerites em PDF**.
- ☁️ **Segurança e armazenamento de dados em nuvem com PostgreSQL**.

---

<p align="center">
  <img src="Assets/Captura de tela 2023-10-20 154450.png" alt="Imagem 1" width="600"/>
  <img src="Assets/Captura de tela 2023-10-20 154805.png" alt="Imagem 2" width="600"/>
</p>
<p align="center">
  <img src="Assets/Captura de tela 2023-10-20 154856.png" alt="Imagem 3" width="600"/>
  <img src="Assets/Captura de tela 2023-10-20 155101.png" alt="Imagem 4" width="600"/>
</p>

---

<h2 align="center">⚙️ Tecnologias Utilizadas</h2>

<div align="center"><a href="https://skillicons.dev"><img src="https://skillicons.dev/icons?i=git,vscode,js,css,html,postgres,dotnet,cs,visualstudio,flutter,firebase,react,dart" /></a><br /></div>

---

### 🌐 2. Portal do Funcionário (Web)

Aplicação web que permite aos colaboradores acessarem suas informações pessoais, visualizarem holerites, registros de ponto e atualizarem dados.

🔗 [Acessar repositório do Portal do Funcionário](https://github.com/Luizsaw/RHS_Portal_Funcionario)

---

### 📱 3. Registro de Ponto (App Android)

Aplicativo móvel para registro de jornada de trabalho. Funcionalidades:

- Marcação de entrada/saída  
- Intervalos (almoço)  
- Integração com o sistema de folha

🔗 [Acessar repositório do App de Ponto](https://github.com/Luizsaw/RHS_Folha_de_Ponto)

---

## 📚 Documentação Técnica

A documentação do projeto inclui detalhes sobre:

- Estrutura e arquitetura do sistema  
- Modelagem de dados  
- Decisões de design e tecnologias utilizadas  
- Fluxos de uso e integração entre os sistemas

📄 [Visualizar Documentação Completa]("\Documentacao\Doc_Sistema_Folha_de_Pagamento.pdf")

---

## 🧰 Tecnologias Utilizadas

- C# (.NET Framework – Windows Forms)  
- SQL Server (banco de dados)  
- Git + GitHub  
- Visual Studio

---

## 🙋 Sobre os Autores

**LUIZ CARLOS DE ARAÚJO MACHADO**  
Desenvolvedor de Sistemas com foco em aplicações full-stack e soluções empresariais.  
📧 [luizsaw@gmail.com](mailto:luizsaw@gmail.com)  
🔗 [LinkedIn](https://www.linkedin.com/in/luiz-machado-57366a174)

**GABRIEL NATAN MAGALHÃES BENTO DE MEDEIROS**    
📧 [gabriel.natan.mb@gmail.com](mailto:gabriel.natan.mb@gmail.com)  
🔗 [LinkedIn](https://www.linkedin.com/in/gabrielnmag/)

---

## ⭐ Contribuições e Feedback

Sinta-se à vontade para abrir **issues** com sugestões, correções ou melhorias.  
Contribuições são sempre bem-vindas!

---

