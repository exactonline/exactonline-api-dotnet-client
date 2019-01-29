namespace ExactOnline.Client.Models.Financial
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class GLClassification
    {
        /// <summary>Abstract elements are only used in presentation linkbases to group other elements. They are not supposed to be used in instance documents</summary>
        public bool? Abstract { get; set; }
        /// <summary>Only used for amount concepts: in that case either &apos;debit&apos; or &apos;credit&apos;</summary>
        public string Balance { get; set; }
        /// <summary>The Code is unique</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description of the element. Note that this description is only used for division-specific taxonomies (or reporting schemes). For general taxonomies, the descriptions are stored in the TaxonomyLabels table</summary>
        public string Description { get; set; }
        /// <summary>Division is optional. For taxonomies of Taxonomies.Type = 0 (general taxonomies), the Division is empty. For division specific taxonomies it is mandatory</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Obsolete</summary>
        public bool? IsTupleSubElement { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>The Name is unique in the namespace</summary>
        public string Name { get; set; }
        /// <summary>Determines whether usage of the element is mandatory in an instance document</summary>
        public bool? Nillable { get; set; }
        /// <summary>Parent element for reporting schemes. In a reporting scheme, an element can have only one parent. This column is only used for reporting schemes. Note that in a real taxonomy, elements can have multiple parents.</summary>
        public Guid? Parent { get; set; }
        /// <summary>Only used for item concepts: either &apos;instant&apos; or &apos;duration&apos;. &apos;instant&apos; is used for balance types of concepts, &apos;duration&apos; is used for P&amp;L types of concepts</summary>
        public string PeriodType { get; set; }
        /// <summary>Mostly import sutstitutiongroup is xbrli:tuple, which makes the element a tuple concept. The default substitutiongroup for item concepts is xbrli:item</summary>
        public string SubstitutionGroup { get; set; }
        /// <summary>Namespace of the element</summary>
        public Guid? TaxonomyNamespace { get; set; }
        /// <summary>Description of TaxonomyNamespace</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TaxonomyNamespaceDescription { get; set; }
        /// <summary>Type of the element</summary>
        public Guid? Type { get; set; }
    }
}