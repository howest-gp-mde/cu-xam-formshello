//ensures the shared class library has access to this class. Must be defined outside of the namespace
[assembly: Xamarin.Forms.Dependency(typeof(XrnCourse.FormsHello.Droid.Services.MessageServiceDroid))]

namespace XrnCourse.FormsHello.Droid.Services
{

    class MessageServiceDroid : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "Android!";
        }
    }
}
