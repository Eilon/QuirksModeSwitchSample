# QuirksModeSwitchSample
Sample showing how to enable AppContext switches on .NET Framework and .NET Core

It has a very simple console app that reads a switch that you can set in the following ways:

1. Set programmatically by calling AppContext.SetSwitch() for .NET Framework and .NET Core: https://github.com/Eilon/QuirksModeSwitchSample/blob/master/QuirksModeSwitchSample/Program.cs#L14
2. Set in app.config for .NET Framework: https://github.com/Eilon/QuirksModeSwitchSample/blob/master/QuirksModeSwitchSample/app.config#L5
3. Set in runtimeconfig.json for .NET Core: https://github.com/Eilon/QuirksModeSwitchSample/blob/master/QuirksModeSwitchSample/runtimeconfig.template.json#L4
