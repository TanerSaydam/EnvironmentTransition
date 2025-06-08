# .NET ile Ortam Değişikliği

## Youtube Videosu
https://youtu.be/mkWuMRzN1d4

## CLI Komutları
```dash
dotnet run --launch-profile Production

dotnet publish -c Release -o C:\Users\PC\Desktop\1 -p:EnvironmentName=Production
```

## Publish için csproj dosyasındaki ayar
````xml
<Target Name="OverrideAppSettings" AfterTargets="Publish">
	<PropertyGroup>
		<EnvironmentName Condition=" '$(EnvironmentName)' == '' ">Production</EnvironmentName>
		<SourceAppSettings>appsettings.$(EnvironmentName).json</SourceAppSettings>
		<DestinationAppSettings>$(PublishDir)appsettings.json</DestinationAppSettings>
	</PropertyGroup>

	<Message Text="Kopyalanıyor: $(SourceAppSettings) → $(DestinationAppSettings)" Importance="high" />

	<Copy SourceFiles="$(SourceAppSettings)"
		  DestinationFiles="$(DestinationAppSettings)"
		  SkipUnchangedFiles="false"
		  OverwriteReadOnlyFiles="true"
		  Condition="Exists('$(SourceAppSettings)')" />
</Target>
```