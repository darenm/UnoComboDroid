using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoComboDroid.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoComboDroid.App(), args);
            host.Run();
        }
    }
}
