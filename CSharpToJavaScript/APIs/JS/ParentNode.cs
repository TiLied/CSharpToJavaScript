using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS;

public partial interface ParentNode
{
	[To(ToAttribute.FirstCharToLowerCase)]
	///<include file='Utils/Docs/ElementQuerySelector/ElementQuerySelector.generated.xml' path='docs/ElementQuerySelector/*'/>
	public T? QuerySelector<T>(string selectors) where T : Element { throw new System.NotImplementedException(); }
}

