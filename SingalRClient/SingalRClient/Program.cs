using Microsoft.AspNetCore.SignalR.Client;

var connection = new HubConnectionBuilder()
    .WithUrl("https://localhost:44341/dataHub")
    .Build();

connection.On<string>("ReceiveData", (data) =>
{
    Console.WriteLine( string.Join(", ", data));
    //Console.WriteLine("Received data from server: " + string.Join(", ", data));
});

await connection.StartAsync();

Console.ReadKey();
