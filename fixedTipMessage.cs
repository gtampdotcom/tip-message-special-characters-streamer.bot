// allow special characters in tip messages

using System;
using System.IO;
		
public class CPHInline
{
	public bool Execute()
	{
		var fixedTipMessage = args["tipMessage"].ToString();
		fixedTipMessage = fixedTipMessage.Replace("&#39;" , "'");
		fixedTipMessage = fixedTipMessage.Replace("&amp;" , "&");
		fixedTipMessage = fixedTipMessage.Replace("&lt;" , "<");
		fixedTipMessage = fixedTipMessage.Replace("&gt;"  , ">");
		
		CPH.SetArgument("tipMessage",fixedTipMessage);
		return true;
	}
}
