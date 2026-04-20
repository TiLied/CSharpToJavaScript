using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS;

public partial interface ParentNode
{
	///<include file='CSharpToJavaScript/Utils/Docs/element/element.generated.xml' path='docs/ElementQuerySelector/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public T? QuerySelector<T>(string selectors) where T : Element { throw new System.NotImplementedException(); }
}

