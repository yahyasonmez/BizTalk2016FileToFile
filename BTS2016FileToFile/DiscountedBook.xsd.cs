namespace BTS2016FileToFile {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BTS2016.com.tr/FileToFile",@"DiscountedBook")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DiscountedBook"})]
    public sealed class DiscountedBook : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BTS2016.com.tr/FileToFile"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BTS2016.com.tr/FileToFile"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""DiscountedBook"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Name"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Summary"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""PublishedYear"" type=""xs:int"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Price"" type=""xs:int"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""AuthorInfo"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DiscountedBook() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "DiscountedBook";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
