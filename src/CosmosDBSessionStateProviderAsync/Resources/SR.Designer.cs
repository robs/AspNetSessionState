﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNet.SessionState.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNet.SessionStateCosmosDBSessionStateProviderAsync.Resources.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; cannot be null..
        /// </summary>
        internal static string ArgumentNull_WithParamName {
            get {
                return ResourceManager.GetString("ArgumentNull_WithParamName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified container &apos;{0}&apos; already exists with a partition key path other than &apos;{1}&apos;..
        /// </summary>
        internal static string Container_PKey_Does_Not_Match {
            get {
                return ResourceManager.GetString("Container_PKey_Does_Not_Match", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration &apos;{0}&apos; cannot be null..
        /// </summary>
        internal static string EmptyConfig_WithName {
            get {
                return ResourceManager.GetString("EmptyConfig_WithName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The session state information is invalid and might be corrupted..
        /// </summary>
        internal static string Invalid_session_state {
            get {
                return ResourceManager.GetString("Invalid_session_state", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request rate to CosmosDB is too large. You may consider to increase the offer throughput of the CosmosDB collection or increase maxRetryAttemptsOnThrottledRequests and maxRetryWaitTimeInSeconds settings in web.config.
        /// </summary>
        internal static string Request_To_CosmosDB_Is_Too_Large {
            get {
                return ResourceManager.GetString("Request_To_CosmosDB_Is_Too_Large", resourceCulture);
            }
        }
    }
}
