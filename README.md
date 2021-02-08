# Cantina do tio bil

<h3>Parte do sistema pronto:</h3>

* Crud Produtos.

* Crud Pedidos.

* Crud Clientes.

* Banco de dados com entity framework.

<h3>Em andamento:</h3>

* Parte da logica da tela de detalhes do pedido.

* Tela de relatorios com ReportViewer.
  
<h3>Não feito:</h3>

* Teste unitario.

<h3>Observação</h3>
* Na pasta "Banco de dados modelo" está o arquivo .sql que foi usado no funcionamento do sistema.

* Caso queira usar um DB local, no aquivo Models/ApllicationDBContex.cs trocar na linha 9 o valor que 'Data Source' para seu banco de dados.
* linha 9:optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\SQLEXPRESS;Initial Catalog=db_cantina;Integrated Security=True");.
