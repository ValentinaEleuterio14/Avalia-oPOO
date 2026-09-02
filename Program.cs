// Cliente - Reservar mesa //

Cliente cliente = new Cliente("Eduardo", "38564785199");

cliente.ReservarMesa();


// Cliente - Pedir um prato //

cliente.PedirPrato("Nhoque ao molho de noz moscada");

Console.WriteLine(cliente);


// ChefDeCozinha - Exibir prato e valor //

ChefDeCozinha prato = new ChefDeCozinha(
    "Nhoque ao molho de noz moscada",
    45.90
);

Console.WriteLine(prato);


// Garçom - Servir cliente//

Garcom garcom = new Garcom("João");


garcom.ServirCliente(cliente);


// Garçom - Trazer a conta //

garcom.TrazerConta(85.90);

Console.WriteLine(garcom);



 