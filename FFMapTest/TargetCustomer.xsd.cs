namespace FFMapTest {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://FFMapTest.TargetCustomer",@"TargetCustomer")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TargetCustomer"})]
    public sealed class TargetCustomer : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://FFMapTest.TargetCustomer"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://FFMapTest.TargetCustomer"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""TargetCustomer"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""Recs"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""FullName"" type=""xs:string"" />
              <xs:element name=""Town"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TargetCustomer() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "TargetCustomer";
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
