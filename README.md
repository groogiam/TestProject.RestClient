# Groogiam.TestProject.RestClient

A C# REST API client for [TestProject](https://testproject.io/).

This client was generated using [NSwag](https://github.com/RicoSuter/NSwag).

## Building
The client can be regenerated using 
- msbuild by excecuting `dotnet msbuild -target:NSwag` in the `src/Groogiam.TestProject.RestClient` directory.
- [NSwag Studio](https://github.com/RicoSuter/NSwag/wiki/NSwagStudio) 

Generation [settings](https://github.com/RicoSuter/NSwag/wiki/CSharpClientGeneratorSettings) can be changed via the `TestProject.nswag` file. 

## Sample Usage

```csharp
var client = new AgentsClient(httpClient)
{
	ApiKey = "Your Api Key"
};

var agents = await client.GetAgentsAsync(string.Empty, null, null);
```

## Useful TestProject Links
- [Getting Started](https://docs.testproject.io/api/getting-started-with-using-the-testproject-api)
- [API Documentation](https://api.testproject.io/docs/v2/)
