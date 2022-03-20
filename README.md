# Desafio técnico
## Seleção de famílias aptas a ganharem uma casa popular

- Teste desenvolvido em template WebApi (RestAPI) em .Net core 5.
- Utilizado banco de dados SQlEXPRESS para armazenar dados das familias.
- Utilizado EntityFrameWork para manipulação gerenciamento. 
- Utilizado Migrations para gerar a base de dados em SQL.
### Gerar o Banco de dados:
 Para gerar o banco de dados, é necessário que tenhas o SQLEXPRESS instalado na maqui ou apontar a string de conexão em "appsettings.json" para o servidor de banco desejado.
 Para gerar o banco, rode os seguintes comandos no Visual Studio em Package Manager Console apontando o default project para "familia.data".


	Add-Migration CreateInitialSchema -Context DatabaseContext
	script-migration -Context DatabaseContext (Opcional. Rode o comando se desejar gerar script.)
	Update-Database -Context DatabaseContext

### Informações de armazenamento das familias:
Dentro da aplicação existe a funcionalidade de SEED para gerar os dados das familias para facilitar o entendimento.
Ao rodar a aplicação pela primeira vez será feito uma verificação se existe dados nas tabelas respectivas da base de dados, caso não exista o software fará o insert.

