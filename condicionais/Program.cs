using condicionais.Classes;

Endereco newEndereco = new Endereco();

newEndereco.Logradouro = "Rua Deodato Wertheim";
newEndereco.Numero = 22;
newEndereco.Cep = "08773-090";
newEndereco.Bairro = "Vila Mogilar";
newEndereco.Municipio = "Mogi das Cruzes";
newEndereco.Estado = "São Paulo";
newEndereco.Pais = "Brasil";

Endereco metodosEnd = new Endereco();

Eleitor newEleitor = new Eleitor();

newEleitor.Nome = "Gustavo";
newEleitor.Cpf = "54698712399";
newEleitor.DataNasc = new DateTime(2002,10,05);
newEleitor.Endereco = newEndereco;

Eleitor metodosEleitor = new Eleitor();

Console.WriteLine(@$"
Nome: {newEleitor.Nome}
CPF: {newEleitor.Cpf}
Data de Nascimento: {newEleitor.DataNasc}
Endereço: {newEleitor.Endereco.Logradouro}, {newEleitor.Endereco.Cep}, {newEleitor.Endereco.Numero}, {newEleitor.Endereco.Bairro}, {newEleitor.Endereco.Municipio}
O eleitor está apto a votar?: {(metodosEleitor.ValidarDataNasc(newEleitor.DataNasc) ? "Sim" : "Não")}
");