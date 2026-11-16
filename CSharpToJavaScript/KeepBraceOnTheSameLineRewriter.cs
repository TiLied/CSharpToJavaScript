
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpToJavaScript;

internal class KeepBraceOnTheSameLineRewriter : CSharpSyntaxRewriter
{
	private SyntaxToken? _ReplacedPreviousToken = null;
	public override SyntaxToken VisitToken(SyntaxToken token)
	{
		if (token.IsKind(SyntaxKind.OpenBraceToken))
		{
			if (_ReplacedPreviousToken != null)
			{
				_ReplacedPreviousToken = null;
				token = token.WithLeadingTrivia(SyntaxFactory.Space);
				return token;
			}
		}

		SyntaxToken _nextToken = token.GetNextToken();

		if (_nextToken.IsKind(SyntaxKind.OpenBraceToken))
		{
			if (token.HasTrailingTrivia)
			{
				SyntaxTriviaList trivias = token.TrailingTrivia;

				for (int i = 0; i < trivias.Count; i++)
				{
					if (trivias[i].IsKind(SyntaxKind.EndOfLineTrivia))
					{
						token = token.WithoutTrivia().WithLeadingTrivia(token.LeadingTrivia);
						_ReplacedPreviousToken = token;
						return token;
					}
				}
			}
		}
		return base.VisitToken(token);
	}

}