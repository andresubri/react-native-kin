using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Kin.RNKin
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNKinModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNKinModule"/>.
        /// </summary>
        internal RNKinModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNKin";
            }
        }
    }
}
