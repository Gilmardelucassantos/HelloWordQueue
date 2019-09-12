using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.App
{
    public class AppProvider: IAppProvider
    {
        public string AppId { get; set; }

        public AppProvider(string appId)
        {
            AppId = appId;
        }
    }
}
