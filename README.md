# QuirksModeSwitchSample
Sample showing how to enable AppContext and Configuration AppSettings switches on .NET Framework 4.5.1 and higher, and .NET Core 1.0 and higher.

AppContext is generally the easiest way to enable quirks mode, however it was not available before .NET Framework 4.6 and .NET Core. If the code requires .NET Framework 4.6 or higher or .NET Core, use only AppContext. If .NET Framework 4.5.x support is required, also use Configuration AppSettings.

This sample is a console app that reads a switch that you can set in the following ways:

1. Set programmatically by calling `AppContext.SetSwitch()` for .NET Framework 4.6 and higher, and .NET Core: https://github.com/Eilon/QuirksModeSwitchSample/blob/master/QuirksModeSwitchSample/Program.cs#L24-L27
2. Set programmatically by calling `ConfigurationManager.AppSettings.Set()` on .NET Framework 4.5.x : https://github.com/Eilon/QuirksModeSwitchSample/blob/master/QuirksModeSwitchSample/Program.cs#L18-L22
3. Set in app.config `<runtime>`/`<AppContextSwitchOverrides>` section for .NET Framework 4.6 and higher: https://github.com/Eilon/QuirksModeSwitchSample/blob/master/QuirksModeSwitchSample/app.config#L7-L9
4. Set in app.config `<appSettings>` section for .NET Framework 4.5.1 and higher: https://github.com/Eilon/QuirksModeSwitchSample/blob/master/QuirksModeSwitchSample/app.config#L4-L6
5. Set in runtimeconfig.json for .NET Core: https://github.com/Eilon/QuirksModeSwitchSample/blob/master/QuirksModeSwitchSample/runtimeconfig.template.json#L4
