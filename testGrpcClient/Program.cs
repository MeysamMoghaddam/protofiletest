// See https://aka.ms/new-console-template for more information


using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using testGrpcService;

using var grpcChannel = GrpcChannel.ForAddress("https://localhost:7008/");

var client = new Greeter.GreeterClient(grpcChannel);
HelloRequest request = new HelloRequest
{
    Name = "Meysam",
    Test = new Test
    {
        TestName = "Moghaddam"
    }
};

var reply = client.SayHello(request);

Console.WriteLine(reply.Message);
Console.ReadKey();
