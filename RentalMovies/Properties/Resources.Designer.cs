﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalMovies.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RentalMovies.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Database {
            get {
                object obj = ResourceManager.GetObject("Database", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM RentingRecord.
        /// </summary>
        internal static string GetAllRentingRecord {
            get {
                return ResourceManager.GetString("GetAllRentingRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT id FROM DVDs WHERE status = &quot;Dostepny&quot; AND movieid = ?.
        /// </summary>
        internal static string GetAvailableDVDByMovieID {
            get {
                return ResourceManager.GetString("GetAvailableDVDByMovieID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Limits.
        /// </summary>
        internal static string GetLimits {
            get {
                return ResourceManager.GetString("GetLimits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Movies WHERE id = (SELECT movieid FROM DVDs WHERE id = ?)
        ///.
        /// </summary>
        internal static string GetMovieTitle {
            get {
                return ResourceManager.GetString("GetMovieTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM RentingRecord WHERE customerid = ?.
        /// </summary>
        internal static string GetRentingRecordByCustomerID {
            get {
                return ResourceManager.GetString("GetRentingRecordByCustomerID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM RentingRecord WHERE id = [id].
        /// </summary>
        internal static string GetTransactionByID {
            get {
                return ResourceManager.GetString("GetTransactionByID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM RentingRecord WHERE dvdid = [id].
        /// </summary>
        internal static string GetTransactionsByDVDID {
            get {
                return ResourceManager.GetString("GetTransactionsByDVDID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select Cast(Cast(newid() AS binary(3)) AS int) as NextID.
        /// </summary>
        internal static string NewID {
            get {
                return ResourceManager.GetString("NewID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Customers
        ///WHERE name
        ///	LIKE ? AND surname LIKE ?
        ///	AND pesel LIKE ?
        ///	AND phone LIKE ?
        ///	AND address LIKE ?.
        /// </summary>
        internal static string SearchCustomers {
            get {
                return ResourceManager.GetString("SearchCustomers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Movies 
        ///WHERE 
        ///title LIKE ?
        ///AND releaseYear LIKE ?
        ///AND country LIKE ?
        ///AND
        ///(
        ///	(&apos;%[director]%&apos; = ? OR id IN (SELECT movieid FROM MoviesTags WHERE tagId IN (SELECT id FROM Tags WHERE name LIKE &apos;%[director]%&apos; AND category = &apos;Writer&apos;)))
        ///	AND (&apos;%[genre]%&apos; = ? OR id IN (SELECT movieid FROM MoviesTags WHERE tagId IN (SELECT id FROM Tags WHERE name LIKE &apos;%[genre]%&apos; AND category = &apos;Genre&apos;)))
        ///	AND (&apos;%[actor]%&apos; = ? OR id IN (SELECT movieid FROM MoviesTags WHERE tagId IN (SELECT id FROM Tags WHERE [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SearchMoviesWithTheseTags {
            get {
                return ResourceManager.GetString("SearchMoviesWithTheseTags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Tags WHERE name LIKE ? AND category = ? ORDER BY name ASC.
        /// </summary>
        internal static string SearchTags {
            get {
                return ResourceManager.GetString("SearchTags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select * FROM DVDs.
        /// </summary>
        internal static string SelectAllDVDs {
            get {
                return ResourceManager.GetString("SelectAllDVDs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Customers.
        /// </summary>
        internal static string SelectAllFromCustomers {
            get {
                return ResourceManager.GetString("SelectAllFromCustomers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Movies.
        /// </summary>
        internal static string SelectAllFromMovies {
            get {
                return ResourceManager.GetString("SelectAllFromMovies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM MoviesTags.
        /// </summary>
        internal static string SelectAllMoviesTags {
            get {
                return ResourceManager.GetString("SelectAllMoviesTags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Tags ORDER BY name ASC.
        /// </summary>
        internal static string SelectAllTags {
            get {
                return ResourceManager.GetString("SelectAllTags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Tags WHERE category = @category ORDER BY name ASC.
        /// </summary>
        internal static string SelectAllTagsOfGenre {
            get {
                return ResourceManager.GetString("SelectAllTagsOfGenre", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Customers WHERE id=?.
        /// </summary>
        internal static string SelectCustomerById {
            get {
                return ResourceManager.GetString("SelectCustomerById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * from DVDs WHERE id IN (SELECT id FROM DVDs WHERE movieId = ?).
        /// </summary>
        internal static string SelectDVDByMovieID {
            get {
                return ResourceManager.GetString("SelectDVDByMovieID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM DVDs WHERE id = ?.
        /// </summary>
        internal static string SelectDVDsByID {
            get {
                return ResourceManager.GetString("SelectDVDsByID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Movies WHERE id=?.
        /// </summary>
        internal static string SelectMovieByID {
            get {
                return ResourceManager.GetString("SelectMovieByID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM MoviesTags WHERE tagId = ?.
        /// </summary>
        internal static string SelectMoviesTagsByMovieID {
            get {
                return ResourceManager.GetString("SelectMoviesTagsByMovieID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM MoviesTags WHERE tagId = ? AND movieid = ?.
        /// </summary>
        internal static string SelectMoviesTagsByTagAndMovieId {
            get {
                return ResourceManager.GetString("SelectMoviesTagsByTagAndMovieId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Tags WHERE id = @id.
        /// </summary>
        internal static string SelectTagByID {
            get {
                return ResourceManager.GetString("SelectTagByID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * from Tags
        ///WHERE id IN
        ///(
        ///	SELECT tagId
        ///	FROM MoviesTags
        ///	WHERE movieId = ?)
        ///AND category = ?.
        /// </summary>
        internal static string SelectTagsByMovieID {
            get {
                return ResourceManager.GetString("SelectTagsByMovieID", resourceCulture);
            }
        }
    }
}
