﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domin.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ResourceData {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceData() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Domin.Resources.ResourceData", typeof(ResourceData).Assembly);
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
        ///   Looks up a localized string similar to يجب إدخال اسم العلامة التجارية.
        /// </summary>
        internal static string BrandName {
            get {
                return ResourceManager.GetString("BrandName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to يجب ادخال اسم السيارة.
        /// </summary>
        internal static string CarsName {
            get {
                return ResourceManager.GetString("CarsName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to يجب إدخال اسم الفئة.
        /// </summary>
        internal static string CategoryName {
            get {
                return ResourceManager.GetString("CategoryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to يجب الا يزيد حروف الكلمة عن ثلاثون حرف.
        /// </summary>
        internal static string MaxLength {
            get {
                return ResourceManager.GetString("MaxLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to يجب الا يقل عدد حروف الكلمة عن ثلاث حروف.
        /// </summary>
        internal static string MinLength {
            get {
                return ResourceManager.GetString("MinLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to يجب إدخال إسم المجموعة.
        /// </summary>
        internal static string RoleName {
            get {
                return ResourceManager.GetString("RoleName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to يجب ادخال اسم الفئة الفرعية.
        /// </summary>
        internal static string SubCategoryName {
            get {
                return ResourceManager.GetString("SubCategoryName", resourceCulture);
            }
        }
    }
}
