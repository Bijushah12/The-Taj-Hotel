using Microsoft.AspNetCore.SignalR;

public class BookingHub : Hub
{
    public async Task SendBookingUpdate(string message)
    {
        await Clients.All.SendAsync("ReceiveBooking", message);
    }
}
