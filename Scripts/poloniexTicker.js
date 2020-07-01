eval(CSFile.ReadAllText("C:\\ProgramData\\RulesetRunner\\PolyFills.js"));
eval(CSFile.ReadAllText("C:\\web\\riLib\\PoloniexSupport.ri"));
eval(CSFile.ReadAllText("C:\\web\\riLib\\WebBrowserSupport.ri"));

// debugger;


var ticker = GetTicker();
var tickerKeys = Object.keys(ticker);
var tickedKeys = Object.keys(ticker[tickerKeys[0]]);

CSDocument.Body.InnerHtml = "";

var table = insertAfterBegin(CSDocument.Body, buildTag({
      tag: "TABLE"
    }));

var thead = insertAfterBegin(table, buildTag({
      tag: "THEAD"
    }));

var heads = tickedKeys.slice(0);
heads.unshift("Currency Pair");

for (var h = 0; h < heads.length; h++) {
  var there = insertBeforeEnd(thead, buildTag({
        tag: "TD",
        text: heads[h],
        style: "background-color:black;color:white;font-weight:bold;width:auto;"
      }));
}

// debugger;
for (var k = 0; k < tickerKeys.length; k++) {

  var tr = insertBeforeEnd(table, buildTag({
        tag: "TR"
      }));

  var tmp = insertAfterBegin(tr, buildTag({
        tag: "TD",
        text: tickerKeys[k],
        id: tickerKeys[k]
      }));

  for (var t = 0; t < tickedKeys.length; t++) {
    var tickedKey = tickedKeys[t];
    var tickedVal = ticker[tickerKeys[k]][tickedKey];
    tmp = insertBeforeEnd(tr, buildTag({
          tag: "TD",
          /*text: tickedVal,*/
          id: tickerKeys[k] + "_" + tickedKey
        }));
		
    CSLStatus.Text = "Loading...";
    CSLStatus.Visible = !CSLStatus.Visible;
    CSLStatus.Refresh();
  }
}

CSLStatus.Visible = false;
CSDocument.Body.InnerHtml = CSDocument.Body.InnerHtml; // weird but what's required to make visible
// CSWebBrowser.Refresh();
// CSThread.Sleep(1000);
// } while (true);
// var tmp = insertBeforeEnd(tr, buildTag({
// tag: "TD",
// text: "Meow",
// style: "background-color:red;color:blue;font-weight:bold;width:auto;"
// }));

// var tmp = insertBeforeEnd(tr, buildTag({
// tag: "TD",
// text: "Moo",
// style: "background-color:red;color:blue;font-weight:bold;width:auto;"
// }));

CSConsole.WriteLine(CSDocument.Body.Parent.OuterHtml);
// CSMessageBox.Show(CSDocument.Body.Parent.OuterHtml);
// CSMessageBox.Show(pos.Parent.OuterHtml);
