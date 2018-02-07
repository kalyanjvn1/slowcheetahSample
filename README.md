# slowcheetahSample
Create Test environment specific configuration manager and use slow cheetah to transform the config files

First manually create configuration manager for all test environments
Install SlowCheetah nuget package and SlowCheetah extension 
Right click on the app.config file --> Add Transform and it will generate all child config files like app.Reg.config,app.stage.config
Manual add the transformation in the app.Reg.config files "xdt:Transform="Replace" xdt:Locator="Match(key)""
<appSettings>
    <add key="appName" value="stage-demo" xdt:Transform="Replace" xdt:Locator="Match(key)"/>
    <add key="email" value="stage@contoso.com" xdt:Transform="Replace" xdt:Locator="Match(key)"/>
  </appSettings>

