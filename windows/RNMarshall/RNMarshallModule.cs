using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Marshall.RNMarshall
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNMarshallModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNMarshallModule"/>.
        /// </summary>
        internal RNMarshallModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNMarshall";
            }
        }
    }
}
