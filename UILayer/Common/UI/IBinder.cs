using System.Collections.Generic;
using GalaSoft.MvvmLight.Helpers;

namespace UILayer.UILayer.Common.UI
{
    public interface IBinder
    {
        List<Binding> Bindings { get; }

        void SetBindings();
        void SetCommands();
    }
}
