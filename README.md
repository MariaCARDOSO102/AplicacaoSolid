# Padrão SOLID

## 🧱 S - Single Responsibility Principle (Princípio da Responsabilidade Única)  
Cada classe deve ter apenas uma responsabilidade, ou seja, deve haver apenas uma razão para ela mudar. 
No exemplo a seguir é possível observar diversas classe, cada uma com sua responsabilidade bem definida.
- ConsoleTarefa -> É responsável por mostrar as operações que podem ser realizadas referente às tarefas e retorna o valor escolhido pelo usuário.
- GerenciadorTarefa -> Armazena uma lista de tarefas e possui métodos para: adicionar uma nova tarefa, retornar os valores da lista e filtrar por prioridade da tarefa.
- RelatorioTarefa -> É responsável por realizar os cálculos e exibir o relatório final das tarefas.
- Tarefa -> É a classe que representa cada tarefa e seus métodos.
- TarefaPrinter -> Tem a responsabilidade de printar cada tarefa.

![image](https://github.com/user-attachments/assets/86c347e4-bd6a-4c5c-b822-b6d674bfaafb)

---

## 🧱 O - Open/Closed Principle (Princípio Aberto/Fechado)  
Entidades de software devem estar abertas para extensão, mas fechadas para modificação. Ou seja, você pode estender funcionalidades sem alterar o código existente.
No código, Relatorio é uma classe base para todos os tipos de relatorios que podem ser feitos a partir de sua extensão.

![image](https://github.com/user-attachments/assets/d11a43b9-e1a5-495b-9d92-e6920eb9e7fc)

---

## 🧱 L - Liskov Substitution Principle (Princípio da Substituição de Liskov)  
Subtipos devem poder ser usados no lugar de seus tipos base sem alterar o comportamento do programa.
A classe GerenciadorTarefa pode assumir o tipo de Gerenciador pois sua interface estende a interface genérica IGerenciador.

![image](https://github.com/user-attachments/assets/5b777843-8d6f-490f-bc5e-b3bff2bb8801)

![image](https://github.com/user-attachments/assets/4a208822-1ac9-45fb-8439-347f4a16691c)

---

## 🧱 I - Interface Segregation Principle (Princípio da Segregação de Interfaces)  
Uma classe não deve ser forçada a implementar interfaces que não usa. Prefira interfaces menores e específicas.
No código as interfaces são minimas e possuem somente métodos correlatos.

![image](https://github.com/user-attachments/assets/28dc8c0d-5df9-4caf-9262-c58b39269383)

---

## 🧱 D - Dependency Inversion Principle (Princípio da Inversão de Dependência)  
Dependa de abstrações e não de implementações concretas. Isso torna o código mais flexível e testável.
Na classe RelatorioTarefa, a instancia do GerenciadorTarefa é representada por sua interface e inserida pelo método construtor

![image](https://github.com/user-attachments/assets/ad63d008-c8c3-4eb6-8488-057de0daef87)

