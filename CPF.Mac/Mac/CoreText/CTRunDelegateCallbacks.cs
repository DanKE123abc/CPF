using System.Runtime.InteropServices;

namespace CPF.Mac.CoreText
{
	[StructLayout(LayoutKind.Sequential)]
	internal class CTRunDelegateCallbacks
	{
		public CTRunDelegateVersion version;

		public CTRunDelegateDeallocateCallback dealloc;

		public CTRunDelegateGetAscentCallback getAscent;

		public CTRunDelegateGetDescentCallback getDescent;

		public CTRunDelegateGetWidthCallback getWidth;
	}
}
