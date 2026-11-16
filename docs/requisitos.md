# Requisitos do Sistema

## 1. Regras de Negócio (RN)

- **RN01** - As consultas duram 30 minutos.
- **RN02** - As consultas só podem ser marcadas de segunda a sexta, das 8h às 12h e das 13h30 às 18h, considerando o horário de almoço das 12h às 13h30.
- **RN03** - As consultas só podem estar em uma de 3 situações por vez: agendada, realizada ou cancelada.
- **RN04** - Uma consulta só pode ser cancelada se ainda estiver como agendada.
- **RN05** - Dentro da agenda de um veterinário, uma consulta não pode sobrepor o horário de outra e não pode estar dentro do horário de almoço.
- **RN06** - Apenas recepcionistas podem cadastrar animais, tutores e veterinários.
- **RN07** - Apenas recepcionistas podem marcar ou cancelar consultas.
- **RN08** - Cada veterinário pode consultar apenas a própria agenda do dia.
- **RN09** - Não é possível agendar consultas para datas que já passaram.
- **RN10** - Somente consultas agendadas podem ser marcadas como realizadas, e apenas pelo veterinário da consulta. 
- **RN11** - O veterinário deve realizar observações sobre a consulta.
- **RN12** - Os recepcionistas podem consultar as agendas do dia.
- **RN13** - O horário máximo do início de uma consulta no período matutino é 11h30 e no período vespertino é 17h30.

## 2. Requisitos Funcionais (RF)

- **RF01** - O sistema deverá cadastrar animais (RN06).
- **RF02** - O sistema deverá cadastrar veterinários (RN06).
- **RF03** - O sistema deverá cadastrar tutores (RN06).
- **RF04** - O sistema deverá agendar consultas (RN07).
- **RF05** - O sistema deverá impedir o cadastro de consultas para datas passadas (RN09).
- **RF06** - O sistema deverá agendar consultas apenas para segunda à sexta, das 8h às 12h e das 13h30 às 18h, considerando o horário de almoço das 12h às 13h30. (RN02).
- **RF07** - O sistema deverá realizar o cancelamento somente de consultas agendadas (RN07).
- **RF08** - O sistema deverá mudar a situação da consulta para realizada (RN10).
- **RF09** - O sistema deverá registrar observações sobre a consulta (RN11).
- **RF10** - O sistema deverá permitir que o veterinário consulte apenas sua própria agenda (RN08).
- **RF11** - O sistema deverá impedir o cadastro de horários sobrepostos para o mesmo veterinário (RN05). 
- **RF12** - O sistema deverá estabelecer a duração de 30 minutos por consulta (RN01).
- **RF13** - O sistema deverá realizar consultas das agendadas do dia (RN12).
  
## 3. Requisitos Não Funcionais (RNF)

- **RNF01** - O sistema será desenvolvido em C# (.NET 10) | linguagem e plataforma de desenvolvimento.
- **RNF02** - O acesso às funcionalidades deve ser correspondente ao ator | segurança e controle de acesso.
- **RNF03** - O sistema deverá carregar e apresentar os dados das consultas em até 5 segundos | desempenho.
- **RNF04** - O sistema deverá utilizar um banco de dados relacional, gerenciado por um SGBD compatível com SQL | Gerenciamento de banco de dados.
