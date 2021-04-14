# TinyURL
A Basic Repo for shrinking URL's, something I threw together really quickly...

```csharp

  Uri url = new Uri("https://mywebsite.com/longlink/moredata");
  string shrunk = url.Shrink();
  
  string webSitePath = "https://mywebsite.com/longlink/moredata";
  string shrunk_link = webSitePath.Shrink();

```
