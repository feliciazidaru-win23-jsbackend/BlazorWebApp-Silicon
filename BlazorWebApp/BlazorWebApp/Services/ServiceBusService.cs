using Azure.Messaging.ServiceBus;
using Newtonsoft.Json;

namespace BlazorWebApp.Services;

public class ServiceBusService(ILogger<ServiceBusService> logger, IConfiguration configuration)
{
    private readonly ILogger<ServiceBusService> _logger = logger;
    private readonly IConfiguration _configuration = configuration;

    public async Task SendServiceBusMessage(object body, string connectionString, string queue)
    {
        try
        {
            var serviceBusClient = new ServiceBusClient(_configuration.GetConnectionString(connectionString));
            var sender = serviceBusClient.CreateSender(queue);
            var json = JsonConvert.SerializeObject(body);
            var message = new ServiceBusMessage(json);
            await sender.SendMessageAsync(message);
        }
        catch (Exception ex)
        {
            _logger.LogError($"SendServiceBusMessage() error : {ex.Message}");
        }

        return;
    }
}
