namespace BTS2016FileToFile {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTS2016FileToFile.Book", typeof(global::BTS2016FileToFile.Book))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTS2016FileToFile.DiscountedBook", typeof(global::BTS2016FileToFile.DiscountedBook))]
    public sealed class BookToDiscountedBook : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://BTS2016.com.tr/FileToFile"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Book"" />
  </xsl:template>
  <xsl:template match=""/ns0:Book"">
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(string(AuthorFirstName/text()) , &quot; &quot; , string(AuthorLastName/text()))"" />
    <ns0:DiscountedBook>
      <Name>
        <xsl:value-of select=""Name/text()"" />
      </Name>
      <Summary>
        <xsl:value-of select=""Summary/text()"" />
      </Summary>
      <PublishedYear>
        <xsl:value-of select=""PublishedYear/text()"" />
      </PublishedYear>
      <xsl:variable name=""var:v1"" select=""userCSharp:DiscountPrice(string(Price/text()))"" />
      <Price>
        <xsl:value-of select=""$var:v1"" />
      </Price>
      <AuthorInfo>
        <xsl:value-of select=""$var:v2"" />
      </AuthorInfo>
    </ns0:DiscountedBook>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public int DiscountPrice(int price)
{
	return price-(price*10/100);
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BTS2016FileToFile.Book";
        
        private const global::BTS2016FileToFile.Book _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BTS2016FileToFile.DiscountedBook";
        
        private const global::BTS2016FileToFile.DiscountedBook _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
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
                _SrcSchemas[0] = @"BTS2016FileToFile.Book";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BTS2016FileToFile.DiscountedBook";
                return _TrgSchemas;
            }
        }
    }
}
