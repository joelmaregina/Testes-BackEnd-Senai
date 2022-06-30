# 📃 Relatório do Teste de Integração da Cauculadora de IMC :

## **Objetivo**:
Este teste tem a finalidade de descrever os resultados do Teste de Unidade realizado na aplicação de cálculo e classificação de IMC da NutriVitta pela TestFul, utilizando a ferramenta XUnit do Framework NET(C#).

## **Sobre o teste**:

|Aplicativo| NutriVitta |
|----------------|----------|
| Objetivo| Testar a funcionalidade do calculo e classificação do IMC <br> Testes únicos e em lista 
| Ferramentas | XUnit (Framework .NET ) |
| Linguagem | C# |
| IDE| Visual Studio |
| Tipo de teste| Teste de Unidade |
| Casos de teste com êxito| 10 => 100%
| Casos de teste com falha| 0 => 0%
|Responsável pelo teste|Joelma Regina Assis|
---
## **Desenho de teste :**
- O desenho do teste desenvolvido pode ser visto através desde <a href = "https://github.com/joelmaregina/Testes-BackEnd-Senai/blob/master/NutriVitta/TestXUnit/UnitTest1.cs">link</a>.

---
### **Primeiro caso – Cálculo do IMC::**
#### **Objetivo**
- Avaliar se aplicação realiza o calculo do IMC (peso/(altura*altura) corretamente após a inserção de dados fictícios de peso e altura.
#### **Resultado**
- Durante a chamada do método, ocorre o resultado esperado, a aplicação calcula corretamente o IMC.
----
### **Segundo caso – Classificação do IMC:**
#### **Objetivo**
- Avaliar se aplicação realiza o classificação do IMC corretamente após a inserção do IMC cauculado anteriormente.
#### **Resultado**
- Durante a chamada do método, ocorre o resultado esperado, a aplicação realiza a classificação correta do IMC testado.

---
### **Resultado do teste :**

- Conforme mostrado na imagem abaixo, a aplicação testada correspondeu às expectativas de funcionamento, sendo aprovados em todos os testes acima descritos e analisados.

 <img alt= "Printscreen da tela de resultados do teste, mostrando aprovação em todos os casos de teste" src= "https://github.com/joelmaregina/Senai-SQL-API/blob/master/API/img/ResultadoTeste.png"> 
