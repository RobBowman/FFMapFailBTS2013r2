namespace FFMapTest {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FFMapTest.SourceCustomer", typeof(global::FFMapTest.SourceCustomer))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FFMapTest.TargetCustomerFF", typeof(global::FFMapTest.TargetCustomerFF))]
    public sealed class SourceCustomer_2_TargetCustomerFF : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://FFMapTest.TargetCustomerFF"" xmlns:s0=""http://FFMapTest.SourceCustomer"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Customer"" />
  </xsl:template>
  <xsl:template match=""/s0:Customer"">
    <ns0:CustomerFF>
      <xsl:for-each select=""Recs"">
        <xsl:variable name=""var:v1"" select=""userCSharp:StringLowerCase(&quot; &quot;)"" />
        <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(string(FirstName/text()) , string($var:v1) , string(Surname/text()))"" />
        <Recs>
          <FullName>
            <xsl:value-of select=""$var:v2"" />
          </FullName>
          <Town>
            <xsl:value-of select=""HomeTown/text()"" />
          </Town>
        </Recs>
      </xsl:for-each>
    </ns0:CustomerFF>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public string StringLowerCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToLower(System.Globalization.CultureInfo.InvariantCulture);
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"FFMapTest.SourceCustomer";
        
        private const global::FFMapTest.SourceCustomer _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"FFMapTest.TargetCustomerFF";
        
        private const global::FFMapTest.TargetCustomerFF _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"FFMapTest.SourceCustomer";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"FFMapTest.TargetCustomerFF";
                return _TrgSchemas;
            }
        }
    }
}
