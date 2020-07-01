eval(CSFile.ReadAllText("C:\\ProgramData\\RulesetRunner\\PolyFills.js"));
eval(CSFile.ReadAllText("C:\\web\\riLib\\PoloniexSupport.ri"));
eval(CSFile.ReadAllText("C:\\web\\riLib\\WebBrowserSupport.ri"));

// debugger;
// do {
ticker = GetTicker();
tickerKeys = Object.keys(ticker);
tickedKeys = Object.keys(ticker[tickerKeys[0]]);

for (var trk = 0; trk < tickerKeys.length; trk++) {
  tickerKey = tickerKeys[trk];
  for (var tdk = 0; tdk < tickedKeys.length; tdk++) {
    tickedKey = tickedKeys[tdk];
    var sel = CSDocument.GetElementById(tickerKey + "_" + tickedKey);
    sel.InnerText = ticker[tickerKey][tickedKey].toString();
	CSLStatus.Text = "Loading...";
	CSLStatus.Visible = !CSLStatus.Visible;
	CSLStatus.Refresh();
  }
}
CSLStatus.Visible = false;
CSDocument.Body.InnerHtml = CSDocument.Body.InnerHtml; // weird but what's required to make visible
