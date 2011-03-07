﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Interface.Strings {
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
    internal class Common {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Common() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Interface.Strings.Common", typeof(Common).Assembly);
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
        ///   Looks up a localized string similar to Cancelled.
        /// </summary>
        internal static string CancelExceptionError {
            get {
                return ResourceManager.GetString("CancelExceptionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration for the backend is not valid, it is missing the {0} field.
        /// </summary>
        internal static string ConfigurationIsMissingItemError {
            get {
                return ResourceManager.GetString("ConfigurationIsMissingItemError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to test the connection?.
        /// </summary>
        internal static string ConfirmTestConnectionQuestion {
            get {
                return ResourceManager.GetString("ConfirmTestConnectionQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection Failed: {0}.
        /// </summary>
        internal static string ConnectionFailure {
            get {
                return ResourceManager.GetString("ConnectionFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection succeeded!.
        /// </summary>
        internal static string ConnectionSuccess {
            get {
                return ResourceManager.GetString("ConnectionSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have not entered a path. This will store all backups in the default directory. Is this what you want?.
        /// </summary>
        internal static string DefaultDirectoryWarning {
            get {
                return ResourceManager.GetString("DefaultDirectoryWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must enter a password.
        /// </summary>
        internal static string EmptyPasswordError {
            get {
                return ResourceManager.GetString("EmptyPasswordError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have not entered a password.
        ///Proceed without a password?.
        /// </summary>
        internal static string EmptyPasswordWarning {
            get {
                return ResourceManager.GetString("EmptyPasswordWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must enter the name of the server.
        /// </summary>
        internal static string EmptyServernameError {
            get {
                return ResourceManager.GetString("EmptyServernameError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must enter a username.
        /// </summary>
        internal static string EmptyUsernameError {
            get {
                return ResourceManager.GetString("EmptyUsernameError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have not entered a username.
        ///This is fine if the server allows anonymous uploads, but likely a username is required
        ///Proceed without a username?.
        /// </summary>
        internal static string EmptyUsernameWarning {
            get {
                return ResourceManager.GetString("EmptyUsernameWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder cannot be created because it already exists.
        /// </summary>
        internal static string FolderAlreadyExistsError {
            get {
                return ResourceManager.GetString("FolderAlreadyExistsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder created!.
        /// </summary>
        internal static string FolderCreated {
            get {
                return ResourceManager.GetString("FolderCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested folder does not exist.
        /// </summary>
        internal static string FolderMissingError {
            get {
                return ResourceManager.GetString("FolderMissingError", resourceCulture);
            }
        }
    }
}
