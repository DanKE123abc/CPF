using CPF.Mac.Foundation;

namespace CPF.Mac.CoreText
{
	public class CTFontFeatureVerticalSubstitutionConnection : CTFontFeatureSelectors
	{
		public enum Selector
		{
			SubstituteVerticalFormsOn,
			SubstituteVerticalFormsOff
		}

		public Selector Feature => Feature;

		public CTFontFeatureVerticalSubstitutionConnection(NSDictionary dictionary)
			: base(dictionary)
		{
		}
	}
}
