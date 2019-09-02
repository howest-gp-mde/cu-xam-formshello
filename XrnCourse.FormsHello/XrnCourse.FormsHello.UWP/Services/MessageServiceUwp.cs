//ensures the shared class library has access to this class. Must be defined outside of the namespace
[assembly: Xamarin.Forms.Dependency(typeof(XrnCourse.FormsHello.UWP.Services.MessageServiceUWP))]

namespace XrnCourse.FormsHello.UWP.Services
{
    class MessageServiceUWP : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "UWP!";
        }
    }
}
