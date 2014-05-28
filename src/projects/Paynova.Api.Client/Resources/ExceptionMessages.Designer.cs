﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Paynova.Api.Client.Resources {
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
    public class ExceptionMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Paynova.Api.Client.Resources.ExceptionMessages", typeof(ExceptionMessages).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Credentials should be url encoded and added to url according to format: &quot;http://user:password@serverurl&quot;.
        /// </summary>
        public static string BasicHttpConnection_InvalidFormatOfBasicCredentials {
            get {
                return ResourceManager.GetString("BasicHttpConnection_InvalidFormatOfBasicCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server address must contain url encoded basic credentials.
        /// </summary>
        public static string BasicHttpConnection_MissingBasicCredentials {
            get {
                return ResourceManager.GetString("BasicHttpConnection_MissingBasicCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while trying to create response: &apos;{0}&apos;. Description: &apos;{1}&apos;..
        /// </summary>
        public static string PaynovaSdkException_WhileCreatingResponse {
            get {
                return ResourceManager.GetString("PaynovaSdkException_WhileCreatingResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arrival can not be scheduled at the same time as, or before departure..
        /// </summary>
        public static string TravelSegment_ArivalMustBeAfterDeparture {
            get {
                return ResourceManager.GetString("TravelSegment_ArivalMustBeAfterDeparture", resourceCulture);
            }
        }
    }
}