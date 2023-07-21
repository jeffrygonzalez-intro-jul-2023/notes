using FirstApp.Models;

namespace FirstApp.Services;

public class RemoteStatusService : IProvideTheSystemStatus
{
    public StatusResponseModel GetCurrentStatus()
    {
        // put all the code here to call the other service, unit test, it, get it approved, all that stuff
        return new StatusResponseModel(new DateTime(1969, 4, 20, 23, 59, 00), "The other server says awesome!", "Good Jorb");
    }
}
