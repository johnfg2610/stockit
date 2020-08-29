/*
 * Inventory
 *
 * Used to access inventory counts as well as brands and catalog items
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: johnfg2610@gmail.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Johnfg2610.Stockit.Converters;

namespace Johnfg2610.Stockit.Models
{ 
    /// <summary>
    /// A item contained within the catalog
    /// </summary>
    [DataContract]
    public partial class CatalogItem : IEquatable<CatalogItem>
    {
        /// <summary>
        /// A random identifier used to identify this object
        /// </summary>
        /// <value>A random identifier used to identify this object</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// the name of this item
        /// </summary>
        /// <value>the name of this item</value>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// the description of this item
        /// </summary>
        /// <value>the description of this item</value>
        [Required]
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A optional url pointing to a jpg or png image
        /// </summary>
        /// <value>A optional url pointing to a jpg or png image</value>
        [DataMember(Name="iconUrl", EmitDefaultValue=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// A optional list of image urls to display
        /// </summary>
        /// <value>A optional list of image urls to display</value>
        [DataMember(Name="imagesUrls", EmitDefaultValue=false)]
        public List<string> ImagesUrls { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [Required]
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public CatalogItemLinks Links { get; set; }

        /// <summary>
        /// A random string used to identify the seller
        /// </summary>
        /// <value>A random string used to identify the seller</value>
        [Required]
        [DataMember(Name="sellerId", EmitDefaultValue=false)]
        public string SellerId { get; set; }

        /// <summary>
        /// A random string used to identify the brand
        /// </summary>
        /// <value>A random string used to identify the brand</value>
        [Required]
        [DataMember(Name="brandId", EmitDefaultValue=false)]
        public string BrandId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  ImagesUrls: ").Append(ImagesUrls).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  BrandId: ").Append(BrandId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((CatalogItem)obj);
        }

        /// <summary>
        /// Returns true if CatalogItem instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogItem other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    IconUrl == other.IconUrl ||
                    IconUrl != null &&
                    IconUrl.Equals(other.IconUrl)
                ) && 
                (
                    ImagesUrls == other.ImagesUrls ||
                    ImagesUrls != null &&
                    other.ImagesUrls != null &&
                    ImagesUrls.SequenceEqual(other.ImagesUrls)
                ) && 
                (
                    Links == other.Links ||
                    Links != null &&
                    Links.Equals(other.Links)
                ) && 
                (
                    SellerId == other.SellerId ||
                    SellerId != null &&
                    SellerId.Equals(other.SellerId)
                ) && 
                (
                    BrandId == other.BrandId ||
                    BrandId != null &&
                    BrandId.Equals(other.BrandId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (IconUrl != null)
                    hashCode = hashCode * 59 + IconUrl.GetHashCode();
                    if (ImagesUrls != null)
                    hashCode = hashCode * 59 + ImagesUrls.GetHashCode();
                    if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                    if (SellerId != null)
                    hashCode = hashCode * 59 + SellerId.GetHashCode();
                    if (BrandId != null)
                    hashCode = hashCode * 59 + BrandId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CatalogItem left, CatalogItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CatalogItem left, CatalogItem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}