# TinyURL
A Basic Repo for shrinking URL's, something I threw together really quickly...

```chsarp
using TinyURL;
```

### Use

```csharp
Uri url = new Uri("https://mywebsite.com/longlink/moredata");
string shrunk = url.Shrink();
  
string webSitePath = "https://mywebsite.com/longlink/moredata";
string shrunk_link = webSitePath.Shrink();
```

### Async

```csharp
Uri url = new Uri("https://mywebsite/com/longlink/moredata");
string shrunk_link = await url.ShrinkAsync();

string webSitePath = "https://mywebsite/com/longlink/moredata";
string shrunk_link = await webSitePath.ShrinkAsync();
```
