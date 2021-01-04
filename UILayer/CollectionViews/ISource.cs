using System.Collections.Generic;

namespace UILayer.UILayer.CollectionViews
{
    public interface ISource<T>
    {
        void LoadData(List<T> data);
    }
}
